using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Horoscope.Services;
using Horoscope.ViewModels;

namespace Horoscope.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHoroscopeData _studentInfos;

        public HomeController(IHoroscopeData studentInfos)
        {
            _studentInfos = studentInfos;
        }
        public IActionResult Index()
        {
            var model = new IndexViewModel
            {
                StudentInfos = _studentInfos.GetAll(),
                Result = string.Empty
            };

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult CalculateMark(Guid id)
        {
            var student = _studentInfos.Get(id);
            var model = new CalculateViewModel
            {
                _Student = student,
                result=predictMark(student)
            };

            return View(model);
        }

        public IActionResult CalculateDay(Guid id)
        {
            var student = _studentInfos.Get(id);
            var model = new CalculateViewModel
            {
                _Student = student,
                result = predictDay(student)
            };

            return View(model);
        }

        public IActionResult CalculateAll()
        {
            var Getmodel = _studentInfos.GetAboveEight();
            int result=0;
            foreach(var item in Getmodel)
            {
                if (predictMark(item).Equals("Media va creste"))
                    result++;
            }

            return View("CalculateAll", result.ToString());
        }
        private string predictDay(Student student)
        {
            var day = DateTime.Now.Day;
            var fistLetter = student.Nume[0];

            var sumOf = day + fistLetter;

            if (sumOf % 2 == 1)
                return "Azi va fii o zi frumoasa";

            return "Azi va fii o zi mohorata";
        }
        private string predictMark(Student student)
        {
            var sumOfChar = student.Matricol.Length + student.Nume.Length;

            if(sumOfChar%2==1)
            {
                return "Media va creste";
            }

            return "Media va scadea";
        }


    }
}
