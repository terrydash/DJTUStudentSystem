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
	/// 实体类Vw_ChoseExamRoom 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_ChoseExamRoom")]
	[Serializable]
	public partial class Vw_ChoseExamRoom : Entity 
	{
		#region Model
		private int _CRID;
		private string _CRname;
		private string _Sort;
		private int _PsNumber;
		private string _BuildName;
		private string _Memo;
		/// <summary>
		/// 
		/// </summary>
		public int CRID
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
		public string CRname
		{
			get{ return _CRname; }
			set
			{
				this.OnPropertyValueChange(_.CRname,_CRname,value);
				this._CRname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sort
		{
			get{ return _Sort; }
			set
			{
				this.OnPropertyValueChange(_.Sort,_Sort,value);
				this._Sort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PsNumber
		{
			get{ return _PsNumber; }
			set
			{
				this.OnPropertyValueChange(_.PsNumber,_PsNumber,value);
				this._PsNumber=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BuildName
		{
			get{ return _BuildName; }
			set
			{
				this.OnPropertyValueChange(_.BuildName,_BuildName,value);
				this._BuildName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get{ return _Memo; }
			set
			{
				this.OnPropertyValueChange(_.Memo,_Memo,value);
				this._Memo=value;
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
				_.CRID,
				_.CRname,
				_.Sort,
				_.PsNumber,
				_.BuildName,
				_.Memo};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CRID,
				this._CRname,
				this._Sort,
				this._PsNumber,
				this._BuildName,
				this._Memo};
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
			public readonly static Field All = new Field("*","vw_ChoseExamRoom");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRID = new Field("CRID","vw_ChoseExamRoom","CRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CRname = new Field("CRname","vw_ChoseExamRoom","CRname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","vw_ChoseExamRoom","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PsNumber = new Field("PsNumber","vw_ChoseExamRoom","PsNumber");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BuildName = new Field("BuildName","vw_ChoseExamRoom","BuildName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","vw_ChoseExamRoom","Memo");
		}
		#endregion


	}
}
