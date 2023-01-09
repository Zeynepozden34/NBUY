using Microsoft.EntityFrameworkCore;
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
    public class EfCoreBranchRepository : EfCoreGenericRepository<Branch>, IBranchRepository
    {
        public EfCoreBranchRepository(OzelDersContext context) : base(context)
        {
        }
        private OzelDersContext OzelDersContext
        {
            get { return _context as OzelDersContext; }
        }

        public async Task<List<Branch>> GetHomePageProductsAsync()
        {
            return await OzelDersContext
                      .Branches                     
                      .ToListAsync();
        }


        public async Task<List<Branch>> GetTeacherByIdBranch(int id)
        {
            return await OzelDersContext
                .Branches
                .Where(b => b.Id == id)
                .Include(b => b.Teacher)
                .ThenInclude(bt => bt.BranchId)
                .ToListAsync();
        }

    }
}
