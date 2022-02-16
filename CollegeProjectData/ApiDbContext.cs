using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProjectData
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<Students> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-1GNOQEQ\\SQLEXPRESS;database=firstTraining;trusted_connection=True;");
        }
    }
}
