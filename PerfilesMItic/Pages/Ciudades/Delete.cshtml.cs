using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PerfilesMItic.Models;
using PerfilesMItic.Data;

namespace PerfilesMItic.Pages.Ciudades
{
    public class DeleteModel : PageModel
    {
        private readonly PerfilesMIticContext _context;

        public DeleteModel(PerfilesMIticContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ciudad Ciudad { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ciudad = await _context.Ciudad.FirstOrDefaultAsync(m => m.IdCiudad == id);

            if (Ciudad == null)
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

            Ciudad = await _context.Ciudad.FindAsync(id);

            if (Ciudad != null)
            {
                _context.Ciudad.Remove(Ciudad);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
