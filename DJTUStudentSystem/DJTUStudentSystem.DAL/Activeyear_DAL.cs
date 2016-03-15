using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DBSession;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.DAL
{
    public class Activeyear_DAL : IBaseDAL<Activeyear>
    {


        public List<Activeyear> GetAllEntityFromDB()
        {
            return DISTDBSession.Context.From<Activeyear>()
                            .Select(d => new { d.ATID, d.ATName, d.PKstate, d.State })
                            .OrderBy(Activeyear._.ATID.Desc)
                            .ToList();
        }

        public List<Activeyear> GetALLEntityToListFromDB()
        {
            return DISTDBSession.Context.From<Activeyear>()
                          .Select(d => new { d.ATID, d.ATName, d.PKstate, d.State })
                          .OrderBy(Activeyear._.ATID.Desc)
                          .ToList();
        }

        public List<Activeyear> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            return DISTDBSession.Context.From<Activeyear>()
                         .Select(d => new { d.ATID, d.ATName, d.PKstate, d.State })
                         .Page(_PageSize, _PageIndex)
                         .OrderBy(Activeyear._.ATID.Desc)
                         .ToList();
        }

     

        public Activeyear GetEntityFromDB_WithEntityID(int _EntityID)
        {
            return GetEntityListFromDB_WithEntityID(_EntityID).First();
        }

        public List<Activeyear> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
            return _EntityID <= 0 ? DISTDBSession.Context.From<Activeyear>()
                     .Select(d => new { d.ATID, d.ATName, d.PKstate, d.State })
                     .OrderBy(Activeyear._.ATID.Desc)
                     .ToList() : DISTDBSession.Context.From<Activeyear>()
                     .Select(d => new { d.ATID, d.ATName, d.PKstate, d.State })
                     .Where(d => d.ATID == _EntityID)
                     .OrderBy(Activeyear._.ATID.Desc)
                     .ToList();
        }
    }
}
