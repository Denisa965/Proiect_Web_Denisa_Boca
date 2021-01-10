using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Web_Denisa_Boca.Models;

namespace Proiect_Web_Denisa_Boca.Data
{
    public class Proiect_Web_Denisa_BocaContext : DbContext
    {
        public Proiect_Web_Denisa_BocaContext (DbContextOptions<Proiect_Web_Denisa_BocaContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Web_Denisa_Boca.Models.Dress> Dress { get; set; }

        public DbSet<Proiect_Web_Denisa_Boca.Models.Store> Store { get; set; }

        public DbSet<Proiect_Web_Denisa_Boca.Models.Category> Category { get; set; }
    }
}
