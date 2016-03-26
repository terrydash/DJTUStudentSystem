using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DBSession;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.DAL
{
    public class Curricula_DAL : IBaseDAL<Curricula>
    {
        public List<Curricula> GetALLEntityToListFromDB()
        {
            return DISTDBSession.Context.From<Curricula>()
                          .Select(d => new { d.CCID,d.CCname,d.CCode,d.Csort,d.Source,d.Period})
                          .OrderBy(Curricula._.CCID.Desc)
                          .ToList();
        }

        public List<Curricula> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            return DISTDBSession.Context.From<Curricula>()
                         .Select(d => new { d.CCID, d.CCname, d.CCode, d.Csort, d.Source, d.Period })
                         .OrderBy(Curricula._.CCID.Desc)
                         .Page(_PageSize,_PageIndex)
                         .ToList();
        }

        public Curricula GetEntityFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<Curricula>()
                          .Select(d => new { d.CCID, d.CCname, d.CCode, d.Csort, d.Source, d.Period })
                          .OrderBy(Curricula._.CCID.Desc)
                          .Where(d => d.CCID == _EntityID).Top(1).First();
                          
        }

        public List<Curricula> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<Curricula>()
                          .Select(d => new { d.CCID, d.CCname, d.CCode, d.Csort, d.Source, d.Period })
                          .OrderBy(Curricula._.CCID.Desc)
                          .ToList();
        }
    }
}
