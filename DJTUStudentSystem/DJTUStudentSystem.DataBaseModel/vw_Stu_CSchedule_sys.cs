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
	/// 实体类Vw_Stu_CSchedule_sys 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Stu_CSchedule_sys")]
	[Serializable]
	public partial class Vw_Stu_CSchedule_sys : Entity 
	{
		#region Model
		private int? _TCID;
		private int? _StuID;
		private int? _StartW;
		private int? _EndW;
		private int? _DayOfWeek;
		private string _SectionTH;
		private int? _AtyID;
		private int? _CCID;
		private int? _CRID;
		private string _DSZ;
		private string _Mark;
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
		public int? StuID
		{
			get{ return _StuID; }
			set
			{
				this.OnPropertyValueChange(_.StuID,_StuID,value);
				this._StuID=value;
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
		public string DSZ
		{
			get{ return _DSZ; }
			set
			{
				this.OnPropertyValueChange(_.DSZ,_DSZ,value);
				this._DSZ=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mark
		{
			get{ return _Mark; }
			set
			{
				this.OnPropertyValueChange(_.Mark,_Mark,value);
				this._Mark=value;
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
				_.TCID,
				_.StuID,
				_.StartW,
				_.EndW,
				_.DayOfWeek,
				_.SectionTH,
				_.AtyID,
				_.CCID,
				_.CRID,
				_.DSZ,
				_.Mark};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TCID,
				this._StuID,
				this._StartW,
				this._EndW,
				this._DayOfWeek,
				this._SectionTH,
				this._AtyID,
				this._CCID,
				this._CRID,
				this._DSZ,
				this._Mark};
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
			public readonly static Field All = new Field("*","vw_Stu_CSchedule_sys");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","vw_Stu_CSchedule_sys","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StuID = new Field("StuID","vw_Stu_CSchedule_sys","StuID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartW = new Field("StartW","vw_Stu_CSchedule_sys","StartW");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EndW = new Field("EndW","vw_Stu_CSchedule_sys","EndW");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DayOfWeek = new Field("DayOfWeek","vw_Stu_CSchedule_sys","DayOfWeek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SectionTH = new Field("SectionTH","vw_Stu_CSchedule_sys","SectionTH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","vw_Stu_CSchedule_sys","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_Stu_CSchedule_sys","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRID = new Field("CRID","vw_Stu_CSchedule_sys","CRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DSZ = new Field("DSZ","vw_Stu_CSchedule_sys","DSZ");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Mark = new Field("Mark","vw_Stu_CSchedule_sys","Mark");
		}
		#endregion


	}
}

