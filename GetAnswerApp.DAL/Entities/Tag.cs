namespace GetAnswerApp.DAL.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public ICollection<Question> AttachedQuestions { get; set; }
        public ICollection<User> AttachedUsers { get; set; }
    }
}
