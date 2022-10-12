using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje09_Interface
{
   public interface IGeneral
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
       

    }
    public interface IGenarel2:IGeneral
    {
        public string NameToUpper { get; set; }    
    }
    public class Product : IGenarel2
    {
        public string NameToUpper { get; set; }
    
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Id { get; internal set; }
        public int Price { get; internal set; }
        int IGeneral.Id { get; set; }
    }

    public class Category : IGenarel2
    {
        public string NameToUpper { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class Departman : IGeneral
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class Employee : IGeneral
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
