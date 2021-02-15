using Core.Models;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class ClubRepository : Repository<Club>, IClubRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public ClubRepository(AppDbContext context):base(context)
        {
            
        }
    }
}
