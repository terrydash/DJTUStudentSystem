using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DBSession;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.DAL
{
    public class ClassAndTeach_DAL : IBaseDAL<ClassAndTeach>
    {
        public bool Delete (int clid,int tcid)
        {
            try
            {
                DISTDBSession.Context.Delete<ClassAndTeach>(d => d.CLID == clid && d.TCID == tcid);
            }
            catch { return false; }
            return true;

        }
        public List<ClassAndTeach> GetALLEntityToListFromDB()
        {
            return DISTDBSession.Context.From<ClassAndTeach>()
                        .OrderBy(ClassAndTeach._.CLID)
                        .ToList();
        }

        public List<ClassAndTeach> GetALLEntityToListFromDB(int _PageSize, int _PageIndex)
        {
            return DISTDBSession.Context.From<ClassAndTeach>()
                         .Page(_PageSize,_PageIndex)
                         .OrderBy(ClassAndTeach._.CLID)
                         .ToList();
        }

        public ClassAndTeach GetEntityFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<ClassAndTeach>()
                                                              .Where(d => d.CLID == _EntityID)
                                                              .First();
        }

        public ClassAndTeach GetEntityFromDB_WithTcIDandCLID(int tcid,int clid)
        {
            return DISTDBSession.Context.From<ClassAndTeach>()
                                                              .Where(d => d.TCID == tcid &&d.CLID== clid)
                                                              .First();
        }
        public bool Insert(ClassAndTeach C)
        {
            try
            {
                DISTDBSession.Context.Insert<ClassAndTeach>(C);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<ClassAndTeach> GetEntityListFromDB_WithEntityID(int _EntityID)
        {
            return DISTDBSession.Context.From<ClassAndTeach>()
                         
                          .OrderBy(ClassAndTeach._.CLID)
                          .Where(d=>d.CLID==_EntityID)
                          .ToList();
        }
    }
}
