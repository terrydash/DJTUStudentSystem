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
	/// 实体类Vw_ReStudyGroup 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_ReStudyGroup")]
	[Serializable]
	public partial class Vw_ReStudyGroup : Entity 
	{
		#region Model
		private int _RSGID;
		private int? _Atyid;
		private int? _CCID;
		private int? _DeptID;
		private int? _GRID;
		private int? _Mark;
		private string _DeptName;
		private string _GRName;
		private string _SPName;
		private int? _SPID;
		private string _SPNo;
		private string _DeptCode;
		private string _Method;
		private string _Sort;
		private string _CSort;
		/// <summary>
		/// 
		/// </summary>
		public int RSGID
		{
			get{ return _RSGID; }
			set
			{
				this.OnPropertyValueChange(_.RSGID,_RSGID,value);
				this._RSGID=value;
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
		public int? GRID
		{
			get{ return _GRID; }
			set
			{
				this.OnPropertyValueChange(_.GRID,_GRID,value);
				this._GRID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Mark
		{
			get{ return _Mark; }
			set
			{
				this.OnPropertyValueChange(_.Mark,_Mark,value);
				this._Mark=value;
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
		public string GRName
		{
			get{ return _GRName; }
			set
			{
				this.OnPropertyValueChange(_.GRName,_GRName,value);
				this._GRName=value;
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
		public string DeptCode
		{
			get{ return _DeptCode; }
			set
			{
				this.OnPropertyValueChange(_.DeptCode,_DeptCode,value);
				this._DeptCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Method
		{
			get{ return _Method; }
			set
			{
				this.OnPropertyValueChange(_.Method,_Method,value);
				this._Method=value;
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
		public string CSort
		{
			get{ return _CSort; }
			set
			{
				this.OnPropertyValueChange(_.CSort,_CSort,value);
				this._CSort=value;
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
				_.RSGID,
				_.Atyid,
				_.CCID,
				_.DeptID,
				_.GRID,
				_.Mark,
				_.DeptName,
				_.GRName,
				_.SPName,
				_.SPID,
				_.SPNo,
				_.DeptCode,
				_.Method,
				_.Sort,
				_.CSort};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._RSGID,
				this._Atyid,
				this._CCID,
				this._DeptID,
				this._GRID,
				this._Mark,
				this._DeptName,
				this._GRName,
				this._SPName,
				this._SPID,
				this._SPNo,
				this._DeptCode,
				this._Method,
				this._Sort,
				this._CSort};
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
			public readonly static Field All = new Field("*","vw_ReStudyGroup");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RSGID = new Field("RSGID","vw_ReStudyGroup","RSGID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Atyid = new Field("Atyid","vw_ReStudyGroup","Atyid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_ReStudyGroup","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptID = new Field("DeptID","vw_ReStudyGroup","DeptID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRID = new Field("GRID","vw_ReStudyGroup","GRID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Mark = new Field("Mark","vw_ReStudyGroup","Mark");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName","vw_ReStudyGroup","DeptName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_ReStudyGroup","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPName = new Field("SPName","vw_ReStudyGroup","SPName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPID = new Field("SPID","vw_ReStudyGroup","SPID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field SPNo = new Field("SPNo","vw_ReStudyGroup","SPNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptCode = new Field("DeptCode","vw_ReStudyGroup","DeptCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Method = new Field("Method","vw_ReStudyGroup","Method");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","vw_ReStudyGroup","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSort = new Field("CSort","vw_ReStudyGroup","CSort");
		}
		#endregion


	}
}

