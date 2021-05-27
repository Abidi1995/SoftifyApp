using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftifyApp.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Company> Companies { get; set; }
    }
}
