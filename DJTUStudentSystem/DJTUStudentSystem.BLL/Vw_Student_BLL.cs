using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DAL;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.BLL 
{
    public class Vw_Student_BLL : IBaseBLL<Vw_Student>
    {
        private Vw_Student_DAL S_DAL = new Vw_Student_DAL();
        public List<Vw_Student> GetALLEntityToListFromDAL(int _PageSize, int _PageIndex)
        {
            return S_DAL.GetALLEntityToListFromDB(_PageSize, _PageIndex);

        }
        public List<Vw_Student> GetALLEntityToListFromDAL()
        {
            return S_DAL.GetALLEntityToListFromDB();
        }

        public Vw_Student GetEntityFromDAL_WithEntity(Vw_Student _entityModel)
        {
            throw new NotImplementedException();
        }
     
      

        public Vw_Student GetEntityFromDAL_WithEntityID(int EntityID)
        {
            return S_DAL.GetEntityFromDB_WithEntityID(EntityID);
        }

        public List<Vw_Student> GetEntityListFromDAL_WithEntityID(int EntityID)
        {
            return S_DAL.GetEntityListFromDB_WithEntityID(EntityID);
        }

    }
}
