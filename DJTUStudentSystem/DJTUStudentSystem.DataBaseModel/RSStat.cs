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
	/// 实体类RSStat 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("RSStat")]
	[Serializable]
	public partial class RSStat : Entity 
	{
		#region Model
		private int _RSID;
		private int? _ATYID;
		private int? _CCID;
		private string _LEV;
		private int? _Per;
		private int? _TotalPer;
		private decimal? _RPer;
		private int? _KeyS;
		private int? _KeyN;
		private int? _Point;
		/// <summary>
		/// 
		/// </summary>
		public int RSID
		{
			get{ return _RSID; }
			set
			{
				this.OnPropertyValueChange(_.RSID,_RSID,value);
				this._RSID=value;
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
		public string LEV
		{
			get{ return _LEV; }
			set
			{
				this.OnPropertyValueChange(_.LEV,_LEV,value);
				this._LEV=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Per
		{
			get{ return _Per; }
			set
			{
				this.OnPropertyValueChange(_.Per,_Per,value);
				this._Per=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TotalPer
		{
			get{ return _TotalPer; }
			set
			{
				this.OnPropertyValueChange(_.TotalPer,_TotalPer,value);
				this._TotalPer=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? RPer
		{
			get{ return _RPer; }
			set
			{
				this.OnPropertyValueChange(_.RPer,_RPer,value);
				this._RPer=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? KeyS
		{
			get{ return _KeyS; }
			set
			{
				this.OnPropertyValueChange(_.KeyS,_KeyS,value);
				this._KeyS=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? KeyN
		{
			get{ return _KeyN; }
			set
			{
				this.OnPropertyValueChange(_.KeyN,_KeyN,value);
				this._KeyN=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Point
		{
			get{ return _Point; }
			set
			{
				this.OnPropertyValueChange(_.Point,_Point,value);
				this._Point=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.RSID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.RSID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.RSID,
				_.ATYID,
				_.CCID,
				_.LEV,
				_.Per,
				_.TotalPer,
				_.RPer,
				_.KeyS,
				_.KeyN,
				_.Point};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._RSID,
				this._ATYID,
				this._CCID,
				this._LEV,
				this._Per,
				this._TotalPer,
				this._RPer,
				this._KeyS,
				this._KeyN,
				this._Point};
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
			public readonly static Field All = new Field("*","RSStat");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RSID = new Field("RSID","RSStat","RSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATYID = new Field("ATYID","RSStat","ATYID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","RSStat","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LEV = new Field("LEV","RSStat","LEV");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Per = new Field("Per","RSStat","Per");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TotalPer = new Field("TotalPer","RSStat","TotalPer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RPer = new Field("RPer","RSStat","RPer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KeyS = new Field("KeyS","RSStat","KeyS");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KeyN = new Field("KeyN","RSStat","KeyN");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Point = new Field("Point","RSStat","Point");
		}
		#endregion


	}
}

