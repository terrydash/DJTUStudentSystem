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
	/// 实体类Vw_Engage_Curricla_List 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Engage_Curricla_List")]
	[Serializable]
	public partial class Vw_Engage_Curricla_List : Entity 
	{
		#region Model
		private string _课程名称;
		private int? _SPID;
		private int? _ActYear;
		private int? _GRDID;
		private int? _EPID;
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
		public int? ActYear
		{
			get{ return _ActYear; }
			set
			{
				this.OnPropertyValueChange(_.ActYear,_ActYear,value);
				this._ActYear=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GRDID
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
		public int? EPID
		{
			get{ return _EPID; }
			set
			{
				this.OnPropertyValueChange(_.EPID,_EPID,value);
				this._EPID=value;
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
				_.课程名称,
				_.SPID,
				_.ActYear,
				_.GRDID,
				_.EPID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._课程名称,
				this._SPID,
				this._ActYear,
				this._GRDID,
				this._EPID};
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
			public readonly static Field All = new Field("*","vw_Engage_Curricla_List");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 课程名称 = new Field("课程名称","vw_Engage_Curricla_List","课程名称");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_Engage_Curricla_List","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ActYear = new Field("ActYear","vw_Engage_Curricla_List","ActYear");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRDID = new Field("GRDID","vw_Engage_Curricla_List","GRDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPID = new Field("EPID","vw_Engage_Curricla_List","EPID");
		}
		#endregion


	}
}

