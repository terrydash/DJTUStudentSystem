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
	/// 实体类Section 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Section")]
	[Serializable]
	public partial class Section : Entity 
	{
		#region Model
		private int _STID;
		private int? _Period;
		private int? _FAXH;
		private int? _DayOfWeek;
		private string _SectionTH;
		private int? _Used;
		private int? _Start;
		/// <summary>
		/// 
		/// </summary>
		public int STID
		{
			get{ return _STID; }
			set
			{
				this.OnPropertyValueChange(_.STID,_STID,value);
				this._STID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Period
		{
			get{ return _Period; }
			set
			{
				this.OnPropertyValueChange(_.Period,_Period,value);
				this._Period=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FAXH
		{
			get{ return _FAXH; }
			set
			{
				this.OnPropertyValueChange(_.FAXH,_FAXH,value);
				this._FAXH=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DayOfWeek
		{
			get{ return _DayOfWeek; }
			set
			{
				this.OnPropertyValueChange(_.DayOfWeek,_DayOfWeek,value);
				this._DayOfWeek=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SectionTH
		{
			get{ return _SectionTH; }
			set
			{
				this.OnPropertyValueChange(_.SectionTH,_SectionTH,value);
				this._SectionTH=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Used
		{
			get{ return _Used; }
			set
			{
				this.OnPropertyValueChange(_.Used,_Used,value);
				this._Used=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Start
		{
			get{ return _Start; }
			set
			{
				this.OnPropertyValueChange(_.Start,_Start,value);
				this._Start=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.STID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.STID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.STID,
				_.Period,
				_.FAXH,
				_.DayOfWeek,
				_.SectionTH,
				_.Used,
				_.Start};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._STID,
				this._Period,
				this._FAXH,
				this._DayOfWeek,
				this._SectionTH,
				this._Used,
				this._Start};
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
			public readonly static Field All = new Field("*","Section");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STID = new Field("STID","Section","STID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Period = new Field("Period","Section","Period");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAXH = new Field("FAXH","Section","FAXH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DayOfWeek = new Field("DayOfWeek","Section","DayOfWeek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SectionTH = new Field("SectionTH","Section","SectionTH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Used = new Field("Used","Section","Used");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Start = new Field("Start","Section","Start");
		}
		#endregion


	}
}

