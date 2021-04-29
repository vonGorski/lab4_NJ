using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab44.Data;
using lab44.modele;

namespace lab44.Pages.Telefony
{
    public class DeleteModel : PageModel
    {
        private readonly lab44.Data.lab44Context _context;

        public DeleteModel(lab44.Data.lab44Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Telefon Telefon { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Telefon = await _context.Telefon.FirstOrDefaultAsync(m => m.ID == id);

            if (Telefon == null)
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

            Telefon = await _context.Telefon.FindAsync(id);

            if (Telefon != null)
            {
                _context.Telefon.Remove(Telefon);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
