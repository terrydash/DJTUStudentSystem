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
	/// 实体类SAnswer 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("SAnswer")]
	[Serializable]
	public partial class SAnswer : Entity 
	{
		#region Model
		private int _SAID;
		private string _Title;
		private string _Content;
		private DateTime _SADate;
		private string _State;
		/// <summary>
		/// 
		/// </summary>
		public int SAID
		{
			get{ return _SAID; }
			set
			{
				this.OnPropertyValueChange(_.SAID,_SAID,value);
				this._SAID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			get{ return _Title; }
			set
			{
				this.OnPropertyValueChange(_.Title,_Title,value);
				this._Title=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			get{ return _Content; }
			set
			{
				this.OnPropertyValueChange(_.Content,_Content,value);
				this._Content=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SADate
		{
			get{ return _SADate; }
			set
			{
				this.OnPropertyValueChange(_.SADate,_SADate,value);
				this._SADate=value;
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
			return _.SAID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.SAID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.SAID,
				_.Title,
				_.Content,
				_.SADate,
				_.State};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SAID,
				this._Title,
				this._Content,
				this._SADate,
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
			public readonly static Field All = new Field("*","SAnswer");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SAID = new Field("SAID","SAnswer","SAID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Title = new Field("Title","SAnswer","Title");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","SAnswer","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SADate = new Field("SADate","SAnswer","SADate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","SAnswer","state");
		}
		#endregion


	}
}

