﻿
using System.Collections.Generic;

using System.Web.Mvc;
using DJTUStudentSystem.BLL;
using DJTUStudentSystem.MVCWEB.Models;
using DJTUStudentSystem.Config;
using DJTUStudentSystem.Common;
namespace DJTUStudentSystem.MVCWEB.Controllers
{
    public class GetJsonController : Controller
    {
        
        public ActionResult GetNowElectiveCourseList_Json()
        {
            if (!Request.IsAjaxRequest()) { return Content("不可直接调用"); }
            
            var CheckSessionResult = SessionHelper.CheckSession("获取当前学期的选修课", 1);
            if (CheckSessionResult != "SessionOk".ToUpper())
            {
                return Content("tofast".ToUpper());
            }
            
            if (!Request.IsAjaxRequest()) { return null; }
            
            LoadEntityListFromCache_BLL L_BLL = new LoadEntityListFromCache_BLL();
            
            TeachClassViewModel _TeachClassViewModel = new TeachClassViewModel();
            var _TeachClassList = L_BLL.GetNowTeachClassCsort2();
            var _TeachClassViewModelList = _TeachClassViewModel.ConvertDataBaseModelToViewModelList(_TeachClassList);
            /*
            Setting.isReadFromDB = true;
            LoadEntityListFromCache_BLL L_BLL = new LoadEntityListFromCache_BLL();
            List<TeachClassViewModel> _TeachClassViewModelList = new List<TeachClassViewModel>();
            TeachClassViewModel _TeachClassViewModel = new TeachClassViewModel();
            Vw_TeachClass_BLL _Vw_TeachClass_BLL = new Vw_TeachClass_BLL();
            var _Vw_TeachClassList = _Vw_TeachClass_BLL.GetNowTeachClassCsort2();
            _TeachClassViewModelList = _TeachClassViewModel.ConvertDataBaseModelToViewModelList(_Vw_TeachClassList);
            Setting.isReadFromDB = false;
            */
            return Content(JsonHelper.SerializeObject(_TeachClassViewModelList));


        }
        public ActionResult GetStudentInfoFromSession_Json()
        {
             if (!Request.IsAjaxRequest()) { return Content("不可直接调用"); }
           
                if (Session["Student"] == null) { return Content("登陆信息丢失，请重新登陆！".ToUpper()); }
                
                var CheckSessionResult = SessionHelper.CheckSession("获取学生信息", 1);
                if (CheckSessionResult != "SessionOk".ToUpper())
                {
                    return Content(CheckSessionResult);
                }
                
                var _StudentModelView = Session["Student"] as StudentViewModel;
                LoadEntityListFromCache_BLL L_BLL = new LoadEntityListFromCache_BLL();
                Setting.isReadFromDB = true;
                var _Student = L_BLL.GetStudentByStuID(_StudentModelView.StudentID);
                _StudentModelView = _StudentModelView.ConvertDataBaseModelToViewModel(_Student);
                Setting.isReadFromDB = false;
                Session["Student"] = _StudentModelView;
                return Content(JsonHelper.SerializeObject(_StudentModelView));
        }
            
        /// <summary>
        /// 获得当前学期的学生课表
        /// </summary>
        /// <param name="StuID">学生ID</param>
        /// <returns>包含课表的LIST JSON数据</returns>
        public ActionResult GetStudentNowKCBWithStuID_Json()
        {   if (Session["Student"] == null) { return Content("登陆信息丢失，请重新登陆！".ToUpper()); }
           
             var CheckSessionResult = SessionHelper.CheckSession("获取学生课表", 10);
            if (CheckSessionResult != "SessionOk".ToUpper())
            {
                return Content(CheckSessionResult);
            }
            if (!Request.IsAjaxRequest()) { return Content("不可直接调用"); }
            { 
            

            }
            var Student = Session["Student"] as StudentViewModel;
            return Content(JsonHelper.SerializeObject(Student.StudentKCBViewModelList));

        }

    }
}
