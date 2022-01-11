using Arslan252.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arslan252.Data
{
    public class DbStoreContext :DbContext
    {
        public DbStoreContext(DbContextOptions<DbStoreContext> options): base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
       
    }
}