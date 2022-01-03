using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using data_layer;

namespace tabulator.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            

            return View();
        }

        public JsonResult GetStats() {
            var data = VehicleTxService.GetVehicleTx();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetColumnDefinitions() {
            var data = TestService.GetColumnDefinitions();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}