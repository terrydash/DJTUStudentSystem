﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Support: http://www.cnblogs.com/huxj
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace DJTUStudentSystem.DataBaseModel
{

    /// <summary>
    /// 实体类ClassAndTeach 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ClassAndTeach : Entity
    {
        public ClassAndTeach() : base("ClassAndTeach") { }

        #region Model
        private int _CATID;
        private int _TCID;
        private int? _CCID;
        private int _CLID;
        private string _CLName;
        private string _Direct;
        private string _ReportState;
        private string _Affirmant;
        private string _Memo;
        private string _State;
        private int? _Num;
        private string _Ctype;
        private string _Pjstate;
        private int? _Psid;
        /// <summary>
        /// 
        /// </summary>
        public int CATID
        {
            get { return _CATID; }
            set
            {
                this.OnPropertyValueChange(_.CATID, _CATID, value);
                this._CATID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int TCID
        {
            get { return _TCID; }
            set
            {
                this.OnPropertyValueChange(_.TCID, _TCID, value);
                this._TCID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CCID
        {
            get { return _CCID; }
            set
            {
                this.OnPropertyValueChange(_.CCID, _CCID, value);
                this._CCID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CLID
        {
            get { return _CLID; }
            set
            {
                this.OnPropertyValueChange(_.CLID, _CLID, value);
                this._CLID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CLName
        {
            get { return _CLName; }
            set
            {
                this.OnPropertyValueChange(_.CLName, _CLName, value);
                this._CLName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Direct
        {
            get { return _Direct; }
            set
            {
                this.OnPropertyValueChange(_.Direct, _Direct, value);
                this._Direct = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ReportState
        {
            get { return _ReportState; }
            set
            {
                this.OnPropertyValueChange(_.ReportState, _ReportState, value);
                this._ReportState = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Affirmant
        {
            get { return _Affirmant; }
            set
            {
                this.OnPropertyValueChange(_.Affirmant, _Affirmant, value);
                this._Affirmant = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Memo
        {
            get { return _Memo; }
            set
            {
                this.OnPropertyValueChange(_.Memo, _Memo, value);
                this._Memo = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string State
        {
            get { return _State; }
            set
            {
                this.OnPropertyValueChange(_.State, _State, value);
                this._State = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Num
        {
            get { return _Num; }
            set
            {
                this.OnPropertyValueChange(_.Num, _Num, value);
                this._Num = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Ctype
        {
            get { return _Ctype; }
            set
            {
                this.OnPropertyValueChange(_.Ctype, _Ctype, value);
                this._Ctype = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Pjstate
        {
            get { return _Pjstate; }
            set
            {
                this.OnPropertyValueChange(_.Pjstate, _Pjstate, value);
                this._Pjstate = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Psid
        {
            get { return _Psid; }
            set
            {
                this.OnPropertyValueChange(_.Psid, _Psid, value);
                this._Psid = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.CATID;
        }
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                _.CATID};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.CATID,
                _.TCID,
                _.CCID,
                _.CLID,
                _.CLName,
                _.Direct,
                _.ReportState,
                _.Affirmant,
                _.Memo,
                _.State,
                _.Num,
                _.Ctype,
                _.Pjstate,
                _.Psid};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._CATID,
                this._TCID,
                this._CCID,
                this._CLID,
                this._CLName,
                this._Direct,
                this._ReportState,
                this._Affirmant,
                this._Memo,
                this._State,
                this._Num,
                this._Ctype,
                this._Pjstate,
                this._Psid};
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._CATID = DataUtils.ConvertValue<int>(reader["CATID"]);
            this._TCID = DataUtils.ConvertValue<int>(reader["TCID"]);
            this._CCID = DataUtils.ConvertValue<int?>(reader["CCID"]);
            this._CLID = DataUtils.ConvertValue<int>(reader["CLID"]);
            this._CLName = DataUtils.ConvertValue<string>(reader["CLName"]);
            this._Direct = DataUtils.ConvertValue<string>(reader["Direct"]);
            this._ReportState = DataUtils.ConvertValue<string>(reader["ReportState"]);
            this._Affirmant = DataUtils.ConvertValue<string>(reader["Affirmant"]);
            this._Memo = DataUtils.ConvertValue<string>(reader["Memo"]);
            this._State = DataUtils.ConvertValue<string>(reader["State"]);
            this._Num = DataUtils.ConvertValue<int?>(reader["Num"]);
            this._Ctype = DataUtils.ConvertValue<string>(reader["ctype"]);
            this._Pjstate = DataUtils.ConvertValue<string>(reader["pjstate"]);
            this._Psid = DataUtils.ConvertValue<int?>(reader["psid"]);
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._CATID = DataUtils.ConvertValue<int>(row["CATID"]);
            this._TCID = DataUtils.ConvertValue<int>(row["TCID"]);
            this._CCID = DataUtils.ConvertValue<int?>(row["CCID"]);
            this._CLID = DataUtils.ConvertValue<int>(row["CLID"]);
            this._CLName = DataUtils.ConvertValue<string>(row["CLName"]);
            this._Direct = DataUtils.ConvertValue<string>(row["Direct"]);
            this._ReportState = DataUtils.ConvertValue<string>(row["ReportState"]);
            this._Affirmant = DataUtils.ConvertValue<string>(row["Affirmant"]);
            this._Memo = DataUtils.ConvertValue<string>(row["Memo"]);
            this._State = DataUtils.ConvertValue<string>(row["State"]);
            this._Num = DataUtils.ConvertValue<int?>(row["Num"]);
            this._Ctype = DataUtils.ConvertValue<string>(row["ctype"]);
            this._Pjstate = DataUtils.ConvertValue<string>(row["pjstate"]);
            this._Psid = DataUtils.ConvertValue<int?>(row["psid"]);
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// * 
            /// </summary>
            public readonly static Field All = new Field("*", "ClassAndTeach");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CATID = new Field("CATID", "ClassAndTeach", "CATID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TCID = new Field("TCID", "ClassAndTeach", "TCID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CCID = new Field("CCID", "ClassAndTeach", "CCID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CLID = new Field("CLID", "ClassAndTeach", "CLID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CLName = new Field("CLName", "ClassAndTeach", "CLName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Direct = new Field("Direct", "ClassAndTeach", "Direct");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ReportState = new Field("ReportState", "ClassAndTeach", "ReportState");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Affirmant = new Field("Affirmant", "ClassAndTeach", "Affirmant");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Memo = new Field("Memo", "ClassAndTeach", "Memo");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field State = new Field("State", "ClassAndTeach", "State");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Num = new Field("Num", "ClassAndTeach", "Num");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Ctype = new Field("ctype", "ClassAndTeach", "ctype");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Pjstate = new Field("pjstate", "ClassAndTeach", "pjstate");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Psid = new Field("psid", "ClassAndTeach", "psid");
        }
        #endregion


    }
}
