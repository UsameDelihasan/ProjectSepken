using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public IResult Add(Book book)
        {
            _bookDal.Create(book);

            return new SuccessResult();
        }

        public IResult Delete(Book entity)
        {
            _bookDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Book>> ReadAll()
        {
            var result = _bookDal.Read(null);

            return new SuccessDataResult<List<Book>>(result);
        }

        public IResult Update(Book entity)
        {
            _bookDal.Update(entity);

            return new SuccessResult();
        }
    }
}
