using MVC_WebApi.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WebApi.Controllers
{
    public class BusquedasController : Controller
    {
        //
        // GET: /Busquedas/

        public ActionResult Busquedas(FormCollection form)
        {
            Session["search"] = form["search"];
            return View();
        }
        public JsonResult GetSearch()
        {
            Connection cn = new Connection(Session["search"].ToString());
            var json = "";
            try
            {
                json = cn.GetJSON(); 

            }
            catch (Exception ex)
            {
                json = ex.ToString();
            }

            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}
