using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Common;
using DJTUStudentSystem.Config;
using DJTUStudentSystem.Interface;
using DJTUStudentSystem.BLL;
namespace DJTUStudentSystem.MVCWEB.Models
{
    public class TeachClassViewModel:IDataBaseModelToViewModel<TeachClassViewModel,TeachClass>
    {
        private int i = 0;
        public string XuHao=string.Empty;
        public int? CourseID { get; set; }//课程名称
        public string CourseName { get; set; }//课程名称
        public int TCID { get; set; }//ID
        public string TeacherName { get; set; }//教师名称
        public int? OpenNum { get; set; } //开放人数
        public int? HaveNum { get; set; } //已选人数    
        public string KCB { get; set; } // 课程表
        public int allowance { get; set; } //余量
        //public List<TeachClassKCBViewModel> KCBList { get; set; } //课程表的列表
        public string SelectState { get; set; }//开放状态
        public bool IsCurrentStudentCanChoose = true;//当前学生是否能选
        public bool IsHaveChosen = false;//当前学生是否已选
        
        public string Html { get; set; }//输出HTML代码 

        public List<TeachClassViewModel> ConvertDataBaseModelToViewModelList(List<TeachClass> _EntityList)
        {
            List<TeachClassViewModel> _TeachClassViewModelList = new List<TeachClassViewModel>();
            foreach (var item in _EntityList)
            {
                _TeachClassViewModelList.Add(ConvertDataBaseModelToViewModel(item));
            }
            return _TeachClassViewModelList;
        }

