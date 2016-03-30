using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DJTUStudentSystem.BLL;
using DJTUStudentSystem.Common;
using DJTUStudentSystem.MVCWEB.Models;
using DJTUStudentSystem.Config;
namespace DJTUStudentSystem.MVCWEB.Controllers
{
    public partial class LoginController : Controller
    {

        //
        // GET: /Login/

        public virtual ActionResult Index()
        {
            
            if (Session["Student"] == null)
            {
                RedirectToAction("/Login/Index");
            }

          



            return View();
        }
        [AllowAnonymous]
        public virtual ActionResult GetValidateCode()
        {
           
            
            string _ValidateCode = ValidateCode.CreateValidateCode(4);
            Session["ValidateCode"] = _ValidateCode;
            return File(ValidateCode.CreateValidateGraphic(Session["ValidateCode"].ToString()), @"image/jpeg");
            
                

        }
       
        public virtual ActionResult CheckYanZhengMa(string yzm)
        {


            if (Session["ValidateCode"] != null & string.IsNullOrEmpty(Request.Form["ValidateCode"]))
            {
                string _ValidateCode = Session["ValidateCode"] as string;
                string ValidateCode = yzm;
                if (!_ValidateCode.Equals(ValidateCode))
                {
                    return Content("验证码输入错误！");
                }
                else
                {
                    return Content("true");
                }
            }
            else
            {
                return Content("验证码错误！");

            }

        }

        public virtual ActionResult CheckLogin()
        {
            if (!Setting.AllowChooseChourse)
            {
                return Content(("选课开关未打开！"));

            }

            string StudentCode = Request.Form["StudentCode"];
            string StudentPassword = Request.Form["StudentPassword"];
            var CheckSessionResult = SessionHelper.CheckSession("LoginTimePass", 5);

            if (CheckSessionResult != "SessionOk".ToUpper())
            {
                return Content(CheckSessionResult);
            }

         

            string result = "SB";
            if (Request.IsAjaxRequest())
            {

                if (string.IsNullOrEmpty(StudentCode))
                {
                    result = "学号不能为空!";
                    return Content(result);
                }

                Student_BLL S_BLL = new Student_BLL();
                var _StudentModel = S_BLL.GetStudentEntityFromDB_WithStudentCodeAndStudentPassword(StudentCode, StudentPassword);
                var _StudentViewModel = new StudentViewModel();
                _StudentViewModel = _StudentViewModel.ConvertDataBaseModelToViewModel(_StudentModel);
                if (_StudentViewModel != null)
                {
                    var GradeCanChooseCourse = Setting.GradeCanChooseCourse.First(d => d.GradeName == _StudentViewModel.GradeName);
                     if (GradeCanChooseCourse==null)
                    {
                        return Content("当前年级没有设置，请联系管理员!");
                    }
                    if (GradeCanChooseCourse.isChooseCouse==false)
                    {

                        return Content(_StudentViewModel.StudentName + "同学,你当前所在的年级" + _StudentViewModel.GradeName + "级现在不允许选课!");
                    }
                   Session["Student"] = _StudentViewModel;
                    Session["LoginTimePass"] = null;
                    return Content("loginok");

                }
                else
                {
                    result = "学号或者密码错误!";
                }
                

            }
            return Content(result);

        }
    }
}
