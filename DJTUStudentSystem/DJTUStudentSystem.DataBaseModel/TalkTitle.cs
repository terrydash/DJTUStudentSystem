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
	/// 实体类TalkTitle 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TalkTitle")]
	[Serializable]
	public partial class TalkTitle : Entity 
	{
		#region Model
		private int _TTID;
		private string _TTCode;
		private string _TTname;
		private string _Memo;
		private string _Img;
		private string _Manager;
		private string _PWD;
		/// <summary>
		/// 
		/// </summary>
		public int TTID
		{
			get{ return _TTID; }
			set
			{
				this.OnPropertyValueChange(_.TTID,_TTID,value);
				this._TTID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TTCode
		{
			get{ return _TTCode; }
			set
			{
				this.OnPropertyValueChange(_.TTCode,_TTCode,value);
				this._TTCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TTname
		{
			get{ return _TTname; }
			set
			{
				this.OnPropertyValueChange(_.TTname,_TTname,value);
				this._TTname=value;
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
		public string Img
		{
			get{ return _Img; }
			set
			{
				this.OnPropertyValueChange(_.Img,_Img,value);
				this._Img=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Manager
		{
			get{ return _Manager; }
			set
			{
				this.OnPropertyValueChange(_.Manager,_Manager,value);
				this._Manager=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PWD
		{
			get{ return _PWD; }
			set
			{
				this.OnPropertyValueChange(_.PWD,_PWD,value);
				this._PWD=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.TTID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.TTID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TTID,
				_.TTCode,
				_.TTname,
				_.Memo,
				_.Img,
				_.Manager,
				_.PWD};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TTID,
				this._TTCode,
				this._TTname,
				this._Memo,
				this._Img,
				this._Manager,
				this._PWD};
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
			public readonly static Field All = new Field("*","TalkTitle");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TTID = new Field("TTID","TalkTitle","TTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TTCode = new Field("TTCode","TalkTitle","TTCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TTname = new Field("TTname","TalkTitle","TTname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","TalkTitle","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Img = new Field("img","TalkTitle","img");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Manager = new Field("Manager","TalkTitle","Manager");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PWD = new Field("PWD","TalkTitle","PWD");
		}
		#endregion


	}
}

