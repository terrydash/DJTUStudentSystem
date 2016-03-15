using System;
using System.Collections;
using System.Web.Caching;



namespace DJTUStudentSystem.Common
{
    public class CacheHelper
    {

        static Cache _cache = System.Web.HttpRuntime.Cache;
        /// <summary>
        /// 获取数据缓存
        /// </summary>
        /// <param name="CacheKey">键</param>
        public static object GetCache(string CacheKey)
    {
        
            return _cache[CacheKey];
    }

    /// <summary>
    /// 设置数据缓存
    /// </summary>
    public static void SetCache(string CacheKey, object objObject)
    {

            _cache.Insert(CacheKey, objObject);
    }

    /// <summary>
    /// 设置数据缓存
    /// </summary>
    public static void SetCache(string CacheKey, object objObject, TimeSpan Timeout)
    {

            _cache.Insert(CacheKey, objObject, null, DateTime.MaxValue, Timeout, System.Web.Caching.CacheItemPriority.NotRemovable, null);
    }

    /// <summary>
    /// 设置数据缓存
    /// </summary>
    public static void SetCache(string CacheKey, object objObject, DateTime absoluteExpiration, TimeSpan slidingExpiration)
    {

            _cache.Insert(CacheKey, objObject, null, absoluteExpiration, slidingExpiration);
    }

    /// <summary>
    /// 移除指定数据缓存
    /// </summary>
    public static void RemoveAllCache(string CacheKey)
    {
        
        _cache.Remove(CacheKey);
    }

    /// <summary>
    /// 移除全部缓存
    /// </summary>
    public static void RemoveAllCache()
    {
        
        IDictionaryEnumerator CacheEnum = _cache.GetEnumerator();
        while (CacheEnum.MoveNext())
        {
            _cache.Remove(CacheEnum.Key.ToString());
        }
    }


    }


    
}
