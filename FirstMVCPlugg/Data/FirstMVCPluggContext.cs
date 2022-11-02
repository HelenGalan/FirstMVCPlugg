using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstMVCPlugg.Models;

namespace FirstMVCPlugg.Data
{
    public class FirstMVCPluggContext : DbContext
    {
        public FirstMVCPluggContext (DbContextOptions<FirstMVCPluggContext> options)
            : base(options)
        {
        }

        public DbSet<FirstMVCPlugg.Models.Department> Department { get; set; } = default!;
    }
}
