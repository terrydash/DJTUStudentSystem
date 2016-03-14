using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DJTUStudentSystem.BLL;
using DJTUStudentSystem.Common;
using DJTUStudentSystem.MVCWEB.Models;

namespace DJTUStudentSystem.MVCWEB.Controllers
{
    public class LoginController : Controller
    {
        
        //
        // GET: /Login/

        public ActionResult Index()
        {
           
            
            return View();
        }
        [AllowAnonymous]
        public ActionResult GetValidateCode()
        {
            string _ValidateCode = ValidateCode.CreateValidateCode(4);
            Session["ValidateCode"] = _ValidateCode;
            return File(ValidateCode.CreateValidateGraphic(_ValidateCode), @"image/jpeg");
        }
        public ActionResult CheckYanZhengMa(string yzm)
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
        [HttpPost]
        public ActionResult CheckLogin()
        {

            string StudentCode = Request.Form["StudentCode"];
            string StudentPassword = Request.Form["StudentPassword"];

          
            if (Session["LoginTimePass"] != null)
            {

                var session = Session["LoginTimePass"].ToString(); ;
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
                if (ts.TotalSeconds < 10)
                {
                    return Content("请等待10秒后再试!已等待" + ts.TotalSeconds.ToString("0.00") + "秒");

                }
            }

            string result = string.Empty;
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
                    
                    Session["Student"] = _StudentViewModel;
                    Session["LoginTimePass"] = null;
                    return Content("loginok");

                }
                else
                {
                    result = "学号或者密码错误!";
                }
                Session["LoginTimePass"] = DateTime.Now.ToString();

            }
            return Content(result);

        }
    }
}
