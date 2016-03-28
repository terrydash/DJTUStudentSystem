using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using DJTUStudentSystem.BLL;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Config;
using DJTUStudentSystem.Common;
namespace DJTUStudentSystem.MVCWEB
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Application["OnLineUserCount"] = 0; ///在线人数
            AreaRegistration.RegisterAllAreas();
            log4net.Config.XmlConfigurator.Configure();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var filename = "AppSetting.ini";
            var filepath = HttpRuntime.AppDomainAppPath.ToString();
            var filefullname = filepath + filename;
            
            if (filefullname != string.Empty)
            {
                ConfigHelper.FileFullName = filefullname;
                if (System.IO.File.Exists(filefullname))
                {
                    


                    var _KeysAndValues = ConfigHelper.LoadConfigSettingFromFile("General", new List<string> { "AllowChooseChourse","AllowConfictWeek" });
                    foreach (var _KeyAndValue in _KeysAndValues)
                    {

                        switch (_KeyAndValue.Key)
                        {
                            case "AllowChooseChourse":
                                try
                                {
                                    Setting.AllowChooseChourse = Convert.ToBoolean(_KeyAndValue.Value);
                                }
                                catch (Exception e)
                                {
                                    Setting.AllowChooseChourse = true;
                                    LogHelper.Logger.Error(e.ToString());
                                }
                                break;
                            case "AllowConfictWeek":
                                try
                                {
                                    Setting.AllowConfictWeeks = Convert.ToInt32(_KeyAndValue.Value);
                                }
                                catch (Exception e)
                                {
                                    Setting.AllowConfictWeeks= 3;
                                    LogHelper.Logger.Error(e.ToString());
                                }

                                break;
                            default:
                                break;
                        }
                    }
                }else
                {
                    var _KeysAndValues = new Dictionary<string, string>();
                    _KeysAndValues.Add("AllowChooseChourse", Setting.AllowChooseChourse.ToString());
                    _KeysAndValues.Add("AllowConfictWeek", Setting.AllowConfictWeeks.ToString());
                    try
                    {
                        var state=ConfigHelper.SaveConfigSettingToFile("General", _KeysAndValues);
                        Console.WriteLine(state.ToString());
                    }
                       catch (Exception e)
                    {
                        
                        LogHelper.Logger.Error(e.ToString());
                    }
                }

            }
            
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["OnLineUserCount"] = Convert.ToInt32(Application["OnLineUserCount"]) + 1;
            Application.UnLock();
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["OnLineUserCount"] = Convert.ToInt32(Application["OnLineUserCount"]) - 1;
            Application.UnLock();
        }

    }
}