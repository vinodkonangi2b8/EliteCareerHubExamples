using System.Collections.Generic;

namespace EliteTravels.Models
{
    public class QuestionAndAnswers
    {
        public string Question { get; set; }

        public List<Options> Options { get; set; }

        public string Answer { get; set; }
    }

}
