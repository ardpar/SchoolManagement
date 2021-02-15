using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.UnitOfWorks
{
    public interface IUnitOfWorks
    {
        IClubRepository Clubs { get; }
        ICourseRepository Courses { get; }
        IExamRepository Exams { get; }
        IStudentRepository Students { get; }
        Task CommitAsync();
        void Commit();
    }
}
