using System;
using System.Collections.Generic;

using DJTUStudentSystem.DAL;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;


namespace DJTUStudentSystem.BLL
{
    public class Actyear_BLL : IBaseBLL<Activeyear>
        
    {
        Activeyear_DAL A_DAL = new Activeyear_DAL();
        public List<Activeyear> GetALLEntityToListFromDAL()
        {
            return A_DAL.GetALLEntityToListFromDB();
        }

        public Activeyear GetEntityFromDAL_WithEntity(Activeyear _entityModel)
        {
            throw new NotImplementedException();
        }

        public Activeyear GetEntityFromDAL_WithEntityID(int EntityID)
        {
            return A_DAL.GetEntityFromDB_WithEntityID(EntityID);
        }

        public List<Activeyear> GetEntityListFromDAL_WithEntityID(int EntityID)
        {
            return A_DAL.GetEntityListFromDB_WithEntityID(EntityID);
        }
        public Activeyear GetNowActiveYear()
        {
            var ActiveYearList = GetALLEntityToListFromDAL();
            var actyear = new Activeyear();
            if (ActiveYearList.Count != 0)
            {
                actyear = ActiveYearList.Find(d => d.State == "当前");
            }
            return actyear;

        }
    }
}
