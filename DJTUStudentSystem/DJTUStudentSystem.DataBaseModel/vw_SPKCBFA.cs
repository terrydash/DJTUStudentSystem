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
	/// 实体类Vw_SPKCBFA 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_SPKCBFA")]
	[Serializable]
	public partial class Vw_SPKCBFA : Entity 
	{
		#region Model
		private string _FAName;
		private int? _SPID;
		private int? _GRID;
		private int? _FAXH;
		private string _GRName;
		private int? _AtyID;
		/// <summary>
		/// 
		/// </summary>
		public string FAName
		{
			get{ return _FAName; }
			set
			{
				this.OnPropertyValueChange(_.FAName,_FAName,value);
				this._FAName=value;
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
		public int? AtyID
		{
			get{ return _AtyID; }
			set
			{
				this.OnPropertyValueChange(_.AtyID,_AtyID,value);
				this._AtyID=value;
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
				_.FAName,
				_.SPID,
				_.GRID,
				_.FAXH,
				_.GRName,
				_.AtyID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._FAName,
				this._SPID,
				this._GRID,
				this._FAXH,
				this._GRName,
				this._AtyID};
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
			public readonly static Field All = new Field("*","vw_SPKCBFA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAName = new Field("FAName","vw_SPKCBFA","FAName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_SPKCBFA","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","vw_SPKCBFA","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAXH = new Field("FAXH","vw_SPKCBFA","FAXH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_SPKCBFA","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","vw_SPKCBFA","AtyID");
		}
		#endregion


	}
}

