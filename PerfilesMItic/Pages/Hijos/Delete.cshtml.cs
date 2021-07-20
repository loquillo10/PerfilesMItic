using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PerfilesMItic.Models;
using PerfilesMItic.Data;

namespace PerfilesMItic.Pages.Hijos
{
    public class DeleteModel : PageModel
    {
        private readonly PerfilesMIticContext _context;

        public DeleteModel(PerfilesMIticContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Hijo Hijo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hijo = await _context.Hijo.FirstOrDefaultAsync(m => m.IdHijo == id);

            if (Hijo == null)
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

            Hijo = await _context.Hijo.FindAsync(id);

            if (Hijo != null)
            {
                _context.Hijo.Remove(Hijo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
