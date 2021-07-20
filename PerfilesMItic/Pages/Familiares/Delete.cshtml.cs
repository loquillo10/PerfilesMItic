using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PerfilesMItic.Models;
using PerfilesMItic.Data;

namespace PerfilesMItic.Pages.Familiares
{
    public class DeleteModel : PageModel
    {
        private readonly PerfilesMIticContext _context;

        public DeleteModel(PerfilesMIticContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Familiar Familiar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Familiar = await _context.Familiar.FirstOrDefaultAsync(m => m.IdFamiliar == id);

            if (Familiar == null)
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

            Familiar = await _context.Familiar.FindAsync(id);

            if (Familiar != null)
            {
                _context.Familiar.Remove(Familiar);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
