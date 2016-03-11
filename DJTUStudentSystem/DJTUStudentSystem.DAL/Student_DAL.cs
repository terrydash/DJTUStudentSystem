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
        public Student GetEntityFromDB_WithEntityID(int EntityID)
        {
           
                return GetEntityListFromDB_WithEntityID(EntityID).FirstOrDefault();
                
        }


        /*
        public Student GetEntityFromDB_WithEntity(Student _entityModel)
        {   if (_entityModel!=null)
            {
                                                
            }
        }
        */

        public List<Student> GetEntityListFromDB_WithEntityID(int EntityID)
        {  
                  return EntityID <= 0 ? DISTDBSession.Context.From<Student>().Top(20)                                                     
                                                        .OrderBy(Student._.StdCode.Asc)
                                                        .ToList():
                                         DISTDBSession.Context.From<Student>()
                                                        .Where(d => d.StdID == EntityID)
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
