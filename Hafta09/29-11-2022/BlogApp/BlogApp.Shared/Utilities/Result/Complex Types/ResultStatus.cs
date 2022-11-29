using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Utilities.Result.Complex_Types
{
    public enum ResultStatus
    {
        Success=0,
        Error=1,
        Warning=2, //ResultStatus.warning kullanımında  aslında arka planda 2 değerini tutacak
        Info=3
    }
}
//enum kendi nesne tiplerimizi yararırkrn kullanırız.