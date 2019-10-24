using Microsoft.EntityFrameworkCore;
using PathToTheMaster.Web.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathToTheMaster.Web.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            Database.Migrate();
        }

        public DbSet<Patient> Patient { get; set; }

        public DbSet<SalePack> SalePack { get; set; }

        public DbSet<Package> Package { get; set; }

        public DbSet<Laboratory> Laboratory { get; set; }

        public DbSet<Group> Group { get; set; }

        public DbSet<City> City { get; set; }

        public DbSet<AnalysisNorm> AnalysisNorm { get; set; }

        public DbSet<Analysis> Analysis { get; set; }

        public DbSet<Addresses> Addresses { get; set; }
    }
}
