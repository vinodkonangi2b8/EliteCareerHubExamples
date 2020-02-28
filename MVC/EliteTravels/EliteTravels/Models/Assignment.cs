using System.Collections.Generic;

namespace EliteTravels.Models
{
    public class Assignment
    {
        public string Question { get; set; }

        public List<string> Options { get; set; }

        public string Answer { get; set; }

        public string SelectedAnswer { get; set; }
    }
}
