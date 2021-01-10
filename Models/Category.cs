using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Proiect_Web_Denisa_Boca.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name = "Category Name")]
        public string CategorName { get; set; }
        public ICollection<DressCategory> DressCategories { get; set; }
    }
}
