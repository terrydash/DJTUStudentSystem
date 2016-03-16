using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DJTUStudentSystem.BLL;
namespace DJTUStudentSystem.MVCWEB.Controllers
{
    public partial class CacheController : Controller
    {
        //
        // GET: /Cache/

        public virtual ActionResult Index()
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
