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
	/// 实体类Equivalent 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Equivalent")]
	[Serializable]
	public partial class Equivalent : Entity 
	{
		#region Model
		private int _EQID;
		private int? _GRID;
		private int? _CCID;
		private int? _CCIDA;
		/// <summary>
		/// 
		/// </summary>
		public int EQID
		{
			get{ return _EQID; }
			set
			{
				this.OnPropertyValueChange(_.EQID,_EQID,value);
				this._EQID=value;
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
		public int? CCIDA
		{
			get{ return _CCIDA; }
			set
			{
				this.OnPropertyValueChange(_.CCIDA,_CCIDA,value);
				this._CCIDA=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.EQID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.EQID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.EQID,
				_.GRID,
				_.CCID,
				_.CCIDA};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EQID,
				this._GRID,
				this._CCID,
				this._CCIDA};
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
			public readonly static Field All = new Field("*","Equivalent");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EQID = new Field("EQID","Equivalent","EQID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","Equivalent","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","Equivalent","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCIDA = new Field("CCIDA","Equivalent","CCIDA");
		}
		#endregion


	}
}

