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
	/// 实体类SystemSetup 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("SystemSetup")]
	[Serializable]
	public partial class SystemSetup : Entity 
	{
		#region Model
		private int _SSID;
		private string _Item;
		private string _Values;
		private string _Memo;
		/// <summary>
		/// 
		/// </summary>
		public int SSID
		{
			get{ return _SSID; }
			set
			{
				this.OnPropertyValueChange(_.SSID,_SSID,value);
				this._SSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Item
		{
			get{ return _Item; }
			set
			{
				this.OnPropertyValueChange(_.Item,_Item,value);
				this._Item=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Values
		{
			get{ return _Values; }
			set
			{
				this.OnPropertyValueChange(_.Values,_Values,value);
				this._Values=value;
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
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.SSID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.SSID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.SSID,
				_.Item,
				_.Values,
				_.Memo};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SSID,
				this._Item,
				this._Values,
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
			public readonly static Field All = new Field("*","SystemSetup");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SSID = new Field("SSID","SystemSetup","SSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Item = new Field("item","SystemSetup","item");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Values = new Field("Values","SystemSetup","Values");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","SystemSetup","Memo");
		}
		#endregion


	}
}
