using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.Interface;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.DBSession;
namespace DJTUStudentSystem.DAL
{
    public class Vw_Student_DAL : IBaseDAL<Vw_Student>
    {
        public List<Vw_Student> GetALLEntityToListFromDB()
        {
            return GetEntityListFromDB_WithEntityID(0);
        }

        public List<Vw_Student> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            return DISTDBSession.Context.From<Vw_Student>()
                                                        .OrderBy(Vw_Student._.学号.Asc)
                                                        .Page(_PageIndex, _PageIndex)
                                                        .ToList();
        }

        public Vw_Student GetEntityFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<Vw_Student>()
                                                         
                                                         .Where(d => d.StdID == _EntityID)
                                                         .First();
        }

        public List<Vw_Student> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
            return _EntityID <= 0 ? DISTDBSession.Context.From<Vw_Student>()
                                                        .OrderBy(Vw_Student._.学号.Asc)
                                                        .ToList() :
                                         DISTDBSession.Context.From<Vw_Student>()
                                                        .Where(d => d.StdID == _EntityID)
                                                        .OrderBy(Vw_Student._.学号.Asc)
                                                        .ToList();
        }
    }
}
