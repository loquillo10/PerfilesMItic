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
    public class DetailsModel : PageModel
    {
        private readonly PerfilesMIticContext _context;

        public DetailsModel(PerfilesMIticContext context)
        {
            _context = context;
        }

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
    }
}