        public TeachClassViewModel ConvertDataBaseModelToViewModel(TeachClass _Entity)
        {
            i += 1;
           
            TeachClassViewModel _TeachClassViewModel = new TeachClassViewModel();
            _TeachClassViewModel.XuHao = i.ToString();
            LoadEntityListFromCache_BLL L_BLL = new LoadEntityListFromCache_BLL();
            
           
                        _TeachClassViewModel.HaveNum =_Entity.Havenum;
                if (_TeachClassViewModel.HaveNum==null)
                {
                    _TeachClassViewModel.HaveNum = 0;
                }
                         _TeachClassViewModel.OpenNum =_Entity.OpenNum;
                if (_TeachClassViewModel.OpenNum==null)
                {
                    _TeachClassViewModel.OpenNum = 0;
                }
                if ((int) _TeachClassViewModel.HaveNum> (int) _TeachClassViewModel.OpenNum)
                {
                    _TeachClassViewModel.HaveNum = _TeachClassViewModel.OpenNum;
                }
                          _TeachClassViewModel.SelectState =_Entity.SelectState;
                          _TeachClassViewModel.TCID =_Entity.TCID;
                          _TeachClassViewModel.allowance = (int)_TeachClassViewModel.OpenNum - (int)_TeachClassViewModel.HaveNum;                            
                          _TeachClassViewModel.CourseID =_Entity.CCID;

                        var _KCBList = L_BLL.GetCscheduleByTCID(_TeachClassViewModel.TCID);
                        string _KCBStrList = string.Empty;
                        
                           
                      foreach (var _KCB in _KCBList)
                      {
                        string _KCBStr = string.Empty;
                        string DSZ= string.Empty;
                        string ClassRoomName = string.Empty;

                        if (_KCB.DSZ != "整")
                           { DSZ = "(" + _KCB.DSZ + "周)"; } else { DSZ = string.Empty; }

                        try
                        {
                            ClassRoomName = L_BLL.GetClassRoomByCRID((int)_KCB.CRID).CRname;
                        }
                        catch (Exception e)
                        {
                            LogHelper.Logger.Error(e.ToString());
                            ClassRoomName = "教室待定";
                        }

                         _KCBStr= "第" + _KCB.StartW + "-" + _KCB.EndW + "周 周" + _KCB.DayOfWeek + " " + _KCB.SectionTH  + DSZ + " " + ClassRoomName;
                            if (string.IsNullOrEmpty(_KCBStrList))
                          {
                                _KCBStrList = _KCBStr;
                          }
                            else
                          {
                                _KCBStrList =_KCBStrList+"<br />"+ _KCBStr;
                           }                            

                         }
                    _TeachClassViewModel.KCB = _KCBStrList;
                          
                try
                { 
                    _TeachClassViewModel.CourseName = L_BLL.GetCurriculaByCCID((int)_Entity.CCID).CCname;
                    _TeachClassViewModel.TeacherName = L_BLL.GetTeacherByPSID((int)_Entity.TCHID).PsName;
                }
                catch (Exception e)
                {
                    LogHelper.Logger.Error(e.ToString());
                    _TeachClassViewModel.CourseName = "课程名未知";
                    _TeachClassViewModel.TeacherName = "教师待定";
                }
            if (System.Web.HttpContext.Current.Session["Student"] != null)
            {
                
                
                int SRID = -1;                
                var StudentModel = System.Web.HttpContext.Current.Session["Student"] as StudentViewModel;
                var GradeCanChoose = Setting.GradeCanChooseCourse().Find(d => d.GradeName == StudentModel.GradeName);
                if (StudentModel.NowStuReportViewModelList.Find(d => d.TeachClassID == _TeachClassViewModel.TCID) != null)
                {
                    _TeachClassViewModel.IsHaveChosen = true;
                    SRID = (int)StudentModel.NowStuReportViewModelList.Find(d => d.TeachClassID == _TeachClassViewModel.TCID).SRID;
                }
                var FindTeachCLass = StudentModel.StuReportViewModelList.FindAll(d => d.CourseID == _TeachClassViewModel.CourseID);
                _TeachClassViewModel.Html = "异常";
               
                if (_TeachClassViewModel.SelectState != "开放")
                {
                    _TeachClassViewModel.IsCurrentStudentCanChoose = false;
                    _TeachClassViewModel.Html = "锁定状态";
                }
                else
                if (_TeachClassViewModel.allowance == 0)
                {
                    _TeachClassViewModel.IsCurrentStudentCanChoose = false;
                    _TeachClassViewModel.Html = "已选满";

                }
                else
                if (StudentModel.HowManyHaveStudentChoose >= 3)
                {

                    _TeachClassViewModel.IsCurrentStudentCanChoose = false;
                    _TeachClassViewModel.Html = "已修够3门";
                }
                else
                if (StudentModel.HowManyNowHaveStudentChoose >= StudentModel.GradeCanChoose)
                {

                    _TeachClassViewModel.IsCurrentStudentCanChoose = false;
                    _TeachClassViewModel.Html = "本学期选满";
                } else
                 if (FindTeachCLass != null)
                {
                    var maxresult = 0;
                    foreach (var item in FindTeachCLass)
                    {
                        try
                        {
                            if (Convert.ToInt32(item.CourseResult) > maxresult)
                            {
                                maxresult = Convert.ToInt32(item.CourseResult);

                            }
                        }
                        catch (Exception e)
                        {
                            LogHelper.Logger.Error(e.ToString());
                        }
                        if (maxresult > 60)
                        {
                            _TeachClassViewModel.IsCurrentStudentCanChoose = false;
                            _TeachClassViewModel.Html = "已经修过";
                        }

                    }

                }
                
                if (_TeachClassViewModel.IsHaveChosen)
                {
                    _TeachClassViewModel.XuHao = "已选";
                    _TeachClassViewModel.Html = "<button type='button' onclick='DeleteCourse(" + SRID + ")' class='btn btn-danger' >退 选</button>";

                }
                else { _TeachClassViewModel.XuHao = i.ToString(); }


                if (!_TeachClassViewModel.IsHaveChosen && _TeachClassViewModel.SelectState == "开放" && _TeachClassViewModel.allowance > 0 && StudentModel.HowManyHaveStudentChoose < 3 && StudentModel.HowManyNowHaveStudentChoose < StudentModel.GradeCanChoose)
                {
                    {
                        _TeachClassViewModel.IsCurrentStudentCanChoose = true;
                        _TeachClassViewModel.Html = "<button type='button' onclick='ChooseCourse(" + _TeachClassViewModel.TCID + ")' class='btn btn-success vert-align' >选此课</button>";
                    }
                }




            }

            return _TeachClassViewModel;

        }
        #region 停止使用
        public List<TeachClassViewModel> ConvertDataBaseModelToViewModelList(List<Vw_TeachClass> _EntityList)
        {
            List<TeachClassViewModel> _TeachClassViewModelList = new List<TeachClassViewModel>();
            foreach (var item in _EntityList)
            {
                _TeachClassViewModelList.Add(ConvertDataBaseModelToViewModel(item));
            }
            return _TeachClassViewModelList;
        }

