using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
