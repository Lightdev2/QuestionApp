using GetAnswerApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GetAnswerApp.DAL
{
    public class GetAnswerAppContext : DbContext
    {
        public GetAnswerAppContext(DbContextOptions<GetAnswerAppContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Achievement> Achievements { get; set; }

    }
}
