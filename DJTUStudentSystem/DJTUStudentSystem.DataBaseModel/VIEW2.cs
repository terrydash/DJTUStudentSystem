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
	/// 实体类VIEW2 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("VIEW2")]
	[Serializable]
	public partial class VIEW2 : Entity 
	{
		#region Model
		private string _Stdcode;
		private string _Stdname;
		private string _Sex;
		private string _家庭电话;
		private string _Address;
		private string _CLName;
		private string _SPName;
		/// <summary>
		/// 
		/// </summary>
		public string Stdcode
		{
			get{ return _Stdcode; }
			set
			{
				this.OnPropertyValueChange(_.Stdcode,_Stdcode,value);
				this._Stdcode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Stdname
		{
			get{ return _Stdname; }
			set
			{
				this.OnPropertyValueChange(_.Stdname,_Stdname,value);
				this._Stdname=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			get{ return _Sex; }
			set
			{
				this.OnPropertyValueChange(_.Sex,_Sex,value);
				this._Sex=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 家庭电话
		{
			get{ return _家庭电话; }
			set
			{
				this.OnPropertyValueChange(_.家庭电话,_家庭电话,value);
				this._家庭电话=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			get{ return _Address; }
			set
			{
				this.OnPropertyValueChange(_.Address,_Address,value);
				this._Address=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLName
		{
			get{ return _CLName; }
			set
			{
				this.OnPropertyValueChange(_.CLName,_CLName,value);
				this._CLName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPName
		{
			get{ return _SPName; }
			set
			{
				this.OnPropertyValueChange(_.SPName,_SPName,value);
				this._SPName=value;
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
				_.Stdcode,
				_.Stdname,
				_.Sex,
				_.家庭电话,
				_.Address,
				_.CLName,
				_.SPName};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Stdcode,
				this._Stdname,
				this._Sex,
				this._家庭电话,
				this._Address,
				this._CLName,
				this._SPName};
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
			public readonly static Field All = new Field("*","VIEW2");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdcode = new Field("stdcode","VIEW2","stdcode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdname = new Field("Stdname","VIEW2","Stdname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sex = new Field("Sex","VIEW2","Sex");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 家庭电话 = new Field("家庭电话","VIEW2","家庭电话");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Address = new Field("Address","VIEW2","Address");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLName = new Field("CLName","VIEW2","CLName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPName = new Field("SPName","VIEW2","SPName");
		}
		#endregion


	}
}

