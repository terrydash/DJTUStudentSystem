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
	/// 实体类TeachClass 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("TeachClass")]
	[Serializable]
	public partial class TeachClass : Entity 
	{
		#region Model
		private int _TCID;
		private int? _EPID;
		private int? _KBID;
		private int? _CCID;
		private int? _ActYear;
		private string _Grade;
		private int? _TCHID;
		private int? _HTCHID;
		private int? _TCHID3;
		private string _ComeDept;
		private string _LimitSP;
		private string _TCName;
		private string _ReportState;
		private string _Affirmant;
		private DateTime? _CheckDate;
		private string _Receipter;
		private DateTime? _Receiptdate;
		private string _Memo;
		private int? _OpenNum;
		private int? _Havenum;
		private int? _MaxStuNum;
		private string _State;
		private string _EduCalen;
		private int? _RGID;
		private int? _PKstate;
		private int? _CTID;
		private int? _FAXH;
		private int? _FAXHB;
		private string _CLRSort;
		private string _ExminSort;
		private string _Sort;
		private string _IFJoin;
		private int? _CL1;
		private int? _CL2;
		private int? _SPID;
		private string _Oper;
		private DateTime? _OperDate;
		private string _Lev;
		private string _SelectState;
		private string _GroupMark;
		private int? _CLnums;
		private int? _RgNums;
		private int? _KsNums;
		private string _Minor;
		private string _Ctype;
		private string _NeedCalendar;
		private string _NeedPJ;
		private string _FX;
		private string _LimitGrade;
		private string _LSPMethod;
		private DateTime? _SubmitDate;
		/// <summary>
		/// 
		/// </summary>
		public int TCID
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
		public int? EPID
		{
			get{ return _EPID; }
			set
			{
				this.OnPropertyValueChange(_.EPID,_EPID,value);
				this._EPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? KBID
		{
			get{ return _KBID; }
			set
			{
				this.OnPropertyValueChange(_.KBID,_KBID,value);
				this._KBID=value;
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
		public int? ActYear
		{
			get{ return _ActYear; }
			set
			{
				this.OnPropertyValueChange(_.ActYear,_ActYear,value);
				this._ActYear=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Grade
		{
			get{ return _Grade; }
			set
			{
				this.OnPropertyValueChange(_.Grade,_Grade,value);
				this._Grade=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TCHID
		{
			get{ return _TCHID; }
			set
			{
				this.OnPropertyValueChange(_.TCHID,_TCHID,value);
				this._TCHID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? HTCHID
		{
			get{ return _HTCHID; }
			set
			{
				this.OnPropertyValueChange(_.HTCHID,_HTCHID,value);
				this._HTCHID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TCHID3
		{
			get{ return _TCHID3; }
			set
			{
				this.OnPropertyValueChange(_.TCHID3,_TCHID3,value);
				this._TCHID3=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ComeDept
		{
			get{ return _ComeDept; }
			set
			{
				this.OnPropertyValueChange(_.ComeDept,_ComeDept,value);
				this._ComeDept=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LimitSP
		{
			get{ return _LimitSP; }
			set
			{
				this.OnPropertyValueChange(_.LimitSP,_LimitSP,value);
				this._LimitSP=value;
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
		public string ReportState
		{
			get{ return _ReportState; }
			set
			{
				this.OnPropertyValueChange(_.ReportState,_ReportState,value);
				this._ReportState=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Affirmant
		{
			get{ return _Affirmant; }
			set
			{
				this.OnPropertyValueChange(_.Affirmant,_Affirmant,value);
				this._Affirmant=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CheckDate
		{
			get{ return _CheckDate; }
			set
			{
				this.OnPropertyValueChange(_.CheckDate,_CheckDate,value);
				this._CheckDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Receipter
		{
			get{ return _Receipter; }
			set
			{
				this.OnPropertyValueChange(_.Receipter,_Receipter,value);
				this._Receipter=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Receiptdate
		{
			get{ return _Receiptdate; }
			set
			{
				this.OnPropertyValueChange(_.Receiptdate,_Receiptdate,value);
				this._Receiptdate=value;
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
		public int? OpenNum
		{
			get{ return _OpenNum; }
			set
			{
				this.OnPropertyValueChange(_.OpenNum,_OpenNum,value);
				this._OpenNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Havenum
		{
			get{ return _Havenum; }
			set
			{
				this.OnPropertyValueChange(_.Havenum,_Havenum,value);
				this._Havenum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MaxStuNum
		{
			get{ return _MaxStuNum; }
			set
			{
				this.OnPropertyValueChange(_.MaxStuNum,_MaxStuNum,value);
				this._MaxStuNum=value;
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
		public string EduCalen
		{
			get{ return _EduCalen; }
			set
			{
				this.OnPropertyValueChange(_.EduCalen,_EduCalen,value);
				this._EduCalen=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RGID
		{
			get{ return _RGID; }
			set
			{
				this.OnPropertyValueChange(_.RGID,_RGID,value);
				this._RGID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PKstate
		{
			get{ return _PKstate; }
			set
			{
				this.OnPropertyValueChange(_.PKstate,_PKstate,value);
				this._PKstate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CTID
		{
			get{ return _CTID; }
			set
			{
				this.OnPropertyValueChange(_.CTID,_CTID,value);
				this._CTID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FAXH
		{
			get{ return _FAXH; }
			set
			{
				this.OnPropertyValueChange(_.FAXH,_FAXH,value);
				this._FAXH=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FAXHB
		{
			get{ return _FAXHB; }
			set
			{
				this.OnPropertyValueChange(_.FAXHB,_FAXHB,value);
				this._FAXHB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLRSort
		{
			get{ return _CLRSort; }
			set
			{
				this.OnPropertyValueChange(_.CLRSort,_CLRSort,value);
				this._CLRSort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExminSort
		{
			get{ return _ExminSort; }
			set
			{
				this.OnPropertyValueChange(_.ExminSort,_ExminSort,value);
				this._ExminSort=value;
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
		public string IFJoin
		{
			get{ return _IFJoin; }
			set
			{
				this.OnPropertyValueChange(_.IFJoin,_IFJoin,value);
				this._IFJoin=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CL1
		{
			get{ return _CL1; }
			set
			{
				this.OnPropertyValueChange(_.CL1,_CL1,value);
				this._CL1=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CL2
		{
			get{ return _CL2; }
			set
			{
				this.OnPropertyValueChange(_.CL2,_CL2,value);
				this._CL2=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SPID
		{
			get{ return _SPID; }
			set
			{
				this.OnPropertyValueChange(_.SPID,_SPID,value);
				this._SPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Oper
		{
			get{ return _Oper; }
			set
			{
				this.OnPropertyValueChange(_.Oper,_Oper,value);
				this._Oper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OperDate
		{
			get{ return _OperDate; }
			set
			{
				this.OnPropertyValueChange(_.OperDate,_OperDate,value);
				this._OperDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Lev
		{
			get{ return _Lev; }
			set
			{
				this.OnPropertyValueChange(_.Lev,_Lev,value);
				this._Lev=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SelectState
		{
			get{ return _SelectState; }
			set
			{
				this.OnPropertyValueChange(_.SelectState,_SelectState,value);
				this._SelectState=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GroupMark
		{
			get{ return _GroupMark; }
			set
			{
				this.OnPropertyValueChange(_.GroupMark,_GroupMark,value);
				this._GroupMark=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CLnums
		{
			get{ return _CLnums; }
			set
			{
				this.OnPropertyValueChange(_.CLnums,_CLnums,value);
				this._CLnums=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RgNums
		{
			get{ return _RgNums; }
			set
			{
				this.OnPropertyValueChange(_.RgNums,_RgNums,value);
				this._RgNums=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? KsNums
		{
			get{ return _KsNums; }
			set
			{
				this.OnPropertyValueChange(_.KsNums,_KsNums,value);
				this._KsNums=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Minor
		{
			get{ return _Minor; }
			set
			{
				this.OnPropertyValueChange(_.Minor,_Minor,value);
				this._Minor=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ctype
		{
			get{ return _Ctype; }
			set
			{
				this.OnPropertyValueChange(_.Ctype,_Ctype,value);
				this._Ctype=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NeedCalendar
		{
			get{ return _NeedCalendar; }
			set
			{
				this.OnPropertyValueChange(_.NeedCalendar,_NeedCalendar,value);
				this._NeedCalendar=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NeedPJ
		{
			get{ return _NeedPJ; }
			set
			{
				this.OnPropertyValueChange(_.NeedPJ,_NeedPJ,value);
				this._NeedPJ=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FX
		{
			get{ return _FX; }
			set
			{
				this.OnPropertyValueChange(_.FX,_FX,value);
				this._FX=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LimitGrade
		{
			get{ return _LimitGrade; }
			set
			{
				this.OnPropertyValueChange(_.LimitGrade,_LimitGrade,value);
				this._LimitGrade=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LSPMethod
		{
			get{ return _LSPMethod; }
			set
			{
				this.OnPropertyValueChange(_.LSPMethod,_LSPMethod,value);
				this._LSPMethod=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SubmitDate
		{
			get{ return _SubmitDate; }
			set
			{
				this.OnPropertyValueChange(_.SubmitDate,_SubmitDate,value);
				this._SubmitDate=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.TCID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.TCID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.TCID,
				_.EPID,
				_.KBID,
				_.CCID,
				_.ActYear,
				_.Grade,
				_.TCHID,
				_.HTCHID,
				_.TCHID3,
				_.ComeDept,
				_.LimitSP,
				_.TCName,
				_.ReportState,
				_.Affirmant,
				_.CheckDate,
				_.Receipter,
				_.Receiptdate,
				_.Memo,
				_.OpenNum,
				_.Havenum,
				_.MaxStuNum,
				_.State,
				_.EduCalen,
				_.RGID,
				_.PKstate,
				_.CTID,
				_.FAXH,
				_.FAXHB,
				_.CLRSort,
				_.ExminSort,
				_.Sort,
				_.IFJoin,
				_.CL1,
				_.CL2,
				_.SPID,
				_.Oper,
				_.OperDate,
				_.Lev,
				_.SelectState,
				_.GroupMark,
				_.CLnums,
				_.RgNums,
				_.KsNums,
				_.Minor,
				_.Ctype,
				_.NeedCalendar,
				_.NeedPJ,
				_.FX,
				_.LimitGrade,
				_.LSPMethod,
				_.SubmitDate};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TCID,
				this._EPID,
				this._KBID,
				this._CCID,
				this._ActYear,
				this._Grade,
				this._TCHID,
				this._HTCHID,
				this._TCHID3,
				this._ComeDept,
				this._LimitSP,
				this._TCName,
				this._ReportState,
				this._Affirmant,
				this._CheckDate,
				this._Receipter,
				this._Receiptdate,
				this._Memo,
				this._OpenNum,
				this._Havenum,
				this._MaxStuNum,
				this._State,
				this._EduCalen,
				this._RGID,
				this._PKstate,
				this._CTID,
				this._FAXH,
				this._FAXHB,
				this._CLRSort,
				this._ExminSort,
				this._Sort,
				this._IFJoin,
				this._CL1,
				this._CL2,
				this._SPID,
				this._Oper,
				this._OperDate,
				this._Lev,
				this._SelectState,
				this._GroupMark,
				this._CLnums,
				this._RgNums,
				this._KsNums,
				this._Minor,
				this._Ctype,
				this._NeedCalendar,
				this._NeedPJ,
				this._FX,
				this._LimitGrade,
				this._LSPMethod,
				this._SubmitDate};
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
			public readonly static Field All = new Field("*","TeachClass");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","TeachClass","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPID = new Field("EPID","TeachClass","EPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KBID = new Field("KBID","TeachClass","KBID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","TeachClass","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ActYear = new Field("ActYear","TeachClass","ActYear");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Grade = new Field("Grade","TeachClass","Grade");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCHID = new Field("TCHID","TeachClass","TCHID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HTCHID = new Field("HTCHID","TeachClass","HTCHID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCHID3 = new Field("TCHID3","TeachClass","TCHID3");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ComeDept = new Field("ComeDept","TeachClass","ComeDept");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LimitSP = new Field("LimitSP","TeachClass","LimitSP");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCName = new Field("TCName","TeachClass","TCName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ReportState = new Field("ReportState","TeachClass","ReportState");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Affirmant = new Field("Affirmant","TeachClass","Affirmant");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CheckDate = new Field("CheckDate","TeachClass","CheckDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Receipter = new Field("Receipter","TeachClass","Receipter");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Receiptdate = new Field("Receiptdate","TeachClass","Receiptdate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","TeachClass","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OpenNum = new Field("OpenNum","TeachClass","OpenNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Havenum = new Field("havenum","TeachClass","havenum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MaxStuNum = new Field("MaxStuNum","TeachClass","MaxStuNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","TeachClass","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EduCalen = new Field("EduCalen","TeachClass","EduCalen");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGID = new Field("RGID","TeachClass","RGID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PKstate = new Field("PKstate","TeachClass","PKstate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CTID = new Field("CTID","TeachClass","CTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAXH = new Field("FAXH","TeachClass","FAXH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAXHB = new Field("FAXHB","TeachClass","FAXHB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLRSort = new Field("CLRSort","TeachClass","CLRSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExminSort = new Field("ExminSort","TeachClass","ExminSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","TeachClass","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IFJoin = new Field("IFJoin","TeachClass","IFJoin");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CL1 = new Field("CL1","TeachClass","CL1");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CL2 = new Field("CL2","TeachClass","CL2");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","TeachClass","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","TeachClass","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OperDate = new Field("OperDate","TeachClass","OperDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Lev = new Field("Lev","TeachClass","Lev");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SelectState = new Field("SelectState","TeachClass","SelectState");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GroupMark = new Field("GroupMark","TeachClass","GroupMark");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLnums = new Field("CLnums","TeachClass","CLnums");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RgNums = new Field("RgNums","TeachClass","RgNums");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KsNums = new Field("KsNums","TeachClass","KsNums");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Minor = new Field("Minor","TeachClass","Minor");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Ctype = new Field("ctype","TeachClass","ctype");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NeedCalendar = new Field("NeedCalendar","TeachClass","NeedCalendar");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NeedPJ = new Field("NeedPJ","TeachClass","NeedPJ");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FX = new Field("FX","TeachClass","FX");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LimitGrade = new Field("LimitGrade","TeachClass","LimitGrade");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LSPMethod = new Field("LSPMethod","TeachClass","LSPMethod");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SubmitDate = new Field("SubmitDate","TeachClass","SubmitDate");
		}
		#endregion


	}
}

