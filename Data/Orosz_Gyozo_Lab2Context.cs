using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Orosz_Gyozo_Lab2.Models;

namespace Orosz_Gyozo_Lab2.Data
{
    public class Orosz_Gyozo_Lab2Context : DbContext
    {
        public Orosz_Gyozo_Lab2Context (DbContextOptions<Orosz_Gyozo_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Orosz_Gyozo_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Orosz_Gyozo_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
