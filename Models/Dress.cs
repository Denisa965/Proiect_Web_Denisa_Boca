using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Web_Denisa_Boca.Models
{
    public class Dress
    {
        public int ID { get; set; }
     
        [Display(Name="Dress Color")]
        public string Color { get; set; }
        [Display(Name = "Dress Designer")]
        public string Designer { get; set; }
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        public int StoreID { get; set; }
        public Store Store { get; set; }

        public ICollection<DressCategory> BookCategories { get; set; }
    }
}
