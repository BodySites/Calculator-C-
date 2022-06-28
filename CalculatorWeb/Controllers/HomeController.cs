using OneArgCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwoArgCalculator;

namespace CalculatorWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
             new SelectListItem() { Value = "multiply", Text ="умножение" },
             new SelectListItem() { Value = "addition", Text ="сумма" },
             new SelectListItem() { Value = "subtraction", Text ="вычитание" },
             new SelectListItem() { Value = "division", Text ="деление" },
            new SelectListItem() { Value = "step", Text = "x^y" },
            new SelectListItem() { Value = "degree", Text = "√" },
            };
            return View();
        }
        [HttpPost]
        public ActionResult Index(
 double firstNumber,
 double secondNumber,
 string operation)
        {

            ITwoArgumentsCalculator calculator =
            TwoArgumentsFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstNumber, secondNumber);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]

            {
             new SelectListItem() { Value = "multiply", Text ="умножение" },
             new SelectListItem() { Value = "addition", Text ="сумма" },
             new SelectListItem() { Value = "subtraction", Text ="вычитание" },
             new SelectListItem() { Value = "division", Text ="деление" },
            new SelectListItem() { Value = "step", Text = "x^y" },
            new SelectListItem() { Value = "degree", Text = "√" }
            };
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}