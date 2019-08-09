using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Users.Domain.Interfaces;

namespace UsersApi.Attributes
{
    public class MyLoggerFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var logService = GetService<ILogServise>(actionContext);


            string rawRequest;
            using (var stream = new StreamReader(actionContext.Request.Content.ReadAsStreamAsync().Result))
            {
                stream.BaseStream.Position = 0;
                rawRequest = stream.ReadToEnd();
            }

            logService.Log(new Users.Domain.Models.RequestInfo()
            {
                ClientIP = /*"8.8.8.8",*/GetClientsIpAddress(actionContext.Request),
                Controller = /*"Google",*/ actionContext.ControllerContext.ControllerDescriptor.ControllerName,
                Request = /*"La-la",*/ rawRequest
                });
        }

        public string GetClientsIpAddress(HttpRequestMessage requestMessage)
        {
            if (requestMessage.Properties.ContainsKey("MS_HttpConteaxt"))
            {
                return IPAddress.Parse(((HttpContextBase)requestMessage.Properties["MS_HttpConteaxt"]).Request.UserHostAddress).ToString();
            }
            return String.Empty;
        }

        private T GetService<T>(HttpActionContext actionContext)
        {
            return (T)actionContext.Request.GetDependencyScope().GetService(typeof(T));
        }
    }
}