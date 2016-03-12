using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dos.ORM;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
using DJTUStudentSystem.DBSession;
namespace DJTUStudentSystem.DAL
{
    #region 学生表的数据库交互层
    public class Student_DAL : IBaseDAL<Student>
    {
        #region 获取方法
        public List<Student> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            return DISTDBSession.Context.From<Student>()
                                                         .OrderBy(Student._.StdCode.Asc)
                                                         .Page(_PageIndex, _PageIndex)
                                                         .ToList();
        }
        public Student GetEntityFromDB_WithEntityID(int _EntityID)
        {

            return GetEntityListFromDB_WithEntityID(_EntityID).FirstOrDefault();

        }

        public Student GetStudentEntityFromDB_WithStudentCode(string _StudentCode)

        {

            return DISTDBSession.Context.From<Student>()
                                                    .Where(d => d.StdCode == _StudentCode)
                                                    .First();                                      
                                                    
        }



        public Student GetStudentEntityFromDB_WithStudentCodeAndStudentPassword(string _StudentCode, string _StudentPassword = "")

        {
           
                    return DISTDBSession.Context.From<Student>()
                                                            .Where(d => d.StdCode == _StudentCode && d.Password==_StudentPassword)
                                                            .First();
        }
        
        

        public List<Student> GetEntityListFromDB_WithEntityID(int _EntityID)
        {  
                  return _EntityID <= 0 ? DISTDBSession.Context.From<Student>()                                                    
                                                        .OrderBy(Student._.StdCode.Asc)
                                                        .ToList():
                                         DISTDBSession.Context.From<Student>()
                                                        .Where(d => d.StdID == _EntityID)
                                                        .OrderBy(Student._.StdCode.Asc)
                                                        .ToList();
          

        }
        #endregion
        public List<Student> GetALLEntityToListFromDB()
        {
            return GetEntityListFromDB_WithEntityID(0);
        }


    }
     #endregion
}
