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
	/// 实体类LimitForSelect 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("LimitForSelect")]
	[Serializable]
	public partial class LimitForSelect : Entity 
	{
		#region Model
		private int _LMID;
		private int? _AtyID;
		private string _CSort;
		private int? _CLID;
		private int? _DayofWeek;
		private string _SectionTH;
		/// <summary>
		/// 
		/// </summary>
		public int LMID
		{
			get{ return _LMID; }
			set
			{
				this.OnPropertyValueChange(_.LMID,_LMID,value);
				this._LMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AtyID
		{
			get{ return _AtyID; }
			set
			{
				this.OnPropertyValueChange(_.AtyID,_AtyID,value);
				this._AtyID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CSort
		{
			get{ return _CSort; }
			set
			{
				this.OnPropertyValueChange(_.CSort,_CSort,value);
				this._CSort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CLID
		{
			get{ return _CLID; }
			set
			{
				this.OnPropertyValueChange(_.CLID,_CLID,value);
				this._CLID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DayofWeek
		{
			get{ return _DayofWeek; }
			set
			{
				this.OnPropertyValueChange(_.DayofWeek,_DayofWeek,value);
				this._DayofWeek=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SectionTH
		{
			get{ return _SectionTH; }
			set
			{
				this.OnPropertyValueChange(_.SectionTH,_SectionTH,value);
				this._SectionTH=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.LMID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.LMID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.LMID,
				_.AtyID,
				_.CSort,
				_.CLID,
				_.DayofWeek,
				_.SectionTH};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._LMID,
				this._AtyID,
				this._CSort,
				this._CLID,
				this._DayofWeek,
				this._SectionTH};
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
			public readonly static Field All = new Field("*","LimitForSelect");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LMID = new Field("LMID","LimitForSelect","LMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","LimitForSelect","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSort = new Field("CSort","LimitForSelect","CSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLID = new Field("CLID","LimitForSelect","CLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DayofWeek = new Field("DayofWeek","LimitForSelect","DayofWeek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SectionTH = new Field("SectionTH","LimitForSelect","SectionTH");
		}
		#endregion


	}
}

