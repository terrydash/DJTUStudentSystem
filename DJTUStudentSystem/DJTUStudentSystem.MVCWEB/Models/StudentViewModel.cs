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
        public Activeyear GetNowActYear() { LoadEntityListFromCache_BLL L_BLL = new LoadEntityListFromCache_BLL(); return L_BLL.GetNowActyear(Setting.isReadFromDB); }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int? GradeID { get; set; }
        public string GradeName { get; set; }

        public string StudentCode { get; set; }
        public string StudentPassword { get; set; }
        public string PhotoUrl { get; set; }
        public string[,] NowKCBstring = new string[8, 8];//本学期课表，字符串数组

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
             _StudentViewModel.NowStuReportViewModelList= S.ConvertDataBaseModelToViewModelList(C_BLl.GetNowActYearVw_StuReportByStuid(Config.Setting.isReadFromDB, _Entity.StdID));
                _StudentViewModel.StuReportViewModelList = S.ConvertDataBaseModelToViewModelList(C_BLl.GetVw_StuReportByStuid(Config.Setting.isReadFromDB, _Entity.StdID));
            _StudentViewModel.PhotoUrl = @"http://125.222.144.18/photo/" + _Entity.StdCode.Substring(0, 8) + @"/" + _Entity.StdCode + @".jpg";
                _StudentViewModel.NowKCBstring = DJTUStudentSystem.MVCWEB.Controllers.StudentController.GetStudentNowKCBWithStuID(_Entity.StdID);
                return _StudentViewModel;
            }
            return null;
        }
    }
}
