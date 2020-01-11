using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQLSetup.Data.Entity;

namespace GraphQLSetup.GraphQL.Types
{
    public class ProductType:ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Description);
            Field(t => t.Qty);
        }
    }
}
