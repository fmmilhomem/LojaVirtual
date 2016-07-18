using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Felipe.LojaVirtual.Domino.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Felipe.LojaVirtual.Domino.Repositorio
{
    public class EntityFrameworkDBContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }
    }
}
