namespace Task.Entites
{
    public class project
    {
        public int Id { get; set; }
        public int CVId { get; set; }
        public CV cv { get; set; }
        public string Description { get; set; }
        public string GitHupLink { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

             


    }
}
