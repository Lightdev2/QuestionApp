using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GetAnswerApp.DAL.Entities
{
    public class Question
    {
        public string Id { get; set; }
        public User Creator { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Title { get; set; }
        public bool IsSolved { get; set; }
        public string Desc { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }

    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Questions");

            builder.HasMany(x => x.Tags)
                .WithMany(x => x.AttachedQuestions);
        }
    }

}
