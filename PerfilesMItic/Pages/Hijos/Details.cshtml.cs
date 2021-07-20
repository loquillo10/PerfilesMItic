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
    public class DetailsModel : PageModel
    {
        private readonly PerfilesMIticContext _context;

        public DetailsModel(PerfilesMIticContext context)
        {
            _context = context;
        }

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
    }
}
