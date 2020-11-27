using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoOOAD.Entities;
namespace DemoOOAD.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index(string id)
        {
            ViewBag.Ma = id;
            return View();

        }
    }
}
