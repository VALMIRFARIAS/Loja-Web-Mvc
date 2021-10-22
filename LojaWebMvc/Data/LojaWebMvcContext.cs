using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LojaWebMvc.Models;

namespace LojaWebMvc.Data
{
    public class LojaWebMvcContext : DbContext
    {
        public LojaWebMvcContext (DbContextOptions<LojaWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller  { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
