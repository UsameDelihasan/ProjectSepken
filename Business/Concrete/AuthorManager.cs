using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidators;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {

        private readonly IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        [ValidationAspect(typeof(AuthorValidator))]
        public IResult Add(Author author)
        {
            BusinessRules businessRules = new BusinessRules();

            IResult ruleCheck = businessRules.Run(CheckIfAuthorNameExists(author.Name));

            if (ruleCheck != null)
            {
                return ruleCheck;
            }

            _authorDal.Create(author);

            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(Author entity)
        {
            _authorDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Author>> ReadAll()
        {
            var result= _authorDal.Read(null);

            return new SuccessDataResult<List<Author>>(result);
        }

        public IResult Update(Author entity)
        {
            _authorDal.Update(entity);

            return new SuccessResult();
        }


        private IResult CheckIfAuthorNameExists(string name)
        {
            var countAuthor =_authorDal.Read(p=>p.Name == name).Any();

            if (countAuthor)
            {
                return new ErrorResult("bu isimde bir yazar daha önce eklenmiş");
            }

            return new SuccessResult();
        }
    }
}
