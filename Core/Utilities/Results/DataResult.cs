using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : IDataResult<T>
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }

        public DataResult(bool success,T data,string message):this(success,data)
        {
            Message = message;
            Success = success;
            Data = data;
        }

        public DataResult(bool success, T data)
        {
            Success = success;
            Data = data;
        }
    }
}
