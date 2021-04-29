using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using lab44.Data;
using lab44.modele;

namespace lab44.Pages.Kierowcy
{
    public class CreateModel : PageModel
    {
        private readonly lab44.Data.lab44Context _context;

        public CreateModel(lab44.Data.lab44Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Kierowca Kierowca { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Kierowca.Add(Kierowca);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
