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
	/// 实体类Vw_TeacherToClass 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_TeacherToClass")]
	[Serializable]
	public partial class Vw_TeacherToClass : Entity 
	{
		#region Model
		private int _TPID;
		private int? _AtyID;
		private int? _PSID;
		private int? _DeptID;
		private int? _Tectitle;
		private int? _Duty;
		private int? _StuNum;
		private int? _Period;
		private string _姓名;
		private string _学历;
		private string _学位;
		private string _职称;
		private string _职务;
		private string _系部名称;
		private string _系部编码;
		private string _学期;
		/// <summary>
		/// 
		/// </summary>
		public int TPID
		{
			get{ return _TPID; }
			set
			{
				this.OnPropertyValueChange(_.TPID,_TPID,value);
				this._TPID=value;
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
		public int? DeptID
		{
			get{ return _DeptID; }
			set
			{
				this.OnPropertyValueChange(_.DeptID,_DeptID,value);
				this._DeptID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Tectitle
		{
			get{ return _Tectitle; }
			set
			{
				this.OnPropertyValueChange(_.Tectitle,_Tectitle,value);
				this._Tectitle=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Duty
		{
			get{ return _Duty; }
			set
			{
				this.OnPropertyValueChange(_.Duty,_Duty,value);
				this._Duty=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StuNum
		{
			get{ return _StuNum; }
			set
			{
				this.OnPropertyValueChange(_.StuNum,_StuNum,value);
				this._StuNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Period
		{
			get{ return _Period; }
			set
			{
				this.OnPropertyValueChange(_.Period,_Period,value);
				this._Period=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 姓名
		{
			get{ return _姓名; }
			set
			{
				this.OnPropertyValueChange(_.姓名,_姓名,value);
				this._姓名=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学历
		{
			get{ return _学历; }
			set
			{
				this.OnPropertyValueChange(_.学历,_学历,value);
				this._学历=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学位
		{
			get{ return _学位; }
			set
			{
				this.OnPropertyValueChange(_.学位,_学位,value);
				this._学位=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 职称
		{
			get{ return _职称; }
			set
			{
				this.OnPropertyValueChange(_.职称,_职称,value);
				this._职称=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 职务
		{
			get{ return _职务; }
			set
			{
				this.OnPropertyValueChange(_.职务,_职务,value);
				this._职务=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 系部名称
		{
			get{ return _系部名称; }
			set
			{
				this.OnPropertyValueChange(_.系部名称,_系部名称,value);
				this._系部名称=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 系部编码
		{
			get{ return _系部编码; }
			set
			{
				this.OnPropertyValueChange(_.系部编码,_系部编码,value);
				this._系部编码=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学期
		{
			get{ return _学期; }
			set
			{
				this.OnPropertyValueChange(_.学期,_学期,value);
				this._学期=value;
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
				_.TPID,
				_.AtyID,
				_.PSID,
				_.DeptID,
				_.Tectitle,
				_.Duty,
				_.StuNum,
				_.Period,
				_.姓名,
				_.学历,
				_.学位,
				_.职称,
				_.职务,
				_.系部名称,
				_.系部编码,
				_.学期};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TPID,
				this._AtyID,
				this._PSID,
				this._DeptID,
				this._Tectitle,
				this._Duty,
				this._StuNum,
				this._Period,
				this._姓名,
				this._学历,
				this._学位,
				this._职称,
				this._职务,
				this._系部名称,
				this._系部编码,
				this._学期};
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
			public readonly static Field All = new Field("*","vw_TeacherToClass");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TPID = new Field("TPID","vw_TeacherToClass","TPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","vw_TeacherToClass","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","vw_TeacherToClass","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","vw_TeacherToClass","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Tectitle = new Field("Tectitle","vw_TeacherToClass","Tectitle");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Duty = new Field("Duty","vw_TeacherToClass","Duty");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StuNum = new Field("StuNum","vw_TeacherToClass","StuNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Period = new Field("Period","vw_TeacherToClass","Period");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 姓名 = new Field("姓名","vw_TeacherToClass","姓名");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学历 = new Field("学历","vw_TeacherToClass","学历");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学位 = new Field("学位","vw_TeacherToClass","学位");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 职称 = new Field("职称","vw_TeacherToClass","职称");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 职务 = new Field("职务","vw_TeacherToClass","职务");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 系部名称 = new Field("系部名称","vw_TeacherToClass","系部名称");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 系部编码 = new Field("系部编码","vw_TeacherToClass","系部编码");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学期 = new Field("学期","vw_TeacherToClass","学期");
		}
		#endregion


	}
}

