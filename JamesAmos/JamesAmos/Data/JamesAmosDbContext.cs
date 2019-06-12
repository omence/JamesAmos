using JamesAmos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamesAmos.Data
{
    public class JamesAmosDbContext : DbContext
    {
        public JamesAmosDbContext(DbContextOptions<JamesAmosDbContext> options) : base(options)
        {

        }
        public DbSet<Vlog> Petition { get; set; }
    }
}
