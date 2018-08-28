using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bootstrap4Test.Data;
using Bootstrap4Test.DomainModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bootstrap4Test.Controllers
{
    public class UserTestController : Controller
    {
        private UserContext _userContext;
        public UserTestController(UserContext userContext)
        {
            _userContext = userContext;
        }
        // GET: UserTest
        public ActionResult Index()
        {
            return View(_userContext.Users.ToList());
        }

        // GET: UserTest/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var user = _userContext.Find(typeof(User), id) as User;
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return View(user);
            }
        }

        // GET: UserTest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserTest/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm]DTOs.User u)
        {
            try
            {                
                    var user = new User
                    {
                        UserName = u.UserName
                    };
                    _userContext.SaveChanges();  
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserTest/Edit/5
        public ActionResult Edit(int id)
        {
            var user = _userContext.Find(typeof(User), id) as User;
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return View(user);
            }            
        }

        // POST: UserTest/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm]DTOs.User u)
        {
            try
            {
                var dbUser = _userContext.Find(typeof(User), id) as User;
                if (dbUser == null)
                {
                    return NotFound();
                }
                else
                {
                    dbUser.UserName = u.UserName;
                    _userContext.SaveChanges();
                }                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserTest/Delete/5
        public ActionResult Delete(int id)
        {
            var dbUser = _userContext.Find(typeof(User), id) as User;
            if (dbUser == null)
            {
                return NotFound();
            }
            else
            {
                _userContext.Users.Remove(dbUser);
                _userContext.SaveChanges();
                return RedirectToAction("Index");
            }           
        }        
    }
}