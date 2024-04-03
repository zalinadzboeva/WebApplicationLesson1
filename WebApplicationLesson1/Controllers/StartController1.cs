using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplicationLesson1.Controllers
{
    public class StartController1 : Controller
    {
        public string hello()
        {
            var time = DateTime.Now.Hour;
            if (time < 6)
            {
                return "Доброй ночи";
            }
            if (time < 12)
            {
                return "Доброе утро";
            }
            if (time < 18)
            {
                return "Добрый день";
            }
            return "Добрый вечер";
        }
    }
}
