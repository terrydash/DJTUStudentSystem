﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dos.ORM;
using System.Data.Common;

namespace DJTUStudentSystem.DBSession
{
    public  class DISTDBSession
    {
        public static DbSession Context2 = new DbSession(DatabaseType.SqlServer9, @"Data Source=DataServer;Database=Education;User Id=sa;Password=52Xuguoxu;");//服务器
        public static DbSession Context1 = new DbSession(DatabaseType.SqlServer9, @"Data Source=WIN-79FIINOQABU;Database=Education;User Id=sa;Password=52Xuguoxu;");//家
        public static DbSession Context = new DbSession(DatabaseType.SqlServer9, @"Data Source=.\XUGUOXU54;Database=Education;User Id=sa;Password=52Xuguoxu;");//单位


        /// <summary>
        /// 执行带参数的SQL语句
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <param name="parameters">参数</param>
        /// <returns>返回影响的数目</returns>
        public int ExecutNoneQuery(string sql, IList<DbParameter> parameters)
        {
            DbCommand db = Context.Db.GetSqlStringCommand(sql);
            if (!(parameters == null || parameters.Count == 0))
            {
                foreach (DbParameter parameter in parameters)
                {
                    db.Parameters.Add(parameter);
                }
            }

            return Context.ExecuteNonQuery(db);
        }
    }
}