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
	/// 实体类Vw_EduPlan_CSchedule 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_EduPlan_CSchedule")]
	[Serializable]
	public partial class Vw_EduPlan_CSchedule : Entity 
	{
		#region Model
		private int? _AtyID;
		private int? _TCID;
		private int? _PSID;
		private int? _CRID;
		private int? _DayOfWeek;
		private string _SectionTH;
		private string _State;
		private string _CCname;
		private string _PsName;
		private string _CRname;
		private string _TCName;
		private int? _StartW;
		private int? _EndW;
		private string _CLRSort;
		private int? _MaxStuNum;
		private string _RGName;
		private int? _PsNumber;
		private string _Sort;
		private string _RoomRGName;
		private string _DeptCode;
		private string _ExminSort;
		private int? _CCID;
		private int? _EMID;
		private int? _TermID;
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
		public int? DayOfWeek
		{
			get{ return _DayOfWeek; }
			set
			{
				this.OnPropertyValueChange(_.DayOfWeek,_DayOfWeek,value);
				this._DayOfWeek=value;
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
		public int? StartW
		{
			get{ return _StartW; }
			set
			{
				this.OnPropertyValueChange(_.StartW,_StartW,value);
				this._StartW=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EndW
		{
			get{ return _EndW; }
			set
			{
				this.OnPropertyValueChange(_.EndW,_EndW,value);
				this._EndW=value;
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
		public string RGName
		{
			get{ return _RGName; }
			set
			{
				this.OnPropertyValueChange(_.RGName,_RGName,value);
				this._RGName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PsNumber
		{
			get{ return _PsNumber; }
			set
			{
				this.OnPropertyValueChange(_.PsNumber,_PsNumber,value);
				this._PsNumber=value;
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
		public string RoomRGName
		{
			get{ return _RoomRGName; }
			set
			{
				this.OnPropertyValueChange(_.RoomRGName,_RoomRGName,value);
				this._RoomRGName=value;
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
		public int? TermID
		{
			get{ return _TermID; }
			set
			{
				this.OnPropertyValueChange(_.TermID,_TermID,value);
				this._TermID=value;
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
				_.AtyID,
				_.TCID,
				_.PSID,
				_.CRID,
				_.DayOfWeek,
				_.SectionTH,
				_.State,
				_.CCname,
				_.PsName,
				_.CRname,
				_.TCName,
				_.StartW,
				_.EndW,
				_.CLRSort,
				_.MaxStuNum,
				_.RGName,
				_.PsNumber,
				_.Sort,
				_.RoomRGName,
				_.DeptCode,
				_.ExminSort,
				_.CCID,
				_.EMID,
				_.TermID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._AtyID,
				this._TCID,
				this._PSID,
				this._CRID,
				this._DayOfWeek,
				this._SectionTH,
				this._State,
				this._CCname,
				this._PsName,
				this._CRname,
				this._TCName,
				this._StartW,
				this._EndW,
				this._CLRSort,
				this._MaxStuNum,
				this._RGName,
				this._PsNumber,
				this._Sort,
				this._RoomRGName,
				this._DeptCode,
				this._ExminSort,
				this._CCID,
				this._EMID,
				this._TermID};
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
			public readonly static Field All = new Field("*","vw_EduPlan_CSchedule");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","vw_EduPlan_CSchedule","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","vw_EduPlan_CSchedule","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","vw_EduPlan_CSchedule","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRID = new Field("CRID","vw_EduPlan_CSchedule","CRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DayOfWeek = new Field("DayOfWeek","vw_EduPlan_CSchedule","DayOfWeek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SectionTH = new Field("SectionTH","vw_EduPlan_CSchedule","SectionTH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","vw_EduPlan_CSchedule","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_EduPlan_CSchedule","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PsName = new Field("PsName","vw_EduPlan_CSchedule","PsName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRname = new Field("CRname","vw_EduPlan_CSchedule","CRname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCName = new Field("TCName","vw_EduPlan_CSchedule","TCName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartW = new Field("StartW","vw_EduPlan_CSchedule","StartW");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EndW = new Field("EndW","vw_EduPlan_CSchedule","EndW");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLRSort = new Field("CLRSort","vw_EduPlan_CSchedule","CLRSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MaxStuNum = new Field("MaxStuNum","vw_EduPlan_CSchedule","MaxStuNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGName = new Field("RGName","vw_EduPlan_CSchedule","RGName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PsNumber = new Field("PsNumber","vw_EduPlan_CSchedule","PsNumber");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","vw_EduPlan_CSchedule","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RoomRGName = new Field("RoomRGName","vw_EduPlan_CSchedule","RoomRGName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","vw_EduPlan_CSchedule","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExminSort = new Field("ExminSort","vw_EduPlan_CSchedule","ExminSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_EduPlan_CSchedule","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","vw_EduPlan_CSchedule","EMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TermID = new Field("TermID","vw_EduPlan_CSchedule","TermID");
		}
		#endregion


	}
}

