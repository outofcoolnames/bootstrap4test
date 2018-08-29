using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularTest.Data;
using AngularTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularTest.Controllers
{
    public class UserController : Controller
    {
        private IUserContext _userContext;
        public UserController(IUserContext userContext)
        {
            _userContext = userContext;
        }

        [Route("api/User")]
        public IEnumerable<User> GetUsers()
        {
            return _userContext.Users.ToList();
        }
    }
}
