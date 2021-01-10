using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Web_Denisa_Boca.Models
{
    public class DressCategory
    {
        public int ID { get; set; }
        public int DressID { get; set; }

        public Dress Dress { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
