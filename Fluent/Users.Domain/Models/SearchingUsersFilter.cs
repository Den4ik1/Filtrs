using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Domain.Models
{
    public class SearchingUsersFilter
    {
        public int Limit { get; set; }

        public int Offset { get; set; }
    }
}
