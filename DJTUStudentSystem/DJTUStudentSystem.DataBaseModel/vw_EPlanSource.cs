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
	/// 实体类Vw_EPlanSource 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_EPlanSource")]
	[Serializable]
	public partial class Vw_EPlanSource : Entity 
	{
		#region Model
		private string _GRName;
		private string _SPName;
		private string _CScode;
		private string _CSName;
		private string _BX;
		private int? _Source;
		private decimal? _NeedSource;
		private decimal? _Scale;
		private int _EPSID;
		private int? _SPID;
		private int? _GRID;
		private int? _EMID;
		/// <summary>
		/// 
		/// </summary>
		public string GRName
		{
			get{ return _GRName; }
			set
			{
				this.OnPropertyValueChange(_.GRName,_GRName,value);
				this._GRName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPName
		{
			get{ return _SPName; }
			set
			{
				this.OnPropertyValueChange(_.SPName,_SPName,value);
				this._SPName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CScode
		{
			get{ return _CScode; }
			set
			{
				this.OnPropertyValueChange(_.CScode,_CScode,value);
				this._CScode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CSName
		{
			get{ return _CSName; }
			set
			{
				this.OnPropertyValueChange(_.CSName,_CSName,value);
				this._CSName=value;
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
		public int? Source
		{
			get{ return _Source; }
			set
			{
				this.OnPropertyValueChange(_.Source,_Source,value);
				this._Source=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? NeedSource
		{
			get{ return _NeedSource; }
			set
			{
				this.OnPropertyValueChange(_.NeedSource,_NeedSource,value);
				this._NeedSource=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Scale
		{
			get{ return _Scale; }
			set
			{
				this.OnPropertyValueChange(_.Scale,_Scale,value);
				this._Scale=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int EPSID
		{
			get{ return _EPSID; }
			set
			{
				this.OnPropertyValueChange(_.EPSID,_EPSID,value);
				this._EPSID=value;
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
		public int? EMID
		{
			get{ return _EMID; }
			set
			{
				this.OnPropertyValueChange(_.EMID,_EMID,value);
				this._EMID=value;
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
				_.GRName,
				_.SPName,
				_.CScode,
				_.CSName,
				_.BX,
				_.Source,
				_.NeedSource,
				_.Scale,
				_.EPSID,
				_.SPID,
				_.GRID,
				_.EMID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._GRName,
				this._SPName,
				this._CScode,
				this._CSName,
				this._BX,
				this._Source,
				this._NeedSource,
				this._Scale,
				this._EPSID,
				this._SPID,
				this._GRID,
				this._EMID};
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
			public readonly static Field All = new Field("*","vw_EPlanSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_EPlanSource","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPName = new Field("SPName","vw_EPlanSource","SPName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CScode = new Field("CScode","vw_EPlanSource","CScode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSName = new Field("CSName","vw_EPlanSource","CSName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BX = new Field("BX","vw_EPlanSource","BX");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Source = new Field("Source","vw_EPlanSource","Source");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NeedSource = new Field("NeedSource","vw_EPlanSource","NeedSource");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Scale = new Field("Scale","vw_EPlanSource","Scale");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPSID = new Field("EPSID","vw_EPlanSource","EPSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_EPlanSource","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","vw_EPlanSource","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMID = new Field("EMID","vw_EPlanSource","EMID");
		}
		#endregion


	}
}

