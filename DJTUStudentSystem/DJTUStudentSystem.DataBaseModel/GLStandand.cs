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
	/// 实体类GLStandand 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("GLStandand")]
	[Serializable]
	public partial class GLStandand : Entity 
	{
		#region Model
		private int _GSID;
		private string _GLCode;
		private string _Content;
		private string _Lev;
		private short? _Source;
		/// <summary>
		/// 
		/// </summary>
		public int GSID
		{
			get{ return _GSID; }
			set
			{
				this.OnPropertyValueChange(_.GSID,_GSID,value);
				this._GSID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLCode
		{
			get{ return _GLCode; }
			set
			{
				this.OnPropertyValueChange(_.GLCode,_GLCode,value);
				this._GLCode=value;
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
		public short? Source
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
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.GSID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.GSID,
				_.GLCode,
				_.Content,
				_.Lev,
				_.Source};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._GSID,
				this._GLCode,
				this._Content,
				this._Lev,
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
			public readonly static Field All = new Field("*","GLStandand");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GSID = new Field("GSID","GLStandand","GSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GLCode = new Field("GLCode","GLStandand","GLCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","GLStandand","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Lev = new Field("Lev","GLStandand","Lev");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Source = new Field("Source","GLStandand","Source");
		}
		#endregion


	}
}

