using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PerfilesMItic.Data;
using PerfilesMItic.Models;

namespace PerfilesMItic.Pages.Barrios
{
    public class IndexModel : PageModel
    {
        private readonly PerfilesMItic.Data.PerfilesMIticContext _context;

        public IndexModel(PerfilesMItic.Data.PerfilesMIticContext context)
        {
            _context = context;
        }

        public IList<Barrio> Barrio { get;set; }

        public async Task OnGetAsync()
        {
            Barrio = await _context.Barrio.ToListAsync();
        }
    }
}
