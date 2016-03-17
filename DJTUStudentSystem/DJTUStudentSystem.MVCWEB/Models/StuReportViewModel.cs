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
        public int? SRID { get; set; }//学生选课表的ID
        public string CourseName { get; set; }//课程名称
        public string CSort { get; set; }//课程类型
        public string CourseResult { get; set; }//课程成绩
         public string Minor { get; set; }//课程方式
        
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
            try
            {
                Convert.ToInt32(_Entity.成绩);

            }
            catch
            {

                _Entity.成绩 = "0";
            }
            _StuReportViewModel.CourseResult = _Entity.成绩;
            _StuReportViewModel.AtyName = _Entity.当前学期;
            _StuReportViewModel.Minor = _Entity.Minor;
            _StuReportViewModel.TeachClassID = _Entity.TCID;
            _StuReportViewModel.CSort = _Entity.Csort;
            _StuReportViewModel.SRID = _Entity.SRID;
            return _StuReportViewModel;
        }
    }
}
