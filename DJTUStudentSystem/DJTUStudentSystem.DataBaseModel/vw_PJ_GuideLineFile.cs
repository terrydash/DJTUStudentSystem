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
	/// 实体类Vw_PJ_GuideLineFile 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_PJ_GuideLineFile")]
	[Serializable]
	public partial class Vw_PJ_GuideLineFile : Entity 
	{
		#region Model
		private int _PGID;
		private int _FMID;
		private int _GLID;
		private string _MFilename;
		private string _FromDept;
		private DateTime? _Indate;
		private string _FName;
		private string _Oper;
		private DateTime? _GLDate;
		/// <summary>
		/// 
		/// </summary>
		public int PGID
		{
			get{ return _PGID; }
			set
			{
				this.OnPropertyValueChange(_.PGID,_PGID,value);
				this._PGID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FMID
		{
			get{ return _FMID; }
			set
			{
				this.OnPropertyValueChange(_.FMID,_FMID,value);
				this._FMID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int GLID
		{
			get{ return _GLID; }
			set
			{
				this.OnPropertyValueChange(_.GLID,_GLID,value);
				this._GLID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MFilename
		{
			get{ return _MFilename; }
			set
			{
				this.OnPropertyValueChange(_.MFilename,_MFilename,value);
				this._MFilename=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FromDept
		{
			get{ return _FromDept; }
			set
			{
				this.OnPropertyValueChange(_.FromDept,_FromDept,value);
				this._FromDept=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Indate
		{
			get{ return _Indate; }
			set
			{
				this.OnPropertyValueChange(_.Indate,_Indate,value);
				this._Indate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FName
		{
			get{ return _FName; }
			set
			{
				this.OnPropertyValueChange(_.FName,_FName,value);
				this._FName=value;
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
		public DateTime? GLDate
		{
			get{ return _GLDate; }
			set
			{
				this.OnPropertyValueChange(_.GLDate,_GLDate,value);
				this._GLDate=value;
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
				_.PGID,
				_.FMID,
				_.GLID,
				_.MFilename,
				_.FromDept,
				_.Indate,
				_.FName,
				_.Oper,
				_.GLDate};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._PGID,
				this._FMID,
				this._GLID,
				this._MFilename,
				this._FromDept,
				this._Indate,
				this._FName,
				this._Oper,
				this._GLDate};
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
			public readonly static Field All = new Field("*","vw_PJ_GuideLineFile");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PGID = new Field("PGID","vw_PJ_GuideLineFile","PGID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FMID = new Field("FMID","vw_PJ_GuideLineFile","FMID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GLID = new Field("GLID","vw_PJ_GuideLineFile","GLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MFilename = new Field("MFilename","vw_PJ_GuideLineFile","MFilename");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FromDept = new Field("FromDept","vw_PJ_GuideLineFile","FromDept");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Indate = new Field("Indate","vw_PJ_GuideLineFile","Indate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FName = new Field("FName","vw_PJ_GuideLineFile","FName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oper = new Field("Oper","vw_PJ_GuideLineFile","Oper");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GLDate = new Field("GLDate","vw_PJ_GuideLineFile","GLDate");
		}
		#endregion


	}
}

