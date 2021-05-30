using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQl.Data;
using HotChocolate.Types.Relay;

namespace GraphQl.Attendees
{
    public record CheckInAttendeeInput(
        [ID(nameof(Session))]
        int SessionId,
        [ID(nameof(Attendee))]
        int AttendeeId);
}
