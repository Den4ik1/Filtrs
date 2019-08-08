using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Users.Domain.Interfaces;
using Users.Domain.Models;
using UsersApi.Attributes;
using UsersApi.Mappers;
using UsersApi.Models;

namespace UsersApi.Controllers
{
    [RoutePrefix("users")]
    [CustomAuthorizationFilter, CustomActionFilter, CustomExceptionFilter]
    public class UsersController : ApiController
    {
        private IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [CustomActionFilter]
        [Route(""), HttpGet]
        public List<UserModel> GetUsers([FromUri] GetUsersRequest request)
        {
            if (request == null)
                request = new GetUsersRequest();

            var users = _usersService.SearchUsers(new SearchingUsersFilter()
            {
                Limit = request.Limit ?? 9,
                Offset = request.Offset ?? 0
            });

            return users.Select(_ => _.ToModel()).ToList();
        }

        [Route("{userId:int}"), HttpGet]
        public UserModel GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        [Route(""), HttpPost]
        public void PostUser([FromBody] UserModel userModel)
        {

        }
    }
}
