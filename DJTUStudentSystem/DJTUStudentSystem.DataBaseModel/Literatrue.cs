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
	/// 实体类Literatrue 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Literatrue")]
	[Serializable]
	public partial class Literatrue : Entity 
	{
		#region Model
		private int _LID;
		private string _Sort;
		private string _IfGvieMoney;
		private int? _Source;
		/// <summary>
		/// 
		/// </summary>
		public int LID
		{
			get{ return _LID; }
			set
			{
				this.OnPropertyValueChange(_.LID,_LID,value);
				this._LID=value;
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
		public string IfGvieMoney
		{
			get{ return _IfGvieMoney; }
			set
			{
				this.OnPropertyValueChange(_.IfGvieMoney,_IfGvieMoney,value);
				this._IfGvieMoney=value;
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
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.LID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.LID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.LID,
				_.Sort,
				_.IfGvieMoney,
				_.Source};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._LID,
				this._Sort,
				this._IfGvieMoney,
				this._Source};
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
			public readonly static Field All = new Field("*","Literatrue");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LID = new Field("LID","Literatrue","LID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","Literatrue","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IfGvieMoney = new Field("IfGvieMoney","Literatrue","IfGvieMoney");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Source = new Field("Source","Literatrue","Source");
		}
		#endregion


	}
}

