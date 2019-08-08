using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Infrastructure.Models
{
    public class InfrastructureUser
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Role { get; set; }

        public string Sex { get; set; }

        public int Age { get; set; }
    }
}
