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
	/// 实体类Vw_Apptext 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Apptext")]
	[Serializable]
	public partial class Vw_Apptext : Entity 
	{
		#region Model
		private int _APTID;
		private int? _Atyid;
		private int? _Stdid;
		private int? _CCID;
		private int? _PSID;
		private int? _TCID;
		private int? _SRID;
		private string _APTcontent;
		private string _PsName;
		private string _CCname;
		/// <summary>
		/// 
		/// </summary>
		public int APTID
		{
			get{ return _APTID; }
			set
			{
				this.OnPropertyValueChange(_.APTID,_APTID,value);
				this._APTID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Atyid
		{
			get{ return _Atyid; }
			set
			{
				this.OnPropertyValueChange(_.Atyid,_Atyid,value);
				this._Atyid=value;
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
		public int? CCID
		{
			get{ return _CCID; }
			set
			{
				this.OnPropertyValueChange(_.CCID,_CCID,value);
				this._CCID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PSID
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
		public int? SRID
		{
			get{ return _SRID; }
			set
			{
				this.OnPropertyValueChange(_.SRID,_SRID,value);
				this._SRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APTcontent
		{
			get{ return _APTcontent; }
			set
			{
				this.OnPropertyValueChange(_.APTcontent,_APTcontent,value);
				this._APTcontent=value;
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
		/// <summary>
		/// 
		/// </summary>
		public string CCname
		{
			get{ return _CCname; }
			set
			{
				this.OnPropertyValueChange(_.CCname,_CCname,value);
				this._CCname=value;
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
				_.APTID,
				_.Atyid,
				_.Stdid,
				_.CCID,
				_.PSID,
				_.TCID,
				_.SRID,
				_.APTcontent,
				_.PsName,
				_.CCname};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._APTID,
				this._Atyid,
				this._Stdid,
				this._CCID,
				this._PSID,
				this._TCID,
				this._SRID,
				this._APTcontent,
				this._PsName,
				this._CCname};
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
			public readonly static Field All = new Field("*","vw_Apptext");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APTID = new Field("APTID","vw_Apptext","APTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("Atyid","vw_Apptext","Atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Stdid = new Field("stdid","vw_Apptext","stdid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_Apptext","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","vw_Apptext","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","vw_Apptext","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SRID = new Field("SRID","vw_Apptext","SRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field APTcontent = new Field("APTcontent","vw_Apptext","APTcontent");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PsName = new Field("PsName","vw_Apptext","PsName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_Apptext","CCname");
		}
		#endregion


	}
}

