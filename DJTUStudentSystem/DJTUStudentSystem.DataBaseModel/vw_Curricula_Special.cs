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
	/// 实体类Vw_Curricula_Special 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Curricula_Special")]
	[Serializable]
	public partial class Vw_Curricula_Special : Entity 
	{
		#region Model
		private int _CCID;
		private int? _TermID;
		private string _EPName;
		private int? _CTID;
		private string _Direct;
		private string _ExamSort;
		private string _GRName;
		private string _Importance;
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
		public int? TermID
		{
			get{ return _TermID; }
			set
			{
				this.OnPropertyValueChange(_.TermID,_TermID,value);
				this._TermID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EPName
		{
			get{ return _EPName; }
			set
			{
				this.OnPropertyValueChange(_.EPName,_EPName,value);
				this._EPName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CTID
		{
			get{ return _CTID; }
			set
			{
				this.OnPropertyValueChange(_.CTID,_CTID,value);
				this._CTID=value;
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
		public string ExamSort
		{
			get{ return _ExamSort; }
			set
			{
				this.OnPropertyValueChange(_.ExamSort,_ExamSort,value);
				this._ExamSort=value;
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
		public string Importance
		{
			get{ return _Importance; }
			set
			{
				this.OnPropertyValueChange(_.Importance,_Importance,value);
				this._Importance=value;
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
				_.TermID,
				_.EPName,
				_.CTID,
				_.Direct,
				_.ExamSort,
				_.GRName,
				_.Importance};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CCID,
				this._TermID,
				this._EPName,
				this._CTID,
				this._Direct,
				this._ExamSort,
				this._GRName,
				this._Importance};
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
			public readonly static Field All = new Field("*","vw_Curricula_Special");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_Curricula_Special","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TermID = new Field("TermID","vw_Curricula_Special","TermID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EPName = new Field("EPName","vw_Curricula_Special","EPName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CTID = new Field("CTID","vw_Curricula_Special","CTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Direct = new Field("Direct","vw_Curricula_Special","Direct");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ExamSort = new Field("ExamSort","vw_Curricula_Special","ExamSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_Curricula_Special","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Importance = new Field("Importance","vw_Curricula_Special","Importance");
		}
		#endregion


	}
}

