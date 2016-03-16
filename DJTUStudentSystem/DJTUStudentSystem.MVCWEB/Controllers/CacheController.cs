using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DJTUStudentSystem.BLL;
namespace DJTUStudentSystem.MVCWEB.Controllers
{
    public class CacheController : Controller
    {
        //
        // GET: /Cache/

        public ActionResult Index()
        {
            if (Session["Student"] == null)
            {
                Response.Redirect("/Login/Index");
            }
            ViewData["LostSession"] = true;
            return View();
        }

    }
}
