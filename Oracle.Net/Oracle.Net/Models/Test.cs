using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oracle.Net.Models
{
    public class Test
    {
        [Key]
        public int Id { get; set; }

        public int Testid { get; set; }

        public string Question { get; set; }

        public string Info { get; set; }

        public string Op1 { get; set; }

        public string Op2 { get; set; }

        public string Op3 { get; set; }

        public string Op4 { get; set; }

        public string Answ { get; set; }

        public int Mark { get; set; }
    }
}
