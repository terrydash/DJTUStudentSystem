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
	/// 实体类ExpStdlist 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ExpStdlist")]
	[Serializable]
	public partial class ExpStdlist : Entity 
	{
		#region Model
		private int _Stdid;
		private decimal? _BadSource;
		private decimal? _Mainavg;
		private decimal? _Mainavg2;
		/// <summary>
		/// 
		/// </summary>
		public int Stdid
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
		public decimal? BadSource
		{
			get{ return _BadSource; }
			set
			{
				this.OnPropertyValueChange(_.BadSource,_BadSource,value);
				this._BadSource=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Mainavg
		{
			get{ return _Mainavg; }
			set
			{
				this.OnPropertyValueChange(_.Mainavg,_Mainavg,value);
				this._Mainavg=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Mainavg2
		{
			get{ return _Mainavg2; }
			set
			{
				this.OnPropertyValueChange(_.Mainavg2,_Mainavg2,value);
				this._Mainavg2=value;
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
				_.Stdid,
				_.BadSource,
				_.Mainavg,
				_.Mainavg2};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Stdid,
				this._BadSource,
				this._Mainavg,
				this._Mainavg2};
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
			public readonly static Field All = new Field("*","ExpStdlist");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("Stdid","ExpStdlist","Stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BadSource = new Field("BadSource","ExpStdlist","BadSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Mainavg = new Field("Mainavg","ExpStdlist","Mainavg");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Mainavg2 = new Field("Mainavg2","ExpStdlist","Mainavg2");
		}
		#endregion


	}
}

