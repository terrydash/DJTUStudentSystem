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
	/// 实体类Vw_ReportAccountSpecial 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_ReportAccountSpecial")]
	[Serializable]
	public partial class Vw_ReportAccountSpecial : Entity 
	{
		#region Model
		private int _RCID;
		private int? _Atyid;
		private string _PlanSort;
		private int? _CCID;
		private int? _GRID;
		private int? _AllNum;
		private int? _PassNum;
		private int? _BadNum;
		private decimal? _PassPer;
		private decimal? _BadPer;
		private string _ATName;
		private string _CCode;
		private string _CCname;
		private string _GRName;
		private string _CSort;
		private int? _SPID;
		private string _SPNo;
		private string _SPName;
		/// <summary>
		/// 
		/// </summary>
		public int RCID
		{
			get{ return _RCID; }
			set
			{
				this.OnPropertyValueChange(_.RCID,_RCID,value);
				this._RCID=value;
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
		public string PlanSort
		{
			get{ return _PlanSort; }
			set
			{
				this.OnPropertyValueChange(_.PlanSort,_PlanSort,value);
				this._PlanSort=value;
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
		public int? AllNum
		{
			get{ return _AllNum; }
			set
			{
				this.OnPropertyValueChange(_.AllNum,_AllNum,value);
				this._AllNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PassNum
		{
			get{ return _PassNum; }
			set
			{
				this.OnPropertyValueChange(_.PassNum,_PassNum,value);
				this._PassNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BadNum
		{
			get{ return _BadNum; }
			set
			{
				this.OnPropertyValueChange(_.BadNum,_BadNum,value);
				this._BadNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PassPer
		{
			get{ return _PassPer; }
			set
			{
				this.OnPropertyValueChange(_.PassPer,_PassPer,value);
				this._PassPer=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BadPer
		{
			get{ return _BadPer; }
			set
			{
				this.OnPropertyValueChange(_.BadPer,_BadPer,value);
				this._BadPer=value;
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
		public string CSort
		{
			get{ return _CSort; }
			set
			{
				this.OnPropertyValueChange(_.CSort,_CSort,value);
				this._CSort=value;
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
		public string SPNo
		{
			get{ return _SPNo; }
			set
			{
				this.OnPropertyValueChange(_.SPNo,_SPNo,value);
				this._SPNo=value;
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
				_.RCID,
				_.Atyid,
				_.PlanSort,
				_.CCID,
				_.GRID,
				_.AllNum,
				_.PassNum,
				_.BadNum,
				_.PassPer,
				_.BadPer,
				_.ATName,
				_.CCode,
				_.CCname,
				_.GRName,
				_.CSort,
				_.SPID,
				_.SPNo,
				_.SPName};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._RCID,
				this._Atyid,
				this._PlanSort,
				this._CCID,
				this._GRID,
				this._AllNum,
				this._PassNum,
				this._BadNum,
				this._PassPer,
				this._BadPer,
				this._ATName,
				this._CCode,
				this._CCname,
				this._GRName,
				this._CSort,
				this._SPID,
				this._SPNo,
				this._SPName};
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
			public readonly static Field All = new Field("*","vw_ReportAccountSpecial");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RCID = new Field("RCID","vw_ReportAccountSpecial","RCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("Atyid","vw_ReportAccountSpecial","Atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PlanSort = new Field("PlanSort","vw_ReportAccountSpecial","PlanSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_ReportAccountSpecial","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","vw_ReportAccountSpecial","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AllNum = new Field("AllNum","vw_ReportAccountSpecial","AllNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PassNum = new Field("PassNum","vw_ReportAccountSpecial","PassNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BadNum = new Field("BadNum","vw_ReportAccountSpecial","BadNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PassPer = new Field("PassPer","vw_ReportAccountSpecial","PassPer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BadPer = new Field("BadPer","vw_ReportAccountSpecial","BadPer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATName = new Field("ATName","vw_ReportAccountSpecial","ATName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_ReportAccountSpecial","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_ReportAccountSpecial","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_ReportAccountSpecial","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSort = new Field("CSort","vw_ReportAccountSpecial","CSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_ReportAccountSpecial","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPNo = new Field("SPNo","vw_ReportAccountSpecial","SPNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPName = new Field("SPName","vw_ReportAccountSpecial","SPName");
		}
		#endregion


	}
}

