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
    public class IndexModel : PageModel
    {
        private readonly PerfilesMIticContext _context;

        public IndexModel(PerfilesMIticContext context)
        {
            _context = context;
        }

        public IList<Funcionario> Funcionario { get;set; }

        public async Task OnGetAsync()
        {
            Funcionario = await _context.Funcionario.ToListAsync();
        }
    }
}
