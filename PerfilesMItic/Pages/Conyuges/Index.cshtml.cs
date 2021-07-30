using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PerfilesMItic.Data;
using PerfilesMItic.Models;

namespace PerfilesMItic.Pages.Conyuges
{
   
    public class IndexModel : PageModel
    {
        private readonly PerfilesMIticContext _context;
        [BindProperty(SupportsGet = true)]
        [Column("IdFuncionario")]
        public int Id { get; set; }
        public Funcionario Funcionario { get; set; }

        public IndexModel(PerfilesMIticContext context)
        {
            _context = context;
        }
        public async Task OnGetASync() => Funcionario = await _context.Funcionario.FindAsync(Id);

        [BindProperty]
        public Conyuge Conyuge { get; set; }
        

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Conyuge.Add(Conyuge);
            await _context.SaveChangesAsync();

            return RedirectToRoute("../Hijos/Index", Funcionario);
        }

    }
}
