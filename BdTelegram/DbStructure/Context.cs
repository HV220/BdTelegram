using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdTelegram.DbStructure
{
    class Context : DbContext
    {

        DbSet<Category> Category { get; set; }
        DbSet<Product> Product { get; set; }

        //метод для подключения к БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=;database=;user=;password=");
        }


        #region OnModelBuilder
        //метод для создания новой модели БД
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    //Для преобразования объекта в сущность для БД

        //    modelBuilder.Entity<Category>(e =>
        //    {
        //        e.HasKey(obj => obj.Id);
        //        e.Property(obj => obj.Name);

        //    });
        //    modelBuilder.Entity<Product>(e =>
        //    {
        //        e.HasKey(obj => obj.IdProduct);
        //        e.Property(obj => obj.Name).IsRequired();
        //        e.HasOne(obj => obj.Category).WithMany(obj => obj.Products);

        //    });
        //}
        #endregion
    }

}
