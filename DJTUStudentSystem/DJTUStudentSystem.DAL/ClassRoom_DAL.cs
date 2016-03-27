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
            return DISTDBSession.Context.From<ClassRoom>()
                            .Select(d => new { d.CRID,d.CRname,d.BuildName,d.RGID,d.PsNumber,d.Memo })
                            .OrderBy(ClassRoom._.CRID.Desc)
                            .ToList();
        }

        public List<ClassRoom> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            return DISTDBSession.Context.From<ClassRoom>()
                            .Select(d => new { d.CRID, d.CRname, d.BuildName, d.RGID, d.PsNumber, d.Memo })
                            .OrderBy(ClassRoom._.CRID.Desc)
                            .Page(_PageSize,_PageIndex)
                            .ToList();
        }

        public ClassRoom GetEntityFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<ClassRoom>()
                             .Select(d => new { d.CRID, d.CRname, d.BuildName, d.RGID, d.PsNumber, d.Memo })
                             .OrderBy(ClassRoom._.CRID.Desc)
                             .Where(d=>d.CRID==_EntityID)
                             .Top(1)
                             .First();
        }

        public List<ClassRoom> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<ClassRoom>()
                            .Select(d => new { d.CRID, d.CRname, d.BuildName, d.RGID, d.PsNumber, d.Memo })
                            .OrderBy(ClassRoom._.CRID.Desc)
                            .Where(d => d.CRID == _EntityID)
                           .ToList();
        }
    }
}
