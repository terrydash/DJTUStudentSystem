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
	/// 实体类Vw_StuEduPlan 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_StuEduPlan")]
	[Serializable]
	public partial class Vw_StuEduPlan : Entity 
	{
		#region Model
		private int _CCID;
		private string _CSort;
		private string _Direct;
		private int? _StdID;
		private int _SPID;
		private int _GRDID;
		private string _Importance;
		private string _IfCheck;
		private string _IfCheckBY;
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
		public int? StdID
		{
			get{ return _StdID; }
			set
			{
				this.OnPropertyValueChange(_.StdID,_StdID,value);
				this._StdID=value;
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
				_.CCID,
				_.CSort,
				_.Direct,
				_.StdID,
				_.SPID,
				_.GRDID,
				_.Importance,
				_.IfCheck,
				_.IfCheckBY};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CCID,
				this._CSort,
				this._Direct,
				this._StdID,
				this._SPID,
				this._GRDID,
				this._Importance,
				this._IfCheck,
				this._IfCheckBY};
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
			public readonly static Field All = new Field("*","vw_StuEduPlan");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_StuEduPlan","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSort = new Field("CSort","vw_StuEduPlan","CSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Direct = new Field("Direct","vw_StuEduPlan","Direct");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdID = new Field("StdID","vw_StuEduPlan","StdID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_StuEduPlan","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRDID = new Field("GRDID","vw_StuEduPlan","GRDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Importance = new Field("Importance","vw_StuEduPlan","Importance");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IfCheck = new Field("ifCheck","vw_StuEduPlan","ifCheck");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IfCheckBY = new Field("ifCheckBY","vw_StuEduPlan","ifCheckBY");
		}
		#endregion


	}
}

