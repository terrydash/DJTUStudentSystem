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
        public Dictionary<string, object> AddSelectClass(int TCID,string StdCode,string Minor)
        {   List<DISTDBSession.Procparameters> _parametersinlist = new List<DISTDBSession.Procparameters>();
            List<DISTDBSession.Procparameters> _parametersoutlist = new List<DISTDBSession.Procparameters>();
            DISTDBSession.Procparameters _parameters = new DISTDBSession.Procparameters() { parameterName = "TCID", DbType = System.Data.DbType.Int32, value = TCID };
            _parametersinlist.Add(_parameters);
            _parameters = new DISTDBSession.Procparameters() { parameterName = "Stdcode", DbType = System.Data.DbType.StringFixedLength, value = StdCode };
            _parametersinlist.Add(_parameters);
            _parameters = new DISTDBSession.Procparameters() { parameterName = "Minor", DbType = System.Data.DbType.StringFixedLength, value = Minor };
            _parametersinlist.Add(_parameters);
            _parameters = new DISTDBSession.Procparameters() { parameterName = "R", DbType = System.Data.DbType.String, value = ""};
            _parametersoutlist.Add(_parameters);
            return DISTDBSession.ExecuteProc("usp_SELECTCLASS_Add", _parametersinlist, _parametersoutlist);

        }
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
