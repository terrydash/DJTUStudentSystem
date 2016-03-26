using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DBSession;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.DAL
{
    public class TeachClass_DAL : IBaseDAL<TeachClass>
    {
        public List<TeachClass> GetALLEntityToListFromDB()
        {
            return DISTDBSession.Context.From<TeachClass>()
                            .Select(d => new {d.TCHID,d.RGID,d.TCID,d.TCName,d.CCID,d.ActYear,d.EPID,d.Grade,d.Havenum,d.OpenNum,d.SelectState,d.Minor,d.MaxStuNum,d.LimitGrade,d.LimitSP,d.SPID,d.CTID })
                            .OrderBy(TeachClass._.TCID.Desc)
                            .ToList();
        }

        public List<TeachClass> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            return DISTDBSession.Context.From<TeachClass>()
                           .Select(d => new { d.TCHID, d.RGID, d.TCID, d.TCName, d.CCID, d.ActYear, d.EPID, d.Grade, d.Havenum, d.OpenNum, d.SelectState, d.Minor, d.MaxStuNum, d.LimitGrade, d.LimitSP, d.SPID, d.CTID })
                            .OrderBy(TeachClass._.TCID.Desc)
                            .Page(_PageSize,_PageIndex)
                            .ToList();
        }

        public TeachClass GetEntityFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<TeachClass>()
                           .Select(d => new { d.TCHID, d.RGID, d.TCID, d.TCName, d.CCID, d.ActYear, d.EPID, d.Grade, d.Havenum, d.OpenNum, d.SelectState, d.Minor, d.MaxStuNum, d.LimitGrade, d.LimitSP, d.SPID, d.CTID })
                           .OrderBy(TeachClass._.TCID.Desc)
                           .Where(d => d.TCID == _EntityID)
                           .Top(1)
                           .First();


        }

        public List<TeachClass> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<TeachClass>()
                         .Select(d => new { d.TCHID, d.RGID, d.TCID, d.TCName, d.CCID, d.ActYear, d.EPID, d.Grade, d.Havenum, d.OpenNum, d.SelectState, d.Minor, d.MaxStuNum, d.LimitGrade, d.LimitSP, d.SPID, d.CTID })
                          .OrderBy(TeachClass._.TCID.Desc)
                          .Where(d => d.TCID == _EntityID)
                          .ToList();
        }
    }
}
