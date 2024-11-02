namespace Task.Entites
{
    public class Tracks
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Interview interview { get; set; }
        public List<Q_A> q_a { get; set; }=new List<Q_A>();

    }
}
