using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IBookService
    {
        public IResult Add(Book book);
        public IDataResult<List<Book>> ReadAll();
        public IResult Update(Book entity);
        public IResult Delete(Book entity);
    }
}
