using ISProject.Dal.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISProject.Dal
{
    public class ISDataContext : DbContext
    {
        public ISDataContext(DbContextOptions<ISDataContext> options) : base(options)
        {
            //Database.EnsureDeleted(); 
            Database.EnsureCreated();
        }
        public DbSet<CompanyModel> Companys { get; set; }
        public DbSet<HoldingModel> Holdings { get; set; }
        public DbSet<ReportModel> Reports { get; set; }
        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // конфигурация моделей
        }
    }
}
