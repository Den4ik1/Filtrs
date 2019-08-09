using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Domain.Interfaces;
using Users.Domain.Models;
using Users.Infrastructure.Intrefaces;

namespace Users.DomainService.Services
{
    public class LogService : ILogServise
    {
        private readonly ILogrepository _logrepository;

        public LogService(ILogrepository logrepository)
        {

        }

        public void Log(RequestInfo ri)
        {
            _logrepository.RequestInformation(new Infrastructure.Models.ReqestLogEntry()
            {
                ClientIP = ri.ClientIP,
                Controller = ri.Controller,
                Request = ri.Request
            });
        }
    }
}
