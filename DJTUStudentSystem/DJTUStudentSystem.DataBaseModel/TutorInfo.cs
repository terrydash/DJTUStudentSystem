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
	/// 实体类TutorInfo 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TutorInfo")]
	[Serializable]
	public partial class TutorInfo : Entity 
	{
		#region Model
		private int _TIID;
		private int? _Stdid;
		private int? _Psid;
		private int? _Sortid;
		private string _Froms;
		private string _SayToAll;
		private string _UserName;
		private DateTime? _EDate;
		private string _Content;
		/// <summary>
		/// 
		/// </summary>
		public int TIID
		{
			get{ return _TIID; }
			set
			{
				this.OnPropertyValueChange(_.TIID,_TIID,value);
				this._TIID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Stdid
		{
			get{ return _Stdid; }
			set
			{
				this.OnPropertyValueChange(_.Stdid,_Stdid,value);
				this._Stdid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Psid
		{
			get{ return _Psid; }
			set
			{
				this.OnPropertyValueChange(_.Psid,_Psid,value);
				this._Psid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Sortid
		{
			get{ return _Sortid; }
			set
			{
				this.OnPropertyValueChange(_.Sortid,_Sortid,value);
				this._Sortid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Froms
		{
			get{ return _Froms; }
			set
			{
				this.OnPropertyValueChange(_.Froms,_Froms,value);
				this._Froms=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SayToAll
		{
			get{ return _SayToAll; }
			set
			{
				this.OnPropertyValueChange(_.SayToAll,_SayToAll,value);
				this._SayToAll=value;
			}
		}
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
		public DateTime? EDate
		{
			get{ return _EDate; }
			set
			{
				this.OnPropertyValueChange(_.EDate,_EDate,value);
				this._EDate=value;
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
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.TIID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.TIID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TIID,
				_.Stdid,
				_.Psid,
				_.Sortid,
				_.Froms,
				_.SayToAll,
				_.UserName,
				_.EDate,
				_.Content};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TIID,
				this._Stdid,
				this._Psid,
				this._Sortid,
				this._Froms,
				this._SayToAll,
				this._UserName,
				this._EDate,
				this._Content};
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
			public readonly static Field All = new Field("*","TutorInfo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TIID = new Field("TIID","TutorInfo","TIID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("stdid","TutorInfo","stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Psid = new Field("psid","TutorInfo","psid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sortid = new Field("sortid","TutorInfo","sortid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Froms = new Field("Froms","TutorInfo","Froms");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SayToAll = new Field("SayToAll","TutorInfo","SayToAll");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserName = new Field("UserName","TutorInfo","UserName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EDate = new Field("EDate","TutorInfo","EDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","TutorInfo","Content");
		}
		#endregion


	}
}

