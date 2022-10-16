using Core.Repository;
using Core.Repository.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfAuthorDal : EfRepositoryBase<Author,ProjectSepkenContext> , IAuthorDal
    {
    }
}
