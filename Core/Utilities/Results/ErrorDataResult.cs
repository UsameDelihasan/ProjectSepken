﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(false, data, message)
        {

        }

        public ErrorDataResult(T data) : base(false, data)
        {


        }
    }
}
