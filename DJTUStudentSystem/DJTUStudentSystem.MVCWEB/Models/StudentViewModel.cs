using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.BLL;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
using DJTUStudentSystem.Config;
namespace DJTUStudentSystem.MVCWEB.Models
{
    public class StudentViewModel :IDataBaseModelToViewModel<StudentViewModel,Student>
    {
        public Activeyear GetNowActYear { get; set; }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int? GradeID { get; set; }
        public string GradeName { get; set; }
        public int HowManyHaveStudentChoose { get; set; }
        public int HowManyNowHaveStudentChoose { get; set; }
        public string StudentCode { get; set; }
        public string StudentPassword { get; set; }
        public string PhotoUrl { get; set; }
        
        public int GradeCanChoose { get; set; }
        public List<StudentKCBViewModel> StudentKCBViewModelList { get; set; }
        public List<StuReportViewModel> NowStuReportViewModelList { get; set; } //本学期课表修课程,列表形式
        public List<StuReportViewModel> StuReportViewModelList{ get;set;} //所有的成绩单和所修课程
        public List<StudentViewModel> ConvertDataBaseModelToViewModelList(List<Student> LS)
        {
            if (LS != null)
            { 
                var StudentViewModelList = new List<StudentViewModel>();
                foreach (var S in LS)
                {
                   
                    StudentViewModelList.Add(ConvertDataBaseModelToViewModel(S));
                    
                }
                return StudentViewModelList;
            }
            else
            {
                return null;
            }



        }

        public  StudentViewModel ConvertDataBaseModelToViewModel(Student _Entity)
        {
            if (_Entity!=null)
            {
                LoadEntityListFromCache_BLL C_BLl = new LoadEntityListFromCache_BLL();
                Vw_Student_BLL VSB = new Vw_Student_BLL();
                var _StudentViewModel = new StudentViewModel();
                _StudentViewModel.GetNowActYear = C_BLl.GetNowActyear(Setting.isReadFromDB);
                _StudentViewModel.StudentCode = _Entity.StdCode;
            _StudentViewModel.StudentID =_Entity.StdID;
            _StudentViewModel.StudentName = _Entity.StdName;
            _StudentViewModel.StudentPassword = _Entity.Password;
                if (_Entity.GradeID==null)
                {
                    _Entity.GradeID = 0;

                }
                _StudentViewModel.GradeName = VSB.GetEntityFromDAL_WithEntityID(_Entity.StdID).年级;
             _StudentViewModel.GradeID =_Entity.GradeID ;
             StuReportViewModel S = new StuReportViewModel();
             _StudentViewModel.NowStuReportViewModelList= S.ConvertDataBaseModelToViewModelList(C_BLl.GetNowActYearVw_StuReportByStuid(Setting.isReadFromDB, _Entity.StdID));
                _StudentViewModel.StuReportViewModelList = S.ConvertDataBaseModelToViewModelList(C_BLl.GetVw_StuReportByStuid(Setting.isReadFromDB, _Entity.StdID));
            _StudentViewModel.PhotoUrl = @"http://125.222.144.18/photo/" + _Entity.StdCode.Substring(0, 8) + @"/" + _Entity.StdCode + @".jpg";

                _StudentViewModel.HowManyNowHaveStudentChoose = _StudentViewModel.NowStuReportViewModelList.Where(d => d.CSort == "2" && d.Minor == "主修").ToList().Count;
                _StudentViewModel.GradeCanChoose = Setting.GradeCanChooseCourse.Find(d => d.GradeName == _StudentViewModel.GradeName).HowManyCanChoose;
                _StudentViewModel.HowManyHaveStudentChoose = _StudentViewModel.StuReportViewModelList.FindAll(d=>d.CSort=="2" && d.Minor=="主修" && Convert.ToInt32(d.CourseResult)>=60).ToList().Count;
                List<StudentKCBViewModel> _StudentKCBViewModelList = new List<StudentKCBViewModel>();
                LoadEntityListFromCache_BLL L_BLL = new LoadEntityListFromCache_BLL();
                var Vw_Cschedule = L_BLL.GetNowVw_CscheduleByStuid(Setting.isReadFromDB, _StudentViewModel.StudentID);
                if (Vw_Cschedule != null)
                {
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
                        { _StudentKCBViewModel.SingleOrDouble = _Vw_Cschedule.DSZ + "周"; }
                        else { _StudentKCBViewModel.SingleOrDouble = string.Empty; }
                        _StudentKCBViewModel.Week = _Vw_Cschedule.DayOfWeek;
                        _StudentKCBViewModel.TCName = _Vw_Cschedule.TCName;
                        _StudentKCBViewModelList.Add(_StudentKCBViewModel);

                    }
                    _StudentViewModel.StudentKCBViewModelList = _StudentKCBViewModelList;
                }

                return _StudentViewModel;
            }
            return null;
        }
    }
}
