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
	/// 实体类Vw_Special 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Special")]
	[Serializable]
	public partial class Vw_Special : Entity 
	{
		#region Model
		private string _SPCode;
		private string _SPName;
		private string _ShortName;
		private string _DeptName;
		private int? _SPYear;
		private string _Degree;
		private string _Memo;
		private int _DeptID;
		private int _SPID;
		private string _SPNo;
		private string _Minor;
		private string _Descript;
		private string _IfJoin;
		/// <summary>
		/// 
		/// </summary>
		public string SPCode
		{
			get{ return _SPCode; }
			set
			{
				this.OnPropertyValueChange(_.SPCode,_SPCode,value);
				this._SPCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPName
		{
			get{ return _SPName; }
			set
			{
				this.OnPropertyValueChange(_.SPName,_SPName,value);
				this._SPName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShortName
		{
			get{ return _ShortName; }
			set
			{
				this.OnPropertyValueChange(_.ShortName,_ShortName,value);
				this._ShortName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptName
		{
			get{ return _DeptName; }
			set
			{
				this.OnPropertyValueChange(_.DeptName,_DeptName,value);
				this._DeptName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SPYear
		{
			get{ return _SPYear; }
			set
			{
				this.OnPropertyValueChange(_.SPYear,_SPYear,value);
				this._SPYear=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Degree
		{
			get{ return _Degree; }
			set
			{
				this.OnPropertyValueChange(_.Degree,_Degree,value);
				this._Degree=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get{ return _Memo; }
			set
			{
				this.OnPropertyValueChange(_.Memo,_Memo,value);
				this._Memo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int DeptID
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
		public int SPID
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
		public string SPNo
		{
			get{ return _SPNo; }
			set
			{
				this.OnPropertyValueChange(_.SPNo,_SPNo,value);
				this._SPNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Minor
		{
			get{ return _Minor; }
			set
			{
				this.OnPropertyValueChange(_.Minor,_Minor,value);
				this._Minor=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Descript
		{
			get{ return _Descript; }
			set
			{
				this.OnPropertyValueChange(_.Descript,_Descript,value);
				this._Descript=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IfJoin
		{
			get{ return _IfJoin; }
			set
			{
				this.OnPropertyValueChange(_.IfJoin,_IfJoin,value);
				this._IfJoin=value;
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
				_.SPCode,
				_.SPName,
				_.ShortName,
				_.DeptName,
				_.SPYear,
				_.Degree,
				_.Memo,
				_.DeptID,
				_.SPID,
				_.SPNo,
				_.Minor,
				_.Descript,
				_.IfJoin};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._SPCode,
				this._SPName,
				this._ShortName,
				this._DeptName,
				this._SPYear,
				this._Degree,
				this._Memo,
				this._DeptID,
				this._SPID,
				this._SPNo,
				this._Minor,
				this._Descript,
				this._IfJoin};
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
			public readonly static Field All = new Field("*","vw_Special");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPCode = new Field("SPCode","vw_Special","SPCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPName = new Field("SPName","vw_Special","SPName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ShortName = new Field("ShortName","vw_Special","ShortName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName","vw_Special","DeptName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPYear = new Field("SPYear","vw_Special","SPYear");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Degree = new Field("Degree","vw_Special","Degree");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Memo = new Field("Memo","vw_Special","Memo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","vw_Special","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_Special","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPNo = new Field("SPNo","vw_Special","SPNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Minor = new Field("Minor","vw_Special","Minor");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Descript = new Field("Descript","vw_Special","Descript");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IfJoin = new Field("ifJoin","vw_Special","ifJoin");
		}
		#endregion


	}
}

