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
	/// 实体类Vw_ReportInputByClass 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_ReportInputByClass")]
	[Serializable]
	public partial class Vw_ReportInputByClass : Entity 
	{
		#region Model
		private string _ATName;
		private string _PsName;
		private string _StandCode;
		private string _CCname;
		private string _CCode;
		private string _ClassName;
		private int? _AtyID;
		private int? _PSID;
		private int? _CCID;
		private int? _CLID;
		private string _Oper;
		private DateTime? _MDate;
		private string _State;
		private int _RIBID;
		/// <summary>
		/// 
		/// </summary>
		public string ATName
		{
			get{ return _ATName; }
			set
			{
				this.OnPropertyValueChange(_.ATName,_ATName,value);
				this._ATName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PsName
		{
			get{ return _PsName; }
			set
			{
				this.OnPropertyValueChange(_.PsName,_PsName,value);
				this._PsName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StandCode
		{
			get{ return _StandCode; }
			set
			{
				this.OnPropertyValueChange(_.StandCode,_StandCode,value);
				this._StandCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CCname
		{
			get{ return _CCname; }
			set
			{
				this.OnPropertyValueChange(_.CCname,_CCname,value);
				this._CCname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CCode
		{
			get{ return _CCode; }
			set
			{
				this.OnPropertyValueChange(_.CCode,_CCode,value);
				this._CCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClassName
		{
			get{ return _ClassName; }
			set
			{
				this.OnPropertyValueChange(_.ClassName,_ClassName,value);
				this._ClassName=value;
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
		public int? CLID
		{
			get{ return _CLID; }
			set
			{
				this.OnPropertyValueChange(_.CLID,_CLID,value);
				this._CLID=value;
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
		public DateTime? MDate
		{
			get{ return _MDate; }
			set
			{
				this.OnPropertyValueChange(_.MDate,_MDate,value);
				this._MDate=value;
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
		/// <summary>
		/// 
		/// </summary>
		public int RIBID
		{
			get{ return _RIBID; }
			set
			{
				this.OnPropertyValueChange(_.RIBID,_RIBID,value);
				this._RIBID=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 是否只读
		/// </summary>
		public override bool IsReadOnly()
		{
			return true;
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ATName,
				_.PsName,
				_.StandCode,
				_.CCname,
				_.CCode,
				_.ClassName,
				_.AtyID,
				_.PSID,
				_.CCID,
				_.CLID,
				_.Oper,
				_.MDate,
				_.State,
				_.RIBID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ATName,
				this._PsName,
				this._StandCode,
				this._CCname,
				this._CCode,
				this._ClassName,
				this._AtyID,
				this._PSID,
				this._CCID,
				this._CLID,
				this._Oper,
				this._MDate,
				this._State,
				this._RIBID};
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
			public readonly static Field All = new Field("*","vw_ReportInputByClass");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATName = new Field("ATName","vw_ReportInputByClass","ATName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PsName = new Field("PsName","vw_ReportInputByClass","PsName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StandCode = new Field("StandCode","vw_ReportInputByClass","StandCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_ReportInputByClass","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_ReportInputByClass","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassName = new Field("ClassName","vw_ReportInputByClass","ClassName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","vw_ReportInputByClass","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","vw_ReportInputByClass","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_ReportInputByClass","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLID = new Field("CLID","vw_ReportInputByClass","CLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","vw_ReportInputByClass","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MDate = new Field("MDate","vw_ReportInputByClass","MDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","vw_ReportInputByClass","state");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RIBID = new Field("RIBID","vw_ReportInputByClass","RIBID");
		}
		#endregion


	}
}

