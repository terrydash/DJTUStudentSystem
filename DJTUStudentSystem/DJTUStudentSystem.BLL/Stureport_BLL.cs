using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DAL;
using DJTUStudentSystem.Common;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.BLL
{
    public class Stureport_BLL : IBaseBLL<StuReport>
    {
        StrReport_DAL S_Dal = new StrReport_DAL();
        public Dictionary<string, object> AddSelectClass(int TCID, string StdCode, string Minor)
        {
            return S_Dal.AddSelectClass(TCID, StdCode, Minor);
        }
        public List<StuReport> GetALLEntityToListFromDAL()
        {
            return S_Dal.GetALLEntityToListFromDB();
        }

        public StuReport GetEntityFromDAL_WithEntity(StuReport _entityModel)
        {
            throw new NotImplementedException();
        }

        public StuReport GetEntityFromDAL_WithEntityID(int EntityID)
        {
            return S_Dal.GetEntityFromDB_WithEntityID(EntityID);
        }

        public List<StuReport> GetEntityListFromDAL_WithEntityID(int EntityID)
        {
            return S_Dal.GetEntityListFromDB_WithEntityID(EntityID);
        }
    }
}
