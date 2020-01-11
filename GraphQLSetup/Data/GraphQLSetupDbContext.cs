using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLSetup.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace GraphQLSetup.Data
{
    public class GraphQLSetupDbContext:DbContext
    {
        public GraphQLSetupDbContext(DbContextOptions<GraphQLSetupDbContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
