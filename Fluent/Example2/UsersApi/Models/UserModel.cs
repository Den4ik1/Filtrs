using FluentValidation.Attributes;
using UsersApi.Validators;

namespace UsersApi.Models
{
    [Validator(typeof(UserModelValidator))]
    public class UserModel
    {
        public string Name { get; set; }

        public string Role { get; set; }

        public string Sex { get; set; }

        public int Age { get; set; }

        public SubModel SubModel { get; set; }
    }

    public class SubModel
    {
        public int Test { get; set; }
    }
}