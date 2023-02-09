using CloudRMS.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CloudRMS.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string TellMeDate()
        {
            return DateTime.Now.ToString();
        }
        public ViewResult MakeOrder()=>View();
       
        [HttpPost]
        public JsonResult MakeOrder(OrderModel orderModel)
        {
            orderModel.OrderDate = DateTime.Now;
            return Json(orderModel);
        }
    }
}
