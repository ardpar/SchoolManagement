﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Quota { get; set; }
        public ICollection<Student> Students { get; set; }


    }
}
