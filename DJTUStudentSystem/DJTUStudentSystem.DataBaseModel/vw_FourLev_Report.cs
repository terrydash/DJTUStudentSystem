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
	/// 实体类Vw_FourLev_Report 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_FourLev_Report")]
	[Serializable]
	public partial class Vw_FourLev_Report : Entity 
	{
		#region Model
		private string _成绩;
		private int? _Grid;
		private int? _SPID;
		private int? _Lev;
		private int? _StdID;
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
		public int? Grid
		{
			get{ return _Grid; }
			set
			{
				this.OnPropertyValueChange(_.Grid,_Grid,value);
				this._Grid=value;
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
		public int? Lev
		{
			get{ return _Lev; }
			set
			{
				this.OnPropertyValueChange(_.Lev,_Lev,value);
				this._Lev=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StdID
		{
			get{ return _StdID; }
			set
			{
				this.OnPropertyValueChange(_.StdID,_StdID,value);
				this._StdID=value;
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
				_.成绩,
				_.Grid,
				_.SPID,
				_.Lev,
				_.StdID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._成绩,
				this._Grid,
				this._SPID,
				this._Lev,
				this._StdID};
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
			public readonly static Field All = new Field("*","vw_FourLev_Report");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 成绩 = new Field("成绩","vw_FourLev_Report","成绩");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Grid = new Field("Grid","vw_FourLev_Report","Grid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_FourLev_Report","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Lev = new Field("Lev","vw_FourLev_Report","Lev");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdID = new Field("StdID","vw_FourLev_Report","StdID");
		}
		#endregion


	}
}

