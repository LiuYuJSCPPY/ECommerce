using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Data;

namespace ECommerce.Services
{
    public class ECommerceRoleManager : RoleManager<IdentityRole>
    {
        public ECommerceRoleManager(IRoleStore<IdentityRole, string> roleStore) : base(roleStore)
        {
        }
        public static ECommerceRoleManager Create(IdentityFactoryOptions<ECommerceRoleManager> options, IOwinContext context)
        {
            return new ECommerceRoleManager(new RoleStore<IdentityRole>(context.Get<ECommerceContext>()));
        }
    }
}
