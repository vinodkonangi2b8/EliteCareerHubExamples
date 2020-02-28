using System.Collections.Generic;

namespace EliteTravels.Models
{
    public class Assignment
    {
        public string Question { get; set; }

        public List<Options> Options { get; set; }

        public string Answer { get; set; }

        public string SelectedAnswer { get; set; }
    }

    public class Options
    {
        public string Name { get; set; }

        public bool IsSelected { get; set; }
    }
}
