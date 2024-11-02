using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Entites
{
    public class Interview
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        public string FeedBack { get; set; }
        public int TracksId { get; set; }
        public Tracks track { get; set; }
        public int Score { get; set; }
        public List<Q_A> Questions { get; set; } = new List<Q_A>();
        public Level level { get; set; }

    }
}
