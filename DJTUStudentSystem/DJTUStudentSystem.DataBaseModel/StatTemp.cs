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
	/// 实体类StatTemp 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("StatTemp")]
	[Serializable]
	public partial class StatTemp : Entity 
	{
		#region Model
		private int _STIS;
		private int? _Atyid;
		private string _Classname;
		private float? _Examine;
		private int? _Tcid;
		private int? _Ccid;
		/// <summary>
		/// 
		/// </summary>
		public int STIS
		{
			get{ return _STIS; }
			set
			{
				this.OnPropertyValueChange(_.STIS,_STIS,value);
				this._STIS=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Atyid
		{
			get{ return _Atyid; }
			set
			{
				this.OnPropertyValueChange(_.Atyid,_Atyid,value);
				this._Atyid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Classname
		{
			get{ return _Classname; }
			set
			{
				this.OnPropertyValueChange(_.Classname,_Classname,value);
				this._Classname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public float? Examine
		{
			get{ return _Examine; }
			set
			{
				this.OnPropertyValueChange(_.Examine,_Examine,value);
				this._Examine=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Tcid
		{
			get{ return _Tcid; }
			set
			{
				this.OnPropertyValueChange(_.Tcid,_Tcid,value);
				this._Tcid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Ccid
		{
			get{ return _Ccid; }
			set
			{
				this.OnPropertyValueChange(_.Ccid,_Ccid,value);
				this._Ccid=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.STIS;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.STIS};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.STIS,
				_.Atyid,
				_.Classname,
				_.Examine,
				_.Tcid,
				_.Ccid};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._STIS,
				this._Atyid,
				this._Classname,
				this._Examine,
				this._Tcid,
				this._Ccid};
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
			public readonly static Field All = new Field("*","StatTemp");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STIS = new Field("STIS","StatTemp","STIS");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("atyid","StatTemp","atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Classname = new Field("classname","StatTemp","classname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Examine = new Field("examine","StatTemp","examine");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Tcid = new Field("tcid","StatTemp","tcid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Ccid = new Field("ccid","StatTemp","ccid");
		}
		#endregion


	}
}

