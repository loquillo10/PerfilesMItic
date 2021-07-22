using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PerfilesMItic.Models;
using PerfilesMItic.Data;

namespace PerfilesMItic.Pages.Hijos
{
    public class CreateModel : PageModel
    {
        private readonly PerfilesMIticContext _context;
        public int cantidadHijosobtenidos { get; set; }
        public CreateModel(PerfilesMIticContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
             
            GetNumHijos(_context);
            return Page();
        }

        [BindProperty]
        public Hijo Hijo { get; set; }
        public Funcionario Funcionario { get; set; }

        public void GetNumHijos(PerfilesMIticContext context)
        {
            var numeroHijos = context.Hijo;
            cantidadHijosobtenidos = numeroHijos.Count();
        }
        public async Task<IActionResult> GetFuncionario(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Funcionario = await _context.Funcionario.FindAsync(id);
            if (Funcionario == null)
            {
                return NotFound();
            }
            return Page();
        }
        
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
           
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Hijo.Add(Hijo);
            await _context.SaveChangesAsync();

            var id = GetFuncionario(Funcionario.Id);

            return RedirectToAction("../Conyuge/Create", id);
        }
    }
}
