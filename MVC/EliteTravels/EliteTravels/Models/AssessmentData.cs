using System.Collections.Generic;

namespace EliteTravels.Models
{
    public class AssessmentData
    {
        public List<Assignment> Exam { get; set; }
        public int PageNumber { get; set; }
        public decimal TotalPages { get; set; }
        public bool ShowResult { get; set; } = false;
        public int TotalMarksSecured { get; set; }
        public int TotalMarks { get; set; }
    }
}
