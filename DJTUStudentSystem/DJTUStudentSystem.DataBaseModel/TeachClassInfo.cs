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
	/// 实体类TeachClassInfo 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TeachClassInfo")]
	[Serializable]
	public partial class TeachClassInfo : Entity 
	{
		#region Model
		private int _TCIFID;
		private int? _TCID;
		private int? _Stdid;
		private int? _PSID;
		private DateTime? _PDate;
		private int? _NullName;
		private int? _Sort;
		private string _Content;
		/// <summary>
		/// 
		/// </summary>
		public int TCIFID
		{
			get{ return _TCIFID; }
			set
			{
				this.OnPropertyValueChange(_.TCIFID,_TCIFID,value);
				this._TCIFID=value;
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
		public int? PSID
		{
			get{ return _PSID; }
			set
			{
				this.OnPropertyValueChange(_.PSID,_PSID,value);
				this._PSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PDate
		{
			get{ return _PDate; }
			set
			{
				this.OnPropertyValueChange(_.PDate,_PDate,value);
				this._PDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? NullName
		{
			get{ return _NullName; }
			set
			{
				this.OnPropertyValueChange(_.NullName,_NullName,value);
				this._NullName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Sort
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
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.TCIFID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TCIFID,
				_.TCID,
				_.Stdid,
				_.PSID,
				_.PDate,
				_.NullName,
				_.Sort,
				_.Content};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TCIFID,
				this._TCID,
				this._Stdid,
				this._PSID,
				this._PDate,
				this._NullName,
				this._Sort,
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
			public readonly static Field All = new Field("*","TeachClassInfo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCIFID = new Field("TCIFID","TeachClassInfo","TCIFID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","TeachClassInfo","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("Stdid","TeachClassInfo","Stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","TeachClassInfo","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PDate = new Field("PDate","TeachClassInfo","PDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NullName = new Field("NullName","TeachClassInfo","NullName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","TeachClassInfo","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","TeachClassInfo","Content");
		}
		#endregion


	}
}
