using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DAL;
using DJTUStudentSystem.Common;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Interface;
namespace DJTUStudentSystem.BLL
{
    public class Stureport_BLL : IBaseBLL<StuReport>
    {
        StuReport_DAL S_Dal = new StuReport_DAL();

        public bool Delete(int srid)
        {
            ClassAndTeach_DAL C_DAL = new ClassAndTeach_DAL();
            var _StuReport=S_Dal.GetEntityFromDB_WithEntityID(srid);
            var studid = _StuReport.StuID;
            var tcid = _StuReport.TCID;
            var clid = _StuReport.CLID;
            try
            {
                S_Dal.Delete(srid);
                if (S_Dal.GetEntityListFromDB_WithEntityID((int)clid, (int)tcid) == null)
                {

                    C_DAL.Delete((int)clid, (int)tcid);


                }

            }
            catch
            {
                return false;
            }
            return true;
           
        }
        public bool Insert(int tcid,int stdid)
        { Vw_Student_DAL Stu_DAL = new Vw_Student_DAL();
            
            Vw_TeachClass_DAL V_DAL = new Vw_TeachClass_DAL();
            var TeachClass = V_DAL.GetEntityFromDB_WithEntityID(tcid);
            var Atyid = TeachClass.ActYear;
            var CCID= TeachClass.CCID;
            var Source = TeachClass.学分;
            var Student = Stu_DAL.GetEntityFromDB_WithEntityID(stdid);
            StuReport _StuReport = new StuReport();
            _StuReport.StuID = stdid;
            _StuReport.TCID = tcid;
            _StuReport.ATYID = TeachClass.ActYear;
            _StuReport.CCID = TeachClass.CCID;
            _StuReport.Minor = TeachClass.Minor;
            _StuReport.BasSource = TeachClass.学分;
            _StuReport.CLID = Student.CLassID;
            _StuReport.SPID = Student.SPID;
            _StuReport.Grid = Student.GradeID;
            _StuReport.Deptid = Student.DeptID;
            if (!S_Dal.Insert(_StuReport))
            {
                return false;
            }
            ClassAndTeach_DAL CAT = new ClassAndTeach_DAL();
            if (CAT.GetEntityFromDB_WithTcIDandCLID(tcid,(int)Student.CLassID)==null)
            {
                try
                {
                    CAT.Insert(new ClassAndTeach() { TCID = tcid, CLID = (int)Student.CLassID, CLName = Student.班级, Ctype = "讲课" });
                }
                catch (Exception)
                {

                    return false;
                }
            }
            return true;

        }
        public Dictionary<string, object> AddSelectClass(int TCID, string StdCode, string Minor)
        {
            return S_Dal.AddSelectClass(TCID, StdCode, Minor);
        }
        public List<StuReport> GetALLEntityToListFromDAL()
        {
            return S_Dal.GetALLEntityToListFromDB();
        }

        public StuReport GetEntityFromDAL_WithEntity(StuReport _entityModel)
        {
            throw new NotImplementedException();
        }

        public StuReport GetEntityFromDAL_WithEntityID(int EntityID)
        {
            return S_Dal.GetEntityFromDB_WithEntityID(EntityID);
        }

        public List<StuReport> GetEntityListFromDAL_WithEntityID(int EntityID)
        {
            return S_Dal.GetEntityListFromDB_WithEntityID(EntityID);
        }
    }
}
