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
	/// 实体类CLass 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("CLass")]
	[Serializable]
	public partial class CLass : Entity 
	{
		#region Model
		private int _CLID;
		private int? _DeptID;
		private int? _SPID;
		private int? _GRDID;
		private string _ClassName;
		private string _Assistant;
		private string _Sort;
		private int? _BasicNum;
		private int? _RGID;
		private string _State;
		private string _CHKState;
		private string _Ifjoin;
		private string _BJDM;
		/// <summary>
		/// 
		/// </summary>
		public int CLID
		{
			get{ return _CLID; }
			set
			{
				this.OnPropertyValueChange(_.CLID,_CLID,value);
				this._CLID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DeptID
		{
			get{ return _DeptID; }
			set
			{
				this.OnPropertyValueChange(_.DeptID,_DeptID,value);
				this._DeptID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SPID
		{
			get{ return _SPID; }
			set
			{
				this.OnPropertyValueChange(_.SPID,_SPID,value);
				this._SPID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GRDID
		{
			get{ return _GRDID; }
			set
			{
				this.OnPropertyValueChange(_.GRDID,_GRDID,value);
				this._GRDID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClassName
		{
			get{ return _ClassName; }
			set
			{
				this.OnPropertyValueChange(_.ClassName,_ClassName,value);
				this._ClassName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Assistant
		{
			get{ return _Assistant; }
			set
			{
				this.OnPropertyValueChange(_.Assistant,_Assistant,value);
				this._Assistant=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sort
		{
			get{ return _Sort; }
			set
			{
				this.OnPropertyValueChange(_.Sort,_Sort,value);
				this._Sort=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BasicNum
		{
			get{ return _BasicNum; }
			set
			{
				this.OnPropertyValueChange(_.BasicNum,_BasicNum,value);
				this._BasicNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RGID
		{
			get{ return _RGID; }
			set
			{
				this.OnPropertyValueChange(_.RGID,_RGID,value);
				this._RGID=value;
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
		public string CHKState
		{
			get{ return _CHKState; }
			set
			{
				this.OnPropertyValueChange(_.CHKState,_CHKState,value);
				this._CHKState=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ifjoin
		{
			get{ return _Ifjoin; }
			set
			{
				this.OnPropertyValueChange(_.Ifjoin,_Ifjoin,value);
				this._Ifjoin=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BJDM
		{
			get{ return _BJDM; }
			set
			{
				this.OnPropertyValueChange(_.BJDM,_BJDM,value);
				this._BJDM=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.CLID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.CLID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.CLID,
				_.DeptID,
				_.SPID,
				_.GRDID,
				_.ClassName,
				_.Assistant,
				_.Sort,
				_.BasicNum,
				_.RGID,
				_.State,
				_.CHKState,
				_.Ifjoin,
				_.BJDM};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._CLID,
				this._DeptID,
				this._SPID,
				this._GRDID,
				this._ClassName,
				this._Assistant,
				this._Sort,
				this._BasicNum,
				this._RGID,
				this._State,
				this._CHKState,
				this._Ifjoin,
				this._BJDM};
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
			public readonly static Field All = new Field("*","CLass");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLID = new Field("CLID","CLass","CLID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","CLass","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","CLass","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRDID = new Field("GRDID","CLass","GRDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassName = new Field("ClassName","CLass","ClassName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Assistant = new Field("Assistant","CLass","Assistant");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","CLass","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BasicNum = new Field("BasicNum","CLass","BasicNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGID = new Field("RGID","CLass","RGID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","CLass","state");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CHKState = new Field("CHKState","CLass","CHKState");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Ifjoin = new Field("ifjoin","CLass","ifjoin");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BJDM = new Field("BJDM","CLass","BJDM");
		}
		#endregion


	}
}
