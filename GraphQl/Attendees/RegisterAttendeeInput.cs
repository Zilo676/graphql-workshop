using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.Attendees
{
    public record RegisterAttendeeInput(
        string FirstName,
        string LastName,
        string UserName,
        string EmailAddress);
}
