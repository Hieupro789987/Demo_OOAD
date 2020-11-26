using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoOOAD.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DemoOOAD.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoaiController : Controller
    {
        private readonly DEMO_OOADContext _context;

        public LoaiController(DEMO_OOADContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.LoaiMa);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(LoaiMa loai)
        {
            _context.Add(loai);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
       public IActionResult Edit(string id)
        {
            
            return View();
        }
    }
}
