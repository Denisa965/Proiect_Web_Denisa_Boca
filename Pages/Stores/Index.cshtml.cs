﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Web_Denisa_Boca.Data;
using Proiect_Web_Denisa_Boca.Models;

namespace Proiect_Web_Denisa_Boca.Pages.Stores
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Web_Denisa_Boca.Data.Proiect_Web_Denisa_BocaContext _context;

        public IndexModel(Proiect_Web_Denisa_Boca.Data.Proiect_Web_Denisa_BocaContext context)
        {
            _context = context;
        }

        public IList<Store> Store { get;set; }

        public async Task OnGetAsync()
        {
            Store = await _context.Store.ToListAsync();
        }
    }
}
