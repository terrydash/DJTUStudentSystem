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
	/// 实体类Vw_PStitle_Account_ByTTName 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_PStitle_Account_ByTTName")]
	[Serializable]
	public partial class Vw_PStitle_Account_ByTTName : Entity 
	{
		#region Model
		private int? _AtyID;
		private string _Deptcode;
		private string _ATName;
		private int? _PSNum;
		private string _Lev;
		private string _DeptName;
		private int? _TLID;
		private string _TTName;
		private int? _XH;
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
		/// <summary>
		/// 
		/// </summary>
		public string Deptcode
		{
			get{ return _Deptcode; }
			set
			{
				this.OnPropertyValueChange(_.Deptcode,_Deptcode,value);
				this._Deptcode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ATName
		{
			get{ return _ATName; }
			set
			{
				this.OnPropertyValueChange(_.ATName,_ATName,value);
				this._ATName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PSNum
		{
			get{ return _PSNum; }
			set
			{
				this.OnPropertyValueChange(_.PSNum,_PSNum,value);
				this._PSNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Lev
		{
			get{ return _Lev; }
			set
			{
				this.OnPropertyValueChange(_.Lev,_Lev,value);
				this._Lev=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptName
		{
			get{ return _DeptName; }
			set
			{
				this.OnPropertyValueChange(_.DeptName,_DeptName,value);
				this._DeptName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TLID
		{
			get{ return _TLID; }
			set
			{
				this.OnPropertyValueChange(_.TLID,_TLID,value);
				this._TLID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TTName
		{
			get{ return _TTName; }
			set
			{
				this.OnPropertyValueChange(_.TTName,_TTName,value);
				this._TTName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? XH
		{
			get{ return _XH; }
			set
			{
				this.OnPropertyValueChange(_.XH,_XH,value);
				this._XH=value;
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
				_.AtyID,
				_.Deptcode,
				_.ATName,
				_.PSNum,
				_.Lev,
				_.DeptName,
				_.TLID,
				_.TTName,
				_.XH};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._AtyID,
				this._Deptcode,
				this._ATName,
				this._PSNum,
				this._Lev,
				this._DeptName,
				this._TLID,
				this._TTName,
				this._XH};
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
			public readonly static Field All = new Field("*","vw_PStitle_Account_ByTTName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","vw_PStitle_Account_ByTTName","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Deptcode = new Field("Deptcode","vw_PStitle_Account_ByTTName","Deptcode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATName = new Field("ATName","vw_PStitle_Account_ByTTName","ATName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSNum = new Field("PSNum","vw_PStitle_Account_ByTTName","PSNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Lev = new Field("Lev","vw_PStitle_Account_ByTTName","Lev");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName","vw_PStitle_Account_ByTTName","DeptName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TLID = new Field("TLID","vw_PStitle_Account_ByTTName","TLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TTName = new Field("TTName","vw_PStitle_Account_ByTTName","TTName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field XH = new Field("XH","vw_PStitle_Account_ByTTName","XH");
		}
		#endregion


	}
}
