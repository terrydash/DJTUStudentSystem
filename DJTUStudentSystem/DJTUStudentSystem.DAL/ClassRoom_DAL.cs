using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DBSession;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.DAL
{
    public class ClassRoom_DAL : IBaseDAL<ClassRoom>
    {
        public List<ClassRoom> GetALLEntityToListFromDB()
        {
            throw new NotImplementedException();
        }

        public List<ClassRoom> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            throw new NotImplementedException();
        }

        public ClassRoom GetEntityFromDB_WithEntityID(int _EntityID)
        {
            throw new NotImplementedException();
        }

        public List<ClassRoom> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
            throw new NotImplementedException();
        }
    }
}
