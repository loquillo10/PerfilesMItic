using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APPWEB.Models;

namespace PerfilesMItic.Data
{
    public class PerfilesMIticContext : DbContext
    {
        public PerfilesMIticContext (DbContextOptions<PerfilesMIticContext> options)
            : base(options)
        {
        }

        public DbSet<Funcionario> Funcionario { get; set; }
    }
}
