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
	/// 实体类Vw_UserList 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_UserList")]
	[Serializable]
	public partial class Vw_UserList : Entity 
	{
		#region Model
		private string _UserName;
		private string _Account;
		private string _PassWord;
		private int? _Role;
		private string _RoleName;
		private string _Question;
		private DateTime? _LastDate;
		private string _Oper;
		private int _ID;
		private int? _RID;
		private string _DeptName;
		private string _Sort;
		private string _DeptCode;
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			get{ return _UserName; }
			set
			{
				this.OnPropertyValueChange(_.UserName,_UserName,value);
				this._UserName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Account
		{
			get{ return _Account; }
			set
			{
				this.OnPropertyValueChange(_.Account,_Account,value);
				this._Account=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PassWord
		{
			get{ return _PassWord; }
			set
			{
				this.OnPropertyValueChange(_.PassWord,_PassWord,value);
				this._PassWord=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Role
		{
			get{ return _Role; }
			set
			{
				this.OnPropertyValueChange(_.Role,_Role,value);
				this._Role=value;
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
		/// <summary>
		/// 
		/// </summary>
		public string Question
		{
			get{ return _Question; }
			set
			{
				this.OnPropertyValueChange(_.Question,_Question,value);
				this._Question=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LastDate
		{
			get{ return _LastDate; }
			set
			{
				this.OnPropertyValueChange(_.LastDate,_LastDate,value);
				this._LastDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Oper
		{
			get{ return _Oper; }
			set
			{
				this.OnPropertyValueChange(_.Oper,_Oper,value);
				this._Oper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID,_ID,value);
				this._ID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RID
		{
			get{ return _RID; }
			set
			{
				this.OnPropertyValueChange(_.RID,_RID,value);
				this._RID=value;
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
		public string Sort
		{
			get{ return _Sort; }
			set
			{
				this.OnPropertyValueChange(_.Sort,_Sort,value);
				this._Sort=value;
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
				_.UserName,
				_.Account,
				_.PassWord,
				_.Role,
				_.RoleName,
				_.Question,
				_.LastDate,
				_.Oper,
				_.ID,
				_.RID,
				_.DeptName,
				_.Sort,
				_.DeptCode};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._UserName,
				this._Account,
				this._PassWord,
				this._Role,
				this._RoleName,
				this._Question,
				this._LastDate,
				this._Oper,
				this._ID,
				this._RID,
				this._DeptName,
				this._Sort,
				this._DeptCode};
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
			public readonly static Field All = new Field("*","vw_UserList");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserName = new Field("UserName","vw_UserList","UserName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Account = new Field("Account","vw_UserList","Account");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PassWord = new Field("PassWord","vw_UserList","PassWord");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Role = new Field("Role","vw_UserList","Role");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RoleName = new Field("RoleName","vw_UserList","RoleName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Question = new Field("Question","vw_UserList","Question");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LastDate = new Field("LastDate","vw_UserList","LastDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","vw_UserList","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID","vw_UserList","ID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RID = new Field("RID","vw_UserList","RID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName","vw_UserList","DeptName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","vw_UserList","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","vw_UserList","DeptCode");
		}
		#endregion


	}
}

