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
	/// 实体类TeachUser 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TeachUser")]
	[Serializable]
	public partial class TeachUser : Entity 
	{
		#region Model
		private int _TUID;
		private int? _TRoleID;
		private int? _PSID;
		private int? _CCID;
		/// <summary>
		/// 
		/// </summary>
		public int TUID
		{
			get{ return _TUID; }
			set
			{
				this.OnPropertyValueChange(_.TUID,_TUID,value);
				this._TUID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TRoleID
		{
			get{ return _TRoleID; }
			set
			{
				this.OnPropertyValueChange(_.TRoleID,_TRoleID,value);
				this._TRoleID=value;
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
		public int? CCID
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
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.TUID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.TUID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TUID,
				_.TRoleID,
				_.PSID,
				_.CCID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TUID,
				this._TRoleID,
				this._PSID,
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
			public readonly static Field All = new Field("*","TeachUser");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TUID = new Field("TUID","TeachUser","TUID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TRoleID = new Field("TRoleID","TeachUser","TRoleID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","TeachUser","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","TeachUser","CCID");
		}
		#endregion


	}
}

