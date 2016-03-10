using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DAL;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.BLL 
{
    public class Student_BLL : IBaseBLL<Student>,IDisposable
    {
        private Student_DAL S_DAL = new Student_DAL();
        public List<Student> GetALLEntityToListFromDAL()
        {
            return S_DAL.GetALLEntityToListFromDB();
        }

        public Student GetEntityFromDAL_WithEntity(Student _entityModel)
        {
            throw new NotImplementedException();
        }

        public Student GetEntityFromDAL_WithEntityID(int EntityID)
        {
            return S_DAL.GetEntityFromDB_WithEntityID(EntityID);
        }

        public List<Student> GetEntityListFromDAL_WithEntityID(int EntityID)
        {
            return S_DAL.GetEntityListFromDB_WithEntityID(EntityID);
        }

        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    S_DAL = null;
                    S_DAL.Dispose();
                }

                // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
                // TODO: 将大型字段设置为 null。

                disposedValue = true;
            }
        }

        // TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
             ~Student_BLL()
            {
                //   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
                Dispose(false);
            }

        // 添加此代码以正确实现可处置模式。
        public void Dispose()
        {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
