using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DBSession;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.DAL
{
    public class CSchedule_DAL : IBaseDAL<CSchedule>
    {
        public List<CSchedule> GetALLEntityToListFromDB()
        {
            throw new NotImplementedException();
        }

        public List<CSchedule> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            throw new NotImplementedException();
        }

        public CSchedule GetEntityFromDB_WithEntityID(int _EntityID)
        {
            throw new NotImplementedException();
        }

        public List<CSchedule> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
            throw new NotImplementedException();
        }
    }
}
