using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hackme.Models;
using Microsoft.EntityFrameworkCore;
namespace hackme.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {
            if(id==null || !id.HasValue || id.Value<0 || id.Value>5)
                return View();
            else
                return View("Index"+id.Value.ToString());
        }
        
        public JsonResult CheckPassword(string password) {
            Models.DataContext db = new DataContext();
            string sql = "SELECT * FROM Logins WHERE Password='"+password+"'";
            var l = db.Logins.FromSql(sql).ToList();
            return Json(new { query=sql, success=(l!=null && l.Count>0) });
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
