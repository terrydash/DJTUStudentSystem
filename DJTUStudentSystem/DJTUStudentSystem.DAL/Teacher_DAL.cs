using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DBSession;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.DAL
{
    public class Teacher_DAL : IBaseDAL<RSDA>
    {
        public List<RSDA> GetALLEntityToListFromDB()
        {
            throw new NotImplementedException();
        }

        public List<RSDA> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            throw new NotImplementedException();
        }

        public RSDA GetEntityFromDB_WithEntityID(int _EntityID)
        {
            throw new NotImplementedException();
        }

        public List<RSDA> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
            throw new NotImplementedException();
        }
    }
}
