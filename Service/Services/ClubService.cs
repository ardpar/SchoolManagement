using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class ClubService:Service<Club>,IClubService
    {
        public ClubService(IUnitOfWorks unitOfWorks, IRepository<Club> repository) :base(unitOfWorks,repository)
        {

        }
    }
}
