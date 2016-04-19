using MVC_WebApi.CommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WebApi.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetNews()
        {
            Connection cn = new Connection();
            var json = "";
            try
            {
                json = cn.GetJSON();
                //Json = json.ToString()
                //    //json = json.Replace('\"',' ');
                //json = json.Remove('\"');
                
            }
            catch (Exception ex)
            {
                json = ex.ToString();
            }

            return Json(json, JsonRequestBehavior.AllowGet);
        }


    }
}
