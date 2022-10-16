﻿using Core.Repository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBookDal : IRepositoryBase<Book>
    {
    }
}
