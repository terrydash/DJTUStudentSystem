using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DataBaseModel;
namespace DJTUStudentSystem.Interface
{
    public interface IStudentLogin
    {
        Student GetStudent(int Stdid);
        Student GetStudent(string StdCode, string PassWord);
        bool CheckStudent(string StdCode,string PassWord);

    }
}
