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
	/// 实体类Vw_Tutor_Count_By_Teacher 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Tutor_Count_By_Teacher")]
	[Serializable]
	public partial class Vw_Tutor_Count_By_Teacher : Entity 
	{
		#region Model
		private int? _Nums;
		private int? _Psid;
		private string _Froms;
		/// <summary>
		/// 
		/// </summary>
		public int? Nums
		{
			get{ return _Nums; }
			set
			{
				this.OnPropertyValueChange(_.Nums,_Nums,value);
				this._Nums=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Psid
		{
			get{ return _Psid; }
			set
			{
				this.OnPropertyValueChange(_.Psid,_Psid,value);
				this._Psid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Froms
		{
			get{ return _Froms; }
			set
			{
				this.OnPropertyValueChange(_.Froms,_Froms,value);
				this._Froms=value;
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
				_.Nums,
				_.Psid,
				_.Froms};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Nums,
				this._Psid,
				this._Froms};
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
			public readonly static Field All = new Field("*","vw_Tutor_Count_By_Teacher");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Nums = new Field("Nums","vw_Tutor_Count_By_Teacher","Nums");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Psid = new Field("psid","vw_Tutor_Count_By_Teacher","psid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Froms = new Field("Froms","vw_Tutor_Count_By_Teacher","Froms");
		}
		#endregion


	}
}

