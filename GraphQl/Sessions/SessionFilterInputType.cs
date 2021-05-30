using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQl.Data;
using HotChocolate.Data.Filters;
using HotChocolate.Language;

namespace GraphQl.Sessions
{
    public class SessionFilterInputType : FilterInputType<Session>
    {
        protected override void Configure(IFilterInputTypeDescriptor<Session> descriptor)
        {
            descriptor.Ignore(x => x.Id);
            descriptor.Ignore(x => x.TrackId);
        }
    }
}
