using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootstrap4Test.DomainModels
{
    public class User : IUser
    {
        public int? UserId { get; set; }
        public string UserName { get; set; }
    }
}
