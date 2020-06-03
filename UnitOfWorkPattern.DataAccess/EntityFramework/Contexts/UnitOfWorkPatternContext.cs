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
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
