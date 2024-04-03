using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int a, int b, string c )
        {

               if(c== "+")
                        return $"{a} + {b} = {a + b}";

               if(c=="-")
                        return $"{a} - {b} = {a - b}";
               if(c == "*")
                    return $"{a} * {b} = {a * b}";
            
            return "Ошибка операции";
        }
}
