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
            Student_BLL S_BLL = new Student_BLL();
            var StuList= S_BLL.GetALLEntityToListFromDAL();
            StudentViewModel _StudentViewModel = new StudentViewModel();
            var Students=_StudentViewModel.ConvertDataBaseModelToViewModel(StuList);
            Console.WriteLine(StuList.Count);
            
            //ViewData["StudentList"] = SList;
            return View(Students);

        }

    }
}
