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
    public class Student_DAL : IDisposable,IBaseDAL<Student>
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
            if (EntityID > 0)
            {
                return GetEntityListFromDB_WithEntityID(EntityID).FirstOrDefault();
            }
            else
            {
                return null;
            }     
        }


        /*
        public Student GetEntityFromDB_WithEntity(Student _entityModel)
        {   if (_entityModel!=null)
            {
                                                
            }
        }
        */

        public List<Student> GetEntityListFromDB_WithEntityID(int EntityID)
        {   if (EntityID>0)
            { 
                  return EntityID <= 0 ? DISTDBSession.Context.From<Student>()                                                        
                                                        .OrderBy(Student._.StdCode.Asc)
                                                        .ToList():
                                         DISTDBSession.Context.From<Student>()
                                                        .Where(d => d.StdID == EntityID)
                                                        .OrderBy(Student._.StdCode.Asc)
                                                        .ToList();
            }else
            {

                return null;    
            }


        }
        #endregion
        public List<Student> GetALLEntityToListFromDB()
        {
            return GetEntityListFromDB_WithEntityID(0);
        }
        #region 资源回收相关
        /// <summary>
        /// 是否已经被终结的标识符
        /// </summary>
        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            //通知垃圾回收机制不再调用终结器（析构器）
            GC.SuppressFinalize(this);
        }
        public void Close()
        {
            Dispose();
        }
        ~Student_DAL()
        {
            //必须为false
            Dispose(false);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            if (disposing)
            {
               
                
            }
            // 清理非托管资源
          
            //让类型知道自己已经被释放
            disposed = true;
        }

       
        #endregion


    }
     #endregion
}
