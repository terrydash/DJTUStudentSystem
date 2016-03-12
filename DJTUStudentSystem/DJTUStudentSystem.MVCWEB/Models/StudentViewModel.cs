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
            var _StudentViewModel = new StudentViewModel();
            _StudentViewModel.StudentCode = _Entity.StdCode;
            _StudentViewModel.StudentID =_Entity.StdID;
            _StudentViewModel.StudentName = _Entity.StdName;
            _StudentViewModel.StudentPassword = _Entity.Password;            
           
            return _StudentViewModel;
            }
            return null;
        }
    }
}
