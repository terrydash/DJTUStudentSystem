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
	/// 实体类ImportantCont 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ImportantCont")]
	[Serializable]
	public partial class ImportantCont : Entity 
	{
		#region Model
		private int _CIMID;
		private int? _CHPID;
		private int? _IMDIID;
		private string _IMDegree;
		private int? _CCID;
		private string _CHPNO;
		/// <summary>
		/// 
		/// </summary>
		public int CIMID
		{
			get{ return _CIMID; }
			set
			{
				this.OnPropertyValueChange(_.CIMID,_CIMID,value);
				this._CIMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CHPID
		{
			get{ return _CHPID; }
			set
			{
				this.OnPropertyValueChange(_.CHPID,_CHPID,value);
				this._CHPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IMDIID
		{
			get{ return _IMDIID; }
			set
			{
				this.OnPropertyValueChange(_.IMDIID,_IMDIID,value);
				this._IMDIID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IMDegree
		{
			get{ return _IMDegree; }
			set
			{
				this.OnPropertyValueChange(_.IMDegree,_IMDegree,value);
				this._IMDegree=value;
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
		public string CHPNO
		{
			get{ return _CHPNO; }
			set
			{
				this.OnPropertyValueChange(_.CHPNO,_CHPNO,value);
				this._CHPNO=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.CIMID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.CIMID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.CIMID,
				_.CHPID,
				_.IMDIID,
				_.IMDegree,
				_.CCID,
				_.CHPNO};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CIMID,
				this._CHPID,
				this._IMDIID,
				this._IMDegree,
				this._CCID,
				this._CHPNO};
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
			public readonly static Field All = new Field("*","ImportantCont");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CIMID = new Field("CIMID","ImportantCont","CIMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CHPID = new Field("CHPID","ImportantCont","CHPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IMDIID = new Field("IMDIID","ImportantCont","IMDIID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IMDegree = new Field("IMDegree","ImportantCont","IMDegree");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","ImportantCont","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CHPNO = new Field("CHPNO","ImportantCont","CHPNO");
		}
		#endregion


	}
}

