using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oracle.Net.Models
{
    public class Testlist
    {
        [Key]
        public int Id { get; set; }

        public string Testname { get; set; }

        public string Class { get; set; }

        public string Info { get; set; }

        public int Scene { get; set; }
    }
}
