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
	/// 实体类TutorAndStu 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TutorAndStu")]
	[Serializable]
	public partial class TutorAndStu : Entity 
	{
		#region Model
		private int _TSID;
		private int? _PSID;
		private int? _STDID;
		/// <summary>
		/// 
		/// </summary>
		public int TSID
		{
			get{ return _TSID; }
			set
			{
				this.OnPropertyValueChange(_.TSID,_TSID,value);
				this._TSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PSID
		{
			get{ return _PSID; }
			set
			{
				this.OnPropertyValueChange(_.PSID,_PSID,value);
				this._PSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? STDID
		{
			get{ return _STDID; }
			set
			{
				this.OnPropertyValueChange(_.STDID,_STDID,value);
				this._STDID=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.TSID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.TSID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TSID,
				_.PSID,
				_.STDID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TSID,
				this._PSID,
				this._STDID};
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
			public readonly static Field All = new Field("*","TutorAndStu");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TSID = new Field("TSID","TutorAndStu","TSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","TutorAndStu","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STDID = new Field("STDID","TutorAndStu","STDID");
		}
		#endregion


	}
}

