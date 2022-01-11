using Arslan252.Data;
using Arslan252.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arslan252.Controllers
{
    public class OrderModels_Arslan : Controller
    {
        private readonly DbStoreContext _context;
        

        public OrderModels_Arslan(DbStoreContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Order o)

        {
            _context.Orders.Add(o);
            _context.SaveChanges();
            return View(o);
        }
        public IActionResult show()
        {
            var save = _context.Orders.ToList();
            return View(save);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            var ordersInDb = _context.Orders.FirstOrDefault(os=>os.Id==id);
            return NotFound();
            _context.Orders.Remove(ordersInDb);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
            
        }
        public IActionResult Details(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var order = _context.Orders.FirstOrDefault(os => os.Id == id);
            if(order== null)
            {
                return NotFound();
            }
            return View(order);

        }
}
}
