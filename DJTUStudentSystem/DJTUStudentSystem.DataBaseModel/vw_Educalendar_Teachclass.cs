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
	/// 实体类Vw_Educalendar_Teachclass 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Educalendar_Teachclass")]
	[Serializable]
	public partial class Vw_Educalendar_Teachclass : Entity 
	{
		#region Model
		private string _教学班级名称;
		private string _课程名称;
		private string _编码;
		private string _当前学期;
		private string _任课教师;
		private string _Minor;
		private int? _ActYear;
		private string _DeptCode;
		private string _DeptName;
		private int? _CCID;
		private int? _TCHID;
		private int _TCID;
		private string _State;
		private int? _ECMID;
		private int? _DNUm;
		private int? _AtyID;
		private int? _PSID;
		private string _NeedCalendar;
		private string _NeedPJ;
		private string _Ctype;
		private string _Grade;
		/// <summary>
		/// 
		/// </summary>
		public string 教学班级名称
		{
			get{ return _教学班级名称; }
			set
			{
				this.OnPropertyValueChange(_.教学班级名称,_教学班级名称,value);
				this._教学班级名称=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 课程名称
		{
			get{ return _课程名称; }
			set
			{
				this.OnPropertyValueChange(_.课程名称,_课程名称,value);
				this._课程名称=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 编码
		{
			get{ return _编码; }
			set
			{
				this.OnPropertyValueChange(_.编码,_编码,value);
				this._编码=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 当前学期
		{
			get{ return _当前学期; }
			set
			{
				this.OnPropertyValueChange(_.当前学期,_当前学期,value);
				this._当前学期=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 任课教师
		{
			get{ return _任课教师; }
			set
			{
				this.OnPropertyValueChange(_.任课教师,_任课教师,value);
				this._任课教师=value;
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
		public string DeptName
		{
			get{ return _DeptName; }
			set
			{
				this.OnPropertyValueChange(_.DeptName,_DeptName,value);
				this._DeptName=value;
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
		public int? ECMID
		{
			get{ return _ECMID; }
			set
			{
				this.OnPropertyValueChange(_.ECMID,_ECMID,value);
				this._ECMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DNUm
		{
			get{ return _DNUm; }
			set
			{
				this.OnPropertyValueChange(_.DNUm,_DNUm,value);
				this._DNUm=value;
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
		public string Grade
		{
			get{ return _Grade; }
			set
			{
				this.OnPropertyValueChange(_.Grade,_Grade,value);
				this._Grade=value;
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
				_.教学班级名称,
				_.课程名称,
				_.编码,
				_.当前学期,
				_.任课教师,
				_.Minor,
				_.ActYear,
				_.DeptCode,
				_.DeptName,
				_.CCID,
				_.TCHID,
				_.TCID,
				_.State,
				_.ECMID,
				_.DNUm,
				_.AtyID,
				_.PSID,
				_.NeedCalendar,
				_.NeedPJ,
				_.Ctype,
				_.Grade};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._教学班级名称,
				this._课程名称,
				this._编码,
				this._当前学期,
				this._任课教师,
				this._Minor,
				this._ActYear,
				this._DeptCode,
				this._DeptName,
				this._CCID,
				this._TCHID,
				this._TCID,
				this._State,
				this._ECMID,
				this._DNUm,
				this._AtyID,
				this._PSID,
				this._NeedCalendar,
				this._NeedPJ,
				this._Ctype,
				this._Grade};
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
			public readonly static Field All = new Field("*","vw_Educalendar_Teachclass");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 教学班级名称 = new Field("教学班级名称","vw_Educalendar_Teachclass","教学班级名称");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 课程名称 = new Field("课程名称","vw_Educalendar_Teachclass","课程名称");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 编码 = new Field("编码","vw_Educalendar_Teachclass","编码");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 当前学期 = new Field("当前学期","vw_Educalendar_Teachclass","当前学期");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 任课教师 = new Field("任课教师","vw_Educalendar_Teachclass","任课教师");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Minor = new Field("Minor","vw_Educalendar_Teachclass","Minor");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ActYear = new Field("ActYear","vw_Educalendar_Teachclass","ActYear");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","vw_Educalendar_Teachclass","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName","vw_Educalendar_Teachclass","DeptName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_Educalendar_Teachclass","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCHID = new Field("TCHID","vw_Educalendar_Teachclass","TCHID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","vw_Educalendar_Teachclass","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","vw_Educalendar_Teachclass","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ECMID = new Field("ECMID","vw_Educalendar_Teachclass","ECMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DNUm = new Field("DNUm","vw_Educalendar_Teachclass","DNUm");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","vw_Educalendar_Teachclass","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","vw_Educalendar_Teachclass","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NeedCalendar = new Field("NeedCalendar","vw_Educalendar_Teachclass","NeedCalendar");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NeedPJ = new Field("NeedPJ","vw_Educalendar_Teachclass","NeedPJ");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Ctype = new Field("ctype","vw_Educalendar_Teachclass","ctype");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Grade = new Field("Grade","vw_Educalendar_Teachclass","Grade");
		}
		#endregion


	}
}

