using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLSetup.Data;
using GraphQLSetup.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLSetup.Repositories
{
    public class ProductRepository
    {
        private readonly GraphQLSetupDbContext _context;

        public ProductRepository(GraphQLSetupDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            var product = _context.Products.ToList();
            return product;
        }
    }
}
