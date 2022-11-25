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
    public class EfCategoryRepoitory : EfEntityRepositoryBase<Category>
    {
        public EfCategoryRepoitory(DbContext context) :base(context) 
        {

        }
    }
}
