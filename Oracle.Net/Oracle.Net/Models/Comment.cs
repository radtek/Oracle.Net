using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oracle.Net.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public int Answerid { get; set; }

        public int Senderid { get; set; }

        public string Sendername { get; set; }

        public string Message { get; set; }
    }
}
