using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DBSession;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.DAL
{
    public class Vw_StuReport_DAL : IBaseDAL<Vw_StuReport>
    {
        public List<Vw_StuReport> GetALLEntityToListFromDB()
        {
            return DISTDBSession.Context.From<Vw_StuReport>()
                            .Select(d => new { d.课程名称,d.GRName,d.ATYID, d.StuID, d.SRID, d.TCID, d.CCID, d.CLID, d.成绩,d.班级,d.Discipline,d.学分, d.Minor, d.PJState, d.SPID })
                            .OrderBy(Vw_StuReport._.SRID)
                            .ToList();
        }

        public List<Vw_StuReport> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            return DISTDBSession.Context.From<Vw_StuReport>()
                            .Select(d => new { d.课程名称, d.GRName, d.ATYID, d.StuID, d.SRID, d.TCID, d.CCID, d.CLID, d.成绩, d.班级, d.Discipline, d.学分, d.Minor, d.PJState, d.SPID })
                            .OrderBy(Vw_StuReport._.SRID)
                            .Page(_PageSize,_PageIndex)
                            .ToList();
        }

        public Vw_StuReport GetEntityFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<Vw_StuReport>()
                              .Select(d => new { d.课程名称, d.GRName, d.ATYID, d.StuID, d.SRID, d.TCID, d.CCID, d.CLID, d.成绩, d.班级, d.Discipline, d.学分, d.Minor, d.PJState, d.SPID })
                              .OrderBy(Vw_StuReport._.SRID)
                              .Where(d => d.SRID == _EntityID)
                              .First();
        }

        public List<Vw_StuReport> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<Vw_StuReport>()
                              .Select(d => new { d.课程名称, d.GRName, d.ATYID, d.StuID, d.SRID, d.TCID, d.CCID, d.CLID, d.成绩, d.班级, d.Discipline, d.学分, d.Minor, d.PJState, d.SPID })
                              .OrderBy(Vw_StuReport._.SRID)
                              .Where(d => d.SRID == _EntityID)
                              .ToList();
        }
        public List<Vw_StuReport> GetVw_StuReportListFromDB_WithStuID(int _StuID)
        {
            return DISTDBSession.Context.From<Vw_StuReport>()
                              .Select(d => new {d.当前学期,d.课程名称, d.GRName, d.ATYID, d.StuID, d.SRID, d.TCID, d.CCID, d.CLID, d.成绩, d.班级, d.Discipline, d.学分, d.Minor, d.PJState, d.SPID })
                              .OrderBy(Vw_StuReport._.SRID.Desc)
                              .Where(d => d.StuID == _StuID)
                              .ToList();
        }
        public List<Vw_StuReport> GetNowActYearVw_StuReportListFromDB_WithStuID(int _StuID,int AtyID)
        {
            return DISTDBSession.Context.From<Vw_StuReport>()                              
                              .OrderBy(Vw_StuReport._.SRID)
                              .Where(d => d.StuID == _StuID && d.ATYID==AtyID)
                              .ToList();
        }
    }
}
