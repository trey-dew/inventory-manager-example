using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace inventory_managemnt_system.Data
{
    public class computerContext : DbContext
    {
        public computerContext(DbContextOptions<computerContext> options)
            : base(options)
        {
        }
         
        public DbSet<Models.Computer> Computer { get; set; }
    }
}
