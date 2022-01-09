using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Infrastructure.Entities
{
    public class BasicContext : DbContext
    {
        public BasicContext() { }
        public BasicContext(DbContextOptions<BasicContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 加入自訂的 DbCommandInterceptor 實作
            optionsBuilder.AddInterceptors(new CreateDatabaseCollationInterceptor("Chinese_Taiwan_Stroke_CI_AS"));

            // 設定預設連接字串
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Basic;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<RoleFeature> RoleFeatures { get; set; }
        public DbSet<FeatureGroup> FeatureGroups { get; set; }
        public DbSet<SystemLog> SystemLogs { get; set; }
    }
}
