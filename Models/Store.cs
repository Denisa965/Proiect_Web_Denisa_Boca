using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Web_Denisa_Boca.Models
{
    public class Store
    {
        public int ID { get; set; }
        public string StoreName { get; set; }

        public ICollection<Dress> Dresses { get; set; }//navigate property
    }
}
