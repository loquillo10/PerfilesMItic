using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PerfilesMItic.Models;
using PerfilesMItic.Data;
using Microsoft.EntityFrameworkCore;

namespace PerfilesMItic.Pages
{
    public class CreateModel : PageModel
    {
        private readonly PerfilesMIticContext _context;
        public SelectList listCiudad { get; set; }
        public SelectList listaBarrio { get; set; }
        public SelectList listDepartamento { get; set; }
        public SelectList listPais { get; set; }
        public CreateModel(PerfilesMIticContext context)
        {
            _context = context;
        }
        public void GetListCiudad(PerfilesMIticContext context, object selectedCiudad = null, object selectedBarrio = null , object selectedDepar = null, object selectedPais = null)
        {
            var ciudadQuery = from c in context.Ciudad
                              orderby c.Nombre
                              select c;
            listCiudad = new SelectList(ciudadQuery.AsNoTracking(),
                "IdCiudad", "Nombre", selectedCiudad);

            var barrioQuery = from b in context.Barrio
                              orderby b.NombreB
                              select b;
            listaBarrio = new SelectList(barrioQuery.AsNoTracking(),
                   "IdBarrio", "NombreB", selectedBarrio);

            var DepQuery = from d in context.Departamento
                           orderby d.Nombre
                           select d;
            listDepartamento = new SelectList(DepQuery.AsNoTracking(),
                "IdDepartamento", "Nombre", selectedDepar);

            var paisQuery = from p in context.Pais
                            orderby p.Nombre
                            select p;
            listPais = new SelectList(paisQuery.AsNoTracking(),
                  "IdPais", "Nombre", selectedPais);
        }
        public IActionResult OnGet()
        {
            GetListCiudad(_context);
            


            return Page();

        }
        
        [BindProperty]
        public Funcionario Funcionario { get; set; }
       
        
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
       
        public async Task<IActionResult> OnPostAsync()
        {
            
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Funcionario.Add(Funcionario);
            await _context.SaveChangesAsync();

           var id = _context.Funcionario.Find(Funcionario.Id);

            return RedirectToPage("../Hijos/Create", id);

            
        }
    }
}
