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
	/// 实体类ThesisQuestion 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ThesisQuestion")]
	[Serializable]
	public partial class ThesisQuestion : Entity 
	{
		#region Model
		private int _STQID;
		private int? _StuID;
		private int? _Thid;
		private string _Questions;
		private string _TeaAnswer;
		private DateTime? _Mdate;
		/// <summary>
		/// 
		/// </summary>
		public int STQID
		{
			get{ return _STQID; }
			set
			{
				this.OnPropertyValueChange(_.STQID,_STQID,value);
				this._STQID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StuID
		{
			get{ return _StuID; }
			set
			{
				this.OnPropertyValueChange(_.StuID,_StuID,value);
				this._StuID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Thid
		{
			get{ return _Thid; }
			set
			{
				this.OnPropertyValueChange(_.Thid,_Thid,value);
				this._Thid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Questions
		{
			get{ return _Questions; }
			set
			{
				this.OnPropertyValueChange(_.Questions,_Questions,value);
				this._Questions=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TeaAnswer
		{
			get{ return _TeaAnswer; }
			set
			{
				this.OnPropertyValueChange(_.TeaAnswer,_TeaAnswer,value);
				this._TeaAnswer=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Mdate
		{
			get{ return _Mdate; }
			set
			{
				this.OnPropertyValueChange(_.Mdate,_Mdate,value);
				this._Mdate=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.STQID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.STQID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.STQID,
				_.StuID,
				_.Thid,
				_.Questions,
				_.TeaAnswer,
				_.Mdate};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._STQID,
				this._StuID,
				this._Thid,
				this._Questions,
				this._TeaAnswer,
				this._Mdate};
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
			public readonly static Field All = new Field("*","ThesisQuestion");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STQID = new Field("STQID","ThesisQuestion","STQID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StuID = new Field("StuID","ThesisQuestion","StuID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Thid = new Field("thid","ThesisQuestion","thid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Questions = new Field("Questions","ThesisQuestion","Questions");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TeaAnswer = new Field("TeaAnswer","ThesisQuestion","TeaAnswer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Mdate = new Field("Mdate","ThesisQuestion","Mdate");
		}
		#endregion


	}
}

