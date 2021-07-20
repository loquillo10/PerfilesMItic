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
    public class IndexModel : PageModel
    {
        private readonly PerfilesMIticContext _context;

        public IndexModel(PerfilesMIticContext context)
        {
            _context = context;
        }

        public IList<Hijo> Hijo { get;set; }

        public async Task OnGetAsync()
        {
            Hijo = await _context.Hijo.ToListAsync();
        }
    }
}
