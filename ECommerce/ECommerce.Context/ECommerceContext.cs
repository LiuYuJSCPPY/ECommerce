using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Model;

namespace ECommerce.Context
{
    internal class ECommerceContext : IdentityDbContext<ECommerceAdminUser>
    {
        public ECommerceContext()
            : base("ECommerceContext", throwIfV1Schema: false)
        {
        }

        public static ECommerceContext Create()
        {
            return new ECommerceContext();
        }
    }
   
}
