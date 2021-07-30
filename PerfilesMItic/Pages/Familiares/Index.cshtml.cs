using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PerfilesMItic.Data;
using PerfilesMItic.Models;

namespace PerfilesMItic.Pages.Familiares
{
    public class IndexModel : PageModel
    {
        private PerfilesMIticContext db;
        public IndexModel(PerfilesMIticContext db) => this.db = db;

        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }
        public Funcionario Funcionario { get; set; }
        [BindProperty]
        public Familiar Familiar { get; set; }

        public async Task OnGetAsync() => Funcionario = await db.Funcionario.FindAsync(Id);

        public async Task<IActionResult> OnPostAsync()
        {
            Funcionario = await db.Funcionario.FindAsync(Id);
            if(!ModelState.IsValid)
            {
                return Page();
            }
            db.Familiar.Add(Familiar);
            await db.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}
