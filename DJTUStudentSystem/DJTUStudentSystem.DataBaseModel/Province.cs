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
	/// 实体类Province 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Province")]
	[Serializable]
	public partial class Province : Entity 
	{
		#region Model
		private int _ID;
		private string _ProvinceName;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID,_ID,value);
				this._ID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProvinceName
		{
			get{ return _ProvinceName; }
			set
			{
				this.OnPropertyValueChange(_.ProvinceName,_ProvinceName,value);
				this._ProvinceName=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.ID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.ID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ID,
				_.ProvinceName};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._ProvinceName};
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
			public readonly static Field All = new Field("*","Province");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID","Province","ID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ProvinceName = new Field("ProvinceName","Province","ProvinceName");
		}
		#endregion


	}
}

