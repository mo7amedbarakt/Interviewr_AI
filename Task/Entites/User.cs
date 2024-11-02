using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Entites
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Gender gender { get; set; }
        
        public List<Interview> interviews { get; set; } = new List<Interview>();//list int score gender list<string> skills project
        public Role role { get; set; }
    }
}
