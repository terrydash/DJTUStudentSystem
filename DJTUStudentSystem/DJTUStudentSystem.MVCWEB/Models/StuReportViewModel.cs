using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
using DJTUStudentSystem.BLL;
namespace DJTUStudentSystem.MVCWEB.Models 
{
    public class StuReportViewModel :IDataBaseModelToViewModel<StuReportViewModel,Vw_StuReport>
    {
        public string AtyName { get; set; }//学期
        public int? CourseID { get; set; }//课程名称
        public int? TeachClassID { get; set; }//教学班ID
        public string CourseName { get; set; }//课程名称
        public string CourseResult { get; set; }//课程成绩
        public CourseMinor Minor { get; set; }//修课的方式
        public enum CourseMinor//修课方式的枚举
        { 
            Major=0,//主修
            MakeUp=1,//补考
            ReTake=2 //重修

        }
        
        public List<StuReportViewModel> ConvertDataBaseModelToViewModelList(List<Vw_StuReport> _EntityList)
        {
            if (_EntityList.Count == 0) { return null; }
            var _StuReportViewModelList = new List<StuReportViewModel>();
            foreach (var item in _EntityList)
            {
                _StuReportViewModelList.Add(ConvertDataBaseModelToViewModel(item));
            }
            return _StuReportViewModelList;

        }

        public StuReportViewModel ConvertDataBaseModelToViewModel(Vw_StuReport _Entity)
        {
            var _StuReportViewModel = new StuReportViewModel();
            _StuReportViewModel.CourseID = _Entity.CCID;
            _StuReportViewModel.CourseName = _Entity.课程名称;
            _StuReportViewModel.CourseResult = _Entity.成绩;
            _StuReportViewModel.AtyName = _Entity.当前学期;
            switch (_Entity.Minor)
            {
                case "补考":
                    _StuReportViewModel.Minor = CourseMinor.MakeUp;
                    break;
                case "重修":
                    _StuReportViewModel.Minor = CourseMinor.ReTake;
                    break;
                default:
                    _StuReportViewModel.Minor = CourseMinor.Major;
                    break;
            }
            _StuReportViewModel.TeachClassID = _Entity.TCID;
            return _StuReportViewModel;
        }
    }
}
