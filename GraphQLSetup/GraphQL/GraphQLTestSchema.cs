using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;

namespace GraphQLSetup.GraphQL
{
    public class GraphQLTestSchema:Schema
    {
        public GraphQLTestSchema(IDependencyResolver resolver):base(resolver)
        {
            Query = resolver.Resolve<GraphQLTestQuery>();
        }
    }
}
