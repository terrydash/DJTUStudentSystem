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
	/// 实体类AppendCC 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("AppendCC")]
	[Serializable]
	public partial class AppendCC : Entity 
	{
		#region Model
		private int _APID;
		private int? _ATYID;
		private int? _GRID;
		private string _GRName;
		private int? _CCID;
		private string _Memo;
		/// <summary>
		/// 
		/// </summary>
		public int APID
		{
			get{ return _APID; }
			set
			{
				this.OnPropertyValueChange(_.APID,_APID,value);
				this._APID=value;
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
		public int? GRID
		{
			get{ return _GRID; }
			set
			{
				this.OnPropertyValueChange(_.GRID,_GRID,value);
				this._GRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GRName
		{
			get{ return _GRName; }
			set
			{
				this.OnPropertyValueChange(_.GRName,_GRName,value);
				this._GRName=value;
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
		public string Memo
		{
			get{ return _Memo; }
			set
			{
				this.OnPropertyValueChange(_.Memo,_Memo,value);
				this._Memo=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.APID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.APID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.APID,
				_.ATYID,
				_.GRID,
				_.GRName,
				_.CCID,
				_.Memo};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._APID,
				this._ATYID,
				this._GRID,
				this._GRName,
				this._CCID,
				this._Memo};
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
			public readonly static Field All = new Field("*","AppendCC");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APID = new Field("APID","AppendCC","APID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATYID = new Field("ATYID","AppendCC","ATYID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","AppendCC","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","AppendCC","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","AppendCC","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","AppendCC","Memo");
		}
		#endregion


	}
}
