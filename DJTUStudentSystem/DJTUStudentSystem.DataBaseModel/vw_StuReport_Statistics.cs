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
	/// 实体类Vw_StuReport_Statistics 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_StuReport_Statistics")]
	[Serializable]
	public partial class Vw_StuReport_Statistics : Entity 
	{
		#region Model
		private decimal? _Source;
		private int? _Numbers;
		private decimal? _SourceA;
		private decimal? _Point;
		private int? _TCID;
		/// <summary>
		/// 
		/// </summary>
		public decimal? Source
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
		public int? Numbers
		{
			get{ return _Numbers; }
			set
			{
				this.OnPropertyValueChange(_.Numbers,_Numbers,value);
				this._Numbers=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SourceA
		{
			get{ return _SourceA; }
			set
			{
				this.OnPropertyValueChange(_.SourceA,_SourceA,value);
				this._SourceA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Point
		{
			get{ return _Point; }
			set
			{
				this.OnPropertyValueChange(_.Point,_Point,value);
				this._Point=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TCID
		{
			get{ return _TCID; }
			set
			{
				this.OnPropertyValueChange(_.TCID,_TCID,value);
				this._TCID=value;
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
				_.Source,
				_.Numbers,
				_.SourceA,
				_.Point,
				_.TCID};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Source,
				this._Numbers,
				this._SourceA,
				this._Point,
				this._TCID};
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
			public readonly static Field All = new Field("*","vw_StuReport_Statistics");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Source = new Field("Source","vw_StuReport_Statistics","Source");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Numbers = new Field("Numbers","vw_StuReport_Statistics","Numbers");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SourceA = new Field("SourceA","vw_StuReport_Statistics","SourceA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Point = new Field("Point","vw_StuReport_Statistics","Point");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","vw_StuReport_Statistics","TCID");
		}
		#endregion


	}
}
