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
	/// 实体类Vw_SecExamine 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_SecExamine")]
	[Serializable]
	public partial class Vw_SecExamine : Entity 
	{
		#region Model
		private int _SEID;
		private int? _Atyid;
		private int? _Stdid;
		private int? _CCID;
		private string _State;
		private string _CCode;
		private string _CCname;
		private string _StdCode;
		private string _DeptCode;
		private string _DeptName;
		private string _StdName;
		private string _Examine;
		private string _Memo;
		private int? _DeptID;
		private int? _SPID;
		private int? _GRID;
		private int? _CLID;
		private int? _PSID;
		private int? _TCID;
		private string _ClassName;
		private string _PsName;
		private string _TCName;
		private string _Minor;
		private int? _StuLev;
		private string _CLSort;
		private int? _TMID;
		/// <summary>
		/// 
		/// </summary>
		public int SEID
		{
			get{ return _SEID; }
			set
			{
				this.OnPropertyValueChange(_.SEID,_SEID,value);
				this._SEID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Atyid
		{
			get{ return _Atyid; }
			set
			{
				this.OnPropertyValueChange(_.Atyid,_Atyid,value);
				this._Atyid=value;
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
		public string DeptName
		{
			get{ return _DeptName; }
			set
			{
				this.OnPropertyValueChange(_.DeptName,_DeptName,value);
				this._DeptName=value;
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
		public string Examine
		{
			get{ return _Examine; }
			set
			{
				this.OnPropertyValueChange(_.Examine,_Examine,value);
				this._Examine=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get{ return _Memo; }
			set
			{
				this.OnPropertyValueChange(_.Memo,_Memo,value);
				this._Memo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DeptID
		{
			get{ return _DeptID; }
			set
			{
				this.OnPropertyValueChange(_.DeptID,_DeptID,value);
				this._DeptID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SPID
		{
			get{ return _SPID; }
			set
			{
				this.OnPropertyValueChange(_.SPID,_SPID,value);
				this._SPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GRID
		{
			get{ return _GRID; }
			set
			{
				this.OnPropertyValueChange(_.GRID,_GRID,value);
				this._GRID=value;
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
		public string TCName
		{
			get{ return _TCName; }
			set
			{
				this.OnPropertyValueChange(_.TCName,_TCName,value);
				this._TCName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Minor
		{
			get{ return _Minor; }
			set
			{
				this.OnPropertyValueChange(_.Minor,_Minor,value);
				this._Minor=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StuLev
		{
			get{ return _StuLev; }
			set
			{
				this.OnPropertyValueChange(_.StuLev,_StuLev,value);
				this._StuLev=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLSort
		{
			get{ return _CLSort; }
			set
			{
				this.OnPropertyValueChange(_.CLSort,_CLSort,value);
				this._CLSort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TMID
		{
			get{ return _TMID; }
			set
			{
				this.OnPropertyValueChange(_.TMID,_TMID,value);
				this._TMID=value;
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
				_.SEID,
				_.Atyid,
				_.Stdid,
				_.CCID,
				_.State,
				_.CCode,
				_.CCname,
				_.StdCode,
				_.DeptCode,
				_.DeptName,
				_.StdName,
				_.Examine,
				_.Memo,
				_.DeptID,
				_.SPID,
				_.GRID,
				_.CLID,
				_.PSID,
				_.TCID,
				_.ClassName,
				_.PsName,
				_.TCName,
				_.Minor,
				_.StuLev,
				_.CLSort,
				_.TMID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SEID,
				this._Atyid,
				this._Stdid,
				this._CCID,
				this._State,
				this._CCode,
				this._CCname,
				this._StdCode,
				this._DeptCode,
				this._DeptName,
				this._StdName,
				this._Examine,
				this._Memo,
				this._DeptID,
				this._SPID,
				this._GRID,
				this._CLID,
				this._PSID,
				this._TCID,
				this._ClassName,
				this._PsName,
				this._TCName,
				this._Minor,
				this._StuLev,
				this._CLSort,
				this._TMID};
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
			public readonly static Field All = new Field("*","vw_SecExamine");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SEID = new Field("SEID","vw_SecExamine","SEID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("atyid","vw_SecExamine","atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("stdid","vw_SecExamine","stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_SecExamine","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","vw_SecExamine","state");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_SecExamine","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_SecExamine","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_SecExamine","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","vw_SecExamine","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName","vw_SecExamine","DeptName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","vw_SecExamine","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Examine = new Field("Examine","vw_SecExamine","Examine");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("memo","vw_SecExamine","memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","vw_SecExamine","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_SecExamine","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","vw_SecExamine","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLID = new Field("CLID","vw_SecExamine","CLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","vw_SecExamine","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","vw_SecExamine","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassName = new Field("ClassName","vw_SecExamine","ClassName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PsName = new Field("PsName","vw_SecExamine","PsName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCName = new Field("TCName","vw_SecExamine","TCName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Minor = new Field("Minor","vw_SecExamine","Minor");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StuLev = new Field("StuLev","vw_SecExamine","StuLev");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLSort = new Field("CLSort","vw_SecExamine","CLSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TMID = new Field("TMID","vw_SecExamine","TMID");
		}
		#endregion


	}
}

