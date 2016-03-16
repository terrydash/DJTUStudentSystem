using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.Interface;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.DBSession;
namespace DJTUStudentSystem.DAL
{
    public class Vw_Cschedule_DAL : IBaseDAL<Vw_Cschedule>
    {
        public List<Vw_Cschedule> GetALLEntityToListFromDB()
        {
            return GetEntityListFromDB_WithEntityID(0);
        }

        public List<Vw_Cschedule> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            return DISTDBSession.Context.From<Vw_Cschedule>()
                                                                .Page(_PageSize,_PageIndex)
                                                                .ToList(); 
        }

        public Vw_Cschedule GetEntityFromDB_WithEntityID(int _EntityID)
        {
            throw new NotImplementedException();
        }

        public List<Vw_Cschedule> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
            return _EntityID <= 0 ? DISTDBSession.Context.From<Vw_Cschedule>()


                            .ToList() :
                             DISTDBSession.Context.From<Vw_Cschedule>()

                            .Where(d => d.CSID==_EntityID)

                            .ToList();
        }
        public List<Vw_Cschedule> GetVw_CscheduleyListForStudent_WithAtyidAndTCID(int Atyid,int TCID)
        {
            return DISTDBSession.Context.From<Vw_Cschedule>()
                                                             .Where(d => d.AtyID == Atyid && d.TCID == TCID)
                                                             .ToList();                                                              

        }
    }
}
