using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQl.Common;
using GraphQl.Data;

namespace GraphQl.Attendees
{
    public class RegisterAttendeePayload : AttendeePayloadBase
    {
        public RegisterAttendeePayload(Attendee attendee)
            : base(attendee)
        {
        }

        public RegisterAttendeePayload(UserError error)
            : base(new[] { error })
        {
        }
    }
}
