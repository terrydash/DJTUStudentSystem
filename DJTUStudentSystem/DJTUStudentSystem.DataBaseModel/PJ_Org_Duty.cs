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
	/// 实体类PJ_Org_Duty 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("PJ_Org_Duty")]
	[Serializable]
	public partial class PJ_Org_Duty : Entity 
	{
		#region Model
		private int _PODID;
		private int? _OrgID;
		private string _DutyName;
		/// <summary>
		/// 
		/// </summary>
		public int PODID
		{
			get{ return _PODID; }
			set
			{
				this.OnPropertyValueChange(_.PODID,_PODID,value);
				this._PODID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OrgID
		{
			get{ return _OrgID; }
			set
			{
				this.OnPropertyValueChange(_.OrgID,_OrgID,value);
				this._OrgID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DutyName
		{
			get{ return _DutyName; }
			set
			{
				this.OnPropertyValueChange(_.DutyName,_DutyName,value);
				this._DutyName=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.PODID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.PODID,
				_.OrgID,
				_.DutyName};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._PODID,
				this._OrgID,
				this._DutyName};
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
			public readonly static Field All = new Field("*","PJ_Org_Duty");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PODID = new Field("PODID","PJ_Org_Duty","PODID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OrgID = new Field("OrgID","PJ_Org_Duty","OrgID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DutyName = new Field("DutyName","PJ_Org_Duty","DutyName");
		}
		#endregion


	}
}

