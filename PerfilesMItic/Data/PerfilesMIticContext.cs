using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PerfilesMItic.Models;

namespace PerfilesMItic.Data
{
    public class PerfilesMIticContext : DbContext
    {
        public PerfilesMIticContext (DbContextOptions<PerfilesMIticContext> options)
            : base(options)
        {
        }

        public DbSet<Funcionario> Funcionario { get; set; }

        public DbSet<Familiar> Familiar { get; set; }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Conyuge> Conyuge { get; set; }

        public DbSet<Ciudad> Ciudad { get; set; }

        public DbSet<Pais> Pais { get; set; }
        public DbSet<Hijo> Hijo { get; set; }
        public DbSet<FuncionPublica> FuncionPublica { get; set; }
        public DbSet<Barrio> Barrio { get; set; }
    }
}
