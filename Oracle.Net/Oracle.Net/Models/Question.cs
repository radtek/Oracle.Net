using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oracle.Net.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public string Quesname { get; set; }

        public string Info { get; set; }

        public int  Querid { get; set; }

        public string Quername { get; set; }

        public DateTime Subtime { get; set; }

        public string Picture { get; set; }
    }
}
