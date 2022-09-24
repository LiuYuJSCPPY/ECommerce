using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using Microsoft.AspNet.Identity;

namespace ECommerce.Model
{
    
    public class ECommerceAdminUser : IdentityUser
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime? Birthday { get; set; }
        public int UserMember { get; set; }
        public string Telephone { get; set; }
        public string Cellphone { get; set; }

        public string Address { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ECommerceAdminUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
