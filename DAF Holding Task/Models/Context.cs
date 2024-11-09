using Microsoft.EntityFrameworkCore;

namespace DAF_Holding_Task.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options)
      : base(options)
        {
        }
        public DbSet<UserProfile> userProfiles { get; set; }
        public DbSet<Post> posts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding UserProfile data
            modelBuilder.Entity<UserProfile>().HasData(
                new UserProfile { Id = 1, FirstName = "John", LastName = "Doe", DateOfBirth = new DateOnly(1990, 1, 1), Email = "john.doe@example.com" },
                new UserProfile { Id = 2, FirstName = "Jane", LastName = "Smith", DateOfBirth = new DateOnly(1985, 2, 10), Email = "jane.smith@example.com" },
                new UserProfile { Id = 3, FirstName = "Alice", LastName = "Johnson", DateOfBirth = new DateOnly(1992, 3, 15), Email = "alice.johnson@example.com" },
                new UserProfile { Id = 4, FirstName = "Bob", LastName = "Brown", DateOfBirth = new DateOnly(1993, 4, 20), Email = "bob.brown@example.com" },
                new UserProfile { Id = 5, FirstName = "Carol", LastName = "White", DateOfBirth = new DateOnly(1987, 5, 25), Email = "carol.white@example.com" }
            );

            // Seeding Post data (only for the first three users)
            modelBuilder.Entity<Post>().HasData(
                new Post { Id = 1, UserProfileID = 1, Title = "John's First Post", Content = "Content of John's first post.", DatePosted = new DateOnly(2024, 1, 1) },
                new Post { Id = 2, UserProfileID = 1, Title = "John's Second Post", Content = "Content of John's second post.", DatePosted = new DateOnly(2024, 1, 5) },
                new Post { Id = 3, UserProfileID = 2, Title = "Jane's First Post", Content = "Content of Jane's first post.", DatePosted = new DateOnly(2024, 2, 10) },
                new Post { Id = 4, UserProfileID = 3, Title = "Alice's First Post", Content = "Content of Alice's first post.", DatePosted = new DateOnly(2024, 3, 15) },
                new Post { Id = 5, UserProfileID = 3, Title = "Alice's Second Post", Content = "Content of Alice's second post.", DatePosted = new DateOnly(2024, 3, 20) }
            );
        }
    }

}
