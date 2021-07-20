using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PerfilesMItic.Data;
using PerfilesMItic.Models;

namespace PerfilesMItic.Pages.Paises
{
    public class CreateModel : PageModel
    {
        private readonly PerfilesMItic.Data.PerfilesMIticContext _context;

        public CreateModel(PerfilesMItic.Data.PerfilesMIticContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pais Pais { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pais.Add(Pais);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
