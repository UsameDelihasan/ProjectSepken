using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        public IResult Add(Author author);
        public IDataResult<List<Author>> ReadAll();
        public IResult Update(Author entity);
        public IResult Delete(Author entity);
    }
}
