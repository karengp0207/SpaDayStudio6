using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;


namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.user = newUser;
                return View("Index");
            }
            else
            {
                ViewBag.error = "Passwords do not match!  Try again!";
                ViewBag.userName = newUser.Username;
                ViewBag.email = newUser.Email;
                return View("Add");
            }
        }
    }
}
    

