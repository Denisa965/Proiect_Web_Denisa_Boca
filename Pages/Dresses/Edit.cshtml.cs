using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect_Web_Denisa_Boca.Data;
using Proiect_Web_Denisa_Boca.Models;

namespace Proiect_Web_Denisa_Boca.Pages.Dresses
{
    public class EditModel : PageModel
    {
        private readonly Proiect_Web_Denisa_Boca.Data.Proiect_Web_Denisa_BocaContext _context;

        public EditModel(Proiect_Web_Denisa_Boca.Data.Proiect_Web_Denisa_BocaContext context)
        {
            _context = context;
        }

        [BindProperty]
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
            ViewData["StoreID"] = new SelectList(_context.Set<Store>(), "ID", "StoreName");

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Dress).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DressExists(Dress.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DressExists(int id)
        {
            return _context.Dress.Any(e => e.ID == id);
        }
    }
}
