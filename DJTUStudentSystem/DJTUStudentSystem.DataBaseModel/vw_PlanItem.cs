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
	/// 实体类Vw_PlanItem 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_PlanItem")]
	[Serializable]
	public partial class Vw_PlanItem : Entity 
	{
		#region Model
		private int _PIID;
		private string _PSortName;
		private int? _APMID;
		private int? _ToRole;
		private string _APName;
		private string _RoleName;
		/// <summary>
		/// 
		/// </summary>
		public int PIID
		{
			get{ return _PIID; }
			set
			{
				this.OnPropertyValueChange(_.PIID,_PIID,value);
				this._PIID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PSortName
		{
			get{ return _PSortName; }
			set
			{
				this.OnPropertyValueChange(_.PSortName,_PSortName,value);
				this._PSortName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? APMID
		{
			get{ return _APMID; }
			set
			{
				this.OnPropertyValueChange(_.APMID,_APMID,value);
				this._APMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ToRole
		{
			get{ return _ToRole; }
			set
			{
				this.OnPropertyValueChange(_.ToRole,_ToRole,value);
				this._ToRole=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APName
		{
			get{ return _APName; }
			set
			{
				this.OnPropertyValueChange(_.APName,_APName,value);
				this._APName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleName
		{
			get{ return _RoleName; }
			set
			{
				this.OnPropertyValueChange(_.RoleName,_RoleName,value);
				this._RoleName=value;
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
				_.PIID,
				_.PSortName,
				_.APMID,
				_.ToRole,
				_.APName,
				_.RoleName};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._PIID,
				this._PSortName,
				this._APMID,
				this._ToRole,
				this._APName,
				this._RoleName};
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
			public readonly static Field All = new Field("*","vw_PlanItem");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PIID = new Field("PIID","vw_PlanItem","PIID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSortName = new Field("PSortName","vw_PlanItem","PSortName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APMID = new Field("APMID","vw_PlanItem","APMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ToRole = new Field("ToRole","vw_PlanItem","ToRole");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APName = new Field("APName","vw_PlanItem","APName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RoleName = new Field("RoleName","vw_PlanItem","RoleName");
		}
		#endregion


	}
}
