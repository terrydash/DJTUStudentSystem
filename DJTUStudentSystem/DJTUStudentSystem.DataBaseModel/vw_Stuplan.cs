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
	/// 实体类Vw_Stuplan 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Stuplan")]
	[Serializable]
	public partial class Vw_Stuplan : Entity 
	{
		#region Model
		private string _StdCode;
		private string _StdName;
		private string _ATName;
		private int? _YearName;
		private string _CCode;
		private string _CCname;
		private decimal? _Source;
		private decimal? _Period;
		private int? _Prelect;
		private int? _Experiment;
		private int? _OnComputer;
		private string _Csort;
		private int _STPID;
		private int? _Stdid;
		private int? _Atyid;
		private int? _SPID;
		private int? _CCID;
		private string _Importance;
		private string _ExamSort;
		private string _IfCheck;
		private string _IfCheckby;
		private string _Cunit;
		private int? _TMID;
		private string _CSortCode;
		private decimal? _Other;
		private string _GRName;
		private int? _GRID;
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
		public int? YearName
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
		public decimal? Source
		{
			get{ return _Source; }
			set
			{
				this.OnPropertyValueChange(_.Source,_Source,value);
				this._Source=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Period
		{
			get{ return _Period; }
			set
			{
				this.OnPropertyValueChange(_.Period,_Period,value);
				this._Period=value;
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
		/// <summary>
		/// 
		/// </summary>
		public int? Experiment
		{
			get{ return _Experiment; }
			set
			{
				this.OnPropertyValueChange(_.Experiment,_Experiment,value);
				this._Experiment=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OnComputer
		{
			get{ return _OnComputer; }
			set
			{
				this.OnPropertyValueChange(_.OnComputer,_OnComputer,value);
				this._OnComputer=value;
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
		public int STPID
		{
			get{ return _STPID; }
			set
			{
				this.OnPropertyValueChange(_.STPID,_STPID,value);
				this._STPID=value;
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
		public string Importance
		{
			get{ return _Importance; }
			set
			{
				this.OnPropertyValueChange(_.Importance,_Importance,value);
				this._Importance=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExamSort
		{
			get{ return _ExamSort; }
			set
			{
				this.OnPropertyValueChange(_.ExamSort,_ExamSort,value);
				this._ExamSort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IfCheck
		{
			get{ return _IfCheck; }
			set
			{
				this.OnPropertyValueChange(_.IfCheck,_IfCheck,value);
				this._IfCheck=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IfCheckby
		{
			get{ return _IfCheckby; }
			set
			{
				this.OnPropertyValueChange(_.IfCheckby,_IfCheckby,value);
				this._IfCheckby=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Cunit
		{
			get{ return _Cunit; }
			set
			{
				this.OnPropertyValueChange(_.Cunit,_Cunit,value);
				this._Cunit=value;
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
		public decimal? Other
		{
			get{ return _Other; }
			set
			{
				this.OnPropertyValueChange(_.Other,_Other,value);
				this._Other=value;
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
		public int? GRID
		{
			get{ return _GRID; }
			set
			{
				this.OnPropertyValueChange(_.GRID,_GRID,value);
				this._GRID=value;
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
				_.StdCode,
				_.StdName,
				_.ATName,
				_.YearName,
				_.CCode,
				_.CCname,
				_.Source,
				_.Period,
				_.Prelect,
				_.Experiment,
				_.OnComputer,
				_.Csort,
				_.STPID,
				_.Stdid,
				_.Atyid,
				_.SPID,
				_.CCID,
				_.Importance,
				_.ExamSort,
				_.IfCheck,
				_.IfCheckby,
				_.Cunit,
				_.TMID,
				_.CSortCode,
				_.Other,
				_.GRName,
				_.GRID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._StdCode,
				this._StdName,
				this._ATName,
				this._YearName,
				this._CCode,
				this._CCname,
				this._Source,
				this._Period,
				this._Prelect,
				this._Experiment,
				this._OnComputer,
				this._Csort,
				this._STPID,
				this._Stdid,
				this._Atyid,
				this._SPID,
				this._CCID,
				this._Importance,
				this._ExamSort,
				this._IfCheck,
				this._IfCheckby,
				this._Cunit,
				this._TMID,
				this._CSortCode,
				this._Other,
				this._GRName,
				this._GRID};
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
			public readonly static Field All = new Field("*","vw_Stuplan");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_Stuplan","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","vw_Stuplan","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATName = new Field("ATName","vw_Stuplan","ATName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field YearName = new Field("YearName","vw_Stuplan","YearName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_Stuplan","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_Stuplan","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Source = new Field("Source","vw_Stuplan","Source");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Period = new Field("Period","vw_Stuplan","Period");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Prelect = new Field("Prelect","vw_Stuplan","Prelect");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Experiment = new Field("Experiment","vw_Stuplan","Experiment");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OnComputer = new Field("OnComputer","vw_Stuplan","OnComputer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Csort = new Field("Csort","vw_Stuplan","Csort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STPID = new Field("STPID","vw_Stuplan","STPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("stdid","vw_Stuplan","stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("atyid","vw_Stuplan","atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_Stuplan","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_Stuplan","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Importance = new Field("Importance","vw_Stuplan","Importance");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExamSort = new Field("ExamSort","vw_Stuplan","ExamSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IfCheck = new Field("ifCheck","vw_Stuplan","ifCheck");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IfCheckby = new Field("ifCheckby","vw_Stuplan","ifCheckby");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Cunit = new Field("Cunit","vw_Stuplan","Cunit");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TMID = new Field("TMID","vw_Stuplan","TMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSortCode = new Field("CSortCode","vw_Stuplan","CSortCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Other = new Field("Other","vw_Stuplan","Other");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_Stuplan","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","vw_Stuplan","GRID");
		}
		#endregion


	}
}
