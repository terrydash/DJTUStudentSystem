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
	/// 实体类Vw_TeachProcess 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_TeachProcess")]
	[Serializable]
	public partial class Vw_TeachProcess : Entity 
	{
		#region Model
		private int _TPID;
		private int? _ATYID;
		private int? _CLID;
		private int? _WeekNo;
		private int? _Process;
		private int? _ProcessB;
		private string _Memo;
		private int? _State;
		private string _ClassName;
		private string _GRName;
		private int? _SPID;
		private int? _GRID;
		private string _Mark;
		private string _MarkB;
		private int? _TMID;
		/// <summary>
		/// 
		/// </summary>
		public int TPID
		{
			get{ return _TPID; }
			set
			{
				this.OnPropertyValueChange(_.TPID,_TPID,value);
				this._TPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ATYID
		{
			get{ return _ATYID; }
			set
			{
				this.OnPropertyValueChange(_.ATYID,_ATYID,value);
				this._ATYID=value;
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
		public int? WeekNo
		{
			get{ return _WeekNo; }
			set
			{
				this.OnPropertyValueChange(_.WeekNo,_WeekNo,value);
				this._WeekNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Process
		{
			get{ return _Process; }
			set
			{
				this.OnPropertyValueChange(_.Process,_Process,value);
				this._Process=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProcessB
		{
			get{ return _ProcessB; }
			set
			{
				this.OnPropertyValueChange(_.ProcessB,_ProcessB,value);
				this._ProcessB=value;
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
		public int? State
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
		public string GRName
		{
			get{ return _GRName; }
			set
			{
				this.OnPropertyValueChange(_.GRName,_GRName,value);
				this._GRName=value;
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
		public string Mark
		{
			get{ return _Mark; }
			set
			{
				this.OnPropertyValueChange(_.Mark,_Mark,value);
				this._Mark=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MarkB
		{
			get{ return _MarkB; }
			set
			{
				this.OnPropertyValueChange(_.MarkB,_MarkB,value);
				this._MarkB=value;
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
				_.TPID,
				_.ATYID,
				_.CLID,
				_.WeekNo,
				_.Process,
				_.ProcessB,
				_.Memo,
				_.State,
				_.ClassName,
				_.GRName,
				_.SPID,
				_.GRID,
				_.Mark,
				_.MarkB,
				_.TMID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TPID,
				this._ATYID,
				this._CLID,
				this._WeekNo,
				this._Process,
				this._ProcessB,
				this._Memo,
				this._State,
				this._ClassName,
				this._GRName,
				this._SPID,
				this._GRID,
				this._Mark,
				this._MarkB,
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
			public readonly static Field All = new Field("*","vw_TeachProcess");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TPID = new Field("TPID","vw_TeachProcess","TPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATYID = new Field("ATYID","vw_TeachProcess","ATYID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLID = new Field("CLID","vw_TeachProcess","CLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field WeekNo = new Field("WeekNo","vw_TeachProcess","WeekNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Process = new Field("Process","vw_TeachProcess","Process");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ProcessB = new Field("ProcessB","vw_TeachProcess","ProcessB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","vw_TeachProcess","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","vw_TeachProcess","state");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassName = new Field("ClassName","vw_TeachProcess","ClassName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_TeachProcess","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_TeachProcess","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","vw_TeachProcess","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Mark = new Field("Mark","vw_TeachProcess","Mark");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MarkB = new Field("MarkB","vw_TeachProcess","MarkB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TMID = new Field("TMID","vw_TeachProcess","TMID");
		}
		#endregion


	}
}

