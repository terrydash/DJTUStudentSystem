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
	/// 实体类Vw_StuSourceStruct 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_StuSourceStruct")]
	[Serializable]
	public partial class Vw_StuSourceStruct : Entity 
	{
		#region Model
		private int _SSID;
		private int? _Stdid;
		private int? _SPID;
		private int? _GRID;
		private string _CSortCode;
		private string _Csort;
		private decimal? _GetSource;
		private decimal? _NeedSource;
		private string _LastCalDate;
		private string _StdCode;
		private string _StdName;
		private string _SPName;
		private string _GRName;
		private int? _DeptID;
		private string _ClassName;
		private decimal? _AllNeed;
		private decimal? _AllGet;
		private decimal? _CXSource;
		private decimal? _BadSource;
		private int? _LostNum;
		private decimal? _MainAvg;
		private string _ByState;
		private string _State;
		private decimal? _MainAvg2;
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
		public string CSortCode
		{
			get{ return _CSortCode; }
			set
			{
				this.OnPropertyValueChange(_.CSortCode,_CSortCode,value);
				this._CSortCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Csort
		{
			get{ return _Csort; }
			set
			{
				this.OnPropertyValueChange(_.Csort,_Csort,value);
				this._Csort=value;
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
		public decimal? NeedSource
		{
			get{ return _NeedSource; }
			set
			{
				this.OnPropertyValueChange(_.NeedSource,_NeedSource,value);
				this._NeedSource=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LastCalDate
		{
			get{ return _LastCalDate; }
			set
			{
				this.OnPropertyValueChange(_.LastCalDate,_LastCalDate,value);
				this._LastCalDate=value;
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
		public decimal? AllNeed
		{
			get{ return _AllNeed; }
			set
			{
				this.OnPropertyValueChange(_.AllNeed,_AllNeed,value);
				this._AllNeed=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AllGet
		{
			get{ return _AllGet; }
			set
			{
				this.OnPropertyValueChange(_.AllGet,_AllGet,value);
				this._AllGet=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CXSource
		{
			get{ return _CXSource; }
			set
			{
				this.OnPropertyValueChange(_.CXSource,_CXSource,value);
				this._CXSource=value;
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
		public int? LostNum
		{
			get{ return _LostNum; }
			set
			{
				this.OnPropertyValueChange(_.LostNum,_LostNum,value);
				this._LostNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MainAvg
		{
			get{ return _MainAvg; }
			set
			{
				this.OnPropertyValueChange(_.MainAvg,_MainAvg,value);
				this._MainAvg=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ByState
		{
			get{ return _ByState; }
			set
			{
				this.OnPropertyValueChange(_.ByState,_ByState,value);
				this._ByState=value;
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
		public decimal? MainAvg2
		{
			get{ return _MainAvg2; }
			set
			{
				this.OnPropertyValueChange(_.MainAvg2,_MainAvg2,value);
				this._MainAvg2=value;
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
				_.SSID,
				_.Stdid,
				_.SPID,
				_.GRID,
				_.CSortCode,
				_.Csort,
				_.GetSource,
				_.NeedSource,
				_.LastCalDate,
				_.StdCode,
				_.StdName,
				_.SPName,
				_.GRName,
				_.DeptID,
				_.ClassName,
				_.AllNeed,
				_.AllGet,
				_.CXSource,
				_.BadSource,
				_.LostNum,
				_.MainAvg,
				_.ByState,
				_.State,
				_.MainAvg2};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SSID,
				this._Stdid,
				this._SPID,
				this._GRID,
				this._CSortCode,
				this._Csort,
				this._GetSource,
				this._NeedSource,
				this._LastCalDate,
				this._StdCode,
				this._StdName,
				this._SPName,
				this._GRName,
				this._DeptID,
				this._ClassName,
				this._AllNeed,
				this._AllGet,
				this._CXSource,
				this._BadSource,
				this._LostNum,
				this._MainAvg,
				this._ByState,
				this._State,
				this._MainAvg2};
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
			public readonly static Field All = new Field("*","vw_StuSourceStruct");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SSID = new Field("SSID","vw_StuSourceStruct","SSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("stdid","vw_StuSourceStruct","stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_StuSourceStruct","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","vw_StuSourceStruct","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSortCode = new Field("CSortCode","vw_StuSourceStruct","CSortCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Csort = new Field("Csort","vw_StuSourceStruct","Csort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GetSource = new Field("GetSource","vw_StuSourceStruct","GetSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NeedSource = new Field("NeedSource","vw_StuSourceStruct","NeedSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LastCalDate = new Field("LastCalDate","vw_StuSourceStruct","LastCalDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_StuSourceStruct","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","vw_StuSourceStruct","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPName = new Field("SPName","vw_StuSourceStruct","SPName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_StuSourceStruct","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","vw_StuSourceStruct","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassName = new Field("ClassName","vw_StuSourceStruct","ClassName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AllNeed = new Field("AllNeed","vw_StuSourceStruct","AllNeed");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AllGet = new Field("AllGet","vw_StuSourceStruct","AllGet");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CXSource = new Field("CXSource","vw_StuSourceStruct","CXSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BadSource = new Field("BadSource","vw_StuSourceStruct","BadSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LostNum = new Field("LostNum","vw_StuSourceStruct","LostNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MainAvg = new Field("MainAvg","vw_StuSourceStruct","MainAvg");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ByState = new Field("byState","vw_StuSourceStruct","byState");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","vw_StuSourceStruct","state");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MainAvg2 = new Field("MainAvg2","vw_StuSourceStruct","MainAvg2");
		}
		#endregion


	}
}

