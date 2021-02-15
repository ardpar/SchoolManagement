using Core.Models;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class CourseRepository: Repository<Course>, ICourseRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public CourseRepository(AppDbContext context) : base(context)
        {

        }
    }
}
