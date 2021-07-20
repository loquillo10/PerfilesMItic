using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PerfilesMItic.Models;
using PerfilesMItic.Data;

namespace PerfilesMItic.Pages.Departamentos
{
    public class DetailsModel : PageModel
    {
        private readonly PerfilesMIticContext _context;

        public DetailsModel(PerfilesMIticContext context)
        {
            _context = context;
        }

        public Departamento Departamento { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Departamento = await _context.Departamento.FirstOrDefaultAsync(m => m.IdDepartamento == id);

            if (Departamento == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
