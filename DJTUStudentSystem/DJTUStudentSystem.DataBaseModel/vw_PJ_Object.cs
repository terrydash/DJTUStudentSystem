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
	/// 实体类Vw_PJ_Object 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_PJ_Object")]
	[Serializable]
	public partial class Vw_PJ_Object : Entity 
	{
		#region Model
		private int _POID;
		private string _PObjectName;
		private string _StartMethod;
		private string _PJBodySort;
		private int? _APMID;
		private string _APName;
		private int? _APDNum;
		private string _Content;
		/// <summary>
		/// 
		/// </summary>
		public int POID
		{
			get{ return _POID; }
			set
			{
				this.OnPropertyValueChange(_.POID,_POID,value);
				this._POID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PObjectName
		{
			get{ return _PObjectName; }
			set
			{
				this.OnPropertyValueChange(_.PObjectName,_PObjectName,value);
				this._PObjectName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartMethod
		{
			get{ return _StartMethod; }
			set
			{
				this.OnPropertyValueChange(_.StartMethod,_StartMethod,value);
				this._StartMethod=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PJBodySort
		{
			get{ return _PJBodySort; }
			set
			{
				this.OnPropertyValueChange(_.PJBodySort,_PJBodySort,value);
				this._PJBodySort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? APMID
		{
			get{ return _APMID; }
			set
			{
				this.OnPropertyValueChange(_.APMID,_APMID,value);
				this._APMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APName
		{
			get{ return _APName; }
			set
			{
				this.OnPropertyValueChange(_.APName,_APName,value);
				this._APName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? APDNum
		{
			get{ return _APDNum; }
			set
			{
				this.OnPropertyValueChange(_.APDNum,_APDNum,value);
				this._APDNum=value;
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
				_.POID,
				_.PObjectName,
				_.StartMethod,
				_.PJBodySort,
				_.APMID,
				_.APName,
				_.APDNum,
				_.Content};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._POID,
				this._PObjectName,
				this._StartMethod,
				this._PJBodySort,
				this._APMID,
				this._APName,
				this._APDNum,
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
			public readonly static Field All = new Field("*","vw_PJ_Object");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field POID = new Field("POID","vw_PJ_Object","POID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PObjectName = new Field("PObjectName","vw_PJ_Object","PObjectName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartMethod = new Field("StartMethod","vw_PJ_Object","StartMethod");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PJBodySort = new Field("PJBodySort","vw_PJ_Object","PJBodySort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APMID = new Field("APMID","vw_PJ_Object","APMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APName = new Field("APName","vw_PJ_Object","APName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APDNum = new Field("APDNum","vw_PJ_Object","APDNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","vw_PJ_Object","Content");
		}
		#endregion


	}
}

