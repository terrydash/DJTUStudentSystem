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
	/// 实体类TeachChat 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TeachChat")]
	[Serializable]
	public partial class TeachChat : Entity 
	{
		#region Model
		private int _CHID;
		private int? _TCID;
		private int? _CCID;
		private string _Stdname;
		private string _PSname;
		private string _Sort;
		private string _Content;
		private DateTime? _CDate;
		private int? _Givename;
		/// <summary>
		/// 
		/// </summary>
		public int CHID
		{
			get{ return _CHID; }
			set
			{
				this.OnPropertyValueChange(_.CHID,_CHID,value);
				this._CHID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TCID
		{
			get{ return _TCID; }
			set
			{
				this.OnPropertyValueChange(_.TCID,_TCID,value);
				this._TCID=value;
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
		public string Stdname
		{
			get{ return _Stdname; }
			set
			{
				this.OnPropertyValueChange(_.Stdname,_Stdname,value);
				this._Stdname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PSname
		{
			get{ return _PSname; }
			set
			{
				this.OnPropertyValueChange(_.PSname,_PSname,value);
				this._PSname=value;
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
		public DateTime? CDate
		{
			get{ return _CDate; }
			set
			{
				this.OnPropertyValueChange(_.CDate,_CDate,value);
				this._CDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Givename
		{
			get{ return _Givename; }
			set
			{
				this.OnPropertyValueChange(_.Givename,_Givename,value);
				this._Givename=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.CHID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.CHID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.CHID,
				_.TCID,
				_.CCID,
				_.Stdname,
				_.PSname,
				_.Sort,
				_.Content,
				_.CDate,
				_.Givename};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CHID,
				this._TCID,
				this._CCID,
				this._Stdname,
				this._PSname,
				this._Sort,
				this._Content,
				this._CDate,
				this._Givename};
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
			public readonly static Field All = new Field("*","TeachChat");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CHID = new Field("CHID","TeachChat","CHID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","TeachChat","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","TeachChat","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdname = new Field("Stdname","TeachChat","Stdname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSname = new Field("PSname","TeachChat","PSname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","TeachChat","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","TeachChat","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CDate = new Field("CDate","TeachChat","CDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Givename = new Field("Givename","TeachChat","Givename");
		}
		#endregion


	}
}
