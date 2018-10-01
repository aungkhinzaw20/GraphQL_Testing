using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQL_Testing.Model;
using System.Runtime.InteropServices;

namespace GraphQL_Testing.Model
{
    public class StarWarsQuery : ObjectGraphType
    {
        public StarWarsQuery([Optional] ProductInformationModelTemp PMod)
        {
            Field<DroidType>(
                "hero",
                resolve: context => new Droid { Id = 1, Name = "R2-D2" }
                );
            Field<ProductInformationModelType>(
                "prdinfo",
                resolve: context => PMod
                );
        }
    }
}
