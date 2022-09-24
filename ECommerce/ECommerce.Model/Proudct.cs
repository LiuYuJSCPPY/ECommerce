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
    [Table("Proudct",Schema ="dbo")]
    public class Proudct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string desc { get; set; } 
        public int CategroyId { get; set; }
        public virtual Categroy Categroy { get; set; }
        public int Price { get; set; }
        
        public int DiscountId { get;set; }
        public virtual Discount Discount { get; set; }
        [DisplayFormat(DataFormatString ="{0:d yyyy-mm-dd}")]
        public DateTime? Create_at { get; set; }
        public DateTime? Modified_at { get; set; }
        public DateTime? Deleted_at { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }



    }
}
