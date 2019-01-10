using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDemo.Models
{
    public class NetCoreDBContext : DbContext
    {
        public NetCoreDBContext() { }

        public NetCoreDBContext(DbContextOptions<NetCoreDBContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
