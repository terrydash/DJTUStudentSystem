using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DAL;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.BLL 
{
    public class Student_BLL : IBaseBLL<Student>
    {
        private Student_DAL S_DAL = new Student_DAL();
        public List<Student> GetALLEntityToListFromDAL(int _PageSize, int _PageIndex)
        {
            return S_DAL.GetALLEntityToListFromDB(_PageSize, _PageIndex);

        }
        public List<Student> GetALLEntityToListFromDAL()
        {
            return S_DAL.GetALLEntityToListFromDB();
        }

        public Student GetEntityFromDAL_WithEntity(Student _entityModel)
        {
            throw new NotImplementedException();
        }

        public Student GetEntityFromDAL_WithEntityID(int EntityID)
        {
            return S_DAL.GetEntityFromDB_WithEntityID(EntityID);
        }

        public List<Student> GetEntityListFromDAL_WithEntityID(int EntityID)
        {
            return S_DAL.GetEntityListFromDB_WithEntityID(EntityID);
        }

    }
}
