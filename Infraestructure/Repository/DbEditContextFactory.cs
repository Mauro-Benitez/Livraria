using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace Infraestructure.Repository
{
    public class DbEditContextFactory : IDesignTimeDbContextFactory<DbEditContext>
    {
        public DbEditContext CreateDbContext(string[] args)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            var connectionString = "Server=DESKTOP-94PS21M; Database=Db_Livraria_Edit; Integrated Security=true; TrustServerCertificate=true";

            var optionsBuilder = new DbContextOptionsBuilder<DbEditContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new DbEditContext(optionsBuilder.Options);
        }
    }
}
