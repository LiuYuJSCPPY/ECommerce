using ECommerce.Data;
using ECommerce.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public class ECommerceUserManager :UserManager<ECommerceAdminUser>
    {
        public ECommerceUserManager(IUserStore<ECommerceAdminUser> store)
            : base(store)
    {
    }


    public static ECommerceUserManager Create(IdentityFactoryOptions<ECommerceUserManager> options, IOwinContext context)
    {
        var manager = new ECommerceUserManager(new UserStore<ECommerceAdminUser>(context.Get<ECommerceContext>()));
        // Configure validation logic for usernames
        manager.UserValidator = new UserValidator<ECommerceAdminUser>(manager)
        {
            AllowOnlyAlphanumericUserNames = false,
            RequireUniqueEmail = true
        };

        // Configure validation logic for passwords
        manager.PasswordValidator = new PasswordValidator
        {
            RequiredLength = 6,
            RequireNonLetterOrDigit = true,
            RequireDigit = true,
            RequireLowercase = true,
            RequireUppercase = true,
        };

        // Configure user lockout defaults
        manager.UserLockoutEnabledByDefault = true;
        manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
        manager.MaxFailedAccessAttemptsBeforeLockout = 5;

        // Register two factor authentication providers. This application uses Phone and Emails as a step of receiving a code for verifying the user
        // You can write your own provider and plug it in here.
        manager.RegisterTwoFactorProvider("Phone Code", new PhoneNumberTokenProvider<ECommerceAdminUser>
        {
            MessageFormat = "Your security code is {0}"
        });
        manager.RegisterTwoFactorProvider("Email Code", new EmailTokenProvider<ECommerceAdminUser>
        {
            Subject = "Security Code",
            BodyFormat = "Your security code is {0}"
        });
        //manager.EmailService = new EmailService();
        //manager.SmsService = new SmsService();
        var dataProtectionProvider = options.DataProtectionProvider;
        if (dataProtectionProvider != null)
        {
            manager.UserTokenProvider =
                new DataProtectorTokenProvider<ECommerceAdminUser>(dataProtectionProvider.Create("ASP.NET Identity"));
        }
        return manager;
    }
}


}
