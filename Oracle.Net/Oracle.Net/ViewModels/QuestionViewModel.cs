using Oracle.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oracle.Net.ViewModels
{
    public class QuestionViewModel
    {
        public List<Question> Question { get; set; }

        public List<Answer> Answer { get; set; }

        public List<Comment> Comment { get; set; }

        public QuestionViewModel(List<Question> question, List<Answer> answer)
        {
            Question = question;
            Answer = answer;
        }

        public QuestionViewModel(List<Question> question, List<Answer> answer,List<Comment> comment)
        {
            Question = question;
            Answer = answer;
            Comment = comment;
        }

    }
}
