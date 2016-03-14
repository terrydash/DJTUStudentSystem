using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DJTUStudentSystem.BLL;
using DJTUStudentSystem.MVCWEB.Models;
using System.Web.Services;

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
            var StuList = S_BLL.GetALLEntityToListFromDAL().Take(10).ToList();
            StudentViewModel _StudentViewModel = new StudentViewModel();
            _StudentViewModel = Session["Student"] as StudentViewModel;
            ViewBag.StudentName = _StudentViewModel.StudentName;
            ViewBag.StudentCode = _StudentViewModel.StudentCode;
            ViewBag.StudentPhotoUrl = @"http://125.222.144.18/photo/" + _StudentViewModel.StudentCode.Substring(0,8) + @"/" + _StudentViewModel.StudentCode + @".jpg";
            var Students=_StudentViewModel.ConvertDataBaseModelToViewModelList(StuList);
            return View(Students);

        }
       

        }
}
