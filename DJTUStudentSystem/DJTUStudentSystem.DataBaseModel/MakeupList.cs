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
	/// 实体类MakeupList 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("MakeupList")]
	[Serializable]
	public partial class MakeupList : Entity 
	{
		#region Model
		private int _MLID;
		private int? _ATYID;
		private int? _CCID;
		private int? _StuID;
		private string _State;
		private decimal? _Moneys;
		private string _KSCJ;
		/// <summary>
		/// 
		/// </summary>
		public int MLID
		{
			get{ return _MLID; }
			set
			{
				this.OnPropertyValueChange(_.MLID,_MLID,value);
				this._MLID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ATYID
		{
			get{ return _ATYID; }
			set
			{
				this.OnPropertyValueChange(_.ATYID,_ATYID,value);
				this._ATYID=value;
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
		public int? StuID
		{
			get{ return _StuID; }
			set
			{
				this.OnPropertyValueChange(_.StuID,_StuID,value);
				this._StuID=value;
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
		/// <summary>
		/// 
		/// </summary>
		public decimal? Moneys
		{
			get{ return _Moneys; }
			set
			{
				this.OnPropertyValueChange(_.Moneys,_Moneys,value);
				this._Moneys=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KSCJ
		{
			get{ return _KSCJ; }
			set
			{
				this.OnPropertyValueChange(_.KSCJ,_KSCJ,value);
				this._KSCJ=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.MLID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.MLID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.MLID,
				_.ATYID,
				_.CCID,
				_.StuID,
				_.State,
				_.Moneys,
				_.KSCJ};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._MLID,
				this._ATYID,
				this._CCID,
				this._StuID,
				this._State,
				this._Moneys,
				this._KSCJ};
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
			public readonly static Field All = new Field("*","MakeupList");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MLID = new Field("MLID","MakeupList","MLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATYID = new Field("ATYID","MakeupList","ATYID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","MakeupList","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StuID = new Field("StuID","MakeupList","StuID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","MakeupList","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Moneys = new Field("Moneys","MakeupList","Moneys");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field KSCJ = new Field("KSCJ","MakeupList","KSCJ");
		}
		#endregion


	}
}

