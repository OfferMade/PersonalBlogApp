using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace PersonalBlogApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Writing> Writings { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options): base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Writing>()
                .HasData(
                    new Writing() { WritingId = 1, WritingName = "Deneme", WritingDescription = "denemeiçyazı1" },
                    new Writing() { WritingId = 2, WritingName = "Deneme2", WritingDescription = "denemeiçyazı2" },
                    new Writing() { WritingId = 3, WritingName = "Deneme3", WritingDescription = "denemeiçyazı3" },
                    new Writing() { WritingId = 4, WritingName = "Deneme4", WritingDescription = "denemeiçyazı4" }
                );
        }

    }
}
