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
	/// 实体类YJSorce 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("YJSorce")]
	[Serializable]
	public partial class YJSorce : Entity 
	{
		#region Model
		private int _YJID;
		private string _ContentCount;
		private string _Quotiety;
		private string _YJSort;
		private decimal? _Sorce;
		private decimal? _Xishu;
		/// <summary>
		/// 
		/// </summary>
		public int YJID
		{
			get{ return _YJID; }
			set
			{
				this.OnPropertyValueChange(_.YJID,_YJID,value);
				this._YJID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ContentCount
		{
			get{ return _ContentCount; }
			set
			{
				this.OnPropertyValueChange(_.ContentCount,_ContentCount,value);
				this._ContentCount=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Quotiety
		{
			get{ return _Quotiety; }
			set
			{
				this.OnPropertyValueChange(_.Quotiety,_Quotiety,value);
				this._Quotiety=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YJSort
		{
			get{ return _YJSort; }
			set
			{
				this.OnPropertyValueChange(_.YJSort,_YJSort,value);
				this._YJSort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Sorce
		{
			get{ return _Sorce; }
			set
			{
				this.OnPropertyValueChange(_.Sorce,_Sorce,value);
				this._Sorce=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Xishu
		{
			get{ return _Xishu; }
			set
			{
				this.OnPropertyValueChange(_.Xishu,_Xishu,value);
				this._Xishu=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.YJID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.YJID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.YJID,
				_.ContentCount,
				_.Quotiety,
				_.YJSort,
				_.Sorce,
				_.Xishu};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._YJID,
				this._ContentCount,
				this._Quotiety,
				this._YJSort,
				this._Sorce,
				this._Xishu};
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
			public readonly static Field All = new Field("*","YJSorce");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field YJID = new Field("YJID","YJSorce","YJID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ContentCount = new Field("ContentCount","YJSorce","ContentCount");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Quotiety = new Field("Quotiety","YJSorce","Quotiety");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field YJSort = new Field("YJSort","YJSorce","YJSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sorce = new Field("Sorce","YJSorce","Sorce");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Xishu = new Field("Xishu","YJSorce","Xishu");
		}
		#endregion


	}
}

