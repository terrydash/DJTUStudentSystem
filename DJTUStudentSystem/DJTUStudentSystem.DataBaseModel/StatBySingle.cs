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
	/// 实体类StatBySingle 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("StatBySingle")]
	[Serializable]
	public partial class StatBySingle : Entity 
	{
		#region Model
		private int _STID;
		private int? _AtyID;
		private int? _TCID;
		private int? _CCID;
		private int? _PSID;
		private int? _LevID;
		private int? _PsNum;
		/// <summary>
		/// 
		/// </summary>
		public int STID
		{
			get{ return _STID; }
			set
			{
				this.OnPropertyValueChange(_.STID,_STID,value);
				this._STID=value;
			}
		}
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
		public int? LevID
		{
			get{ return _LevID; }
			set
			{
				this.OnPropertyValueChange(_.LevID,_LevID,value);
				this._LevID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PsNum
		{
			get{ return _PsNum; }
			set
			{
				this.OnPropertyValueChange(_.PsNum,_PsNum,value);
				this._PsNum=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.STID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.STID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.STID,
				_.AtyID,
				_.TCID,
				_.CCID,
				_.PSID,
				_.LevID,
				_.PsNum};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._STID,
				this._AtyID,
				this._TCID,
				this._CCID,
				this._PSID,
				this._LevID,
				this._PsNum};
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
			public readonly static Field All = new Field("*","StatBySingle");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field STID = new Field("STID","StatBySingle","STID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AtyID = new Field("AtyID","StatBySingle","AtyID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","StatBySingle","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","StatBySingle","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PSID = new Field("PSID","StatBySingle","PSID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LevID = new Field("LevID","StatBySingle","LevID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PsNum = new Field("PsNum","StatBySingle","PsNum");
		}
		#endregion


	}
}

