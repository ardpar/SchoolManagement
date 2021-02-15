using Core.Repositories;
using Core.UnitOfWorks;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWorks
    {
        private readonly AppDbContext _context;
        private ClubRepository _clubRepository;
        private CourseRepository _courseRepository;
        private ExamRepository _examRepository;
        private StudentRepository _studentRepository;
        public IClubRepository Clubs => _clubRepository = _clubRepository ?? new ClubRepository(_context);

        public ICourseRepository Courses => _courseRepository = _courseRepository ?? new CourseRepository(_context);

        public IExamRepository Exams => _examRepository = _examRepository ?? new ExamRepository(_context);


        public IStudentRepository Students => _studentRepository = _studentRepository ?? new StudentRepository(_context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
