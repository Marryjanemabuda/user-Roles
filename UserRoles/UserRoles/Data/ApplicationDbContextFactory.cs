using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRoles.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {

        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>();
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-UserRoles-E0161990-E3EA-439A-8D65-E299AA9C163B;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new ApplicationDbContext(options.Options);
        }
    }
}
