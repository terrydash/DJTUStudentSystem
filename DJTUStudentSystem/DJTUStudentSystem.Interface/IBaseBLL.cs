using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DJTUStudentSystem.Interface
{
    public interface IBaseBLL<T> where T : class, new()
    {

        T GetEntityFromDAL_WithEntityID(int EntityID);
        T GetEntityFromDAL_WithEntity(T _entityModel);
        List<T> GetEntityListFromDAL_WithEntityID(int EntityID);
        List<T> GetALLEntityToListFromDAL();
    }
}
