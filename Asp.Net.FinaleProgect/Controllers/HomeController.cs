using Asp.Net.FinaleProgect.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Asp.Net.FinaleProgect.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(/*string sortOrder, string currentFilter, string searchString, int? page*/)
        {
            return View();

            //var data = _db.TestTable.ToLIst();

            //if (searchString == null)
            //{
            //    page = 1;
            //}
            //else
            //{
            //    searchString = currentFilter;
            //}

            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    data = data.Where(s => s.Contains(searchString)).ToLIst();
            //}
            //switch (sortOrder)
            //{
            //    case "name_desc":
            //        data = data.OrderByDescending(s => s.ToString()).ToList();
            //        break;
            //    default:
            //        data = data.OrderBy(s => s.ToString()).ToLIst();
            //        break;
            //}

            //int pageSize = 3;
            //int pageNumber = (page ?? 1);
            //data = data.Skip(pageNumber-1+pageSize).Take(pageSize).ToList();
            //return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}