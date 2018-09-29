using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ZHCG.Data.Entity;

namespace ZHCG.Data
{
    public class ZHCGDbContext : DbContext
    {
        public ZHCGDbContext(DbContextOptions<ZHCGDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
