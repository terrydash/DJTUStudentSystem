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
	/// 实体类Vw_ExpPlanTeacher 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_ExpPlanTeacher")]
	[Serializable]
	public partial class Vw_ExpPlanTeacher : Entity 
	{
		#region Model
		private int _EPTID;
		private int? _EDID;
		private int? _PSID;
		private string _StandCode;
		private string _PsName;
		/// <summary>
		/// 
		/// </summary>
		public int EPTID
		{
			get{ return _EPTID; }
			set
			{
				this.OnPropertyValueChange(_.EPTID,_EPTID,value);
				this._EPTID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EDID
		{
			get{ return _EDID; }
			set
			{
				this.OnPropertyValueChange(_.EDID,_EDID,value);
				this._EDID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PSID
		{
			get{ return _PSID; }
			set
			{
				this.OnPropertyValueChange(_.PSID,_PSID,value);
				this._PSID=value;
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
		public string PsName
		{
			get{ return _PsName; }
			set
			{
				this.OnPropertyValueChange(_.PsName,_PsName,value);
				this._PsName=value;
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
				_.EPTID,
				_.EDID,
				_.PSID,
				_.StandCode,
				_.PsName};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EPTID,
				this._EDID,
				this._PSID,
				this._StandCode,
				this._PsName};
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
			public readonly static Field All = new Field("*","vw_ExpPlanTeacher");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPTID = new Field("EPTID","vw_ExpPlanTeacher","EPTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EDID = new Field("EDID","vw_ExpPlanTeacher","EDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","vw_ExpPlanTeacher","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StandCode = new Field("StandCode","vw_ExpPlanTeacher","StandCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PsName = new Field("PsName","vw_ExpPlanTeacher","PsName");
		}
		#endregion


	}
}

