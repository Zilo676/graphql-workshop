using GraphQl.Data;
using Microsoft.EntityFrameworkCore;
namespace ConferencePlanner.GraphQL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Attendee>()
                .HasIndex(x => x.UserName)
                .IsUnique();

            modelBuilder
                .Entity<SessionAttendee>()
                .HasKey(x => new { x.SessionId, x.AttendeeId });

            modelBuilder
                .Entity<SessionSpeaker>()
                .HasKey(x => new { x.SessionId, x.SpeakerId });

        }

        public DbSet<Speaker> Speakers { get; set; } = default!;
        public DbSet<Session> Sessions { get; set; } = default!;

        public DbSet<Track> Tracks { get; set; } = default!;

        public DbSet<Attendee> Attendees { get; set; } = default!;
    }
}