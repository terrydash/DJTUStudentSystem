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
	/// 实体类VW_ExamRmListSetup 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("VW_ExamRmListSetup")]
	[Serializable]
	public partial class VW_ExamRmListSetup : Entity 
	{
		#region Model
		private int? _CLID;
		private int? _CCID;
		private int? _ATYID;
		private int _EMLID;
		private int? _F;
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
		public int? ATYID
		{
			get{ return _ATYID; }
			set
			{
				this.OnPropertyValueChange(_.ATYID,_ATYID,value);
				this._ATYID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int EMLID
		{
			get{ return _EMLID; }
			set
			{
				this.OnPropertyValueChange(_.EMLID,_EMLID,value);
				this._EMLID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? F
		{
			get{ return _F; }
			set
			{
				this.OnPropertyValueChange(_.F,_F,value);
				this._F=value;
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
				_.CLID,
				_.CCID,
				_.ATYID,
				_.EMLID,
				_.F};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CLID,
				this._CCID,
				this._ATYID,
				this._EMLID,
				this._F};
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
			public readonly static Field All = new Field("*","VW_ExamRmListSetup");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLID = new Field("CLID","VW_ExamRmListSetup","CLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","VW_ExamRmListSetup","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATYID = new Field("ATYID","VW_ExamRmListSetup","ATYID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMLID = new Field("EMLID","VW_ExamRmListSetup","EMLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field F = new Field("f","VW_ExamRmListSetup","f");
		}
		#endregion


	}
}

