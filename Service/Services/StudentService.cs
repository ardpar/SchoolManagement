using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class StudentService : Service<Student>, IStudentService
    {
        public StudentService(IUnitOfWorks unitOfWorks, IRepository<Student> repository) : base(unitOfWorks, repository)
        {
        }
    }
}
