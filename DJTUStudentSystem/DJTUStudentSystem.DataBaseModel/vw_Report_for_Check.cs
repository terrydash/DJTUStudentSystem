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
	/// 实体类Vw_Report_for_Check 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Report_for_Check")]
	[Serializable]
	public partial class Vw_Report_for_Check : Entity 
	{
		#region Model
		private int _SPID;
		private int _GRDID;
		private string _CSort;
		private string _学号;
		private string _学生姓名;
		private string _课程名称;
		private string _成绩;
		private decimal? _TruePoint;
		private int _CCID;
		private int? _Stdid;
		private string _IFCheck;
		/// <summary>
		/// 
		/// </summary>
		public int SPID
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
		public int GRDID
		{
			get{ return _GRDID; }
			set
			{
				this.OnPropertyValueChange(_.GRDID,_GRDID,value);
				this._GRDID=value;
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
		public string 学号
		{
			get{ return _学号; }
			set
			{
				this.OnPropertyValueChange(_.学号,_学号,value);
				this._学号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学生姓名
		{
			get{ return _学生姓名; }
			set
			{
				this.OnPropertyValueChange(_.学生姓名,_学生姓名,value);
				this._学生姓名=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 课程名称
		{
			get{ return _课程名称; }
			set
			{
				this.OnPropertyValueChange(_.课程名称,_课程名称,value);
				this._课程名称=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 成绩
		{
			get{ return _成绩; }
			set
			{
				this.OnPropertyValueChange(_.成绩,_成绩,value);
				this._成绩=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TruePoint
		{
			get{ return _TruePoint; }
			set
			{
				this.OnPropertyValueChange(_.TruePoint,_TruePoint,value);
				this._TruePoint=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CCID
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
		public string IFCheck
		{
			get{ return _IFCheck; }
			set
			{
				this.OnPropertyValueChange(_.IFCheck,_IFCheck,value);
				this._IFCheck=value;
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
				_.SPID,
				_.GRDID,
				_.CSort,
				_.学号,
				_.学生姓名,
				_.课程名称,
				_.成绩,
				_.TruePoint,
				_.CCID,
				_.Stdid,
				_.IFCheck};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SPID,
				this._GRDID,
				this._CSort,
				this._学号,
				this._学生姓名,
				this._课程名称,
				this._成绩,
				this._TruePoint,
				this._CCID,
				this._Stdid,
				this._IFCheck};
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
			public readonly static Field All = new Field("*","vw_Report_for_Check");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_Report_for_Check","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRDID = new Field("GRDID","vw_Report_for_Check","GRDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSort = new Field("CSort","vw_Report_for_Check","CSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学号 = new Field("学号","vw_Report_for_Check","学号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学生姓名 = new Field("学生姓名","vw_Report_for_Check","学生姓名");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 课程名称 = new Field("课程名称","vw_Report_for_Check","课程名称");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 成绩 = new Field("成绩","vw_Report_for_Check","成绩");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TruePoint = new Field("TruePoint","vw_Report_for_Check","TruePoint");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_Report_for_Check","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("Stdid","vw_Report_for_Check","Stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IFCheck = new Field("IFCheck","vw_Report_for_Check","IFCheck");
		}
		#endregion


	}
}

