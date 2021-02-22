using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<Users>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotNull();
            RuleFor(u => u.LastName).NotNull();
            RuleFor(u => u.Email).EmailAddress().NotNull();
            RuleFor(u => u.Password).NotNull().MinimumLength(6);
        }
    }
}
