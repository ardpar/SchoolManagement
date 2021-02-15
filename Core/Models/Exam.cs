using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public int Exam1 { get; set; }
        public int Exam2 { get; set; }
        public int Exam3 { get; set; }
        public int Project { get; set; }
        public decimal Avarege { get; set; }
        public bool Status { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
