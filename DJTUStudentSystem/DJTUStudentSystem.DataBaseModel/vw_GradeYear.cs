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
	/// 实体类Vw_GradeYear 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_GradeYear")]
	[Serializable]
	public partial class Vw_GradeYear : Entity 
	{
		#region Model
		private string _年级;
		private string _学期名称;
		private string _学期;
		private int? _周数;
		private string _备注;
		private int _序号;
		private int? _TMID;
		private int? _ATYID;
		private int? _GRID;
		private string _XKstate;
		private string _GRNo;
		private string _State;
		private string _PKstate;
		private string _Gxkstate;
		private int? _YearName;
		private int? _ATNo;
		private string _GRstate;
		private int? _Weeks;
		/// <summary>
		/// 
		/// </summary>
		public string 年级
		{
			get{ return _年级; }
			set
			{
				this.OnPropertyValueChange(_.年级,_年级,value);
				this._年级=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学期名称
		{
			get{ return _学期名称; }
			set
			{
				this.OnPropertyValueChange(_.学期名称,_学期名称,value);
				this._学期名称=value;
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
		/// <summary>
		/// 
		/// </summary>
		public int? 周数
		{
			get{ return _周数; }
			set
			{
				this.OnPropertyValueChange(_.周数,_周数,value);
				this._周数=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 备注
		{
			get{ return _备注; }
			set
			{
				this.OnPropertyValueChange(_.备注,_备注,value);
				this._备注=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int 序号
		{
			get{ return _序号; }
			set
			{
				this.OnPropertyValueChange(_.序号,_序号,value);
				this._序号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TMID
		{
			get{ return _TMID; }
			set
			{
				this.OnPropertyValueChange(_.TMID,_TMID,value);
				this._TMID=value;
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
		public int? GRID
		{
			get{ return _GRID; }
			set
			{
				this.OnPropertyValueChange(_.GRID,_GRID,value);
				this._GRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XKstate
		{
			get{ return _XKstate; }
			set
			{
				this.OnPropertyValueChange(_.XKstate,_XKstate,value);
				this._XKstate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GRNo
		{
			get{ return _GRNo; }
			set
			{
				this.OnPropertyValueChange(_.GRNo,_GRNo,value);
				this._GRNo=value;
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
		public string PKstate
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
		public string Gxkstate
		{
			get{ return _Gxkstate; }
			set
			{
				this.OnPropertyValueChange(_.Gxkstate,_Gxkstate,value);
				this._Gxkstate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? YearName
		{
			get{ return _YearName; }
			set
			{
				this.OnPropertyValueChange(_.YearName,_YearName,value);
				this._YearName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ATNo
		{
			get{ return _ATNo; }
			set
			{
				this.OnPropertyValueChange(_.ATNo,_ATNo,value);
				this._ATNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GRstate
		{
			get{ return _GRstate; }
			set
			{
				this.OnPropertyValueChange(_.GRstate,_GRstate,value);
				this._GRstate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Weeks
		{
			get{ return _Weeks; }
			set
			{
				this.OnPropertyValueChange(_.Weeks,_Weeks,value);
				this._Weeks=value;
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
				_.年级,
				_.学期名称,
				_.学期,
				_.周数,
				_.备注,
				_.序号,
				_.TMID,
				_.ATYID,
				_.GRID,
				_.XKstate,
				_.GRNo,
				_.State,
				_.PKstate,
				_.Gxkstate,
				_.YearName,
				_.ATNo,
				_.GRstate,
				_.Weeks};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._年级,
				this._学期名称,
				this._学期,
				this._周数,
				this._备注,
				this._序号,
				this._TMID,
				this._ATYID,
				this._GRID,
				this._XKstate,
				this._GRNo,
				this._State,
				this._PKstate,
				this._Gxkstate,
				this._YearName,
				this._ATNo,
				this._GRstate,
				this._Weeks};
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
			public readonly static Field All = new Field("*","vw_GradeYear");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 年级 = new Field("年级","vw_GradeYear","年级");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学期名称 = new Field("学期名称","vw_GradeYear","学期名称");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学期 = new Field("学期","vw_GradeYear","学期");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 周数 = new Field("周数","vw_GradeYear","周数");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 备注 = new Field("备注","vw_GradeYear","备注");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 序号 = new Field("序号","vw_GradeYear","序号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TMID = new Field("TMID","vw_GradeYear","TMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATYID = new Field("ATYID","vw_GradeYear","ATYID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","vw_GradeYear","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field XKstate = new Field("XKstate","vw_GradeYear","XKstate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRNo = new Field("GRNo","vw_GradeYear","GRNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","vw_GradeYear","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PKstate = new Field("PKstate","vw_GradeYear","PKstate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Gxkstate = new Field("Gxkstate","vw_GradeYear","Gxkstate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field YearName = new Field("YearName","vw_GradeYear","YearName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATNo = new Field("ATNo","vw_GradeYear","ATNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRstate = new Field("GRstate","vw_GradeYear","GRstate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Weeks = new Field("Weeks","vw_GradeYear","Weeks");
		}
		#endregion


	}
}

