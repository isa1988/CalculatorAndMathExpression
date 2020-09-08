using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MathExpressionWithBrackets;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            PageInfo pageInfo = new PageInfo();
            pageInfo.Title = "Домашняя страница";
            return View(pageInfo);
        }

        [HttpGet]
        public ActionResult TaskOne()
        {
            TaskOne taskOne = new TaskOne();
            taskOne.Title = "Первое задание";
            return View(taskOne);
        }

        [HttpPost]
        public ActionResult TaskOne(TaskOne model)
        {
            model.Title = "Первое задание";
            if (model.Export == null || model.Export == string.Empty) return View(model);
            model.Result = new MathExpressionWithBracketsCalc().GetResult(model.Export);
            return View(model);
        }
    }
}