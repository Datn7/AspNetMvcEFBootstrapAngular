using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvcEFBootstrapAngular.Services;
using AspNetMvcEFBootstrapAngular.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcEFBootstrapAngular.Controllers
{
    public class AppController : Controller
    {
        private readonly INullMailService mailService;

        public AppController(INullMailService mailService)
        {
            this.mailService = mailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AngularIndex()
        {
            return View();
        }


        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                mailService.SendMessage("mymail@bs.ge", model.Subject, $"From: {model.Email}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            else
            {

            }

            return View();
        }
    }
}