using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oracle.Net.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Info { get; set; }

        public DateTime Time { get; set; }

        public int Fromid { get; set; }

        public string Fromname { get; set; }

        public string Class { get; set; }
    }
}
