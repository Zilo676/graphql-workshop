using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ConferencePlanner.GraphQL.Data;
using GraphQl.Data;
using GraphQl.Extentions;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQl.Attendees
{
    [ExtendObjectType(Name = "Mutation")]
    public class AttendeeMutations
    {
        [UseApplicationDbContext]
        public async Task<RegisterAttendeePayload> RegisterAttendeeAsync(
            RegisterAttendeeInput input,
            [ScopedService] ApplicationDbContext context,
            CancellationToken cancellationToken)
        {
            var attendee = new Attendee
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                UserName = input.UserName,
                EmailAddress = input.EmailAddress
            };

            context.Attendees.Add(attendee);

            await context.SaveChangesAsync(cancellationToken);

            return new RegisterAttendeePayload(attendee);
        }
    }
}
