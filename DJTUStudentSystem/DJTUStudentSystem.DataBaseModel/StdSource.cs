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
	/// 实体类StdSource 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("StdSource")]
	[Serializable]
	public partial class StdSource : Entity 
	{
		#region Model
		private int _SSID;
		private int? _Stdid;
		private int? _DeptID;
		private int? _SPID;
		private int? _CLID;
		private int? _Grdid;
		private int? _Atyid;
		private int? _TMID;
		private string _YearName;
		private decimal? _GetSource;
		private decimal? _BasSource;
		private decimal? _SumBad;
		private decimal? _SumPoint;
		private int? _SequID;
		private string _State;
		/// <summary>
		/// 
		/// </summary>
		public int SSID
		{
			get{ return _SSID; }
			set
			{
				this.OnPropertyValueChange(_.SSID,_SSID,value);
				this._SSID=value;
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
		public int? Grdid
		{
			get{ return _Grdid; }
			set
			{
				this.OnPropertyValueChange(_.Grdid,_Grdid,value);
				this._Grdid=value;
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
		public int? TMID
		{
			get{ return _TMID; }
			set
			{
				this.OnPropertyValueChange(_.TMID,_TMID,value);
				this._TMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YearName
		{
			get{ return _YearName; }
			set
			{
				this.OnPropertyValueChange(_.YearName,_YearName,value);
				this._YearName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? GetSource
		{
			get{ return _GetSource; }
			set
			{
				this.OnPropertyValueChange(_.GetSource,_GetSource,value);
				this._GetSource=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BasSource
		{
			get{ return _BasSource; }
			set
			{
				this.OnPropertyValueChange(_.BasSource,_BasSource,value);
				this._BasSource=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SumBad
		{
			get{ return _SumBad; }
			set
			{
				this.OnPropertyValueChange(_.SumBad,_SumBad,value);
				this._SumBad=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SumPoint
		{
			get{ return _SumPoint; }
			set
			{
				this.OnPropertyValueChange(_.SumPoint,_SumPoint,value);
				this._SumPoint=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SequID
		{
			get{ return _SequID; }
			set
			{
				this.OnPropertyValueChange(_.SequID,_SequID,value);
				this._SequID=value;
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
			return _.SSID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.SSID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.SSID,
				_.Stdid,
				_.DeptID,
				_.SPID,
				_.CLID,
				_.Grdid,
				_.Atyid,
				_.TMID,
				_.YearName,
				_.GetSource,
				_.BasSource,
				_.SumBad,
				_.SumPoint,
				_.SequID,
				_.State};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SSID,
				this._Stdid,
				this._DeptID,
				this._SPID,
				this._CLID,
				this._Grdid,
				this._Atyid,
				this._TMID,
				this._YearName,
				this._GetSource,
				this._BasSource,
				this._SumBad,
				this._SumPoint,
				this._SequID,
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
			public readonly static Field All = new Field("*","StdSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SSID = new Field("SSID","StdSource","SSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("Stdid","StdSource","Stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","StdSource","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","StdSource","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLID = new Field("CLID","StdSource","CLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Grdid = new Field("Grdid","StdSource","Grdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("atyid","StdSource","atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TMID = new Field("TMID","StdSource","TMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field YearName = new Field("YearName","StdSource","YearName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GetSource = new Field("GetSource","StdSource","GetSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BasSource = new Field("BasSource","StdSource","BasSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SumBad = new Field("SumBad","StdSource","SumBad");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SumPoint = new Field("SumPoint","StdSource","SumPoint");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SequID = new Field("SequID","StdSource","SequID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","StdSource","State");
		}
		#endregion


	}
}
