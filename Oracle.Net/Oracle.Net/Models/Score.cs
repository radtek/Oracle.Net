using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oracle.Net.Models
{
    public class Score
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public int Testscore { get; set; }

        public int Testid { get; set; }

        public string Testname { get; set; }

        public DateTime Testtime { get; set; }

        public int? Scene { get; set; }

        public int? Term { get; set; }
    }
}
