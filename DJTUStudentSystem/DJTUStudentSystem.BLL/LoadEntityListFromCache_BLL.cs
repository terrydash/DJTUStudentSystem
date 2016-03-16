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

        /// <summary>
        /// 获取当前学年实体 如果缓存没有则读取到还从中 如果缓存就丛缓存读取
        /// </summary>
        /// <returns></returns>
        public Activeyear GetNowActyear(bool isReloadFromDB)
        {
            if ((CacheHelper.GetCache("NowActyear")==null) || isReloadFromDB)
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
            if ((CacheHelper.GetCache("Vw_StuReportByStuid")==null) || (isReloadFromDB))
            {
                Vw_StuReport_DAL V_S_Dal = new Vw_StuReport_DAL();
                var Vw_StuReportList = V_S_Dal.GetVw_StuReportListFromDB_WithStuID(Stuid);
                CacheHelper.SetCache("Vw_StuReportByStuid", Vw_StuReportList);
            }
            if (CacheHelper.GetCache("Vw_StuReportByStuid")==null)
            {
                return null;
            }
            return CacheHelper.GetCache("Vw_StuReportByStuid") as List<Vw_StuReport>;
        }
        public List<Vw_StuReport> GetNowActYearVw_StuReportByStuid(bool isReloadFromDB, int Stuid)
        {
            if ((CacheHelper.GetCache("Vw_NowStuReportByStuid")==null) || isReloadFromDB)
            {
                Vw_StuReport_DAL V_S_Dal = new Vw_StuReport_DAL();
                var _Activeyear = GetNowActyear(DJTUStudentSystem.Config.Setting.isReadFromDB);
                var Vw_StuReportList = V_S_Dal.GetNowActYearVw_StuReportListFromDB_WithStuID(Stuid, _Activeyear.ATID);
                CacheHelper.SetCache("Vw_NowStuReportByStuid", Vw_StuReportList);
            }
            if (CacheHelper.GetCache("Vw_NowStuReportByStuid") ==null)
            {
                return null;
            }
            return CacheHelper.GetCache("Vw_NowStuReportByStuid") as List<Vw_StuReport>;
        }
    }
}
