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
    public class IndexModel : PageModel
    {
        private readonly lab44.Data.lab44Context _context;

        public IndexModel(lab44.Data.lab44Context context)
        {
            _context = context;
        }

        public IList<Zmiana> Zmiana { get;set; }

        public async Task OnGetAsync()
        {
            Zmiana = await _context.Zmiana.ToListAsync();
        }
    }
}
