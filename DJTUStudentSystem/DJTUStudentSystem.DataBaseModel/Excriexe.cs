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
	/// 实体类Excriexe 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Excriexe")]
	[Serializable]
	public partial class Excriexe : Entity 
	{
		#region Model
		private int _ExID;
		private int? _CCID;
		private string _ChNo;
		private string _Title;
		/// <summary>
		/// 
		/// </summary>
		public int ExID
		{
			get{ return _ExID; }
			set
			{
				this.OnPropertyValueChange(_.ExID,_ExID,value);
				this._ExID=value;
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
		/// <summary>
		/// 
		/// </summary>
		public string ChNo
		{
			get{ return _ChNo; }
			set
			{
				this.OnPropertyValueChange(_.ChNo,_ChNo,value);
				this._ChNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			get{ return _Title; }
			set
			{
				this.OnPropertyValueChange(_.Title,_Title,value);
				this._Title=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ExID,
				_.CCID,
				_.ChNo,
				_.Title};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ExID,
				this._CCID,
				this._ChNo,
				this._Title};
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
			public readonly static Field All = new Field("*","Excriexe");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExID = new Field("ExID","Excriexe","ExID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","Excriexe","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChNo = new Field("ChNo","Excriexe","ChNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Title = new Field("Title","Excriexe","Title");
		}
		#endregion


	}
}

