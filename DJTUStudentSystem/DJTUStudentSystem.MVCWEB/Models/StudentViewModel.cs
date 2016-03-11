using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.BLL;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;

namespace DJTUStudentSystem.MVCWEB.Models
{
    public class StudentViewModel :IDataBaseModelToViewModel<StudentViewModel,Student>
    {
        
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentCode { get; set; }
        public string StudentPassword { get; set; }
        public List<StudentViewModel> ConvertDataBaseModelToViewModel(List<Student> LS)
        {
            if (LS != null)
            { 
                var StudentViewModelList = new List<StudentViewModel>();
                foreach (var S in LS)
                {
                    var _StudentViewModel = new StudentViewModel();
                    _StudentViewModel.StudentCode = S.StdCode;
                    _StudentViewModel.StudentID = S.StdID;
                    _StudentViewModel.StudentName = S.StdName;
                    _StudentViewModel.StudentPassword = S.Password;
                    StudentViewModelList.Add(_StudentViewModel);
                    _StudentViewModel = null;
                }
                return StudentViewModelList;
            }
            else
            {
                return null;
            }



        }

       
    }
}
