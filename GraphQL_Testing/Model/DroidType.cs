using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace GraphQL_Testing.Model
{
    public class DroidType : ObjectGraphType<Droid>
    {
        public DroidType()
        {
            Field(x => x.Id).Description("The id of Droid.");
            Field(x => x.Name).Description("The name of Droid.");
        }
    }
}
