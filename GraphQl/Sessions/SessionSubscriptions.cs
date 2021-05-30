using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GraphQl.Data;
using GraphQl.DataLoader;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQl.Sessions
{
    [ExtendObjectType(Name = "Subscription")]
    public class SessionSubscriptions
    {
        [Subscribe]
        [Topic]
        public Task<Session> OnSessionScheduledAsync(
            [EventMessage] int sessionId,
            SessionByIdDataLoader loader,
            CancellationToken token
        ) => loader.LoadAsync(sessionId, token);


    }
}
