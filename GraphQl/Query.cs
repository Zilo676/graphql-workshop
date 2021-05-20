using System.Linq;
using HotChocolate;
using ConferencePlanner.GraphQL.Data;

namespace GraphQl
{
    public class Query
    {
        public IQueryable<Speaker> GetSpeakers([Service] ApplicationDbContext context) => context.Speakers;
    }
}
