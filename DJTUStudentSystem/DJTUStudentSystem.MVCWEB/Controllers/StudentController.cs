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
            Student_BLL S_BLL = new Student_BLL();
            var StuList = S_BLL.GetALLEntityToListFromDAL().Take(10).ToList();
            StudentViewModel _StudentViewModel = new StudentViewModel();
            var Students=_StudentViewModel.ConvertDataBaseModelToViewModelList(StuList);
            return View(Students);

        }
       

        }
}
