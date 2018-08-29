using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTest.Models
{
    public class User : IUser
    {
        public int? UserId { get; set; }
        public string UserName { get; set; }
    }
}
