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
	/// 实体类AppraiseM 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("AppraiseM")]
	[Serializable]
	public partial class AppraiseM : Entity 
	{
		#region Model
		private int _APMID;
		private string _Content;
		private string _APName;
		private DateTime? _APDate;
		private string _CSortCode;
		private string _APOper;
		private string _Object;
		private string _State;
		private string _Version;
		private int? _APDNum;
		/// <summary>
		/// 
		/// </summary>
		public int APMID
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
		public DateTime? APDate
		{
			get{ return _APDate; }
			set
			{
				this.OnPropertyValueChange(_.APDate,_APDate,value);
				this._APDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CSortCode
		{
			get{ return _CSortCode; }
			set
			{
				this.OnPropertyValueChange(_.CSortCode,_CSortCode,value);
				this._CSortCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APOper
		{
			get{ return _APOper; }
			set
			{
				this.OnPropertyValueChange(_.APOper,_APOper,value);
				this._APOper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Object
		{
			get{ return _Object; }
			set
			{
				this.OnPropertyValueChange(_.Object,_Object,value);
				this._Object=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string State
		{
			get{ return _State; }
			set
			{
				this.OnPropertyValueChange(_.State,_State,value);
				this._State=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Version
		{
			get{ return _Version; }
			set
			{
				this.OnPropertyValueChange(_.Version,_Version,value);
				this._Version=value;
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
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.APMID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.APMID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.APMID,
				_.Content,
				_.APName,
				_.APDate,
				_.CSortCode,
				_.APOper,
				_.Object,
				_.State,
				_.Version,
				_.APDNum};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._APMID,
				this._Content,
				this._APName,
				this._APDate,
				this._CSortCode,
				this._APOper,
				this._Object,
				this._State,
				this._Version,
				this._APDNum};
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
			public readonly static Field All = new Field("*","AppraiseM");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APMID = new Field("APMID","AppraiseM","APMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","AppraiseM","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APName = new Field("APName","AppraiseM","APName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APDate = new Field("APDate","AppraiseM","APDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSortCode = new Field("CSortCode","AppraiseM","CSortCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APOper = new Field("APOper","AppraiseM","APOper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Object = new Field("Object","AppraiseM","Object");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","AppraiseM","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Version = new Field("Version","AppraiseM","Version");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APDNum = new Field("APDNum","AppraiseM","APDNum");
		}
		#endregion


	}
}

