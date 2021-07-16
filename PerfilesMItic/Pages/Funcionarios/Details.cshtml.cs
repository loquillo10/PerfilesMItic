using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using APPWEB.Models;
using PerfilesMItic.Data;

namespace PerfilesMItic.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly PerfilesMItic.Data.PerfilesMIticContext _context;

        public DetailsModel(PerfilesMItic.Data.PerfilesMIticContext context)
        {
            _context = context;
        }

        public Funcionario Funcionario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Funcionario = await _context.Funcionario.FirstOrDefaultAsync(m => m.Id == id);

            if (Funcionario == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
