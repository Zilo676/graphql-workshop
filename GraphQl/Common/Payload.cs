using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.Common
{
    public abstract class Payload
    {
        public IReadOnlyList<UserError>? Errors { get; }
        protected Payload(IReadOnlyList<UserError>? errors = null)
        {
            Errors = errors;
        }

    }
}
