using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class CourseService : Service<Course>, ICourseService
    {
        public CourseService(IUnitOfWorks unitOfWorks, IRepository<Course> repository) : base(unitOfWorks, repository)
        {
        }
    }
}
