using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Users.Domain.Models;
using UsersApi.Models;

namespace UsersApi.Mappers
{
    public static class DomainToUserModelMapper
    {
        public static UserModel ToModel(this DomainUser @this)
        {
            return new UserModel()
            {
                Name = @this.Name,
                Age = @this.Age,
                Role = @this.Role,
                Sex = @this.Sex
            };
        }
    }
}