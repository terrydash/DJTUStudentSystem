using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SharpConfig;
using System.Web;

namespace DJTUStudentSystem.Common
{
    public class ConfigHelper
    {

        public static string FileFullName { get; set; }

        public static string GetConfigFile(string filename)
        {
            var FilePath = HttpRuntime.AppDomainAppPath.ToString();
            var FileFullName = FilePath + filename;
            if (File.Exists(FileFullName))
            {
                try
                {
                    File.Delete(FileFullName);
                }
                catch (Exception e)
                {
                    LogHelper.Logger.Error(e.ToString());
                }
            }
            if (!File.Exists(FileFullName))
            {
                return FileFullName;

            }
            return string.Empty;
        
        }
        public static Dictionary<string ,string> LoadConfigSettingFromFile(string _sectionName,List<string> _keyNames) 
        {
            if (FileFullName.Length<=0 || !File.Exists(FileFullName) || _sectionName.Length<=0 || _keyNames.Count<=0)
            {
                return null;
            }
            var _Dictionary = new Dictionary<string, string>() ;
            Configuration _Config;
            Section _ConfigSection;
            try
            {
                _Config = Configuration.LoadFromFile(FileFullName);
                _ConfigSection = _Config[_sectionName];
                foreach (var _keyName in _keyNames)
                {
                    _Dictionary.Add(_keyName, _ConfigSection[_keyName].StringValue);
                }
                return _Dictionary;
            }
            catch(Exception e)
            {
                LogHelper.Logger.Error(e.ToString());
            }
           
                return null;
        }
        public static bool SaveConfigSettingToFile(string _sectionName, Dictionary<string, string> _KeysAndValues)
        {
            var IsSuccess = true;
            if (FileFullName.Length <= 0 || !File.Exists(FileFullName) || _sectionName.Length <= 0 || _KeysAndValues.Count <= 0)
            {
                IsSuccess = false;
                return IsSuccess;
            }
            Configuration _Config = new Configuration();
            Section _ConfigSection = new Section(_sectionName);
            try
            {
                foreach (var _KeyAndValue in _KeysAndValues)
                {
                    _ConfigSection[_KeyAndValue.Key].SetValue(_KeyAndValue.Value);
                }
                _Config.SaveToFile(FileFullName);
                Console.WriteLine(FileFullName);
            }
            catch (Exception e)
            {
                IsSuccess = false;
                LogHelper.Logger.Error(e.ToString());
            }
            return IsSuccess;

        }

    }
}
