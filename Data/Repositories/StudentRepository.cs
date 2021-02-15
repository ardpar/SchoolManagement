using Core.Models;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class StudentRepository:Repository<Student>, IStudentRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public StudentRepository(AppDbContext context) : base(context)
        {

        }
    }
}
