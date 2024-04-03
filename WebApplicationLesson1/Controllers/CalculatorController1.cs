using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int a, int b, char c)
        {

            if (c == '-')
                return $"{a} -{b} = {a - b}";
            if (c == '*')
                return $"{a} * {b} = {a * b}";
            if (c == '/' && b != 0)
                return $"{a} / {b} = {a / b}";

            return $"{a} + {b} = {a + b}";
        }
    }
}
