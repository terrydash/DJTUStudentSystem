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
	/// 实体类Vw_EduPlan_Teachclass 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_EduPlan_Teachclass")]
	[Serializable]
	public partial class Vw_EduPlan_Teachclass : Entity 
	{
		#region Model
		private int? _EMID;
		private int? _TermID;
		private int _CCID;
		/// <summary>
		/// 
		/// </summary>
		public int? EMID
		{
			get{ return _EMID; }
			set
			{
				this.OnPropertyValueChange(_.EMID,_EMID,value);
				this._EMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TermID
		{
			get{ return _TermID; }
			set
			{
				this.OnPropertyValueChange(_.TermID,_TermID,value);
				this._TermID=value;
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
				_.EMID,
				_.TermID,
				_.CCID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EMID,
				this._TermID,
				this._CCID};
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
			public readonly static Field All = new Field("*","vw_EduPlan_Teachclass");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","vw_EduPlan_Teachclass","EMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TermID = new Field("TermID","vw_EduPlan_Teachclass","TermID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_EduPlan_Teachclass","CCID");
		}
		#endregion


	}
}
