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
	/// 实体类Vw_RepeatApply 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_RepeatApply")]
	[Serializable]
	public partial class Vw_RepeatApply : Entity 
	{
		#region Model
		private int _RSID;
		private int? _AtyID;
		private int? _Stdid;
		private int? _CCID;
		private int? _Number;
		private DateTime? _MDate;
		private string _Oper;
		private DateTime? _RDate;
		private string _State;
		private string _ATName;
		private string _CCode;
		private string _CCname;
		private string _StdCode;
		private string _StdName;
		private string _ClassName;
		private int? _Prelect;
		/// <summary>
		/// 
		/// </summary>
		public int RSID
		{
			get{ return _RSID; }
			set
			{
				this.OnPropertyValueChange(_.RSID,_RSID,value);
				this._RSID=value;
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
		public int? Stdid
		{
			get{ return _Stdid; }
			set
			{
				this.OnPropertyValueChange(_.Stdid,_Stdid,value);
				this._Stdid=value;
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
		public int? Number
		{
			get{ return _Number; }
			set
			{
				this.OnPropertyValueChange(_.Number,_Number,value);
				this._Number=value;
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
		public DateTime? RDate
		{
			get{ return _RDate; }
			set
			{
				this.OnPropertyValueChange(_.RDate,_RDate,value);
				this._RDate=value;
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
		public string StdCode
		{
			get{ return _StdCode; }
			set
			{
				this.OnPropertyValueChange(_.StdCode,_StdCode,value);
				this._StdCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StdName
		{
			get{ return _StdName; }
			set
			{
				this.OnPropertyValueChange(_.StdName,_StdName,value);
				this._StdName=value;
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
		public int? Prelect
		{
			get{ return _Prelect; }
			set
			{
				this.OnPropertyValueChange(_.Prelect,_Prelect,value);
				this._Prelect=value;
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
				_.RSID,
				_.AtyID,
				_.Stdid,
				_.CCID,
				_.Number,
				_.MDate,
				_.Oper,
				_.RDate,
				_.State,
				_.ATName,
				_.CCode,
				_.CCname,
				_.StdCode,
				_.StdName,
				_.ClassName,
				_.Prelect};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._RSID,
				this._AtyID,
				this._Stdid,
				this._CCID,
				this._Number,
				this._MDate,
				this._Oper,
				this._RDate,
				this._State,
				this._ATName,
				this._CCode,
				this._CCname,
				this._StdCode,
				this._StdName,
				this._ClassName,
				this._Prelect};
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
			public readonly static Field All = new Field("*","vw_RepeatApply");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RSID = new Field("RSID","vw_RepeatApply","RSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","vw_RepeatApply","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("Stdid","vw_RepeatApply","Stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_RepeatApply","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Number = new Field("Number","vw_RepeatApply","Number");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MDate = new Field("MDate","vw_RepeatApply","MDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","vw_RepeatApply","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RDate = new Field("RDate","vw_RepeatApply","RDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","vw_RepeatApply","state");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATName = new Field("ATName","vw_RepeatApply","ATName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_RepeatApply","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_RepeatApply","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_RepeatApply","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","vw_RepeatApply","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassName = new Field("ClassName","vw_RepeatApply","ClassName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Prelect = new Field("Prelect","vw_RepeatApply","Prelect");
		}
		#endregion


	}
}

