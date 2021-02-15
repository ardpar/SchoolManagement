using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
