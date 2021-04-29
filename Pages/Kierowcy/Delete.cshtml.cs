﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab44.Data;
using lab44.modele;

namespace lab44.Pages.Kierowcy
{
    public class DeleteModel : PageModel
    {
        private readonly lab44.Data.lab44Context _context;

        public DeleteModel(lab44.Data.lab44Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Kierowca Kierowca { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Kierowca = await _context.Kierowca.FirstOrDefaultAsync(m => m.ID == id);

            if (Kierowca == null)
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

            Kierowca = await _context.Kierowca.FindAsync(id);

            if (Kierowca != null)
            {
                _context.Kierowca.Remove(Kierowca);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
