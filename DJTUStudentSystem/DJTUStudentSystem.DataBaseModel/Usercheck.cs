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
	/// 实体类Usercheck 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Usercheck")]
	[Serializable]
	public partial class Usercheck : Entity 
	{
		#region Model
		private int _UserID;
		private int? _CCID;
		private string _StdClass;
		private string _StdNo;
		private string _StdName;
		private string _ConDifficulty;
		private DateTime? _UseTime;
		/// <summary>
		/// 
		/// </summary>
		public int UserID
		{
			get{ return _UserID; }
			set
			{
				this.OnPropertyValueChange(_.UserID,_UserID,value);
				this._UserID=value;
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
		public string StdClass
		{
			get{ return _StdClass; }
			set
			{
				this.OnPropertyValueChange(_.StdClass,_StdClass,value);
				this._StdClass=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StdNo
		{
			get{ return _StdNo; }
			set
			{
				this.OnPropertyValueChange(_.StdNo,_StdNo,value);
				this._StdNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StdName
		{
			get{ return _StdName; }
			set
			{
				this.OnPropertyValueChange(_.StdName,_StdName,value);
				this._StdName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ConDifficulty
		{
			get{ return _ConDifficulty; }
			set
			{
				this.OnPropertyValueChange(_.ConDifficulty,_ConDifficulty,value);
				this._ConDifficulty=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UseTime
		{
			get{ return _UseTime; }
			set
			{
				this.OnPropertyValueChange(_.UseTime,_UseTime,value);
				this._UseTime=value;
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
				_.UserID,
				_.CCID,
				_.StdClass,
				_.StdNo,
				_.StdName,
				_.ConDifficulty,
				_.UseTime};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._UserID,
				this._CCID,
				this._StdClass,
				this._StdNo,
				this._StdName,
				this._ConDifficulty,
				this._UseTime};
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
			public readonly static Field All = new Field("*","Usercheck");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserID = new Field("UserID","Usercheck","UserID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","Usercheck","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdClass = new Field("StdClass","Usercheck","StdClass");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdNo = new Field("StdNo","Usercheck","StdNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","Usercheck","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ConDifficulty = new Field("ConDifficulty","Usercheck","ConDifficulty");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UseTime = new Field("UseTime","Usercheck","UseTime");
		}
		#endregion


	}
}
