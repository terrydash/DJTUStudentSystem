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
	/// 实体类Vw_RolePower 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_RolePower")]
	[Serializable]
	public partial class Vw_RolePower : Entity 
	{
		#region Model
		private string _FunName;
		private int? _RoleID;
		private int? _FuncID;
		private int _UPID;
		private string _DeptName;
		private string _Deptlimit;
		private int? _MDID;
		/// <summary>
		/// 
		/// </summary>
		public string FunName
		{
			get{ return _FunName; }
			set
			{
				this.OnPropertyValueChange(_.FunName,_FunName,value);
				this._FunName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoleID
		{
			get{ return _RoleID; }
			set
			{
				this.OnPropertyValueChange(_.RoleID,_RoleID,value);
				this._RoleID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FuncID
		{
			get{ return _FuncID; }
			set
			{
				this.OnPropertyValueChange(_.FuncID,_FuncID,value);
				this._FuncID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UPID
		{
			get{ return _UPID; }
			set
			{
				this.OnPropertyValueChange(_.UPID,_UPID,value);
				this._UPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptName
		{
			get{ return _DeptName; }
			set
			{
				this.OnPropertyValueChange(_.DeptName,_DeptName,value);
				this._DeptName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Deptlimit
		{
			get{ return _Deptlimit; }
			set
			{
				this.OnPropertyValueChange(_.Deptlimit,_Deptlimit,value);
				this._Deptlimit=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MDID
		{
			get{ return _MDID; }
			set
			{
				this.OnPropertyValueChange(_.MDID,_MDID,value);
				this._MDID=value;
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
				_.FunName,
				_.RoleID,
				_.FuncID,
				_.UPID,
				_.DeptName,
				_.Deptlimit,
				_.MDID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._FunName,
				this._RoleID,
				this._FuncID,
				this._UPID,
				this._DeptName,
				this._Deptlimit,
				this._MDID};
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
			public readonly static Field All = new Field("*","vw_RolePower");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FunName = new Field("FunName","vw_RolePower","FunName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RoleID = new Field("RoleID","vw_RolePower","RoleID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FuncID = new Field("FuncID","vw_RolePower","FuncID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UPID = new Field("UPID","vw_RolePower","UPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName","vw_RolePower","DeptName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Deptlimit = new Field("Deptlimit","vw_RolePower","Deptlimit");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MDID = new Field("MDID","vw_RolePower","MDID");
		}
		#endregion


	}
}

