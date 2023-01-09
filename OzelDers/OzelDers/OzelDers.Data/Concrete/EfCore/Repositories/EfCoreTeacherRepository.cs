﻿using Microsoft.EntityFrameworkCore;
using OzelDers.Data.Abstract;
using OzelDers.Data.Concrete.EfCore.Contexts;
using OzelDers.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Concrete.EfCore.Repositories
{
    public class EfCoreTeacherRepository : EfCoreGenericRepository<Teacher>, ITeacherRepository
    {
        public EfCoreTeacherRepository(OzelDersContext context) : base(context)
        {
        }
        private OzelDersContext OzelDersContext
        {
            get { return _context as OzelDersContext; }
        }
        public async Task<List<Teacher>> GetByIdBranch(int id)
        {
            return await OzelDersContext
                 .Teachers
                 .Where(t => t.Id==id)
                 .ToListAsync();
        }

        public async Task<List<Teacher>> GetHomePageTeachersAsync()
        {
            return await OzelDersContext
                       .Teachers
                       .Include(t=>t.Branch)
                       .ToListAsync();
        }

        public Task<List<Teacher>> GetTeacherByIdBranch(int id)
        {
            return await OzelDersContext
                .Branches
                .Where(b => b.Id == id)
                .Include(b => b.Branch)
                .ThenInclude(bt => bt.BranchId)
                .ToListAsync();
        }
    }
}
