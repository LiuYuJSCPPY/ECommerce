using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Model;
using System.Data.Entity;

namespace ECommerce.Data
{
    public class ECommerceContext : IdentityDbContext<ECommerceAdminUser>
    {
        public ECommerceContext()
            : base("ECommerceContext", throwIfV1Schema: false)
        {
        }

        public static ECommerceContext Create()
        {
            return new ECommerceContext();
        } 

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Categroy> Categroys { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Proudct> Proudcts { get; set; }
        public virtual DbSet<ProudctCommit> ProudctCommits { get; set; }
        public virtual DbSet<ProudctImages> ProudctImages { get; set; }

    }
    
}
