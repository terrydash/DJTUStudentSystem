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
	/// 实体类Vw_PKCondition 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_PKCondition")]
	[Serializable]
	public partial class Vw_PKCondition : Entity 
	{
		#region Model
		private string _CCName;
		private string _CRname;
		private string _BuildName;
		private string _TCName;
		private string _PSName;
		private string _Sort;
		private string _Content;
		private int? _CCID;
		private int? _TCID;
		private int? _CRID;
		private int? _DayOFWeek;
		private string _SectionTH;
		private int? _StartWeek;
		private int? _EndWeek;
		private string _Memo;
		private int _PKEID;
		private int? _Atyid;
		private string _Limit;
		private string _CCode;
		/// <summary>
		/// 
		/// </summary>
		public string CCName
		{
			get{ return _CCName; }
			set
			{
				this.OnPropertyValueChange(_.CCName,_CCName,value);
				this._CCName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CRname
		{
			get{ return _CRname; }
			set
			{
				this.OnPropertyValueChange(_.CRname,_CRname,value);
				this._CRname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BuildName
		{
			get{ return _BuildName; }
			set
			{
				this.OnPropertyValueChange(_.BuildName,_BuildName,value);
				this._BuildName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TCName
		{
			get{ return _TCName; }
			set
			{
				this.OnPropertyValueChange(_.TCName,_TCName,value);
				this._TCName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PSName
		{
			get{ return _PSName; }
			set
			{
				this.OnPropertyValueChange(_.PSName,_PSName,value);
				this._PSName=value;
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
		public int? CRID
		{
			get{ return _CRID; }
			set
			{
				this.OnPropertyValueChange(_.CRID,_CRID,value);
				this._CRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DayOFWeek
		{
			get{ return _DayOFWeek; }
			set
			{
				this.OnPropertyValueChange(_.DayOFWeek,_DayOFWeek,value);
				this._DayOFWeek=value;
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
		/// <summary>
		/// 
		/// </summary>
		public int? StartWeek
		{
			get{ return _StartWeek; }
			set
			{
				this.OnPropertyValueChange(_.StartWeek,_StartWeek,value);
				this._StartWeek=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EndWeek
		{
			get{ return _EndWeek; }
			set
			{
				this.OnPropertyValueChange(_.EndWeek,_EndWeek,value);
				this._EndWeek=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get{ return _Memo; }
			set
			{
				this.OnPropertyValueChange(_.Memo,_Memo,value);
				this._Memo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PKEID
		{
			get{ return _PKEID; }
			set
			{
				this.OnPropertyValueChange(_.PKEID,_PKEID,value);
				this._PKEID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Atyid
		{
			get{ return _Atyid; }
			set
			{
				this.OnPropertyValueChange(_.Atyid,_Atyid,value);
				this._Atyid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Limit
		{
			get{ return _Limit; }
			set
			{
				this.OnPropertyValueChange(_.Limit,_Limit,value);
				this._Limit=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CCode
		{
			get{ return _CCode; }
			set
			{
				this.OnPropertyValueChange(_.CCode,_CCode,value);
				this._CCode=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 是否只读
		/// </summary>
		public override bool IsReadOnly()
		{
			return true;
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.CCName,
				_.CRname,
				_.BuildName,
				_.TCName,
				_.PSName,
				_.Sort,
				_.Content,
				_.CCID,
				_.TCID,
				_.CRID,
				_.DayOFWeek,
				_.SectionTH,
				_.StartWeek,
				_.EndWeek,
				_.Memo,
				_.PKEID,
				_.Atyid,
				_.Limit,
				_.CCode};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CCName,
				this._CRname,
				this._BuildName,
				this._TCName,
				this._PSName,
				this._Sort,
				this._Content,
				this._CCID,
				this._TCID,
				this._CRID,
				this._DayOFWeek,
				this._SectionTH,
				this._StartWeek,
				this._EndWeek,
				this._Memo,
				this._PKEID,
				this._Atyid,
				this._Limit,
				this._CCode};
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
			public readonly static Field All = new Field("*","vw_PKCondition");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCName = new Field("CCName","vw_PKCondition","CCName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRname = new Field("CRname","vw_PKCondition","CRname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BuildName = new Field("BuildName","vw_PKCondition","BuildName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCName = new Field("TCName","vw_PKCondition","TCName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSName = new Field("PSName","vw_PKCondition","PSName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","vw_PKCondition","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","vw_PKCondition","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_PKCondition","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","vw_PKCondition","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRID = new Field("CRID","vw_PKCondition","CRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DayOFWeek = new Field("DayOFWeek","vw_PKCondition","DayOFWeek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SectionTH = new Field("SectionTH","vw_PKCondition","SectionTH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartWeek = new Field("StartWeek","vw_PKCondition","StartWeek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EndWeek = new Field("EndWeek","vw_PKCondition","EndWeek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","vw_PKCondition","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PKEID = new Field("PKEID","vw_PKCondition","PKEID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("atyid","vw_PKCondition","atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Limit = new Field("Limit","vw_PKCondition","Limit");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_PKCondition","CCode");
		}
		#endregion


	}
}

