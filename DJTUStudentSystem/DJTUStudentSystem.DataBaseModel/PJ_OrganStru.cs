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
	/// 实体类PJ_OrganStru 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("PJ_OrganStru")]
	[Serializable]
	public partial class PJ_OrganStru : Entity 
	{
		#region Model
		private int _UnitID;
		private string _Content;
		private string _UnitName;
		private string _UnitCode;
		private string _Orgname;
		private int? _OrgID;
		private string _Addr;
		private string _Tel;
		private string _Memo;
		private string _DeptCode;
		private int? _DeptID;
		private string _State;
		/// <summary>
		/// 
		/// </summary>
		public int UnitID
		{
			get{ return _UnitID; }
			set
			{
				this.OnPropertyValueChange(_.UnitID,_UnitID,value);
				this._UnitID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			get{ return _Content; }
			set
			{
				this.OnPropertyValueChange(_.Content,_Content,value);
				this._Content=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UnitName
		{
			get{ return _UnitName; }
			set
			{
				this.OnPropertyValueChange(_.UnitName,_UnitName,value);
				this._UnitName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UnitCode
		{
			get{ return _UnitCode; }
			set
			{
				this.OnPropertyValueChange(_.UnitCode,_UnitCode,value);
				this._UnitCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Orgname
		{
			get{ return _Orgname; }
			set
			{
				this.OnPropertyValueChange(_.Orgname,_Orgname,value);
				this._Orgname=value;
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
		public string Addr
		{
			get{ return _Addr; }
			set
			{
				this.OnPropertyValueChange(_.Addr,_Addr,value);
				this._Addr=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tel
		{
			get{ return _Tel; }
			set
			{
				this.OnPropertyValueChange(_.Tel,_Tel,value);
				this._Tel=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get{ return _Memo; }
			set
			{
				this.OnPropertyValueChange(_.Memo,_Memo,value);
				this._Memo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptCode
		{
			get{ return _DeptCode; }
			set
			{
				this.OnPropertyValueChange(_.DeptCode,_DeptCode,value);
				this._DeptCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DeptID
		{
			get{ return _DeptID; }
			set
			{
				this.OnPropertyValueChange(_.DeptID,_DeptID,value);
				this._DeptID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string State
		{
			get{ return _State; }
			set
			{
				this.OnPropertyValueChange(_.State,_State,value);
				this._State=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.UnitID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.UnitID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.UnitID,
				_.Content,
				_.UnitName,
				_.UnitCode,
				_.Orgname,
				_.OrgID,
				_.Addr,
				_.Tel,
				_.Memo,
				_.DeptCode,
				_.DeptID,
				_.State};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._UnitID,
				this._Content,
				this._UnitName,
				this._UnitCode,
				this._Orgname,
				this._OrgID,
				this._Addr,
				this._Tel,
				this._Memo,
				this._DeptCode,
				this._DeptID,
				this._State};
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
			public readonly static Field All = new Field("*","PJ_OrganStru");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UnitID = new Field("UnitID","PJ_OrganStru","UnitID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","PJ_OrganStru","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UnitName = new Field("UnitName","PJ_OrganStru","UnitName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UnitCode = new Field("UnitCode","PJ_OrganStru","UnitCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Orgname = new Field("Orgname","PJ_OrganStru","Orgname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OrgID = new Field("OrgID","PJ_OrganStru","OrgID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Addr = new Field("Addr","PJ_OrganStru","Addr");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Tel = new Field("Tel","PJ_OrganStru","Tel");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","PJ_OrganStru","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","PJ_OrganStru","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","PJ_OrganStru","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","PJ_OrganStru","state");
		}
		#endregion


	}
}

