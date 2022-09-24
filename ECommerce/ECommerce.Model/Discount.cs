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
    [Table("Discount",Schema ="dbo")]
    public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DiscountImage { get; set; }
        public int Discount_Preceint { get; set; }
        public bool IsActival { get; set; }
        public DateTime? Create_at { get; set; }
        public DateTime? Moified_at { get; set; }

        public virtual ICollection<Proudct> Proudcts { get; set; }
    }
}
