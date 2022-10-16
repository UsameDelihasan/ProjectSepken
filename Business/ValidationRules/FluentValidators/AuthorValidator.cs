using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidators
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {

        }
    }
}
