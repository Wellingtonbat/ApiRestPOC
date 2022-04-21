using AR.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace AR.Data
{
    public class ContextoPricipal : DbContext
    {
        public ContextoPricipal(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
