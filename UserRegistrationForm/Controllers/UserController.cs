using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRegistrationForm.Models;

namespace UserRegistrationForm.Controllers
{
    public class UserController : Controller
    {

        // GET: /Customer/Index
        public ActionResult Index()
        {

            using (DBmodel dbmodel = new DBmodel())
            {
                return View(dbmodel.MAS_USER.ToList());
            }

        }

        // GET: User
        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
           MAS_USER usermodel = new MAS_USER();

           return View(usermodel);
            //return View();
        }

        // POST: User
        [HttpPost]
        public ActionResult AddOrEdit(MAS_USER usermodel)
        {

           
                using (DBmodel dbmodel = new DBmodel())
                {
                 
                 if (dbmodel.MAS_USER.Any(x => x.UserName == usermodel.UserName))
                {

                    ViewBag.DuplicateMessage = "User Name Already Exist";
                    return View("AddOrEdit", usermodel);

                }
                    dbmodel.MAS_USER.Add(usermodel);
                    dbmodel.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.SuccessMessage = "Registration Successful";         
                return View("AddOrEdit", new MAS_USER());
           

           
        }

    }
}
