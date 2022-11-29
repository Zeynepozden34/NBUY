using BlogApp.Shared.Utilities.Result.Abstract;
using BlogApp.Shared.Utilities.Result.Complex_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Utilities.Result.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(ResultStatus resultStatus, T data)
        {
            ResultStatus = resultStatus;
            Data = data;
        }
        public DataResult(ResultStatus resultStatus, string message, T data)
        {
            // Dışardan geleni buradakiyle eşleştirdik.
            ResultStatus = resultStatus;
            Data = data;
            Message= message;
        }
        public DataResult(ResultStatus resultStatus, string message, T data, Exception exception)
        {
            
            ResultStatus = resultStatus;
            Data = data;
            Message = message;
            Exception = exception;
        }
        public T Data { get; }

        public ResultStatus ResultStatus { get; }

        public string Message { get; }

        public Exception Exception { get; }
    }
}
