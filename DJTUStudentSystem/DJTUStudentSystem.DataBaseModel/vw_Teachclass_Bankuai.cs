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
	/// 实体类Vw_Teachclass_Bankuai 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Teachclass_Bankuai")]
	[Serializable]
	public partial class Vw_Teachclass_Bankuai : Entity 
	{
		#region Model
		private string _PsName;
		private string _StandCode;
		private string _BKName;
		private int _TCID;
		private string _TCName;
		private int? _ActYear;
		private int? _KBID;
		private int? _CCID;
		/// <summary>
		/// 
		/// </summary>
		public string PsName
		{
			get{ return _PsName; }
			set
			{
				this.OnPropertyValueChange(_.PsName,_PsName,value);
				this._PsName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StandCode
		{
			get{ return _StandCode; }
			set
			{
				this.OnPropertyValueChange(_.StandCode,_StandCode,value);
				this._StandCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BKName
		{
			get{ return _BKName; }
			set
			{
				this.OnPropertyValueChange(_.BKName,_BKName,value);
				this._BKName=value;
			}
		}
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
		public string TCName
		{
			get{ return _TCName; }
			set
			{
				this.OnPropertyValueChange(_.TCName,_TCName,value);
				this._TCName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ActYear
		{
			get{ return _ActYear; }
			set
			{
				this.OnPropertyValueChange(_.ActYear,_ActYear,value);
				this._ActYear=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? KBID
		{
			get{ return _KBID; }
			set
			{
				this.OnPropertyValueChange(_.KBID,_KBID,value);
				this._KBID=value;
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
				_.PsName,
				_.StandCode,
				_.BKName,
				_.TCID,
				_.TCName,
				_.ActYear,
				_.KBID,
				_.CCID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._PsName,
				this._StandCode,
				this._BKName,
				this._TCID,
				this._TCName,
				this._ActYear,
				this._KBID,
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
			public readonly static Field All = new Field("*","vw_Teachclass_Bankuai");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PsName = new Field("PsName","vw_Teachclass_Bankuai","PsName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StandCode = new Field("StandCode","vw_Teachclass_Bankuai","StandCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BKName = new Field("BKName","vw_Teachclass_Bankuai","BKName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","vw_Teachclass_Bankuai","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCName = new Field("TCName","vw_Teachclass_Bankuai","TCName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ActYear = new Field("ActYear","vw_Teachclass_Bankuai","ActYear");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KBID = new Field("KBID","vw_Teachclass_Bankuai","KBID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_Teachclass_Bankuai","CCID");
		}
		#endregion


	}
}
