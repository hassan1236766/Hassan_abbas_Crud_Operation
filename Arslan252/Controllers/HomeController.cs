using Arslan252.Data;
using Arslan252.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Arslan252.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbStoreContext _DbStoreContext;

        public HomeController(DbStoreContext DbstoreContext)
        {
            _DbStoreContext = DbstoreContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
