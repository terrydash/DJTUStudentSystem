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
	/// 实体类AskAndAnswer 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("AskAndAnswer")]
	[Serializable]
	public partial class AskAndAnswer : Entity 
	{
		#region Model
		private int _ASID;
		private int? _CCID;
		private string _AskTitle;
		private string _AskContent;
		private string _AnswContent;
		private string _StdID;
		private string _TchID;
		private DateTime? _ATime;
		/// <summary>
		/// 
		/// </summary>
		public int ASID
		{
			get{ return _ASID; }
			set
			{
				this.OnPropertyValueChange(_.ASID,_ASID,value);
				this._ASID=value;
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
		public string AskTitle
		{
			get{ return _AskTitle; }
			set
			{
				this.OnPropertyValueChange(_.AskTitle,_AskTitle,value);
				this._AskTitle=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AskContent
		{
			get{ return _AskContent; }
			set
			{
				this.OnPropertyValueChange(_.AskContent,_AskContent,value);
				this._AskContent=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AnswContent
		{
			get{ return _AnswContent; }
			set
			{
				this.OnPropertyValueChange(_.AnswContent,_AnswContent,value);
				this._AnswContent=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StdID
		{
			get{ return _StdID; }
			set
			{
				this.OnPropertyValueChange(_.StdID,_StdID,value);
				this._StdID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TchID
		{
			get{ return _TchID; }
			set
			{
				this.OnPropertyValueChange(_.TchID,_TchID,value);
				this._TchID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ATime
		{
			get{ return _ATime; }
			set
			{
				this.OnPropertyValueChange(_.ATime,_ATime,value);
				this._ATime=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.ASID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.ASID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ASID,
				_.CCID,
				_.AskTitle,
				_.AskContent,
				_.AnswContent,
				_.StdID,
				_.TchID,
				_.ATime};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ASID,
				this._CCID,
				this._AskTitle,
				this._AskContent,
				this._AnswContent,
				this._StdID,
				this._TchID,
				this._ATime};
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
			public readonly static Field All = new Field("*","AskAndAnswer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ASID = new Field("ASID","AskAndAnswer","ASID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","AskAndAnswer","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AskTitle = new Field("AskTitle","AskAndAnswer","AskTitle");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AskContent = new Field("AskContent","AskAndAnswer","AskContent");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AnswContent = new Field("AnswContent","AskAndAnswer","AnswContent");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdID = new Field("StdID","AskAndAnswer","StdID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TchID = new Field("TchID","AskAndAnswer","TchID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATime = new Field("ATime","AskAndAnswer","ATime");
		}
		#endregion


	}
}

