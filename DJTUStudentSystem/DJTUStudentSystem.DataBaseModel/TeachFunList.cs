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
	/// 实体类TeachFunList 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TeachFunList")]
	[Serializable]
	public partial class TeachFunList : Entity 
	{
		#region Model
		private int _TFunID;
		private string _TFunName;
		private string _Memo;
		/// <summary>
		/// 
		/// </summary>
		public int TFunID
		{
			get{ return _TFunID; }
			set
			{
				this.OnPropertyValueChange(_.TFunID,_TFunID,value);
				this._TFunID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TFunName
		{
			get{ return _TFunName; }
			set
			{
				this.OnPropertyValueChange(_.TFunName,_TFunName,value);
				this._TFunName=value;
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
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.TFunID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.TFunID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TFunID,
				_.TFunName,
				_.Memo};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TFunID,
				this._TFunName,
				this._Memo};
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
			public readonly static Field All = new Field("*","TeachFunList");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TFunID = new Field("TFunID","TeachFunList","TFunID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TFunName = new Field("TFunName","TeachFunList","TFunName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","TeachFunList","Memo");
		}
		#endregion


	}
}

