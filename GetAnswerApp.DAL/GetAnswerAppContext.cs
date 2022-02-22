using GetAnswerApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GetAnswerApp.DAL
{
    public class GetAnswerAppContext : DbContext
    {
        public GetAnswerAppContext(DbContextOptions<GetAnswerAppContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Question> Questions { get; set; }
    }
}
