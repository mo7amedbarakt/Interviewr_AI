using System.Collections.Generic;

namespace Task.Entites
{
    public class CV
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public List<Skills> skill { get; set; } = new List<Skills>();
        public List<project> projects { get; set; } = new List<project>();

    }
}
