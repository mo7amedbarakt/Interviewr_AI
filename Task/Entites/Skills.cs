﻿namespace Task.Entites
{
    public class Skills
    {
        public int Id { get; set; }
        public int CVId { get; set; }
        public CV cv { get; set; }
        public List<string> TechnicalSkills { get; set; } = new List<string>();
        public List<string> SoftSkills { get; set; } = new List<string>();
    }
}
