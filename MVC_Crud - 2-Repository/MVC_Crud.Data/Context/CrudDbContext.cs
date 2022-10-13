using MVC_Crud.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;//Entity Kütüphanesi Eklendi
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVC_Crud.Models.Context
{
    //Veritabanı İşlemleri
    public class CrudDbContext:DbContext //Entity Framework'u Referensa eklenmeli Nuget Package
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//s takısını alır.
        }
        public CrudDbContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=CrudProject;user Id=sa;password=1234";
        }
        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Users> Users { get; set; }

        //Tools>Nuget Package Console
        //enable-migrations
        //update-database --codefirst
        //update-database -Force

    }
}