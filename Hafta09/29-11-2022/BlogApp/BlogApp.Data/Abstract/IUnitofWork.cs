using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Abstract
{
    public interface IUnitofWork :IAsyncDisposable
    {
        IArticleRepository Articles { get; } // set olmaması demek reodanly property yani dışardan birşey yazamazsın sadece çağırabilirsin
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }    
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }
        Task<int> SaveAsync();
    }
}
