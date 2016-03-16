using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.Interface;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.DAL;
using DJTUStudentSystem.Config;

namespace DJTUStudentSystem.BLL
{
    public class Vw_Cschedule_BLL : IBaseBLL<Vw_Cschedule>
    {
        Vw_Cschedule_DAL V_DAL = new Vw_Cschedule_DAL();
        public List<Vw_Cschedule> GetALLEntityToListFromDAL()
        {
           return V_DAL.GetALLEntityToListFromDB();
        }

        public Vw_Cschedule GetEntityFromDAL_WithEntity(Vw_Cschedule _entityModel)
        {
            throw new NotImplementedException();
        }

        public Vw_Cschedule GetEntityFromDAL_WithEntityID(int EntityID)
        {
            return V_DAL.GetEntityFromDB_WithEntityID(EntityID);
        }

        public List<Vw_Cschedule> GetEntityListFromDAL_WithEntityID(int EntityID)
        {
            return V_DAL.GetEntityListFromDB_WithEntityID(EntityID);
        }
        public List<Vw_Cschedule> GetNowVw_CscheduleyListForStudent_WithStuID(int StuID)
        {
            List<Vw_Cschedule> Vw_CscheduleList = new List<Vw_Cschedule>();
            LoadEntityListFromCache_BLL L_BLL = new LoadEntityListFromCache_BLL();
            var Vw_StuReportList = L_BLL.GetNowActYearVw_StuReportByStuid(Setting.isReadFromDB, StuID);
            foreach (var StuReport in Vw_StuReportList)
            {
                if (StuReport.TCID != null)
                {
                    var _Vw_CscheduleyList = V_DAL.GetVw_CscheduleyListForStudent_WithAtyidAndTCID(L_BLL.GetNowActyear(Setting.isReadFromDB).ATID, (int)StuReport.TCID);
                    if (_Vw_CscheduleyList!=null)
                    { 
                        foreach (var item in _Vw_CscheduleyList)
                        {
                                Vw_CscheduleList.Add(item);
                        }
                    }
                }
            }
            return Vw_CscheduleList;
        }
        
    }
}
