using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoOOAD.Models;
using DemoOOAD.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using HienlthOnline.Helpers;

namespace DemoOOAD.Controllers
{
    public class CartController : Controller
    {
        private readonly DEMO_OOADContext _context;

        public CartController(DEMO_OOADContext context)
        {
            _context = context;
        }
        public List<Cart> Carts
        {
            get
            {
                var data = HttpContext.Session.Get<List<Cart>>("GioHang");
                if (data == null)
                {
                    data = new List<Cart>();
                }
                return data;
            }
        }
        public IActionResult Index()
        {
            var mycart = Carts;
            return View();
        }

       
        public IActionResult addToCart(string id,int quantity )
        {
            var mycart = Carts;
            var item = mycart.SingleOrDefault(p => p.MaMA == id);
            if (item == null)
            {
                var monan = _context.MonAn.SingleOrDefault(p => p.MaMa == id);
                item.MaMA = monan.MaMa;
                item.Hinh = monan.Hinh.ToString();
                item.Gia = Int32.Parse(monan.Gia.ToString());
                item.soluong = quantity;
                Carts.Add(item);
            }
            else
            {
                item.soluong++;
            }
            HttpContext.Session.Set("GioHang", mycart);
            return RedirectToAction("Index", "SanPham");
        }
    }
}
