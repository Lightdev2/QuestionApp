namespace GetAnswerApp.DAL.Entities
{
    public class Achievement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public List<User> Users { get; set; }
    }
}
