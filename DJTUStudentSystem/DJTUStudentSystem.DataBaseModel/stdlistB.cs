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
	/// 实体类StdlistB 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("stdlistB")]
	[Serializable]
	public partial class StdlistB : Entity 
	{
		#region Model
		private int _SSID;
		private int _Stdid;
		private int? _Dayofweek;
		private string _Sectionth;
		private int? _TCID;
		private int? _HaveBy;
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
		public int Stdid
		{
			get{ return _Stdid; }
			set
			{
				this.OnPropertyValueChange(_.Stdid,_Stdid,value);
				this._Stdid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Dayofweek
		{
			get{ return _Dayofweek; }
			set
			{
				this.OnPropertyValueChange(_.Dayofweek,_Dayofweek,value);
				this._Dayofweek=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sectionth
		{
			get{ return _Sectionth; }
			set
			{
				this.OnPropertyValueChange(_.Sectionth,_Sectionth,value);
				this._Sectionth=value;
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
		/// <summary>
		/// 
		/// </summary>
		public int? HaveBy
		{
			get{ return _HaveBy; }
			set
			{
				this.OnPropertyValueChange(_.HaveBy,_HaveBy,value);
				this._HaveBy=value;
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
				_.Stdid,
				_.Dayofweek,
				_.Sectionth,
				_.TCID,
				_.HaveBy};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SSID,
				this._Stdid,
				this._Dayofweek,
				this._Sectionth,
				this._TCID,
				this._HaveBy};
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
			public readonly static Field All = new Field("*","stdlistB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SSID = new Field("SSID","stdlistB","SSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("stdid","stdlistB","stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Dayofweek = new Field("dayofweek","stdlistB","dayofweek");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sectionth = new Field("Sectionth","stdlistB","Sectionth");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","stdlistB","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field HaveBy = new Field("haveBy","stdlistB","haveBy");
		}
		#endregion


	}
}

