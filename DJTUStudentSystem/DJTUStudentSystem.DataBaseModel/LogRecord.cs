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
	/// 实体类LogRecord 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("LogRecord")]
	[Serializable]
	public partial class LogRecord : Entity 
	{
		#region Model
		private int _LGID;
		private int? _Stdid;
		private int? _Psid;
		private int? _UID;
		private string _Operation;
		private DateTime? _OpDate;
		private string _Oper;
		private string _IPaddress;
		/// <summary>
		/// 
		/// </summary>
		public int LGID
		{
			get{ return _LGID; }
			set
			{
				this.OnPropertyValueChange(_.LGID,_LGID,value);
				this._LGID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Stdid
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
		public int? UID
		{
			get{ return _UID; }
			set
			{
				this.OnPropertyValueChange(_.UID,_UID,value);
				this._UID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Operation
		{
			get{ return _Operation; }
			set
			{
				this.OnPropertyValueChange(_.Operation,_Operation,value);
				this._Operation=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OpDate
		{
			get{ return _OpDate; }
			set
			{
				this.OnPropertyValueChange(_.OpDate,_OpDate,value);
				this._OpDate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Oper
		{
			get{ return _Oper; }
			set
			{
				this.OnPropertyValueChange(_.Oper,_Oper,value);
				this._Oper=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IPaddress
		{
			get{ return _IPaddress; }
			set
			{
				this.OnPropertyValueChange(_.IPaddress,_IPaddress,value);
				this._IPaddress=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.LGID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.LGID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.LGID,
				_.Stdid,
				_.Psid,
				_.UID,
				_.Operation,
				_.OpDate,
				_.Oper,
				_.IPaddress};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._LGID,
				this._Stdid,
				this._Psid,
				this._UID,
				this._Operation,
				this._OpDate,
				this._Oper,
				this._IPaddress};
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
			public readonly static Field All = new Field("*","LogRecord");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LGID = new Field("LGID","LogRecord","LGID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("stdid","LogRecord","stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Psid = new Field("psid","LogRecord","psid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UID = new Field("UID","LogRecord","UID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Operation = new Field("Operation","LogRecord","Operation");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field OpDate = new Field("OpDate","LogRecord","OpDate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","LogRecord","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IPaddress = new Field("IPaddress","LogRecord","IPaddress");
		}
		#endregion


	}
}

