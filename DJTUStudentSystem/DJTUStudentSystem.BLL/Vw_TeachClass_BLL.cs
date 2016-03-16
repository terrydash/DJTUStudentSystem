
using System;
using System.Collections.Generic;
using DJTUStudentSystem.DAL;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
using DJTUStudentSystem.Config;
namespace DJTUStudentSystem.BLL
{
    public class Vw_TeachClass_BLL : IBaseBLL<Vw_TeachClass>
    {
        Vw_TeachClass_DAL VTB = new Vw_TeachClass_DAL();
        public List<Vw_TeachClass> GetALLEntityToListFromDAL()
        {
            return VTB.GetALLEntityToListFromDB();
        }

        public Vw_TeachClass GetEntityFromDAL_WithEntity(Vw_TeachClass _entityModel)
        {
            throw new NotImplementedException();
        }

        public Vw_TeachClass GetEntityFromDAL_WithEntityID(int EntityID)
        {
            return VTB.GetEntityFromDB_WithEntityID(EntityID);
        }

        public List<Vw_TeachClass> GetEntityListFromDAL_WithEntityID(int EntityID)
        {
            return VTB.GetEntityListFromDB_WithEntityID(EntityID);
        }
        public List<Vw_TeachClass> GetNowTeachClassCsort2()
        {
            LoadEntityListFromCache_BLL L_BLL = new LoadEntityListFromCache_BLL();
            return VTB.GetEntityListFromDB_WithEntityID(L_BLL.GetNowActyear(Setting.isReadFromDB).ATID, "2", "主修");
        }
    }
}
