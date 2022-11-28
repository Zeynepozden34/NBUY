using BlogApp.Data.Concrete.EntityFramework.Mappings;
using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Contexts
{
    public class BlogAppContext : DbContext
    {
        public DbSet<Article> Articles  { get; set; }
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Comment> Comments  { get; set; }
        public DbSet<Role> Roles  { get; set; }
        public DbSet<User> Users  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Dbcontexteki bir metodu ezerek yeni br metot yazarız.
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OFVK2FD; Database=BlogAppDb; Integrated Security=true; TrustServerCertificate=true");
            #region TrustServerCertificate
            // EntityFarmeworkCore-7 ile SqlServer Veri tabanına bağlantı ile ilgili önemli bir değişiklik olmuştur. BU da gübenlik amacıyla doğrulanmış sertifika gereksinimidir. Bunu ifade eden TrustServerCertificate özelliği, böle bir sertifika yoksa True'ya çekilmelidir. Çünkü default olarak false'dır. maalesef false iken veri tabanına bağlansa bile kullanılamaz. Breaking Changes Efcor-7 ile arama yapablirsin
            #endregion
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Veri girişini buradayapmayacaz. gerekli itemda yapıp onları bir metotla buraya çağıracaz.
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}



//@"" kaçış karakterini kullanmamak için kullanırız.
