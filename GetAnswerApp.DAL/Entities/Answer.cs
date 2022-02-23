namespace GetAnswerApp.DAL.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsSelectedAsSolution { get; set; }
        public User Creator { get; set; }
        public int CreatorId { get; set; }
    }
}
