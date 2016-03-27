using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DAL;
using DJTUStudentSystem.Common;
using DJTUStudentSystem.DataBaseModel;

namespace DJTUStudentSystem.BLL
{
    public class LoadEntityListFromCache_BLL
    {
        public Student GetStudentByStuID(int StuID)
        {

            if (CacheHelper.GetCache("GetStudentByStuID" + StuID.ToString()) == null)
            {
                Student_DAL S_DAL = new Student_DAL();
                CacheHelper.SetCache("GetStudentByStuID" + StuID.ToString(), S_DAL.GetEntityFromDB_WithEntityID(StuID));

            }
            if (CacheHelper.GetCache("GetStudentByStuID" + StuID.ToString()) == null)
            {
                return null;
            }
            return CacheHelper.GetCache("GetStudentByStuID" + StuID.ToString()) as Student;


        }
        public ClassRoom GetClassRoomByCRID(int CRID)
        {
            if (CacheHelper.GetCache("GetClassRoomByCRID" + CRID.ToString()) == null)
            {
                ClassRoom_DAL CR_DAL = new ClassRoom_DAL();
                CacheHelper.SetCache("GetClassRoomByCRID" + CRID.ToString(), CR_DAL.GetEntityFromDB_WithEntityID(CRID));

            }
            if (CacheHelper.GetCache("GetClassRoomByCRID" + CRID.ToString()) == null)
            {
                return null;
            }
            return CacheHelper.GetCache("GetClassRoomByCRID" + CRID.ToString()) as ClassRoom;

        }
        public Curricula GetCurriculaByCCID(int CCID)
        {
            if (CacheHelper.GetCache("GetCurriculaByCCID" + CCID.ToString()) == null)
            {
                Curricula_DAL CU_DAL = new Curricula_DAL();
                CacheHelper.SetCache("GetCurriculaByCCID" + CCID.ToString(), CU_DAL.GetEntityFromDB_WithEntityID(CCID));

            }
            if (CacheHelper.GetCache("GetCurriculaByCCID" + CCID.ToString()) == null)
            {
                return null;
            }
            return CacheHelper.GetCache("GetCurriculaByCCID" + CCID.ToString()) as Curricula;


        }
        public RSDA GetTeacherByPSID(int PSID)
        {
            if (CacheHelper.GetCache("GetTeacherByPSID" + PSID.ToString()) == null)
            {
                Teacher_DAL T_DAL = new Teacher_DAL();
                CacheHelper.SetCache("GetTeacherByPSID" + PSID.ToString(), T_DAL.GetEntityFromDB_WithEntityID(PSID));

            }
            if (CacheHelper.GetCache("GetTeacherByPSID" + PSID.ToString()) == null)
            {
                return null;
            }
            return CacheHelper.GetCache("GetTeacherByPSID" + PSID.ToString()) as RSDA;


        }
        public List<CSchedule> GetCscheduleByTCID(int TCID)
        {
            
             if (CacheHelper.GetCache("NowTeachClassCsort2"+TCID.ToString()) == null)
            {
                CSchedule_DAL CS_DAL = new CSchedule_DAL();
                CacheHelper.SetCache("NowTeachClassCsort2" + TCID.ToString(), CS_DAL.GetEntityListFromDB_TCID(TCID));

            }
             if (CacheHelper.GetCache("NowTeachClassCsort2" + TCID.ToString())==null)
                {
                return null;
            }
            return CacheHelper.GetCache("NowTeachClassCsort2" + TCID.ToString())as List<CSchedule>;

        }
         public List<TeachClass> GetNowTeachClassCsort2()
        {
            if (CacheHelper.GetCache("NowTeachClassCsort2") == null)
            {
                
                List<TeachClass> _TeachClassList = new List<TeachClass>();

                TeachClass_DAL TC_DAL = new TeachClass_DAL();               
                Curricula_DAL CU_DAL = new Curricula_DAL();
                var CurriculaList=CU_DAL.GetNowCurriculaCsort2();
                foreach (var _Curricula in CurriculaList)
                {
                    var _TeachClassListforEletive =TC_DAL.GetEntityFromDB_WithEntityIDByCCID(_Curricula.CCID, "主修",GetNowActyear(false).ATID);
                    if (_TeachClassListforEletive.Count>0)
                    {
                        foreach (var item in _TeachClassListforEletive)
                        {
                            _TeachClassList.Add(item);
                        }
                    }
                }
                CacheHelper.SetCache("NowTeachClassCsort2", _TeachClassList);

            }
            if (CacheHelper.GetCache("NowTeachClassCsort2") == null)
            {

                return null;
            }
            List<TeachClass> _newTeachClassList = new List<TeachClass>();
            TeachClass_DAL TeachC_DAL = new TeachClass_DAL();
            var _refreshNowTeachClassCsort2List = CacheHelper.GetCache("NowTeachClassCsort2") as List<TeachClass>;
            foreach (var _refreshNowTeachClassCsort2 in _refreshNowTeachClassCsort2List)
            {
                _refreshNowTeachClassCsort2.OpenNum = TeachC_DAL.GetEntityFromDB_WithEntityID(_refreshNowTeachClassCsort2.TCID).OpenNum;
                _refreshNowTeachClassCsort2.SelectState= TeachC_DAL.GetEntityFromDB_WithEntityID(_refreshNowTeachClassCsort2.TCID).SelectState;
                _refreshNowTeachClassCsort2.Havenum = TeachC_DAL.GetEntityFromDB_WithEntityID(_refreshNowTeachClassCsort2.TCID).Havenum;
                _newTeachClassList.Add(_refreshNowTeachClassCsort2);
            }
            CacheHelper.SetCache("NowTeachClassCsort2", _newTeachClassList);            
            return _newTeachClassList;


        }
        /// <summary>
        /// 获取当前学年实体 如果缓存没有则读取到还从中 如果缓存就丛缓存读取
        /// </summary>
        /// <returns></returns>
        public Activeyear GetNowActyear(bool isReloadFromDB)
        {
            if ((CacheHelper.GetCache("NowActyear")==null))
            {
                Actyear_BLL A_BLL = new Actyear_BLL();
                var NowActyear = A_BLL.GetNowActiveYear();
                CacheHelper.SetCache("NowActyear", NowActyear);

            }
            if (CacheHelper.GetCache("NowActyear")==null)
            {
                return null;
            }
            return CacheHelper.GetCache("NowActyear") as Activeyear;

        }
        public List<Vw_StuReport> GetVw_StuReportByStuid(bool isReloadFromDB, int Stuid)
        {
            if ((CacheHelper.GetCache("Vw_StuReportByStuid" + Stuid.ToString()) ==null) || (isReloadFromDB))
            {
                Vw_StuReport_DAL V_S_Dal = new Vw_StuReport_DAL();
                var Vw_StuReportList = V_S_Dal.GetVw_StuReportListFromDB_WithStuID(Stuid);
                CacheHelper.SetCache("Vw_StuReportByStuid" + Stuid.ToString(), Vw_StuReportList);
            }
            if (CacheHelper.GetCache("Vw_StuReportByStuid" + Stuid.ToString()) ==null)
            {
                return null;
            }
            return CacheHelper.GetCache("Vw_StuReportByStuid"+ Stuid.ToString()) as List<Vw_StuReport>;
        }
        public List<Vw_StuReport> GetNowActYearVw_StuReportByStuid(bool isReloadFromDB, int Stuid)
        {
            if ((CacheHelper.GetCache("Vw_NowStuReportByStuid" + Stuid.ToString()) ==null) || isReloadFromDB)
            {
                Vw_StuReport_DAL V_S_Dal = new Vw_StuReport_DAL();
                var _Activeyear = GetNowActyear(Config.Setting.isReadFromDB);
                var Vw_StuReportList = V_S_Dal.GetNowActYearVw_StuReportListFromDB_WithStuID(Stuid, _Activeyear.ATID);
                CacheHelper.SetCache("Vw_NowStuReportByStuid" + Stuid.ToString(), Vw_StuReportList);
            }
            if (CacheHelper.GetCache("Vw_NowStuReportByStuid" + Stuid.ToString()) ==null)
            {
                return null;
            }
            return CacheHelper.GetCache("Vw_NowStuReportByStuid"+Stuid.ToString()) as List<Vw_StuReport>;
        }
        public List<Vw_Cschedule> GetNowVw_CscheduleByStuid(bool isReloadFromDB, int Stuid)
        {
            if ((CacheHelper.GetCache("NowVw_CscheduleByStuid"+Stuid.ToString()) == null) || isReloadFromDB)
            {
               Vw_Cschedule_BLL V_C_BLL = new Vw_Cschedule_BLL();
                
                var NowVw_CscheduletList = V_C_BLL.GetNowVw_CscheduleyListForStudent_WithStuID(Stuid);
                CacheHelper.SetCache("NowVw_CscheduleByStuid" + Stuid.ToString(), NowVw_CscheduletList);
            }
            if (CacheHelper.GetCache("NowVw_CscheduleByStuid" + Stuid.ToString()) == null)
            {
                return null;
            }
            return CacheHelper.GetCache("NowVw_CscheduleByStuid" + Stuid.ToString()) as List<Vw_Cschedule>;

        }
        public List<Vw_Cschedule> GetNowVw_CscheduleByTCID(bool isReloadFromDB, int TCID)
        {
            if ((CacheHelper.GetCache("NowVw_CscheduleByTCID"+TCID) == null) || isReloadFromDB)
            {
                Vw_Cschedule_DAL VCD = new Vw_Cschedule_DAL();

                var Vw_CscheduletList = VCD.GetVw_CscheduleyList_WithAtyidAndTCID(GetNowActyear(Config.Setting.isReadFromDB).ATID, TCID);
                CacheHelper.SetCache("NowVw_CscheduleByTCID"+TCID, Vw_CscheduletList);
            }
            if (CacheHelper.GetCache("NowVw_CscheduleByTCID" + TCID) == null)
            {
                return null;
            }
            return CacheHelper.GetCache("NowVw_CscheduleByTCID" + TCID) as List<Vw_Cschedule>;

        }
        public List<Vw_TeachClass> GetNowVW_TeachClassCsort2(bool isReloadFromDB)
        {
            if ((CacheHelper.GetCache("NowVW_TeachClassCsort2") == null) || isReloadFromDB)
            {
                Vw_TeachClass_BLL VTB = new Vw_TeachClass_BLL();
                var NowTeachClassCsort2 = VTB.GetNowTeachClassCsort2();
                CacheHelper.SetCache("NowVW_TeachClassCsort2", NowTeachClassCsort2);
            }
            if (CacheHelper.GetCache("NowVW_TeachClassCsort2") == null)
            {
                return null;
            }
            return CacheHelper.GetCache("NowVW_TeachClassCsort2") as List<Vw_TeachClass>;

        }
    }
}
