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
	/// 实体类StdList 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("StdList")]
	[Serializable]
	public partial class StdList : Entity 
	{
		#region Model
		private int _SLID;
		private int _Stdid;
		private string _State;
		/// <summary>
		/// 
		/// </summary>
		public int SLID
		{
			get{ return _SLID; }
			set
			{
				this.OnPropertyValueChange(_.SLID,_SLID,value);
				this._SLID=value;
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
		public string State
		{
			get{ return _State; }
			set
			{
				this.OnPropertyValueChange(_.State,_State,value);
				this._State=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.SLID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.SLID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.SLID,
				_.Stdid,
				_.State};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SLID,
				this._Stdid,
				this._State};
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
			public readonly static Field All = new Field("*","StdList");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SLID = new Field("SLID","StdList","SLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("stdid","StdList","stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","StdList","state");
		}
		#endregion


	}
}

