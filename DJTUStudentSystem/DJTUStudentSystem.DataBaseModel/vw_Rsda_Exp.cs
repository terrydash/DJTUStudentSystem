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
	/// 实体类Vw_Rsda_Exp 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Rsda_Exp")]
	[Serializable]
	public partial class Vw_Rsda_Exp : Entity 
	{
		#region Model
		private int _PSID;
		private string _DeptCode;
		private string _Sort;
		private string _Password;
		private string _StandCode;
		private string _PsName;
		/// <summary>
		/// 
		/// </summary>
		public int PSID
		{
			get{ return _PSID; }
			set
			{
				this.OnPropertyValueChange(_.PSID,_PSID,value);
				this._PSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptCode
		{
			get{ return _DeptCode; }
			set
			{
				this.OnPropertyValueChange(_.DeptCode,_DeptCode,value);
				this._DeptCode=value;
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
		public string Password
		{
			get{ return _Password; }
			set
			{
				this.OnPropertyValueChange(_.Password,_Password,value);
				this._Password=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StandCode
		{
			get{ return _StandCode; }
			set
			{
				this.OnPropertyValueChange(_.StandCode,_StandCode,value);
				this._StandCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PsName
		{
			get{ return _PsName; }
			set
			{
				this.OnPropertyValueChange(_.PsName,_PsName,value);
				this._PsName=value;
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
				_.PSID,
				_.DeptCode,
				_.Sort,
				_.Password,
				_.StandCode,
				_.PsName};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._PSID,
				this._DeptCode,
				this._Sort,
				this._Password,
				this._StandCode,
				this._PsName};
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
			public readonly static Field All = new Field("*","vw_Rsda_Exp");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","vw_Rsda_Exp","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","vw_Rsda_Exp","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","vw_Rsda_Exp","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Password = new Field("Password","vw_Rsda_Exp","Password");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StandCode = new Field("StandCode","vw_Rsda_Exp","StandCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PsName = new Field("PsName","vw_Rsda_Exp","PsName");
		}
		#endregion


	}
}

