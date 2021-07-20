using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PerfilesMItic.Models;
using PerfilesMItic.Data;

namespace PerfilesMItic.Pages.Familiares
{
    public class IndexModel : PageModel
    {
        private readonly PerfilesMIticContext _context;

        public IndexModel(PerfilesMIticContext context)
        {
            _context = context;
        }

        public IList<Familiar> Familiar { get;set; }

        public async Task OnGetAsync()
        {
            Familiar = await _context.Familiar.ToListAsync();
        }
    }
}
