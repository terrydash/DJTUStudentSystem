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
	/// 实体类Vw_Sp_StuNum 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Sp_StuNum")]
	[Serializable]
	public partial class Vw_Sp_StuNum : Entity 
	{
		#region Model
		private int? _Stunum;
		private int? _GradeID;
		private int? _SPID;
		private int? _RGID;
		/// <summary>
		/// 
		/// </summary>
		public int? Stunum
		{
			get{ return _Stunum; }
			set
			{
				this.OnPropertyValueChange(_.Stunum,_Stunum,value);
				this._Stunum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GradeID
		{
			get{ return _GradeID; }
			set
			{
				this.OnPropertyValueChange(_.GradeID,_GradeID,value);
				this._GradeID=value;
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
		public int? RGID
		{
			get{ return _RGID; }
			set
			{
				this.OnPropertyValueChange(_.RGID,_RGID,value);
				this._RGID=value;
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
				_.Stunum,
				_.GradeID,
				_.SPID,
				_.RGID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Stunum,
				this._GradeID,
				this._SPID,
				this._RGID};
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
			public readonly static Field All = new Field("*","vw_Sp_StuNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stunum = new Field("Stunum","vw_Sp_StuNum","Stunum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GradeID = new Field("GradeID","vw_Sp_StuNum","GradeID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_Sp_StuNum","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGID = new Field("RGID","vw_Sp_StuNum","RGID");
		}
		#endregion


	}
}

