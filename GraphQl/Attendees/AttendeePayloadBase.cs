using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQl.Common;
using GraphQl.Data;

namespace GraphQl.Attendees
{
    public class AttendeePayloadBase : Payload
    {
        protected AttendeePayloadBase(Attendee attendee)
        {
            Attendee = attendee;
        }

        protected AttendeePayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        public Attendee? Attendee { get; }
    }
}
