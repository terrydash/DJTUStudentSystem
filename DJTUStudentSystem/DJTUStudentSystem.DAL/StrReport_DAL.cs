using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DBSession;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.DAL
{
    public class StrReport_DAL : IBaseDAL<StuReport>
    {
        public List<StuReport> GetALLEntityToListFromDB()
        {
            return DISTDBSession.Context.From<StuReport>()
                           .Select(d => new { d.ATYID,d.StuID,d.SRID,d.TCID,d.CCID,d.CLID,d.Deptid,d.Minor,d.PJState,d.SPID})
                           .OrderBy(StuReport._.SRID)
                           .ToList();
        }

        public List<StuReport> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
             return DISTDBSession.Context.From<StuReport>()
                           .Select(d => new { d.ATYID, d.StuID, d.SRID, d.TCID, d.CCID, d.CLID, d.Deptid, d.Minor, d.PJState, d.SPID })
                           .OrderBy(StuReport._.SRID)
                           .Page(_PageSize,_PageIndex)
                           .ToList();
        }

        public StuReport GetEntityFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<StuReport>()
                          .Select(d => new { d.ATYID, d.StuID, d.SRID, d.TCID, d.CCID, d.CLID, d.Deptid, d.Minor, d.PJState, d.SPID })
                          .OrderBy(StuReport._.SRID)
                          .Where(d => d.SRID == _EntityID)
                          .First();
        }

        public List<StuReport> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<StuReport>()
                          .Select(d => new { d.ATYID, d.StuID, d.SRID, d.TCID, d.CCID, d.CLID, d.Deptid, d.Minor, d.PJState, d.SPID })
                          .OrderBy(StuReport._.SRID)
                          .Where(d => d.SRID == _EntityID)
                          .ToList();
        }
        public List<StuReport> GetEntityListFromDB_WithstuID(int _EntityID)
        {
            return DISTDBSession.Context.From<StuReport>()
                          .Select(d => new { d.ATYID, d.StuID, d.SRID, d.TCID, d.CCID, d.CLID, d.Deptid, d.Minor, d.PJState, d.SPID })
                          .OrderBy(StuReport._.SRID)
                          .Where(d => d.StuID == _EntityID)
                          .ToList();
        }
    }
}
