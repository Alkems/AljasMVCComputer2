using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AljasMVCComputer2.Models;

namespace AljasMVCComputer2.Data
{
    public class AljasMVCComputer2Context : DbContext
    {
        public AljasMVCComputer2Context (DbContextOptions<AljasMVCComputer2Context> options)
            : base(options)
        {
        }

        public DbSet<AljasMVCComputer2.Models.Computer> Computer { get; set; }
    }
}
