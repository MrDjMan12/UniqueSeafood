using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniqueSeafood.Models;
//DbContext is used to create a connection to the database in order to allow for database operations to happen.
namespace UniqueSeafood.Data
{
    public class UniqueSeafoodContext : DbContext
    {
        public UniqueSeafoodContext (DbContextOptions<UniqueSeafoodContext> options)
            : base(options)
        {
        }

        public DbSet<UniqueSeafood.Models.Booking> Booking { get; set; } = default!;
    }
}
