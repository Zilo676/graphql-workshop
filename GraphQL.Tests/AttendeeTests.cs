using System.Threading.Tasks;
using ConferencePlanner.GraphQL.Data;
using GraphQl.Attendees;
using GraphQl.Types;
using HotChocolate;
using HotChocolate.Execution;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Snapshooter.Xunit;
using Xunit;

namespace GraphQL.Tests
{
    public class AttendeeTests
    {
        [Fact]
        public async Task Attendee_Schema_Changed()
        {
            // Arrange
            // Act
            var schema = await new ServiceCollection()
                .AddPooledDbContextFactory<ApplicationDbContext>(
                    options => options.UseInMemoryDatabase("Data Source=conferences.db"))
                .AddGraphQL()
                .AddQueryType(d => d.Name("Query"))
                .AddTypeExtension<AttendeeQueries>()
                .AddMutationType(d => d.Name("Mutation"))
                .AddTypeExtension<AttendeeMutations>()
                .AddType<AttendeeType>()
                .AddType<SessionType>()
                .AddType<SpeakerTypes>()
                .AddType<TrackType>()
                .EnableRelaySupport()
                .BuildSchemaAsync();

            // assert
            schema.Print().MatchSnapshot();
        }
    }
}
