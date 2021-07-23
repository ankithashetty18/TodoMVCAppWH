using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoMVCAppWH.Controllers
{
    public class LocalStorageToDoController : Controller
    {
        public IActionResult Index(string item)
        {

            ViewData["TodoItems"] = item;
            return View();
        }

        public IActionResult AddToDoItem(string item)
        {
            ViewData["TodoItems"] = item;
            return View();
        }
    }
}
