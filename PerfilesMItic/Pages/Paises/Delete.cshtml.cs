using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PerfilesMItic.Data;
using PerfilesMItic.Models;

namespace PerfilesMItic.Pages.Paises
{
    public class DeleteModel : PageModel
    {
        private readonly PerfilesMItic.Data.PerfilesMIticContext _context;

        public DeleteModel(PerfilesMItic.Data.PerfilesMIticContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pais Pais { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pais = await _context.Pais.FirstOrDefaultAsync(m => m.IdPais == id);

            if (Pais == null)
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

            Pais = await _context.Pais.FindAsync(id);

            if (Pais != null)
            {
                _context.Pais.Remove(Pais);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
