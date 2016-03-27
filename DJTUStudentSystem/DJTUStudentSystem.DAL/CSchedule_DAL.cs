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
            return DISTDBSession.Context.From<CSchedule>()
                           .Select(d => new { d.AtyID,d.CCID,d.CRID,d.CSID,d.DSZ,d.EndW,d.Mark,d.Memo,d.PSID,d.SectionTH,d.Sort,d.StartW,d.State,d.TCID,d.DayOfWeek })
                           .OrderBy(CSchedule._.CSID.Desc)
                           .ToList();
        }

        public List<CSchedule> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            return DISTDBSession.Context.From<CSchedule>()
                           .Select(d => new { d.AtyID, d.CCID, d.CRID, d.CSID, d.DSZ, d.EndW, d.Mark, d.Memo, d.PSID, d.SectionTH, d.Sort, d.StartW, d.State, d.TCID, d.DayOfWeek })
                           .OrderBy(CSchedule._.CSID.Desc)
                           .Page(_PageSize,_PageIndex)
                           .ToList();
        }

        public CSchedule GetEntityFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<CSchedule>()
                           .Select(d => new { d.AtyID, d.CCID, d.CRID, d.CSID, d.DSZ, d.EndW, d.Mark, d.Memo, d.PSID, d.SectionTH, d.Sort, d.StartW, d.State, d.TCID, d.DayOfWeek })
                           .OrderBy(CSchedule._.CSID.Desc)
                           .Where(d=>d.CSID==_EntityID)
                           .Top(1).First();
                           
        }

        public List<CSchedule> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<CSchedule>()
                             .Select(d => new { d.AtyID, d.CCID, d.CRID, d.CSID, d.DSZ, d.EndW, d.Mark, d.Memo, d.PSID, d.SectionTH, d.Sort, d.StartW, d.State, d.TCID, d.DayOfWeek })
                             .OrderBy(CSchedule._.CSID.Desc)
                             .Where(d => d.CSID == _EntityID)
                             .ToList();
        }
        public List<CSchedule> GetEntityListFromDB_TCID(int TCID)
        {
            return DISTDBSession.Context.From<CSchedule>()
                             .Select(d => new { d.AtyID, d.CCID, d.CRID, d.CSID, d.DSZ, d.EndW, d.Mark, d.Memo, d.PSID, d.SectionTH, d.Sort, d.StartW, d.State, d.TCID, d.DayOfWeek })
                             .OrderBy(CSchedule._.CSID.Desc)
                             .Where(d => d.TCID == TCID)
                             .ToList();
        }
    }

}
