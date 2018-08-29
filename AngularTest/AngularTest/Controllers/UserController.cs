using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

        /// <summary>
        /// Identifies a list of HTTP methods accessible for this resource
        /// </summary>
        /// <returns>A http response containing a "Access-Control-Allow-Method" header</returns>
        [Route("api/User")]
        public HttpResponseMessage Options()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Headers.Add("Access-Control-Allow-Origin", "*");
            response.Headers.Add("Access-Control-Allow-Methods", "GET");

            return response;
        }
    }
}
