using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oracle.Net.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        public int Quesid { get; set; }

        public int Replyerid { get; set; }

        public string Replyername { get; set; }

        public DateTime Replytime { get; set; }

        public string Reply { get; set; }

    }
}
