using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DJTUStudentSystem.BLL;
using DJTUStudentSystem.MVCWEB.Models;
using DJTUStudentSystem.Config;

namespace DJTUStudentSystem.MVCWEB.Controllers
{
    public partial class StudentController : Controller
    {
        public string CheckSession(string SessionName,int WaitTime)
        {
           
            if (Session[SessionName] != null)
            {

                var session = Session[SessionName].ToString(); ;
                var dt1 = DateTime.Now;
                try
                {
                    dt1 = Convert.ToDateTime(session);
                }
                catch
                {
                    return "出错了";
                }
                var dt2 = DateTime.Now;
                TimeSpan ts = dt2.Subtract(dt1);
                if (ts.TotalSeconds < WaitTime)
                {
                    return "请等待" + WaitTime.ToString() + "后再试!已等待" + ts.TotalSeconds.ToString("0.00") + "秒";

                }
            }
            Session[SessionName] = DateTime.Now.ToString();
            return "SessionOk".ToUpper();

        }
        //
        // GET: /Student/
        public ActionResult ChooseElectiveCourse()
        {
            var CheckSessionResult = CheckSession("进入选课页面", 10);
            if (CheckSessionResult!="SessionOk".ToUpper())
                {
                    return Content(CheckSessionResult);
                }
            Setting.isReadFromDB = true;
            LoadEntityListFromCache_BLL L_BLL = new LoadEntityListFromCache_BLL();
            List<TeachClassViewModel> _TeachClassViewModelList = new List<TeachClassViewModel>();
            TeachClassViewModel _TeachClassViewModel = new TeachClassViewModel();
            Vw_TeachClass_BLL _Vw_TeachClass_BLL = new Vw_TeachClass_BLL();
            var _Vw_TeachClassList=_Vw_TeachClass_BLL.GetNowTeachClassCsort2();
            _TeachClassViewModelList = _TeachClassViewModel.ConvertDataBaseModelToViewModelList(_Vw_TeachClassList);
            Setting.isReadFromDB = false;
            return View(_TeachClassViewModelList);
        }

        public ActionResult ChooseCourse(int tcid)
        {
           
          if (Request.IsAjaxRequest())
            {
                var CheckSessionResult = CheckSession("提交选课AJAX的时间", 15);

             if (CheckSessionResult!="SessionOk".ToUpper())
                {
                    return Content(CheckSessionResult);
                }


            StudentViewModel _StudentViewModel = Session["Student"] as StudentViewModel;
            Setting.isReadFromDB = true;
            Student_BLL S_BLL = new Student_BLL();
            _StudentViewModel = _StudentViewModel.ConvertDataBaseModelToViewModel((S_BLL.GetEntityFromDAL_WithEntityID(_StudentViewModel.StudentID)));
           
            Session["Student"] = _StudentViewModel;
            Setting.isReadFromDB = false;
            Vw_TeachClass_BLL VTB = new Vw_TeachClass_BLL();
           
            var teachclass = VTB.GetEntityFromDAL_WithEntityID(tcid);
            var GradeCanChoose = Setting.GradeCanChooseCourse().Find(d => d.GradeName == _StudentViewModel.GradeName);
                var HowManyNowHaveStudentChoose = _StudentViewModel.NowStuReportViewModelList.Where(d => d.CSort == "2" && d.Minor == "主修").ToList().Count;
                if (HowManyNowHaveStudentChoose >= GradeCanChoose.HowManyCanChoose)
                {

                    return Content(_StudentViewModel.StudentName+@"同学您好，您本学期已经选择了" + HowManyNowHaveStudentChoose + @"门公选课,你所在年级" + _StudentViewModel.GradeName + @"级,只允许选择" + GradeCanChoose.HowManyCanChoose.ToString() + @"门公选课!");
                }

                    if (teachclass.OpenNum<=teachclass.Havenum)
            {

                    return Content("该课程已经选满!");
                }
            if (teachclass.SelectState!="开放")
            {
                return Content("该课程不是开放状态!");

            }

                if (_StudentViewModel.StuReportViewModelList != null)
                {
                    Setting.isReadFromDB = false;
                    var isChooseThisTCid = _StudentViewModel.NowStuReportViewModelList.Find(d=> d.CourseID == teachclass.CCID);
                    if (isChooseThisTCid != null)
                    {
                        return Content("该门课程本学期已经选择！无法重复修读！");
                    }

                }
                //已经修过该门课程的判断
                if (_StudentViewModel.StuReportViewModelList!=null)
            {
                Setting.isReadFromDB = false;
                var isChooseThisTCid=_StudentViewModel.StuReportViewModelList.Find(d => Convert.ToInt32(d.CourseResult) > 60 && d.CourseID== teachclass.CCID);
                if (isChooseThisTCid != null)
                {
                    return Content("已经修过该门课程并且已经及格无法再选修!");
                }

            }
                Stureport_BLL Stu_BLL = new Stureport_BLL();
                Stu_BLL.AddSelectClass(tcid, _StudentViewModel.StudentCode, "主修");

                
          }

            return Content("不能能直接访问!");
        }

