using System;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace UsersApi.Attributes
{
    public class CustomActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {

        }

        public override void OnActionExecuted(HttpActionExecutedContext actionContext)
        {
            throw new Exception("Test");
        }
    }
}