using PrintingHouseDatabaseImplement.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingHouseDatabaseImplement
{
    public class PrintingHouseDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DASHULITI\DASHAMSSQLSERVER;Initial Catalog=PrintingHouseDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Component> Components { set; get; }
        public virtual DbSet<PrintingProduct> PrintingProducts { set; get; }
        public virtual DbSet<PrintingComponent> PrintingProductComponents { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
    }
}
