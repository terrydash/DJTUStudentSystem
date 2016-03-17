using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DBSession;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.DAL
{
    public class Vw_TeachClass_DAL : IBaseDAL<Vw_TeachClass>
    {
        public List<Vw_TeachClass> GetALLEntityToListFromDB()
        {
            return GetEntityListFromDB_WithEntityID(0);
        }

        public List<Vw_TeachClass> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            return DISTDBSession.Context.From<Vw_TeachClass>()
                        .Page(_PageSize, _PageIndex)
                        .OrderBy(Vw_TeachClass._.TCID.Desc)
                        .ToList();
        }

        public Vw_TeachClass GetEntityFromDB_WithEntityID(int _EntityID)
        {
          return  DISTDBSession.Context.From<Vw_TeachClass>()
                         .Where(d => d.TCID == _EntityID)
                         .OrderBy(Vw_TeachClass._.TCID.Desc)
                         .First();
        }

        public List<Vw_TeachClass> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
            return _EntityID <= 0 ? DISTDBSession.Context.From<Vw_TeachClass>()                       
                       .OrderBy(Vw_TeachClass._.TCID.Desc)
                       .ToList() : DISTDBSession.Context.From<Vw_TeachClass> ()                      
                       .Where(d => d.TCID == _EntityID)
                       .OrderBy(Vw_TeachClass._.TCID.Desc)
                       .ToList();
        }
       
        public List<Vw_TeachClass> GetEntityListFromDB_WithEntityID(int AtyID,string Csort,string Minor)
        {
            return       DISTDBSession.Context.From<Vw_TeachClass>()
                       .Where(d => d.ActYear==AtyID && d.Csort==Csort && d.Minor==Minor)
                       .OrderBy(Vw_TeachClass._.TCID.Desc)
                       .ToList();
        }
    }
}
