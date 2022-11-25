using BlogApp.Entities.Concrete;
using BlogApp.Shared.Data.Concrete.EntityFrameWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Repository
{
    public class EfUserRepoitory :EfEntityRepositoryBase<User>
    {
        public EfUserRepoitory(DbContext context):base(context)
        {

        }
    }
}