        public virtual ActionResult Main()
        {
            if (Session["Student"] == null)
            { return Content("lostsession"); }
            var CheckSessionResult = CheckSession("刷新选课页面的时间", 10);

            if (CheckSessionResult.ToString() != "SessionOk".ToUpper())
            {
                return Content(CheckSessionResult);
            }
            if (Session["Student"] == null)
            {
                Response.Redirect("/Login/Index");
            }


            Student_BLL S_BLL = new Student_BLL();

            StudentViewModel _StudentViewModel = new StudentViewModel();
            _StudentViewModel = Session["Student"] as StudentViewModel;
            Setting.isReadFromDB = true;
            _StudentViewModel = _StudentViewModel.ConvertDataBaseModelToViewModel((S_BLL.GetEntityFromDAL_WithEntityID(_StudentViewModel.StudentID)));
            Session["Student"] = _StudentViewModel;
            Setting.isReadFromDB = false;
            ViewBag.StudentName = _StudentViewModel.StudentName;
            ViewBag.StudentPhotoUrl = _StudentViewModel.PhotoUrl;
            return View(_StudentViewModel);

        }

        public ActionResult DeleteCourse(int srid)
        {
            var CheckSessionResult = CheckSession("提交选课AJAX的时间", 15);

            if (CheckSessionResult.ToString() != "SessionOk".ToUpper())
            {
                return Content(CheckSessionResult);
            }

                if (Request.IsAjaxRequest())
                {

                        



                }

                return Content("不能直接访问!");
        }
        public static string[,] GetStudentNowKCBWithStuID(int StuID)
        {
            string[,] KCB = new string[8, 8];
            for (int i = 1; i <=7; i++)
            {
                for (int j = 1; j <=7; j++)
                {
                    KCB[i, j] = string.Empty;
                }
                
            }
            LoadEntityListFromCache_BLL L_BLL = new LoadEntityListFromCache_BLL();
            var Vw_Cschedule = L_BLL.GetNowVw_CscheduleByStuid(Setting.isReadFromDB,StuID);
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
                if (_Vw_Cschedule.DSZ!="整")
                { _StudentKCBViewModel.SingleOrDouble ="("+ _Vw_Cschedule.DSZ+"周)"; }
                else { _StudentKCBViewModel.SingleOrDouble = string.Empty; }
                
                _StudentKCBViewModel.Week = _Vw_Cschedule.DayOfWeek;
                int intWeek = 1;
                for (int intSection = 1; intSection <=7 ; intSection++)
                {
                    if  (_StudentKCBViewModel.Section==(intSection * 2 - 1).ToString() + "-" + (intSection * 2).ToString() + "节")
                    {
                        intWeek = Convert.ToInt32(_StudentKCBViewModel.Week);
                        var _KCB= _StudentKCBViewModel.CourseName + "<br />" + _StudentKCBViewModel.TeacherName + "<br />第" + _StudentKCBViewModel.StartWeek + "-" + _StudentKCBViewModel.EndWeek + "周&nbsp;" + _StudentKCBViewModel.SingleOrDouble + "<br />" + _StudentKCBViewModel.RoomName; 
                        if (KCB[intWeek,intSection]==string.Empty)
                        {
                            KCB[intWeek, intSection] = _KCB;

                        }else
                        {
                            KCB[intWeek, intSection] = KCB[intWeek, intSection] + "<br /><br />" + _KCB;
                        }

                    }
                }            
              

            }
            return KCB;

        }


    }
}
