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
	/// 实体类Vw_TeachClass_PKFAB 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_TeachClass_PKFAB")]
	[Serializable]
	public partial class Vw_TeachClass_PKFAB : Entity 
	{
		#region Model
		private int _TCID;
		private int? _TCHID;
		private string _StartB;
		private string _EndB;
		private int? _DayOfWeek;
		private string _SectionTH;
		/// <summary>
		/// 
		/// </summary>
		public int TCID
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
		public int? TCHID
		{
			get{ return _TCHID; }
			set
			{
				this.OnPropertyValueChange(_.TCHID,_TCHID,value);
				this._TCHID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartB
		{
			get{ return _StartB; }
			set
			{
				this.OnPropertyValueChange(_.StartB,_StartB,value);
				this._StartB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndB
		{
			get{ return _EndB; }
			set
			{
				this.OnPropertyValueChange(_.EndB,_EndB,value);
				this._EndB=value;
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
		#endregion

		#region Method
		/// <summary>
		/// 是否只读
		/// </summary>
		public override bool IsReadOnly()
		{
			return true;
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TCID,
				_.TCHID,
				_.StartB,
				_.EndB,
				_.DayOfWeek,
				_.SectionTH};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TCID,
				this._TCHID,
				this._StartB,
				this._EndB,
				this._DayOfWeek,
				this._SectionTH};
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
			public readonly static Field All = new Field("*","vw_TeachClass_PKFAB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","vw_TeachClass_PKFAB","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCHID = new Field("TCHID","vw_TeachClass_PKFAB","TCHID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartB = new Field("StartB","vw_TeachClass_PKFAB","StartB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EndB = new Field("EndB","vw_TeachClass_PKFAB","EndB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DayOfWeek = new Field("DayOfWeek","vw_TeachClass_PKFAB","DayOfWeek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SectionTH = new Field("SectionTH","vw_TeachClass_PKFAB","SectionTH");
		}
		#endregion


	}
}
