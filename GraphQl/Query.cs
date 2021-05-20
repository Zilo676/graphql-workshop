using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using ConferencePlanner.GraphQL.Data;
using GraphQl.Extentions;
using Microsoft.EntityFrameworkCore;

namespace GraphQl
{
    public class Query
    {
        [UseApplicationDbContext]
        public Task<List<Speaker>> GetSpeakers([ScopedService] ApplicationDbContext context) => context.Speakers.ToListAsync();
    }
}
