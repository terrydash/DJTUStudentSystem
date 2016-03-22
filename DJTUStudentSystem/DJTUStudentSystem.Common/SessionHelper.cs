using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DJTUStudentSystem.Common
{
    public class SessionHelper
    {

        #region 检查SESSION是否存在的封装  public static  string CheckSession(string SessionName,int WaitTime)
        /// <summary>
        ///  检查SESSION是否存在的封装 
        /// </summary>
        /// <param name="SessionName"></param>
        /// <param name="WaitTime"></param>
        /// <returns></returns>
        public static string CheckSession(string SessionName, int WaitTime)
        {

            try
            {
                if (System.Web.HttpContext.Current.Session[SessionName] != null)
                {

                    var session = System.Web.HttpContext.Current.Session[SessionName].ToString(); ;
                    var dt1 = DateTime.Now;

                    dt1 = Convert.ToDateTime(session);

                    var dt2 = DateTime.Now;
                    TimeSpan ts = dt2.Subtract(dt1);
                    if (ts.TotalSeconds < WaitTime)
                    {
                        return "请等待" + WaitTime.ToString() + "后再试!已等待" + ts.TotalSeconds.ToString("0.00") + "秒";

                    }
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            System.Web.HttpContext.Current.Session[SessionName] = DateTime.Now.ToString();
            return "SessionOk".ToUpper();

        }
        #endregion
    }
}