        public TeachClassViewModel ConvertDataBaseModelToViewModel(Vw_TeachClass _Entity)
        {
            i += 1;
            var SRID = 0;
            TeachClassViewModel _TeachClassViewModel = new TeachClassViewModel();
            TeachClassKCBViewModel _TeachClassKCBViewModel = new TeachClassKCBViewModel();
            List<TeachClassKCBViewModel> _TeachClassKCBViewModelList = new List<TeachClassKCBViewModel>();
            LoadEntityListFromCache_BLL L_BLL = new LoadEntityListFromCache_BLL();
            var Vw_CscheduleList = L_BLL.GetNowVw_CscheduleByTCID(Setting.isReadFromDB, _Entity.TCID);
            foreach (var _Vw_Cschedule in Vw_CscheduleList)
            {
                _TeachClassKCBViewModel.CCID = _Vw_Cschedule.CCID;
                _TeachClassKCBViewModel.TCID = _Vw_Cschedule.TCID;
                _TeachClassKCBViewModel.CourseName = _Vw_Cschedule.CCname;
                _TeachClassKCBViewModel.CSID = _Vw_Cschedule.CSID;
                _TeachClassKCBViewModel.StartWeek = _Vw_Cschedule.StartW;
                _TeachClassKCBViewModel.EndWeek = _Vw_Cschedule.EndW;
                _TeachClassKCBViewModel.TeacherName = _Vw_Cschedule.PsName;
                _TeachClassKCBViewModel.PSID = _Vw_Cschedule.PSID;
                _TeachClassKCBViewModel.Section = _Vw_Cschedule.SectionTH;
                _TeachClassKCBViewModel.RoomName = _Vw_Cschedule.CRname;
               

                _TeachClassKCBViewModel.Week = _Vw_Cschedule.DayOfWeek;
                var _KCB = "第" + _TeachClassKCBViewModel.StartWeek + "-" + _TeachClassKCBViewModel.EndWeek + "周 周" + _TeachClassKCBViewModel.Week + " " + _TeachClassKCBViewModel.Section + _TeachClassKCBViewModel.SingleOrDouble + " " + _TeachClassKCBViewModel.RoomName;
                if (string.IsNullOrEmpty(_TeachClassViewModel.KCB))
                {
                    _TeachClassViewModel.KCB = _KCB;

                }
                else
                {
                    _TeachClassViewModel.KCB = _TeachClassViewModel.KCB + "<br />" + _KCB;
                }
                //_TeachClassKCBViewModelList.Add(_TeachClassKCBViewModel);
            }


            _TeachClassViewModel.CourseName = _Entity.课程名称;

            //_TeachClassViewModel.KCBList = _TeachClassKCBViewModelList;
            if (_Entity.OpenNum == null) { _Entity.OpenNum = 0; }
            if (_Entity.Havenum == null) { _Entity.Havenum = 0; }

            _TeachClassViewModel.OpenNum = _Entity.OpenNum;
            _TeachClassViewModel.HaveNum = _Entity.Havenum;

            if (_TeachClassViewModel.HaveNum > _TeachClassViewModel.OpenNum)
            {

                _TeachClassViewModel.HaveNum = _TeachClassViewModel.OpenNum;
            }
            _TeachClassViewModel.allowance = (int)_TeachClassViewModel.OpenNum - (int)_TeachClassViewModel.HaveNum;
            _TeachClassViewModel.TCID = _Entity.TCID;
            _TeachClassViewModel.CourseID = (int)_Entity.CCID;
            _TeachClassViewModel.TeacherName = _Entity.任课教师;
            _TeachClassViewModel.SelectState = _Entity.SelectState;

            if (System.Web.HttpContext.Current.Session["Student"] != null)
            {

                Setting.isReadFromDB = true;
                var StudentModel = System.Web.HttpContext.Current.Session["Student"] as StudentViewModel;
                Student_BLL S_BLL = new Student_BLL();
                StudentModel = StudentModel.ConvertDataBaseModelToViewModel((S_BLL.GetEntityFromDAL_WithEntityID(StudentModel.StudentID)));
                System.Web.HttpContext.Current.Session["Student"] = StudentModel;
                Setting.isReadFromDB = false;
                var GradeCanChoose = Setting.GradeCanChooseCourse().Find(d => d.GradeName == StudentModel.GradeName);
                if (StudentModel.NowStuReportViewModelList.Find(d => d.TeachClassID == _TeachClassViewModel.TCID) != null)
                {
                    _TeachClassViewModel.IsHaveChosen = true;
                    SRID = (int)StudentModel.NowStuReportViewModelList.Find(d => d.TeachClassID == _TeachClassViewModel.TCID).SRID;
                }
                var FindTeachCLass = StudentModel.StuReportViewModelList.FindAll(d => d.CourseID == _TeachClassViewModel.CourseID);

                if (FindTeachCLass != null)
                {
                    var maxresult = 0;
                    foreach (var item in FindTeachCLass)
                    {
                        try
                        {
                            if (Convert.ToInt32(item.CourseResult) > maxresult)
                            {
                                maxresult = Convert.ToInt32(item.CourseResult);

                            }
                        }
                        catch (Exception e)
                        {
                            LogHelper.Logger.Error(e.ToString());
                        }
                        if (maxresult > 60)
                        {
                            _TeachClassViewModel.IsCurrentStudentCanChoose = false;
                            _TeachClassViewModel.Html = "已经修过";
                        }

                    }

                }
                if (_TeachClassViewModel.allowance == 0)
                {
                    _TeachClassViewModel.IsCurrentStudentCanChoose = false;
                    _TeachClassViewModel.Html = "已选满";

                }


                if (_TeachClassViewModel.SelectState != "开放")
                {
                    _TeachClassViewModel.IsCurrentStudentCanChoose = false;
                    _TeachClassViewModel.Html = "锁定状态";
                }
                if (StudentModel.HowManyHaveStudentChoose >= 3)
                {

                    _TeachClassViewModel.IsCurrentStudentCanChoose = false;
                    _TeachClassViewModel.Html = "已修够3门";
                }
                if (StudentModel.HowManyNowHaveStudentChoose >= StudentModel.GradeCanChoose)
                {

                    _TeachClassViewModel.IsCurrentStudentCanChoose = false;
                    _TeachClassViewModel.Html = "本学期选满";
                }
                if (_TeachClassViewModel.IsHaveChosen)
                {
                    _TeachClassViewModel.XuHao = "已选";
                    _TeachClassViewModel.Html = "<button type='button' onclick='DeleteCourse(" + SRID + ")' class='btn btn-danger' >退 选</button>";

                }
                

                if (!_TeachClassViewModel.IsHaveChosen && _TeachClassViewModel.SelectState == "开放" && _TeachClassViewModel.allowance > 0 && StudentModel.HowManyHaveStudentChoose < 3 && StudentModel.HowManyNowHaveStudentChoose < StudentModel.GradeCanChoose)
                {
                    {
                        _TeachClassViewModel.IsCurrentStudentCanChoose = true;
                        _TeachClassViewModel.Html = "<button type='button' onclick='ChooseCourse(" + _TeachClassViewModel.TCID + ")' class='btn btn-success vert-align' >选此课</button>";
                    }
                }



            }



            return _TeachClassViewModel;

        }
    }
    #endregion
}
