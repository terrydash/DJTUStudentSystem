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
	/// 实体类ContManage 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ContManage")]
	[Serializable]
	public partial class ContManage : Entity 
	{
		#region Model
		private int _ContMaID;
		private int? _CCID;
		private string _ContMaName;
		private string _ContMapassword;
		/// <summary>
		/// 
		/// </summary>
		public int ContMaID
		{
			get{ return _ContMaID; }
			set
			{
				this.OnPropertyValueChange(_.ContMaID,_ContMaID,value);
				this._ContMaID=value;
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
		public string ContMaName
		{
			get{ return _ContMaName; }
			set
			{
				this.OnPropertyValueChange(_.ContMaName,_ContMaName,value);
				this._ContMaName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ContMapassword
		{
			get{ return _ContMapassword; }
			set
			{
				this.OnPropertyValueChange(_.ContMapassword,_ContMapassword,value);
				this._ContMapassword=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ContMaID,
				_.CCID,
				_.ContMaName,
				_.ContMapassword};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ContMaID,
				this._CCID,
				this._ContMaName,
				this._ContMapassword};
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
			public readonly static Field All = new Field("*","ContManage");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ContMaID = new Field("ContMaID","ContManage","ContMaID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","ContManage","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ContMaName = new Field("ContMaName","ContManage","ContMaName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ContMapassword = new Field("ContMapassword","ContManage","ContMapassword");
		}
		#endregion


	}
}

