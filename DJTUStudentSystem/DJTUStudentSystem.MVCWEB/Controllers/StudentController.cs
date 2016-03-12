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
            var StuList = S_BLL.GetALLEntityToListFromDAL().Take(100).ToList();
            StudentViewModel _StudentViewModel = new StudentViewModel();
            var Students=_StudentViewModel.ConvertDataBaseModelToViewModelList(StuList);
            
            return View(Students);

        }
        [HttpPost]
        public ActionResult GetStudentNameByCode(string scode)
        {

            if (Session["logintimepass"] != null)
            {

                var session = Session["logintimepass"].ToString(); ;
                var dt1 = DateTime.Now;
                try
                {
                    dt1 = Convert.ToDateTime(session);
                }
                catch
                {
                    return Content("出错了");
                }
                var dt2 = DateTime.Now;
                TimeSpan ts = dt2.Subtract(dt1);
                if (ts.TotalSeconds <10)
                {
                    return Content("请等待10秒后再试!已等待"+ ts.TotalSeconds.ToString("0.00")+"秒");

                        }
            }

            string result = string.Empty;
            if (Request.IsAjaxRequest())
            {

                if (string.IsNullOrEmpty(scode))
                {
                    result = "学号不能为空!";
                    return Content(result);
                }

                Student_BLL S_BLL = new Student_BLL();
                var _StudentModel = S_BLL.GetStudentEntityFromDB_WithStudentCode(scode);
                var _StudentViewModel = new StudentViewModel();
                _StudentViewModel = _StudentViewModel.ConvertDataBaseModelToViewModel(_StudentModel);
                if (_StudentViewModel != null)
                {
                    result = _StudentViewModel.StudentName;
                    Session["logintimepass"] = null;
                }
                else
                {
                    result = "学号不存在!";
                }
                Session["logintimepass"] = DateTime.Now.ToString();

            }
            return Content(result);

        }

        }
}
