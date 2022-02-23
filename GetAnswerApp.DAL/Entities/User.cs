using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GetAnswerApp.DAL.Entities
{
    public sealed class User
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<Achievement> Achievements { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Answer> Answers { get; set; }

        public ICollection<Tag> TrackedTags { get; set; }

    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasIndex(x => x.Email);

            builder.Property(x => x.Email)
                .IsRequired(true);
            builder.Property(x => x.Password)
                .IsRequired(true);

            builder.Property(x => x.NickName)
                .IsRequired(true)
                .HasMaxLength(20);

            builder.HasMany(x => x.Achievements)
                .WithMany(x => x.Users);

            builder.HasMany(x => x.Questions)
                .WithOne(x => x.Creator)
                .HasForeignKey(x => x.CreatorId);

            builder.HasMany(x => x.Notifications)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.Answers)
                .WithOne(x => x.Creator)
                .HasForeignKey(x => x.CreatorId);

            builder.HasMany(x => x.TrackedTags)
                .WithMany(x => x.AttachedUsers);
        }
    }
}
