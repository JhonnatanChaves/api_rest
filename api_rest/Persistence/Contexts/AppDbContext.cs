using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest.Domains.Models;
using Microsoft.EntityFrameworkCore;
using Supermarket.API.Domains.Models;

namespace api_rest.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        protected override void OnModelCreating (ModelBuilder builder) 
        {

            base.OnModelCreating(builder);

            //Como o nome da entidade ja esta OK,nao usaremos a linha abaixo
            //builder.Entity<Category>().ToTable("Categories");
            
            //Definindo chave primaria
            builder.Entity<Category>().HasKey(p => p.id);

            //Definindo as colunas da tabela e algumas restricoes
            builder.Entity<Category>().Property(p => p.id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Category>().HasMany(p => p.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);

            builder.Entity<Category>().HasData
            (

                new Category { id = 100, Name = "Fruits and Vegetables" },
                new Category { id = 101, Name = "Dairy" }

            );

            //builder.Entity<Product>().ToTable("Products");

            //Definindo chave primaria
            builder.Entity<Product>().HasKey(p => p.id);

            //Definindo as colunas da tabela e algumas restricoes
            builder.Entity<Product>().Property(p => p.id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.QuatityInPackage).IsRequired();
            builder.Entity<Product>().Property(p => p.UnitOfMeasurement).IsRequired();


            //Especificando relacao muitos para um e estabelecendo chave estrangeira
            builder.Entity<Category>()
                .HasMany(p => p.Products)
                .WithOne(p => p.Category)
                .HasForeignKey( p => p.CategoryId);


        }


















    }
}
