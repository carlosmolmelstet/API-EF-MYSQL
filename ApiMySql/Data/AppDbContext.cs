using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMySql.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
               .Property(e => e.Nome).HasMaxLength(80);

            modelBuilder.Entity<Produto>()
              .Property(e => e.Preco).HasPrecision(10, 2);

            modelBuilder.Entity<Produto>()
                .HasData(
                    new Produto { Id = 1, Nome = "Nome 1", Preco = 1.11M, Estoque = 10},
                    new Produto { Id = 2, Nome = "Nome 2", Preco = 2.22M, Estoque = 20 },
                    new Produto { Id = 3, Nome = "Nome 3", Preco = 3.33M, Estoque = 30 }
                );


        }
    }
}
