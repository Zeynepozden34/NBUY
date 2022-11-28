using BlogApp.Data.Abstract;
using BlogApp.Entities.Concrete;
using BlogApp.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Repositories
{
    public class EfArticleRepository : EfEntityRepositoryBase<Article>, IArticleRepository
    {
        public EfArticleRepository(DbContext context) : base(context)
        {
            
        }
    }
}
// EfEntityRepositoryBase<Article> shareddaki baseden miras alır bu sayede bunları buraddayazmamzıza gerek kalmaz 
//IArticleRepository datada bulunan dosyadakileri alır boş olmasının nedeni  IEntityRepositoryden miras almasıdır. bunlar dışında ekleyeceklerimiz için implemente etmemiz lazım.