﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Web_Denisa_Boca.Data;
using Proiect_Web_Denisa_Boca.Models;

namespace Proiect_Web_Denisa_Boca.Pages.Dresses
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_Web_Denisa_Boca.Data.Proiect_Web_Denisa_BocaContext _context;

        public DetailsModel(Proiect_Web_Denisa_Boca.Data.Proiect_Web_Denisa_BocaContext context)
        {
            _context = context;
        }

        public Dress Dress { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dress = await _context.Dress.FirstOrDefaultAsync(m => m.ID == id);

            if (Dress == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
