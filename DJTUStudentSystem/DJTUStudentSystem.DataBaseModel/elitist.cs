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
	/// 实体类Elitist 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("elitist")]
	[Serializable]
	public partial class Elitist : Entity 
	{
		#region Model
		private int _ELID;
		private int? _TMID;
		private int? _Deptid;
		private int? _GRID;
		private int? _Stdid;
		private int? _M90;
		private int? _M80;
		private int? _M70;
		private int? _M60;
		private int? _MBad;
		private decimal? _Amount;
		private int? _CNums;
		/// <summary>
		/// 
		/// </summary>
		public int ELID
		{
			get{ return _ELID; }
			set
			{
				this.OnPropertyValueChange(_.ELID,_ELID,value);
				this._ELID=value;
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
		public int? Deptid
		{
			get{ return _Deptid; }
			set
			{
				this.OnPropertyValueChange(_.Deptid,_Deptid,value);
				this._Deptid=value;
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
		public int? Stdid
		{
			get{ return _Stdid; }
			set
			{
				this.OnPropertyValueChange(_.Stdid,_Stdid,value);
				this._Stdid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? M90
		{
			get{ return _M90; }
			set
			{
				this.OnPropertyValueChange(_.M90,_M90,value);
				this._M90=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? M80
		{
			get{ return _M80; }
			set
			{
				this.OnPropertyValueChange(_.M80,_M80,value);
				this._M80=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? M70
		{
			get{ return _M70; }
			set
			{
				this.OnPropertyValueChange(_.M70,_M70,value);
				this._M70=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? M60
		{
			get{ return _M60; }
			set
			{
				this.OnPropertyValueChange(_.M60,_M60,value);
				this._M60=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MBad
		{
			get{ return _MBad; }
			set
			{
				this.OnPropertyValueChange(_.MBad,_MBad,value);
				this._MBad=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Amount
		{
			get{ return _Amount; }
			set
			{
				this.OnPropertyValueChange(_.Amount,_Amount,value);
				this._Amount=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CNums
		{
			get{ return _CNums; }
			set
			{
				this.OnPropertyValueChange(_.CNums,_CNums,value);
				this._CNums=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.ELID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.ELID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ELID,
				_.TMID,
				_.Deptid,
				_.GRID,
				_.Stdid,
				_.M90,
				_.M80,
				_.M70,
				_.M60,
				_.MBad,
				_.Amount,
				_.CNums};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ELID,
				this._TMID,
				this._Deptid,
				this._GRID,
				this._Stdid,
				this._M90,
				this._M80,
				this._M70,
				this._M60,
				this._MBad,
				this._Amount,
				this._CNums};
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
			public readonly static Field All = new Field("*","elitist");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ELID = new Field("ELID","elitist","ELID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TMID = new Field("TMID","elitist","TMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Deptid = new Field("deptid","elitist","deptid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","elitist","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("stdid","elitist","stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M90 = new Field("M90","elitist","M90");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M80 = new Field("M80","elitist","M80");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M70 = new Field("M70","elitist","M70");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field M60 = new Field("M60","elitist","M60");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MBad = new Field("MBad","elitist","MBad");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Amount = new Field("Amount","elitist","Amount");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CNums = new Field("CNums","elitist","CNums");
		}
		#endregion


	}
}
