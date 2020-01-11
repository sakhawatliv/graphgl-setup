using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQLSetup.GraphQL.Types;
using GraphQLSetup.Repositories;

namespace GraphQLSetup.GraphQL
{
    public class GraphQLTestQuery:ObjectGraphType
    {
        public GraphQLTestQuery(ProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>("products",
                resolve: context => productRepository.GetAll());
        }
    }
}
