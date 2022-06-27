using CalculatorWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OneArgCalculator;
using System.Diagnostics;
using TwoArgCalculator;

namespace CalculatorWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public SelectListItem[] OperationViewBag()
        {
            return new SelectListItem[]
            {
                new SelectListItem() { Value = "multiply", Text ="умножение" },
                new SelectListItem() { Value = "addition", Text ="сложение" },
                new SelectListItem() { Value = "subtraction", Text ="вычитание" },
                new SelectListItem() { Value = "division", Text ="деление" },
                new SelectListItem() { Value = "searchMin", Text ="мин(x,y)" },
                new SelectListItem() { Value = "searchMax", Text ="мах(x,y)" },
                new SelectListItem() { Value = "cos", Text ="cos(x)" },
                new SelectListItem() { Value = "sin", Text ="sin(x)" },
                new SelectListItem() { Value = "module", Text ="|x|" }
            };
        }

        public ActionResult Index()
        {
            ViewBag.Operation = OperationViewBag();

            return View();
        }

        [HttpPost]
        public ActionResult Index(
         double firstNumber,
         double secondNumber,
         string operation)
        {
            double result = 0;

            try
            {
                if (operation == "cos" || operation == "sin" || operation == "module")
                {
                    IOneArgumentCalculator calculator =
                        OneArgumentFactory.CreateCalculator(operation);

                    if (secondNumber != 0) result = calculator.Calculate(secondNumber);
                    else result = calculator.Calculate(firstNumber);
                }
                else
                {
                    ITwoArgumentsCalculator calculator =
                        TwoArgumentsFactory.CreateCalculator(operation);
                    result = calculator.Calculate(firstNumber, secondNumber);
                }

                ViewBag.Result = result;
            }
            catch (Exception ex)
            {
                ViewBag.Result = "Некорректные данные";
            }

            ViewBag.Operation = OperationViewBag();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}