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
	/// 实体类Vw_ByStudent 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_ByStudent")]
	[Serializable]
	public partial class Vw_ByStudent : Entity 
	{
		#region Model
		private int _BYID;
		private int? _AtyID;
		private string _BatchNo;
		private int? _GRID;
		private int? _Stdid;
		private decimal? _GetSource;
		private decimal? _AvgPoint;
		private string _State;
		private string _HaveBY;
		private string _HaveXW;
		private string _StdCode;
		private string _StdName;
		private int? _SPID;
		private int? _CLID;
		private string _GRName;
		private string _SPName;
		private decimal? _BadSource;
		private string _HaveXW2;
		/// <summary>
		/// 
		/// </summary>
		public int BYID
		{
			get{ return _BYID; }
			set
			{
				this.OnPropertyValueChange(_.BYID,_BYID,value);
				this._BYID=value;
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
		public string BatchNo
		{
			get{ return _BatchNo; }
			set
			{
				this.OnPropertyValueChange(_.BatchNo,_BatchNo,value);
				this._BatchNo=value;
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
		public decimal? AvgPoint
		{
			get{ return _AvgPoint; }
			set
			{
				this.OnPropertyValueChange(_.AvgPoint,_AvgPoint,value);
				this._AvgPoint=value;
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
		public string HaveBY
		{
			get{ return _HaveBY; }
			set
			{
				this.OnPropertyValueChange(_.HaveBY,_HaveBY,value);
				this._HaveBY=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HaveXW
		{
			get{ return _HaveXW; }
			set
			{
				this.OnPropertyValueChange(_.HaveXW,_HaveXW,value);
				this._HaveXW=value;
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
		public string SPName
		{
			get{ return _SPName; }
			set
			{
				this.OnPropertyValueChange(_.SPName,_SPName,value);
				this._SPName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BadSource
		{
			get{ return _BadSource; }
			set
			{
				this.OnPropertyValueChange(_.BadSource,_BadSource,value);
				this._BadSource=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HaveXW2
		{
			get{ return _HaveXW2; }
			set
			{
				this.OnPropertyValueChange(_.HaveXW2,_HaveXW2,value);
				this._HaveXW2=value;
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
				_.BYID,
				_.AtyID,
				_.BatchNo,
				_.GRID,
				_.Stdid,
				_.GetSource,
				_.AvgPoint,
				_.State,
				_.HaveBY,
				_.HaveXW,
				_.StdCode,
				_.StdName,
				_.SPID,
				_.CLID,
				_.GRName,
				_.SPName,
				_.BadSource,
				_.HaveXW2};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._BYID,
				this._AtyID,
				this._BatchNo,
				this._GRID,
				this._Stdid,
				this._GetSource,
				this._AvgPoint,
				this._State,
				this._HaveBY,
				this._HaveXW,
				this._StdCode,
				this._StdName,
				this._SPID,
				this._CLID,
				this._GRName,
				this._SPName,
				this._BadSource,
				this._HaveXW2};
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
			public readonly static Field All = new Field("*","vw_ByStudent");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BYID = new Field("BYID","vw_ByStudent","BYID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","vw_ByStudent","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BatchNo = new Field("BatchNo","vw_ByStudent","BatchNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","vw_ByStudent","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("Stdid","vw_ByStudent","Stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GetSource = new Field("GetSource","vw_ByStudent","GetSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AvgPoint = new Field("AvgPoint","vw_ByStudent","AvgPoint");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","vw_ByStudent","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HaveBY = new Field("HaveBY","vw_ByStudent","HaveBY");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HaveXW = new Field("HaveXW","vw_ByStudent","HaveXW");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_ByStudent","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","vw_ByStudent","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_ByStudent","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLID = new Field("CLID","vw_ByStudent","CLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_ByStudent","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPName = new Field("SPName","vw_ByStudent","SPName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BadSource = new Field("BadSource","vw_ByStudent","BadSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HaveXW2 = new Field("HaveXW2","vw_ByStudent","HaveXW2");
		}
		#endregion


	}
}

