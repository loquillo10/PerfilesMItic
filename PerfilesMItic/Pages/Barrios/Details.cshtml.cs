using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PerfilesMItic.Data;
using PerfilesMItic.Models;

namespace PerfilesMItic.Pages.Barrios
{
    public class DetailsModel : PageModel
    {
        private readonly PerfilesMItic.Data.PerfilesMIticContext _context;

        public DetailsModel(PerfilesMItic.Data.PerfilesMIticContext context)
        {
            _context = context;
        }

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
    }
}
