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
	/// 实体类EduPlan 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("EduPlan")]
	[Serializable]
	public partial class EduPlan : Entity 
	{
		#region Model
		private int _EPID;
		private int? _EMID;
		private int? _ENo;
		private int _SPID;
		private int _GRDID;
		private int _CCID;
		private string _CSort;
		private string _Request;
		private int? _TermID;
		private int? _StartWeek;
		private int? _Endweek;
		private decimal? _PerOfWeek;
		private int? _StartB;
		private int? _EndB;
		private decimal? _PerWB;
		private string _Importance;
		private string _Direct;
		private string _ExamSort;
		private int? _CTID;
		private string _IfCheck;
		private string _IfCheckBY;
		private int? _ToDeptID;
		private int? _ToDeptIDB;
		private int? _HaveDG;
		private int? _EGID;
		private int? _EGSequ;
		private string _BX;
		private string _Tohigh;
		private DateTime? _Newdate;
		private DateTime? _Lastdate;
		private string _CSA;
		private string _OPer;
		/// <summary>
		/// 
		/// </summary>
		public int EPID
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
		public int? EMID
		{
			get{ return _EMID; }
			set
			{
				this.OnPropertyValueChange(_.EMID,_EMID,value);
				this._EMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ENo
		{
			get{ return _ENo; }
			set
			{
				this.OnPropertyValueChange(_.ENo,_ENo,value);
				this._ENo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SPID
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
		public int GRDID
		{
			get{ return _GRDID; }
			set
			{
				this.OnPropertyValueChange(_.GRDID,_GRDID,value);
				this._GRDID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CCID
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
		public string Request
		{
			get{ return _Request; }
			set
			{
				this.OnPropertyValueChange(_.Request,_Request,value);
				this._Request=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TermID
		{
			get{ return _TermID; }
			set
			{
				this.OnPropertyValueChange(_.TermID,_TermID,value);
				this._TermID=value;
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
		public int? Endweek
		{
			get{ return _Endweek; }
			set
			{
				this.OnPropertyValueChange(_.Endweek,_Endweek,value);
				this._Endweek=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PerOfWeek
		{
			get{ return _PerOfWeek; }
			set
			{
				this.OnPropertyValueChange(_.PerOfWeek,_PerOfWeek,value);
				this._PerOfWeek=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StartB
		{
			get{ return _StartB; }
			set
			{
				this.OnPropertyValueChange(_.StartB,_StartB,value);
				this._StartB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EndB
		{
			get{ return _EndB; }
			set
			{
				this.OnPropertyValueChange(_.EndB,_EndB,value);
				this._EndB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PerWB
		{
			get{ return _PerWB; }
			set
			{
				this.OnPropertyValueChange(_.PerWB,_PerWB,value);
				this._PerWB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Importance
		{
			get{ return _Importance; }
			set
			{
				this.OnPropertyValueChange(_.Importance,_Importance,value);
				this._Importance=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Direct
		{
			get{ return _Direct; }
			set
			{
				this.OnPropertyValueChange(_.Direct,_Direct,value);
				this._Direct=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExamSort
		{
			get{ return _ExamSort; }
			set
			{
				this.OnPropertyValueChange(_.ExamSort,_ExamSort,value);
				this._ExamSort=value;
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
		public string IfCheck
		{
			get{ return _IfCheck; }
			set
			{
				this.OnPropertyValueChange(_.IfCheck,_IfCheck,value);
				this._IfCheck=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IfCheckBY
		{
			get{ return _IfCheckBY; }
			set
			{
				this.OnPropertyValueChange(_.IfCheckBY,_IfCheckBY,value);
				this._IfCheckBY=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ToDeptID
		{
			get{ return _ToDeptID; }
			set
			{
				this.OnPropertyValueChange(_.ToDeptID,_ToDeptID,value);
				this._ToDeptID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ToDeptIDB
		{
			get{ return _ToDeptIDB; }
			set
			{
				this.OnPropertyValueChange(_.ToDeptIDB,_ToDeptIDB,value);
				this._ToDeptIDB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? HaveDG
		{
			get{ return _HaveDG; }
			set
			{
				this.OnPropertyValueChange(_.HaveDG,_HaveDG,value);
				this._HaveDG=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EGID
		{
			get{ return _EGID; }
			set
			{
				this.OnPropertyValueChange(_.EGID,_EGID,value);
				this._EGID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EGSequ
		{
			get{ return _EGSequ; }
			set
			{
				this.OnPropertyValueChange(_.EGSequ,_EGSequ,value);
				this._EGSequ=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BX
		{
			get{ return _BX; }
			set
			{
				this.OnPropertyValueChange(_.BX,_BX,value);
				this._BX=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tohigh
		{
			get{ return _Tohigh; }
			set
			{
				this.OnPropertyValueChange(_.Tohigh,_Tohigh,value);
				this._Tohigh=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Newdate
		{
			get{ return _Newdate; }
			set
			{
				this.OnPropertyValueChange(_.Newdate,_Newdate,value);
				this._Newdate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Lastdate
		{
			get{ return _Lastdate; }
			set
			{
				this.OnPropertyValueChange(_.Lastdate,_Lastdate,value);
				this._Lastdate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CSA
		{
			get{ return _CSA; }
			set
			{
				this.OnPropertyValueChange(_.CSA,_CSA,value);
				this._CSA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPer
		{
			get{ return _OPer; }
			set
			{
				this.OnPropertyValueChange(_.OPer,_OPer,value);
				this._OPer=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.EPID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.EPID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.EPID,
				_.EMID,
				_.ENo,
				_.SPID,
				_.GRDID,
				_.CCID,
				_.CSort,
				_.Request,
				_.TermID,
				_.StartWeek,
				_.Endweek,
				_.PerOfWeek,
				_.StartB,
				_.EndB,
				_.PerWB,
				_.Importance,
				_.Direct,
				_.ExamSort,
				_.CTID,
				_.IfCheck,
				_.IfCheckBY,
				_.ToDeptID,
				_.ToDeptIDB,
				_.HaveDG,
				_.EGID,
				_.EGSequ,
				_.BX,
				_.Tohigh,
				_.Newdate,
				_.Lastdate,
				_.CSA,
				_.OPer};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._EPID,
				this._EMID,
				this._ENo,
				this._SPID,
				this._GRDID,
				this._CCID,
				this._CSort,
				this._Request,
				this._TermID,
				this._StartWeek,
				this._Endweek,
				this._PerOfWeek,
				this._StartB,
				this._EndB,
				this._PerWB,
				this._Importance,
				this._Direct,
				this._ExamSort,
				this._CTID,
				this._IfCheck,
				this._IfCheckBY,
				this._ToDeptID,
				this._ToDeptIDB,
				this._HaveDG,
				this._EGID,
				this._EGSequ,
				this._BX,
				this._Tohigh,
				this._Newdate,
				this._Lastdate,
				this._CSA,
				this._OPer};
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
			public readonly static Field All = new Field("*","EduPlan");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPID = new Field("EPID","EduPlan","EPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","EduPlan","EMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ENo = new Field("ENo","EduPlan","ENo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","EduPlan","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRDID = new Field("GRDID","EduPlan","GRDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","EduPlan","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSort = new Field("CSort","EduPlan","CSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Request = new Field("Request","EduPlan","Request");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TermID = new Field("TermID","EduPlan","TermID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartWeek = new Field("StartWeek","EduPlan","StartWeek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Endweek = new Field("Endweek","EduPlan","Endweek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PerOfWeek = new Field("PerOfWeek","EduPlan","PerOfWeek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartB = new Field("StartB","EduPlan","StartB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EndB = new Field("EndB","EduPlan","EndB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PerWB = new Field("PerWB","EduPlan","PerWB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Importance = new Field("Importance","EduPlan","Importance");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Direct = new Field("Direct","EduPlan","Direct");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExamSort = new Field("ExamSort","EduPlan","ExamSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CTID = new Field("CTID","EduPlan","CTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IfCheck = new Field("ifCheck","EduPlan","ifCheck");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IfCheckBY = new Field("ifCheckBY","EduPlan","ifCheckBY");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ToDeptID = new Field("ToDeptID","EduPlan","ToDeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ToDeptIDB = new Field("ToDeptIDB","EduPlan","ToDeptIDB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HaveDG = new Field("HaveDG","EduPlan","HaveDG");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EGID = new Field("EGID","EduPlan","EGID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EGSequ = new Field("EGSequ","EduPlan","EGSequ");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BX = new Field("BX","EduPlan","BX");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Tohigh = new Field("Tohigh","EduPlan","Tohigh");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Newdate = new Field("Newdate","EduPlan","Newdate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Lastdate = new Field("Lastdate","EduPlan","Lastdate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSA = new Field("CSA","EduPlan","CSA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OPer = new Field("OPer","EduPlan","OPer");
		}
		#endregion


	}
}

