using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CalculatorController1 : Controller
    {
        public class CalculatorController : Controller
        {
            public string Index(int a, int b)
            {
                return $"{a} + {b} = {a + b}";
            }
        }

    }
}
