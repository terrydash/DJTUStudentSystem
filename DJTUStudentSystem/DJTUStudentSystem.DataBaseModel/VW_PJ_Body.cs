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
	/// 实体类VW_PJ_Body 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("VW_PJ_Body")]
	[Serializable]
	public partial class VW_PJ_Body : Entity 
	{
		#region Model
		private int _BodID;
		private int? _SubjID;
		private int? _MBID;
		private int? _PSID;
		private int? _STdid;
		private string _SBCode;
		private string _SBName;
		private int? _UnitID;
		private int? _OrgID;
		private int? _DTID;
		private string _Memo;
		private string _State;
		private string _DTName;
		private string _OrgName;
		private string _BatchNo;
		private string _GLName;
		private string _APName;
		private string _ATName;
		private string _DeptCode;
		private string _Deptname;
		private int? _APMID;
		private decimal? _GetSource;
		private DateTime? _Makedate;
		private DateTime? _OverDate;
		private int? _Atyid;
		private DateTime? _MdDate;
		private DateTime? _SRDate;
		private DateTime? _SEdate;
		private string _SExpain;
		/// <summary>
		/// 
		/// </summary>
		public int BodID
		{
			get{ return _BodID; }
			set
			{
				this.OnPropertyValueChange(_.BodID,_BodID,value);
				this._BodID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SubjID
		{
			get{ return _SubjID; }
			set
			{
				this.OnPropertyValueChange(_.SubjID,_SubjID,value);
				this._SubjID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MBID
		{
			get{ return _MBID; }
			set
			{
				this.OnPropertyValueChange(_.MBID,_MBID,value);
				this._MBID=value;
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
		public int? STdid
		{
			get{ return _STdid; }
			set
			{
				this.OnPropertyValueChange(_.STdid,_STdid,value);
				this._STdid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SBCode
		{
			get{ return _SBCode; }
			set
			{
				this.OnPropertyValueChange(_.SBCode,_SBCode,value);
				this._SBCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SBName
		{
			get{ return _SBName; }
			set
			{
				this.OnPropertyValueChange(_.SBName,_SBName,value);
				this._SBName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UnitID
		{
			get{ return _UnitID; }
			set
			{
				this.OnPropertyValueChange(_.UnitID,_UnitID,value);
				this._UnitID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OrgID
		{
			get{ return _OrgID; }
			set
			{
				this.OnPropertyValueChange(_.OrgID,_OrgID,value);
				this._OrgID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DTID
		{
			get{ return _DTID; }
			set
			{
				this.OnPropertyValueChange(_.DTID,_DTID,value);
				this._DTID=value;
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
		public string DTName
		{
			get{ return _DTName; }
			set
			{
				this.OnPropertyValueChange(_.DTName,_DTName,value);
				this._DTName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrgName
		{
			get{ return _OrgName; }
			set
			{
				this.OnPropertyValueChange(_.OrgName,_OrgName,value);
				this._OrgName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BatchNo
		{
			get{ return _BatchNo; }
			set
			{
				this.OnPropertyValueChange(_.BatchNo,_BatchNo,value);
				this._BatchNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLName
		{
			get{ return _GLName; }
			set
			{
				this.OnPropertyValueChange(_.GLName,_GLName,value);
				this._GLName=value;
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
		public string DeptCode
		{
			get{ return _DeptCode; }
			set
			{
				this.OnPropertyValueChange(_.DeptCode,_DeptCode,value);
				this._DeptCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Deptname
		{
			get{ return _Deptname; }
			set
			{
				this.OnPropertyValueChange(_.Deptname,_Deptname,value);
				this._Deptname=value;
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
		public decimal? GetSource
		{
			get{ return _GetSource; }
			set
			{
				this.OnPropertyValueChange(_.GetSource,_GetSource,value);
				this._GetSource=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Makedate
		{
			get{ return _Makedate; }
			set
			{
				this.OnPropertyValueChange(_.Makedate,_Makedate,value);
				this._Makedate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OverDate
		{
			get{ return _OverDate; }
			set
			{
				this.OnPropertyValueChange(_.OverDate,_OverDate,value);
				this._OverDate=value;
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
		public DateTime? MdDate
		{
			get{ return _MdDate; }
			set
			{
				this.OnPropertyValueChange(_.MdDate,_MdDate,value);
				this._MdDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SRDate
		{
			get{ return _SRDate; }
			set
			{
				this.OnPropertyValueChange(_.SRDate,_SRDate,value);
				this._SRDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SEdate
		{
			get{ return _SEdate; }
			set
			{
				this.OnPropertyValueChange(_.SEdate,_SEdate,value);
				this._SEdate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SExpain
		{
			get{ return _SExpain; }
			set
			{
				this.OnPropertyValueChange(_.SExpain,_SExpain,value);
				this._SExpain=value;
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
				_.BodID,
				_.SubjID,
				_.MBID,
				_.PSID,
				_.STdid,
				_.SBCode,
				_.SBName,
				_.UnitID,
				_.OrgID,
				_.DTID,
				_.Memo,
				_.State,
				_.DTName,
				_.OrgName,
				_.BatchNo,
				_.GLName,
				_.APName,
				_.ATName,
				_.DeptCode,
				_.Deptname,
				_.APMID,
				_.GetSource,
				_.Makedate,
				_.OverDate,
				_.Atyid,
				_.MdDate,
				_.SRDate,
				_.SEdate,
				_.SExpain};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._BodID,
				this._SubjID,
				this._MBID,
				this._PSID,
				this._STdid,
				this._SBCode,
				this._SBName,
				this._UnitID,
				this._OrgID,
				this._DTID,
				this._Memo,
				this._State,
				this._DTName,
				this._OrgName,
				this._BatchNo,
				this._GLName,
				this._APName,
				this._ATName,
				this._DeptCode,
				this._Deptname,
				this._APMID,
				this._GetSource,
				this._Makedate,
				this._OverDate,
				this._Atyid,
				this._MdDate,
				this._SRDate,
				this._SEdate,
				this._SExpain};
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
			public readonly static Field All = new Field("*","VW_PJ_Body");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BodID = new Field("BodID","VW_PJ_Body","BodID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SubjID = new Field("SubjID","VW_PJ_Body","SubjID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MBID = new Field("MBID","VW_PJ_Body","MBID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","VW_PJ_Body","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STdid = new Field("STdid","VW_PJ_Body","STdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SBCode = new Field("SBCode","VW_PJ_Body","SBCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SBName = new Field("SBName","VW_PJ_Body","SBName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UnitID = new Field("UnitID","VW_PJ_Body","UnitID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OrgID = new Field("OrgID","VW_PJ_Body","OrgID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DTID = new Field("DTID","VW_PJ_Body","DTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","VW_PJ_Body","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","VW_PJ_Body","state");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DTName = new Field("DTName","VW_PJ_Body","DTName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OrgName = new Field("OrgName","VW_PJ_Body","OrgName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BatchNo = new Field("BatchNo","VW_PJ_Body","BatchNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GLName = new Field("GLName","VW_PJ_Body","GLName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APName = new Field("APName","VW_PJ_Body","APName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATName = new Field("ATName","VW_PJ_Body","ATName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","VW_PJ_Body","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Deptname = new Field("Deptname","VW_PJ_Body","Deptname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APMID = new Field("APMID","VW_PJ_Body","APMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GetSource = new Field("GetSource","VW_PJ_Body","GetSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Makedate = new Field("Makedate","VW_PJ_Body","Makedate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OverDate = new Field("OverDate","VW_PJ_Body","OverDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("Atyid","VW_PJ_Body","Atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MdDate = new Field("MdDate","VW_PJ_Body","MdDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SRDate = new Field("SRDate","VW_PJ_Body","SRDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SEdate = new Field("SEdate","VW_PJ_Body","SEdate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SExpain = new Field("SExpain","VW_PJ_Body","SExpain");
		}
		#endregion


	}
}

