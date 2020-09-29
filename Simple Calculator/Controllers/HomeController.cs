using Simple_Calculator.Models;
using Simple_Calculator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simple_Calculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new CalculatorViewModel();
            return View(model.CalculatorModel);
        }

 
        [HttpPost]
        public ActionResult Index(CalculatorModel model, string command)
        {
            if (command == "add")
            {
                model.Result = model.A + model.B;
            }
            if (command == "subtract")
            {
                model.Result = model.A - model.B;
            }
            if (command == "multiply")
            {
                model.Result = model.A * model.B;
            }
            if (command == "divide")
            {
                model.Result = model.A / model.B;
            }
            return View(model);
        }
    }
}