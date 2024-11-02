namespace Task.Entites
{
    public class Q_A
    {
        public int Id { get; set; }
        public List<string> Answer { get; set; }
        public List<string> Question { get; set; }
        public Level level { get; set; }
        public int trackId { get; set; }
        public int InterviewId { get; set; }
        public Interview Interview { get; set; }


    }
}
