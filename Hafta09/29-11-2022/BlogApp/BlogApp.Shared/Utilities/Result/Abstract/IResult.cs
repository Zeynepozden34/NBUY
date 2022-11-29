using BlogApp.Shared.Utilities.Result.Complex_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Utilities.Result.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get;  } //ResaltStatus.Error, ResaltStatus.Warning gibi
        public string Message { get; } //Hata mesajlarını bununla taşıyacaz.
        public Exception Exception { get;  } //Hataları(exceptions) bununla taşıyacaz

    }
}
// Dışardan veri girilmemes için seti kaldırdık.