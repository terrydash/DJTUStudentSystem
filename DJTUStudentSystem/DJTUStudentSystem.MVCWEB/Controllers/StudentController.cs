using System;
using System.Collections.Generic;
using System.Linq;
using DJTUStudentSystem.Common;
using System.Web.Mvc;
using DJTUStudentSystem.BLL;
using DJTUStudentSystem.MVCWEB.Models;
using DJTUStudentSystem.Config;
using System.Text;

namespace DJTUStudentSystem.MVCWEB.Controllers
{

    //学生选课相关
    public partial class StudentController : Controller
    {
        
        public ActionResult Logout()
        {

            Session.RemoveAll();
            return Redirect("/Login/Index");
            

        }
        #region 进入选课页面  public ActionResult ChooseElectiveCourse()
        //
        // GET: /Student/
        /// <summary>
        /// 进入选课页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChooseElectiveCourse()
        {
            if (Session["Student"] == null)
            {
                Response.Redirect("/Login/Index");
            }
            var CheckSessionResult = SessionHelper.CheckSession("进入选课页面", 10);
            if (CheckSessionResult!="SessionOk".ToUpper())
                {
                    return Content(CheckSessionResult);
                }
            var StudentModelView = Session["Student"] as StudentViewModel;
            
            
            return View();
        }
        #endregion
        #region 选课操作AJAX public ActionResult ChooseCourse(int tcid)
        /// <summary>
        /// 选课操作AJAX
        /// </summary>
        /// <param name="tcid">要选课的ID号</param>
        /// <returns></returns>
        public ActionResult ChooseCourse(int tcid)
        {
           
          if (Request.IsAjaxRequest())
            {
                if (!Setting.AllowChooseChourse)
                {
                    return Content("选课开关未打开！现在不允许选课！");
                }
                string Message = string.Empty;
                var CheckSessionResult = SessionHelper.CheckSession("提交选课AJAX的时间", 5);

             if (CheckSessionResult!="SessionOk".ToUpper())
                {
                    return Content(CheckSessionResult);
                }
                StudentViewModel _StudentViewModel = Session["Student"] as StudentViewModel;
                DataBaseModel.Vw_TeachClass teachclass = new DataBaseModel.Vw_TeachClass(); ;
            try { 

            
            Setting.isReadFromDB = true;
            Student_BLL S_BLL = new Student_BLL();
            _StudentViewModel = _StudentViewModel.ConvertDataBaseModelToViewModel((S_BLL.GetEntityFromDAL_WithEntityID(_StudentViewModel.StudentID)));
                    
                    Session["Student"] = _StudentViewModel;
            
            Vw_TeachClass_BLL VTB = new Vw_TeachClass_BLL();
           
            teachclass = VTB.GetEntityFromDAL_WithEntityID(tcid);

            var GradeCanChoose = Setting.GradeCanChooseCourse().Find(d => d.GradeName == _StudentViewModel.GradeName);
                var HowManyNowHaveStudentChoose = _StudentViewModel.NowStuReportViewModelList.Where(d => d.CSort == "2" && d.Minor == "主修").ToList().Count;
                    //选课判断：是否超过设置的选课数目
                    if (HowManyNowHaveStudentChoose >= GradeCanChoose.HowManyCanChoose)
                {

                    return Content(_StudentViewModel.StudentName+@"同学您好，您本学期已经选择了" + HowManyNowHaveStudentChoose + @"门公选课,你所在年级" + _StudentViewModel.GradeName + @"级,只允许选择" + GradeCanChoose.HowManyCanChoose.ToString() + @"门公选课!");
                }
                    //选课判断：课程是否已经选满

                    if (teachclass.OpenNum<=teachclass.Havenum)
                {

                    return Content("该课程已经选满!");
                }
                    //选课判断：课程是否为开放状态
            if (teachclass.SelectState!="开放")
            {
                return Content("该课程不是开放状态!");

            }
                //选课判断：该课程是否已经选择过
                if (_StudentViewModel.NowStuReportViewModelList != null)
                {
                    
                    var isChooseThisTCid = _StudentViewModel.NowStuReportViewModelList.Find(d=> d.CourseID == teachclass.CCID);
                    if (isChooseThisTCid != null)
                    {
                        return Content("该门课程本学期已经选择！无法重复修读！");
                    }

                }
                //已经修过该门课程的判断
                if (_StudentViewModel.StuReportViewModelList!=null)
            {
                
                var isChooseThisTCid=_StudentViewModel.StuReportViewModelList.Find(d => Convert.ToInt32(d.CourseResult) > 60 && d.CourseID== teachclass.CCID);
                if (isChooseThisTCid != null)
                {
                    return Content("已经修过该门课程并且已经及格无法再选修!");
                }

            }

                    //选课判断：课表是否与本学期课表冲突
                  Vw_Cschedule_BLL _Vw_Cschedule_BLL = new Vw_Cschedule_BLL();
                  var _TeachClassCscheduleList=  _Vw_Cschedule_BLL.GetNowVw_CscheduleyList_WithAtyidAndTCID(tcid);

                  if (_TeachClassCscheduleList!=null && _StudentViewModel.NowStuReportViewModelList != null)
                   {
                        var _StudentNowCscheduleList = _Vw_Cschedule_BLL.GetNowVw_CscheduleyListForStudent_WithStuID(_StudentViewModel.StudentID);
                       
                      Message = CompareKCB(_TeachClassCscheduleList, _StudentNowCscheduleList);
                        if (Message!=string.Empty)
                        {

                            return Content(Message);
                        }

                    }


                //选课成功插入数据库
              
                   Stureport_BLL Stu1_BLL = new Stureport_BLL();
                  bool result=false;
                    
               
                    result = Stu1_BLL.Insert(tcid, _StudentViewModel.StudentID);
                    Setting.isReadFromDB = false;
                    if (result)
                {
                        Session["刷新选课页面的时间"] = null;
                        if (Message != string.Empty) { return Content(Message+"选课成功！请返回首页查看课表！"); }
                    return Content("选课成功！请返回首页查看课表！");
                }else
                {
                    return Content("选课失败！请联系管理员");
                }
                }
                catch (Exception e)
                {
                    LogHelper.Logger.Error("错误: 学号:" + _StudentViewModel.StudentCode + " 姓名" + _StudentViewModel.StudentName + " 课程名:" + teachclass.课程名称 + " 课程ID:" + teachclass.TCID);
                    return Content(e.ToString());
                }
            }
            return Content("不能能直接访问!");
        }
        #endregion
        #region 主页面/Student/Main public virtual ActionResult Main()
        /// <summary>
        /// 主页面
        /// </summary>
        /// <returns></returns>
        public virtual ActionResult Main()
        {
            
            var CheckSessionResult = SessionHelper.CheckSession("刷新选课页面的时间", 5);

            if (CheckSessionResult.ToString() != "SessionOk".ToUpper())
            {
                return Content(CheckSessionResult);
            }
            if (Session["Student"] == null)
            {
               
                Response.Redirect("/Login/Index");
            }


            var Student=Session["Student"] as StudentViewModel;

            LogHelper.Logger.Info("学号:"+Student.StudentCode + " 姓名" +Student.StudentName +" 成功登陆");
            
           return View();

        }
        #endregion
        #region 删除课程
        /// <summary>
        /// 删除课程
        /// </summary>
        /// <param name="srid"></param>
        /// <returns></returns>
        public ActionResult DeleteCourse(int srid)
        {
            var CheckSessionResult = SessionHelper.CheckSession("提交选课AJAX的时间", 5);

            if (CheckSessionResult.ToString() != "SessionOk".ToUpper())
            {
                return Content(CheckSessionResult);
            }

                if (Request.IsAjaxRequest())
                {
                Stureport_BLL S_Bll = new Stureport_BLL();
                bool result=false;
                    try
                { 
                   result= S_Bll.Delete(srid);
                }
                catch (Exception e)
                {
                    var Student = Session["Student"] as StudentViewModel;
                    var Vw_TC = new Vw_TeachClass_BLL();
                    LogHelper.Logger.Error("学号:"+Student.StudentCode +" 姓名:"+Student.StudentName +" 删除的ID:" +srid.ToString() +" 课程名:"+ Vw_TC.GetEntityFromDAL_WithEntityID((int)S_Bll.GetEntityFromDAL_WithEntityID(srid).TCID).课程名称+" 课程TCID:" + S_Bll.GetEntityFromDAL_WithEntityID(srid).TCID.ToString());
                    return Content("退选出错！请联系管理员");
                }

                return Content("退选成功！");

                }

                return Content("不能直接访问!");
        }
        #endregion 
       
