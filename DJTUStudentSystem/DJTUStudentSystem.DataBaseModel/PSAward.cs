﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
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
	/// 实体类PSAward 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("PSAward")]
	[Serializable]
	public partial class PSAward : Entity 
	{
		#region Model
		private int _TID;
		private int? _PSID;
		private string _PSName;
		private string _Dept;
		private string _DeptCode;
		private DateTime? _PMDate;
		private string _Award;
		private decimal? _Sorce;
		private string _Oper;
		private string _ChkOper;
		private string _RtufileOper;
		private string _State;
		/// <summary>
		/// 
		/// </summary>
		public int TID
		{
			get{ return _TID; }
			set
			{
				this.OnPropertyValueChange(_.TID,_TID,value);
				this._TID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PSID
		{
			get{ return _PSID; }
			set
			{
				this.OnPropertyValueChange(_.PSID,_PSID,value);
				this._PSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PSName
		{
			get{ return _PSName; }
			set
			{
				this.OnPropertyValueChange(_.PSName,_PSName,value);
				this._PSName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Dept
		{
			get{ return _Dept; }
			set
			{
				this.OnPropertyValueChange(_.Dept,_Dept,value);
				this._Dept=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptCode
		{
			get{ return _DeptCode; }
			set
			{
				this.OnPropertyValueChange(_.DeptCode,_DeptCode,value);
				this._DeptCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PMDate
		{
			get{ return _PMDate; }
			set
			{
				this.OnPropertyValueChange(_.PMDate,_PMDate,value);
				this._PMDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Award
		{
			get{ return _Award; }
			set
			{
				this.OnPropertyValueChange(_.Award,_Award,value);
				this._Award=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Sorce
		{
			get{ return _Sorce; }
			set
			{
				this.OnPropertyValueChange(_.Sorce,_Sorce,value);
				this._Sorce=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Oper
		{
			get{ return _Oper; }
			set
			{
				this.OnPropertyValueChange(_.Oper,_Oper,value);
				this._Oper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChkOper
		{
			get{ return _ChkOper; }
			set
			{
				this.OnPropertyValueChange(_.ChkOper,_ChkOper,value);
				this._ChkOper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RtufileOper
		{
			get{ return _RtufileOper; }
			set
			{
				this.OnPropertyValueChange(_.RtufileOper,_RtufileOper,value);
				this._RtufileOper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string State
		{
			get{ return _State; }
			set
			{
				this.OnPropertyValueChange(_.State,_State,value);
				this._State=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.TID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.TID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TID,
				_.PSID,
				_.PSName,
				_.Dept,
				_.DeptCode,
				_.PMDate,
				_.Award,
				_.Sorce,
				_.Oper,
				_.ChkOper,
				_.RtufileOper,
				_.State};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TID,
				this._PSID,
				this._PSName,
				this._Dept,
				this._DeptCode,
				this._PMDate,
				this._Award,
				this._Sorce,
				this._Oper,
				this._ChkOper,
				this._RtufileOper,
				this._State};
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
			public readonly static Field All = new Field("*","PSAward");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TID = new Field("TID","PSAward","TID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","PSAward","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSName = new Field("PSName","PSAward","PSName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Dept = new Field("Dept","PSAward","Dept");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","PSAward","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PMDate = new Field("PMDate","PSAward","PMDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Award = new Field("Award","PSAward","Award");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sorce = new Field("Sorce","PSAward","Sorce");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","PSAward","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChkOper = new Field("ChkOper","PSAward","ChkOper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RtufileOper = new Field("RtufileOper","PSAward","RtufileOper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","PSAward","State");
		}
		#endregion


	}
}

