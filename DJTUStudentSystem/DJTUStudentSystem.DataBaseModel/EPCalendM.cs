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
	/// 实体类EPCalendM 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("EPCalendM")]
	[Serializable]
	public partial class EPCalendM : Entity 
	{
		#region Model
		private int _EPCID;
		private int? _AtyID;
		private int? _TCID;
		private int? _CCID;
		private int? _PSID;
		private string _Deptcode;
		private DateTime? _EPDate;
		private string _State;
		/// <summary>
		/// 
		/// </summary>
		public int EPCID
		{
			get{ return _EPCID; }
			set
			{
				this.OnPropertyValueChange(_.EPCID,_EPCID,value);
				this._EPCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AtyID
		{
			get{ return _AtyID; }
			set
			{
				this.OnPropertyValueChange(_.AtyID,_AtyID,value);
				this._AtyID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TCID
		{
			get{ return _TCID; }
			set
			{
				this.OnPropertyValueChange(_.TCID,_TCID,value);
				this._TCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CCID
		{
			get{ return _CCID; }
			set
			{
				this.OnPropertyValueChange(_.CCID,_CCID,value);
				this._CCID=value;
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
		public string Deptcode
		{
			get{ return _Deptcode; }
			set
			{
				this.OnPropertyValueChange(_.Deptcode,_Deptcode,value);
				this._Deptcode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EPDate
		{
			get{ return _EPDate; }
			set
			{
				this.OnPropertyValueChange(_.EPDate,_EPDate,value);
				this._EPDate=value;
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
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.EPCID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.EPCID,
				_.AtyID,
				_.TCID,
				_.CCID,
				_.PSID,
				_.Deptcode,
				_.EPDate,
				_.State};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EPCID,
				this._AtyID,
				this._TCID,
				this._CCID,
				this._PSID,
				this._Deptcode,
				this._EPDate,
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
			public readonly static Field All = new Field("*","EPCalendM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPCID = new Field("EPCID","EPCalendM","EPCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","EPCalendM","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","EPCalendM","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","EPCalendM","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","EPCalendM","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Deptcode = new Field("Deptcode","EPCalendM","Deptcode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPDate = new Field("EPDate","EPCalendM","EPDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","EPCalendM","State");
		}
		#endregion


	}
}
