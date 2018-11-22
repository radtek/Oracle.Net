﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oracle.Net.Models
{
    public class Scenetest
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Info { get; set; }
    }
}
