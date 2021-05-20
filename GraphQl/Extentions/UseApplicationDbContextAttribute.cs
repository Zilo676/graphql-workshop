using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ConferencePlanner.GraphQL.Data;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;

namespace GraphQl.Extentions
{
    public class UseApplicationDbContextAttribute : ObjectFieldDescriptorAttribute
    {
        public override void OnConfigure(IDescriptorContext context, IObjectFieldDescriptor descriptor, MemberInfo member)
        {
            descriptor.UseDbContext<ApplicationDbContext>();
        }
    }
}
