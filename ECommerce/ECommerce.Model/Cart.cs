using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace ECommerce.Model
{
    [Table("Cart",Schema ="dbo")]
    public class Cart
    {
        public int Id { get; set; }
        public string ECommerceAdminUserId { get; set; }
        public virtual ECommerceAdminUser ECommerceAdminUser { get; set; }
        public int? Total { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
