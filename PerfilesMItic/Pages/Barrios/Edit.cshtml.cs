using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PerfilesMItic.Data;
using PerfilesMItic.Models;

namespace PerfilesMItic.Pages.Barrios
{
    public class EditModel : PageModel
    {
        private readonly PerfilesMItic.Data.PerfilesMIticContext _context;

        public EditModel(PerfilesMItic.Data.PerfilesMIticContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Barrio Barrio { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Barrio = await _context.Barrio.FirstOrDefaultAsync(m => m.IdBarrio == id);

            if (Barrio == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Barrio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BarrioExists(Barrio.IdBarrio))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BarrioExists(int id)
        {
            return _context.Barrio.Any(e => e.IdBarrio == id);
        }
    }
}
