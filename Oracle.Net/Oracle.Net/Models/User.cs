using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oracle.Net.Models
{
    
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string Class { get; set; }

        public int?  Term { get; set; }

        public string Role { get; set; }
    }
}
