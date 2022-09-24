using ECommerce.Model;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public class ECommerceSignInManager : SignInManager<ECommerceAdminUser, string>
    {
        public ECommerceSignInManager(ECommerceUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(ECommerceAdminUser user)
        {
            return user.GenerateUserIdentityAsync((ECommerceUserManager)UserManager);
        }

        public static ECommerceSignInManager Create(IdentityFactoryOptions<ECommerceSignInManager> options, IOwinContext context)
        {
            return new ECommerceSignInManager(context.GetUserManager<ECommerceUserManager>(), context.Authentication);
        }
    }
}
