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
        //
        // GET: /Student/
        public ActionResult ChooseElectiveCourse()
        {
            LoadEntityListFromCache_BLL L_BLL = new LoadEntityListFromCache_BLL();
            List<TeachClassViewModel> _TeachClassViewModelList = new List<TeachClassViewModel>();
            TeachClassViewModel _TeachClassViewModel = new TeachClassViewModel();
            Vw_TeachClass_BLL _Vw_TeachClass_BLL = new Vw_TeachClass_BLL();
            var _Vw_TeachClassList=_Vw_TeachClass_BLL.GetNowTeachClassCsort2();
            _TeachClassViewModelList = _TeachClassViewModel.ConvertDataBaseModelToViewModelList(_Vw_TeachClassList);
            return View(_TeachClassViewModelList);
        }

        public ActionResult ChooseCourse(int tcid)
        {if (Session["Student"] == null)
            { return Content("lostsession"); }
          if (Request.IsAjaxRequest())
            {
               
                if (Session["ChooseTimePass"] != null)
                {

                    var session = Session["ChooseTimePass"].ToString(); ;
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
                Session["ChooseTimePass"] = DateTime.Now.ToString();


            }
            StudentViewModel _StudentViewModel = new StudentViewModel();
            if (_StudentViewModel.StuReportViewModelList!=null)
            {

                var isChooseThisTCid=_StudentViewModel.StuReportViewModelList.Find(d => Convert.ToInt32(d.CourseResult) > 60 && d.TeachClassID == tcid);
                if (isChooseThisTCid != null)
                {
                    return Content("已经修过该门课程无法再修!");
                }

            }
            return Content("不能能直接访问!");
        }

        public virtual ActionResult Main()
        {

            if (Session["Student"] == null)
            {
                Response.Redirect("/Login/Index");
            }


            Student_BLL S_BLL = new Student_BLL();

            StudentViewModel _StudentViewModel = new StudentViewModel();


            _StudentViewModel = Session["Student"] as StudentViewModel;
            ViewBag.StudentName = _StudentViewModel.StudentName;
            ViewBag.StudentPhotoUrl = _StudentViewModel.PhotoUrl;
            return View(_StudentViewModel);

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
