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
	/// 实体类Vw_CheckDuplicatu_Code 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_CheckDuplicatu_Code")]
	[Serializable]
	public partial class Vw_CheckDuplicatu_Code : Entity 
	{
		#region Model
		private string _StdCode;
		private int? _AAA;
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
		public int? AAA
		{
			get{ return _AAA; }
			set
			{
				this.OnPropertyValueChange(_.AAA,_AAA,value);
				this._AAA=value;
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
				_.AAA};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._StdCode,
				this._AAA};
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
			public readonly static Field All = new Field("*","vw_CheckDuplicatu_Code");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_CheckDuplicatu_Code","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AAA = new Field("AAA","vw_CheckDuplicatu_Code","AAA");
		}
		#endregion


	}
}

