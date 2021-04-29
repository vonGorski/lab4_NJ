using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab44.Data;
using lab44.modele;

namespace lab44.Pages.Zmiany
{
    public class DeleteModel : PageModel
    {
        private readonly lab44.Data.lab44Context _context;

        public DeleteModel(lab44.Data.lab44Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Zmiana Zmiana { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Zmiana = await _context.Zmiana.FirstOrDefaultAsync(m => m.ID == id);

            if (Zmiana == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Zmiana = await _context.Zmiana.FindAsync(id);

            if (Zmiana != null)
            {
                _context.Zmiana.Remove(Zmiana);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
