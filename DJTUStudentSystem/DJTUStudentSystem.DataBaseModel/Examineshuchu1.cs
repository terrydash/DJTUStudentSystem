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
	/// 实体类Examineshuchu1 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Examineshuchu1")]
	[Serializable]
	public partial class Examineshuchu1 : Entity 
	{
		#region Model
		private string _姓名;
		private string _身份证号;
		private string _性别;
		private int? _CLassID;
		private string _EMName;
		private string _备注;
		/// <summary>
		/// 
		/// </summary>
		public string 姓名
		{
			get{ return _姓名; }
			set
			{
				this.OnPropertyValueChange(_.姓名,_姓名,value);
				this._姓名=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 身份证号
		{
			get{ return _身份证号; }
			set
			{
				this.OnPropertyValueChange(_.身份证号,_身份证号,value);
				this._身份证号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 性别
		{
			get{ return _性别; }
			set
			{
				this.OnPropertyValueChange(_.性别,_性别,value);
				this._性别=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CLassID
		{
			get{ return _CLassID; }
			set
			{
				this.OnPropertyValueChange(_.CLassID,_CLassID,value);
				this._CLassID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMName
		{
			get{ return _EMName; }
			set
			{
				this.OnPropertyValueChange(_.EMName,_EMName,value);
				this._EMName=value;
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
		#endregion

		#region Method
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.姓名,
				_.身份证号,
				_.性别,
				_.CLassID,
				_.EMName,
				_.备注};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._姓名,
				this._身份证号,
				this._性别,
				this._CLassID,
				this._EMName,
				this._备注};
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
			public readonly static Field All = new Field("*","Examineshuchu1");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 姓名 = new Field("姓名","Examineshuchu1","姓名");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 身份证号 = new Field("身份证号","Examineshuchu1","身份证号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 性别 = new Field("性别","Examineshuchu1","性别");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLassID = new Field("CLassID","Examineshuchu1","CLassID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EMName = new Field("EMName","Examineshuchu1","EMName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 备注 = new Field("备注","Examineshuchu1","备注");
		}
		#endregion


	}
}
