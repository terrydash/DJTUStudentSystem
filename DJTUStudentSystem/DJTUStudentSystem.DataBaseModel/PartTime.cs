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
	/// 实体类PartTime 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("PartTime")]
	[Serializable]
	public partial class PartTime : Entity 
	{
		#region Model
		private int _PTID;
		private string _PartTime;
		private int? _Sorce;
		/// <summary>
		/// 
		/// </summary>
		public int PTID
		{
			get{ return _PTID; }
			set
			{
				this.OnPropertyValueChange(_.PTID,_PTID,value);
				this._PTID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PartTime1
		{
			get{ return _PartTime; }
			set
			{
				this.OnPropertyValueChange(_.PartTime,_PartTime,value);
				this._PartTime=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Sorce
		{
			get{ return _Sorce; }
			set
			{
				this.OnPropertyValueChange(_.Sorce,_Sorce,value);
				this._Sorce=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.PTID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.PTID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.PTID,
				_.PartTime,
				_.Sorce};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._PTID,
				this._PartTime,
				this._Sorce};
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
			public readonly static Field All = new Field("*","PartTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PTID = new Field("PTID","PartTime","PTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PartTime = new Field("PartTime","PartTime","PartTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sorce = new Field("Sorce","PartTime","Sorce");
		}
		#endregion


	}
}
