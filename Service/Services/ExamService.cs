using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class ExamService : Service<Exam>, IExamService
    {
        public ExamService(IUnitOfWorks unitOfWorks, IRepository<Exam> repository) : base(unitOfWorks, repository)
        {
        }
    }
}
