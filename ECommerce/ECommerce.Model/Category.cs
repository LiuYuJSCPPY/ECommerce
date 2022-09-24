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
    [Table("Categroy",Schema ="dbo")]
    public class Categroy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategroyImage { get; set; }
        public virtual ICollection<Proudct> Proudcts { get; set; }


    }
}
