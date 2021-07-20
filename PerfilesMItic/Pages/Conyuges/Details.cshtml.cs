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
    public class DetailsModel : PageModel
    {
        private readonly PerfilesMIticContext _context;

        public DetailsModel(PerfilesMIticContext context)
        {
            _context = context;
        }

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
    }
}
