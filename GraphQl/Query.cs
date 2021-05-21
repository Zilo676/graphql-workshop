using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HotChocolate;
using ConferencePlanner.GraphQL.Data;
using GraphQl.DataLoader;
using GraphQl.Extentions;
using HotChocolate.Types.Relay;
using Microsoft.EntityFrameworkCore;

namespace GraphQl
{
    public class Query
    {
        [UseApplicationDbContext]
        public Task<List<Speaker>> GetSpeakers([ScopedService] ApplicationDbContext context) => context.Speakers.ToListAsync();

        public Task<Speaker> GetSpeakerAsync(
            [ID(nameof(Speaker))] int id,
            SpeakerByIdDataLoader dataLoader,
            CancellationToken cancellationToken) =>
            dataLoader.LoadAsync(id, cancellationToken);
    }
}
