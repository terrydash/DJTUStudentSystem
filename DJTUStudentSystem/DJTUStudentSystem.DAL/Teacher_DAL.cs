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
            return DISTDBSession.Context.From<RSDA>()
                           .Select(d => new { d.PSID,d.PsName,d.Sex,d.RoleID,d.DeptId,d.Password,d.StandCode })
                           .OrderBy(RSDA._.PSID.Desc)
                           .ToList();
        }

        public List<RSDA> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            return DISTDBSession.Context.From<RSDA>()
                           .Select(d => new { d.PSID, d.PsName, d.Sex, d.RoleID, d.DeptId, d.Password, d.StandCode })
                           .OrderBy(RSDA._.PSID.Desc)
                           .Page(_PageSize,_PageIndex)
                           .ToList();
        }
    

        public RSDA GetEntityFromDB_WithEntityID(int _EntityID)
        {
        return DISTDBSession.Context.From<RSDA>()
                       .Select(d => new { d.PSID, d.PsName, d.Sex, d.RoleID, d.DeptId, d.Password, d.StandCode })
                       .OrderBy(RSDA._.PSID.Desc)
                       .Top(1)
                       .Where(d => d.PSID == _EntityID)
                       .First();
    }

        public List<RSDA> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
        return DISTDBSession.Context.From<RSDA>()
                    .Select(d => new { d.PSID, d.PsName, d.Sex, d.RoleID, d.DeptId, d.Password, d.StandCode })
                    .OrderBy(RSDA._.PSID.Desc)
                    .Where(d => d.PSID == _EntityID)
                    .ToList();
    }
    }
}