        #region 所选课程 与学生课表 进行比较 看有几周冲突 private string CompareKCB(List<DataBaseModel.Vw_Cschedule> _TeachClassCcheduleList,List<DataBaseModel.Vw_Cschedule> _StudentNowCscheduleList)


        /// <summary>
        /// 所选课程 与学生课表 进行比较 看有几周冲突 private string CompareKCB(List<DataBaseModel.Vw_Cschedule> _TeachClassCcheduleList,List<DataBaseModel.Vw_Cschedule> _StudentNowCscheduleList)
        /// </summary>
        /// <param name="_TeachClassCcheduleList">所选课的课表</param>
        /// <param name="_StudentNowCscheduleList">学生本学期的课表</param>
        /// <returns></returns>
        private string CompareKCB(List<DataBaseModel.Vw_Cschedule> _TeachClassCcheduleList,List<DataBaseModel.Vw_Cschedule> _StudentNowCscheduleList)
        {
            int ConfictWeek = 0;//冲突周数
            string Message = string.Empty;

            StringBuilder _StringBuilder = new StringBuilder();
            foreach (var _TeachClassCschedule in _TeachClassCcheduleList)
            {
                if (_TeachClassCschedule.StartW == null) { _TeachClassCschedule.StartW = 0; }
                if (_TeachClassCschedule.EndW == null) { _TeachClassCschedule.EndW = 0; }
                List<int> XuShengKeBiaohouShu = new List<int>();

                if (_TeachClassCschedule.DSZ == "单")
                {
                    XuShengKeBiaohouShu = MathHelper.GetOddNumbser((int)_TeachClassCschedule.StartW, (int)_TeachClassCschedule.EndW);

                }
                else if (_TeachClassCschedule.DSZ == "双")
                {
                    XuShengKeBiaohouShu = MathHelper.GetEvenNumbser((int)_TeachClassCschedule.StartW, (int)_TeachClassCschedule.EndW);

                }
                else
                {
                    for (int i = (int)_TeachClassCschedule.StartW; i <= (int)_TeachClassCschedule.EndW; i++)
                    {
                        XuShengKeBiaohouShu.Add(i);
                    }

                }


                var FindKCBList = _StudentNowCscheduleList.FindAll(d => d.SectionTH == _TeachClassCschedule.SectionTH && d.DayOfWeek == _TeachClassCschedule.DayOfWeek);
                if (FindKCBList != null)
                {
                    foreach (var FindKCB in FindKCBList)
                    {
                        if (FindKCB.StartW == null) { FindKCB.StartW = 0; }
                        if (FindKCB.EndW == null) { FindKCB.EndW = 0; }
                        List<int> SuoXuanKeZhouShu = new List<int>();
                        
                        if (FindKCB.DSZ == "单")
                        {
                            SuoXuanKeZhouShu = MathHelper.GetOddNumbser((int)FindKCB.StartW, (int)FindKCB.EndW);

                        }
                        else if (FindKCB.DSZ == "双")
                        {
                            SuoXuanKeZhouShu = MathHelper.GetEvenNumbser((int)FindKCB.StartW, (int)FindKCB.EndW);

                        }
                        else
                        {
                            for (int i = (int)FindKCB.StartW; i <= (int)FindKCB.EndW; i++)
                            {
                                SuoXuanKeZhouShu.Add(i);
                            }

                        }
                      


                          

                            foreach (var _XuSheng in XuShengKeBiaohouShu)
                            {
                                foreach (var _SuoXuan in SuoXuanKeZhouShu)
                                {
                                    if (_SuoXuan==_XuSheng)
                                    {
                                        if (_StringBuilder.Length==0)
                                        {
                                            _StringBuilder.Append("您所选的课程<<"+_TeachClassCschedule.CCname+">> 在第");

                                        }
                                        _StringBuilder.Append(_SuoXuan+" &nbsp;");
                                        ConfictWeek += 1;
                                       
                                    }

                                }
                                
                            }
                        
                        if (_StringBuilder.Length != 0)
                        {
                            _StringBuilder.Append("周与<<" + FindKCB.CCname + ">>的周"+FindKCB.DayOfWeek+"的"+FindKCB.SectionTH+"有冲突！");
                            if (Message.Length == 0)
                            {
                                Message = _StringBuilder.ToString();
                            }
                            else
                            {
                                Message = Message + _StringBuilder.ToString();

                            }
                            _StringBuilder.Clear();
                        }


                    }


                }
            }
           
            if (ConfictWeek > Setting.AllowConfictWeeks)
            {
                _StringBuilder.Append("超过了系统设定的只允许冲突" + Setting.AllowConfictWeeks + "周，不允许选课！");
                Setting.AllowChooseChourse = false;

            }
            if (_StringBuilder.Length == 0 && Setting.AllowChooseChourse == true)
            {
                return string.Empty;
            }

            return Message;
        }

        #endregion
       
    }
}
