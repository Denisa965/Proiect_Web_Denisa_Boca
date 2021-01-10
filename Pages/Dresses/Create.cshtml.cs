using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Web_Denisa_Boca.Data;
using Proiect_Web_Denisa_Boca.Models;

namespace Proiect_Web_Denisa_Boca.Pages.Dresses
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_Web_Denisa_Boca.Data.Proiect_Web_Denisa_BocaContext _context;

        public CreateModel(Proiect_Web_Denisa_Boca.Data.Proiect_Web_Denisa_BocaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["StoreID"] = new SelectList(_context.Set<Store>(), "ID", "StoreName");
            return Page();
        }

        [BindProperty]
        public Dress Dress { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Dress.Add(Dress);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
