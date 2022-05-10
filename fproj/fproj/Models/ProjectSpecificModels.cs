using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fproj.Models
{
    public class FAQEntry
    {
        public int QuestionID1 { get; set; }
        public string QuestionValue { get; set; }
        public string AnswerValue { get; set; }
    }
}
