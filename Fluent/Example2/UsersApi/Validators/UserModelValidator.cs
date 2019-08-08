using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsersApi.Models;

namespace UsersApi.Validators
{
    public class UserModelValidator : AbstractValidator<UserModel>
    {
        public UserModelValidator()
        {
            RuleFor(_ => _.Age).InclusiveBetween(18, 99);
        }
    }
}