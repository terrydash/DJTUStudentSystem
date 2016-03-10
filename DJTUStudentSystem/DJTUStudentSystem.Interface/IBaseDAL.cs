using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DJTUStudentSystem.Interface
{
    public interface IBaseDAL<T> where T :class,new ()
    {
        T GetEntityFromDB_WithEntityID(int EntityID);
       // T GetEntityFromDB_WithEntity(T _entityModel);
        List<T> GetEntityListFromDB_WithEntityID(int EntityID);
        List<T> GetALLEntityToListFromDB();
        List<T> GetALLEntityToListFromDB(int _PageSize,int _PageIndex);
    }
}
