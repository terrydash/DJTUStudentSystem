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
	/// 实体类CSreport 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("CSreport")]
	[Serializable]
	public partial class CSreport : Entity 
	{
		#region Model
		private int _CSRID;
		private int? _TCID;
		private string _Content;
		private int? _Num;
		/// <summary>
		/// 
		/// </summary>
		public int CSRID
		{
			get{ return _CSRID; }
			set
			{
				this.OnPropertyValueChange(_.CSRID,_CSRID,value);
				this._CSRID=value;
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
		public int? Num
		{
			get{ return _Num; }
			set
			{
				this.OnPropertyValueChange(_.Num,_Num,value);
				this._Num=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.CSRID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.CSRID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.CSRID,
				_.TCID,
				_.Content,
				_.Num};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CSRID,
				this._TCID,
				this._Content,
				this._Num};
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
			public readonly static Field All = new Field("*","CSreport");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSRID = new Field("CSRID","CSreport","CSRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","CSreport","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","CSreport","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Num = new Field("Num","CSreport","Num");
		}
		#endregion


	}
}

