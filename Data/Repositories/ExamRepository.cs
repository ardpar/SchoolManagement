using Core.Models;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class ExamRepository:Repository<Exam>, IExamRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public ExamRepository(AppDbContext context) : base(context)
        {

        }
    }
}
