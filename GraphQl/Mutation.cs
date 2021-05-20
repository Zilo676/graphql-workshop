﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConferencePlanner.GraphQL.Data;
using GraphQl.Extentions;
using HotChocolate;

namespace GraphQl
{
    public class Mutation
    {
        [UseApplicationDbContext]
        public async Task<AddSpeakerPayload> AddSpeakerAsync(
            AddSpeakerInput input,
            [ScopedService] ApplicationDbContext context)
        {
            var speaker = new Speaker()
            {
                Name = input.Name,
                Bio = input.Bio,
                WebSite = input.WebSite
            };

            context.Speakers.Add(speaker);
            await context.SaveChangesAsync();

            return new AddSpeakerPayload(speaker);
        }
    }
}
