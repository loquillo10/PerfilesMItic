using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PerfilesMItic.Models;
using PerfilesMItic.Data;

namespace PerfilesMItic.Pages.Conyuges
{
    public class DeleteModel : PageModel
    {
        private readonly PerfilesMIticContext _context;

        public DeleteModel(PerfilesMIticContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Conyuge Conyuge { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Conyuge = await _context.Conyuge.FirstOrDefaultAsync(m => m.IdConyuge == id);

            if (Conyuge == null)
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

            Conyuge = await _context.Conyuge.FindAsync(id);

            if (Conyuge != null)
            {
                _context.Conyuge.Remove(Conyuge);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
