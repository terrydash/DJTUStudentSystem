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
	/// 实体类Vw_AppraiseIdea 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_AppraiseIdea")]
	[Serializable]
	public partial class Vw_AppraiseIdea : Entity 
	{
		#region Model
		private int _APIID;
		private int? _TCID;
		private int? _CCID;
		private int? _STDID;
		private int? _PSID;
		private int? _SRID;
		private int? _ATYID;
		private string _APIContent;
		private string _ATName;
		private string _PsName;
		private string _TCName;
		private string _CCname;
		private string _CCode;
		private DateTime? _APIDate;
		private string _StdName;
		private string _StdCode;
		private string _State;
		/// <summary>
		/// 
		/// </summary>
		public int APIID
		{
			get{ return _APIID; }
			set
			{
				this.OnPropertyValueChange(_.APIID,_APIID,value);
				this._APIID=value;
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
		public int? STDID
		{
			get{ return _STDID; }
			set
			{
				this.OnPropertyValueChange(_.STDID,_STDID,value);
				this._STDID=value;
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
		public int? SRID
		{
			get{ return _SRID; }
			set
			{
				this.OnPropertyValueChange(_.SRID,_SRID,value);
				this._SRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ATYID
		{
			get{ return _ATYID; }
			set
			{
				this.OnPropertyValueChange(_.ATYID,_ATYID,value);
				this._ATYID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APIContent
		{
			get{ return _APIContent; }
			set
			{
				this.OnPropertyValueChange(_.APIContent,_APIContent,value);
				this._APIContent=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ATName
		{
			get{ return _ATName; }
			set
			{
				this.OnPropertyValueChange(_.ATName,_ATName,value);
				this._ATName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PsName
		{
			get{ return _PsName; }
			set
			{
				this.OnPropertyValueChange(_.PsName,_PsName,value);
				this._PsName=value;
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
		public string CCname
		{
			get{ return _CCname; }
			set
			{
				this.OnPropertyValueChange(_.CCname,_CCname,value);
				this._CCname=value;
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
		/// <summary>
		/// 
		/// </summary>
		public DateTime? APIDate
		{
			get{ return _APIDate; }
			set
			{
				this.OnPropertyValueChange(_.APIDate,_APIDate,value);
				this._APIDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StdName
		{
			get{ return _StdName; }
			set
			{
				this.OnPropertyValueChange(_.StdName,_StdName,value);
				this._StdName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StdCode
		{
			get{ return _StdCode; }
			set
			{
				this.OnPropertyValueChange(_.StdCode,_StdCode,value);
				this._StdCode=value;
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
				_.APIID,
				_.TCID,
				_.CCID,
				_.STDID,
				_.PSID,
				_.SRID,
				_.ATYID,
				_.APIContent,
				_.ATName,
				_.PsName,
				_.TCName,
				_.CCname,
				_.CCode,
				_.APIDate,
				_.StdName,
				_.StdCode,
				_.State};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._APIID,
				this._TCID,
				this._CCID,
				this._STDID,
				this._PSID,
				this._SRID,
				this._ATYID,
				this._APIContent,
				this._ATName,
				this._PsName,
				this._TCName,
				this._CCname,
				this._CCode,
				this._APIDate,
				this._StdName,
				this._StdCode,
				this._State};
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
			public readonly static Field All = new Field("*","vw_AppraiseIdea");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APIID = new Field("APIID","vw_AppraiseIdea","APIID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","vw_AppraiseIdea","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_AppraiseIdea","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STDID = new Field("STDID","vw_AppraiseIdea","STDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","vw_AppraiseIdea","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SRID = new Field("SRID","vw_AppraiseIdea","SRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATYID = new Field("ATYID","vw_AppraiseIdea","ATYID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APIContent = new Field("APIContent","vw_AppraiseIdea","APIContent");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATName = new Field("ATName","vw_AppraiseIdea","ATName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PsName = new Field("PsName","vw_AppraiseIdea","PsName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCName = new Field("TCName","vw_AppraiseIdea","TCName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_AppraiseIdea","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_AppraiseIdea","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APIDate = new Field("APIDate","vw_AppraiseIdea","APIDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","vw_AppraiseIdea","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_AppraiseIdea","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","vw_AppraiseIdea","state");
		}
		#endregion


	}
}

