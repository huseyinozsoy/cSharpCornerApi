using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpcornerauthorionicapi
{
    public class CsharpDbContext:DbContext
    {
        public CsharpDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
