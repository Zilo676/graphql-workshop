﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HotChocolate;
using ConferencePlanner.GraphQL.Data;
using GraphQl.DataLoader;
using GraphQl.Extentions;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using Microsoft.EntityFrameworkCore;

namespace GraphQl
{
    [ExtendObjectType(Name = "Query")]
    public class SpeakerQueries
    {
        [UseApplicationDbContext]
        public Task<List<Speaker>> GetSpeakersAsync(
            [ScopedService] ApplicationDbContext context) =>
            context.Speakers.ToListAsync();

        public Task<Speaker> GetSpeakerByIdAsync(
            [ID(nameof(Speaker))] int id,
            SpeakerByIdDataLoader dataLoader,
            CancellationToken cancellationToken) =>
            dataLoader.LoadAsync(id, cancellationToken);

        public async Task<IEnumerable<Speaker>> GetSpeakersByIdAsync(
            [ID(nameof(Speaker))] int[] ids,
            SpeakerByIdDataLoader dataLoader,
            CancellationToken cancellationToken) =>
            await dataLoader.LoadAsync(ids, cancellationToken);
    }
}
