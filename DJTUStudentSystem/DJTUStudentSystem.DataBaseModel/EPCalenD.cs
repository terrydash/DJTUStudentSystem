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
	/// 实体类EPCalenD 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("EPCalenD")]
	[Serializable]
	public partial class EPCalenD : Entity 
	{
		#region Model
		private int _EPDID;
		private int? _EPCID;
		private int? _TCID;
		private string _Expname;
		private string _ExpContent;
		private string _Equipment;
		private decimal? _ExpTime;
		/// <summary>
		/// 
		/// </summary>
		public int EPDID
		{
			get{ return _EPDID; }
			set
			{
				this.OnPropertyValueChange(_.EPDID,_EPDID,value);
				this._EPDID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EPCID
		{
			get{ return _EPCID; }
			set
			{
				this.OnPropertyValueChange(_.EPCID,_EPCID,value);
				this._EPCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TCID
		{
			get{ return _TCID; }
			set
			{
				this.OnPropertyValueChange(_.TCID,_TCID,value);
				this._TCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Expname
		{
			get{ return _Expname; }
			set
			{
				this.OnPropertyValueChange(_.Expname,_Expname,value);
				this._Expname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExpContent
		{
			get{ return _ExpContent; }
			set
			{
				this.OnPropertyValueChange(_.ExpContent,_ExpContent,value);
				this._ExpContent=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Equipment
		{
			get{ return _Equipment; }
			set
			{
				this.OnPropertyValueChange(_.Equipment,_Equipment,value);
				this._Equipment=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ExpTime
		{
			get{ return _ExpTime; }
			set
			{
				this.OnPropertyValueChange(_.ExpTime,_ExpTime,value);
				this._ExpTime=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.EPDID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.EPDID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.EPDID,
				_.EPCID,
				_.TCID,
				_.Expname,
				_.ExpContent,
				_.Equipment,
				_.ExpTime};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EPDID,
				this._EPCID,
				this._TCID,
				this._Expname,
				this._ExpContent,
				this._Equipment,
				this._ExpTime};
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
			public readonly static Field All = new Field("*","EPCalenD");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPDID = new Field("EPDID","EPCalenD","EPDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPCID = new Field("EPCID","EPCalenD","EPCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","EPCalenD","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Expname = new Field("Expname","EPCalenD","Expname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExpContent = new Field("ExpContent","EPCalenD","ExpContent");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Equipment = new Field("Equipment","EPCalenD","Equipment");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExpTime = new Field("ExpTime","EPCalenD","ExpTime");
		}
		#endregion


	}
}

