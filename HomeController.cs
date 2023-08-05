using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;
using Newtonsoft.Json;

namespace WebApplication2
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public ActionResult Seatbooking()
        {
            ViewBag.shapeData = this.SeatData();
            return View();
        }
        public object SeatData()
        {
            string allText = System.IO.File.ReadAllText(Microsoft.AspNetCore.Server.MapPath("~/App_Data/MapData/Seat.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}
