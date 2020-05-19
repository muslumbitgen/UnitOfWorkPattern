using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkPattern.Entities;

namespace UnitOfWorkPattern.DataAccess.EntityFramework.Contexts
{
    public class UnitOfWorkPatternContext : DbContext
    {
        public UnitOfWorkPatternContext(DbContextOptions<UnitOfWorkPatternContext> options):base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=UnitOfWorkPattern;Trusted_Connection=True;Integrated Security=True;");
        //}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
