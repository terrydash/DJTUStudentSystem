using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DJTUStudentSystem.BLL;
using DJTUStudentSystem.MVCWEB.Models;
using DJTUStudentSystem.Config;
using DJTUStudentSystem.Common;
namespace DJTUStudentSystem.MVCWEB.Controllers
{
    public class GetJsonController : Controller
    {
        
        public ActionResult GetNowElectiveCourseList()
        {
            StudentController S = new StudentController();
            var CheckSessionResult = S.CheckSession("获取学生课表", 10);
            if (CheckSessionResult != "SessionOk".ToUpper())
            {
                return null;
            }
            if (!Request.IsAjaxRequest()) { return null; }


        }
            
        /// <summary>
        /// 获得当前学期的学生课表
        /// </summary>
        /// <param name="StuID">学生ID</param>
        /// <returns>包含课表的LIST JSON数据</returns>
        public ActionResult GetStudentNowKCBWithStuID_Json(int StuID)
        {
            StudentController S = new StudentController();
             var CheckSessionResult = S.CheckSession("获取学生课表", 10);
            if (CheckSessionResult != "SessionOk".ToUpper())
            {
                return null;
            }
            if (!Request.IsAjaxRequest()) { return null; }
           
            List<StudentKCBViewModel> _StudentKCBViewModelList = new List<StudentKCBViewModel>();
            LoadEntityListFromCache_BLL L_BLL = new LoadEntityListFromCache_BLL();
            var Vw_Cschedule = L_BLL.GetNowVw_CscheduleByStuid(Setting.isReadFromDB, StuID);
            if (Vw_Cschedule == null) { return Content("没有课表"); }
            foreach (var _Vw_Cschedule in Vw_Cschedule)
            {
                
                StudentKCBViewModel _StudentKCBViewModel = new StudentKCBViewModel();
                _StudentKCBViewModel.CCID = _Vw_Cschedule.CCID;
                _StudentKCBViewModel.TCID = _Vw_Cschedule.TCID;
                _StudentKCBViewModel.CourseName = _Vw_Cschedule.CCname;
                _StudentKCBViewModel.CSID = _Vw_Cschedule.CSID;
                _StudentKCBViewModel.StartWeek = _Vw_Cschedule.StartW;
                _StudentKCBViewModel.EndWeek = _Vw_Cschedule.EndW;
                _StudentKCBViewModel.TeacherName = _Vw_Cschedule.PsName;
                _StudentKCBViewModel.PSID = _Vw_Cschedule.PSID;
                _StudentKCBViewModel.Section = _Vw_Cschedule.SectionTH;
                _StudentKCBViewModel.RoomName = _Vw_Cschedule.CRname;
                if (_Vw_Cschedule.DSZ != "整")
                { _StudentKCBViewModel.SingleOrDouble =  _Vw_Cschedule.DSZ + "周"; }
                else { _StudentKCBViewModel.SingleOrDouble = string.Empty; }
                _StudentKCBViewModel.Week = _Vw_Cschedule.DayOfWeek;
                _StudentKCBViewModel.TCName = _Vw_Cschedule.TCName;
                _StudentKCBViewModelList.Add(_StudentKCBViewModel);

            }
            return Content(JsonHelper.SerializeObject(_StudentKCBViewModelList));

        }

    }
}
