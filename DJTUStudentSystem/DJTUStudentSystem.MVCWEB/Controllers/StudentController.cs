using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DJTUStudentSystem.BLL;
using DJTUStudentSystem.MVCWEB.Models;


namespace DJTUStudentSystem.MVCWEB.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        public ActionResult Main()
        {
            
            if (Session["Student"] == null)
            {
                Response.Redirect("/Login/Index");
            }
            

            Student_BLL S_BLL = new Student_BLL();
            
            StudentViewModel _StudentViewModel = new StudentViewModel();
            

            _StudentViewModel = Session["Student"] as StudentViewModel;
            return View(_StudentViewModel);

        }
       

        }
}
