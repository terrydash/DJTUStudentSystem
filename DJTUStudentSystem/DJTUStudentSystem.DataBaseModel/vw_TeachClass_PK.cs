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
	/// 实体类Vw_TeachClass_PK 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_TeachClass_PK")]
	[Serializable]
	public partial class Vw_TeachClass_PK : Entity 
	{
		#region Model
		private int _TCID;
		private int? _CCID;
		private int? _ActYear;
		private int? _TCHID;
		private int? _StartA;
		private int? _EndA;
		private int? _PerWeekA;
		private string _StartB;
		private string _EndB;
		private string _PerWeekB;
		private int? _RGID;
		private int? _CTID;
		private int? _MaxStuNum;
		private string _Sort;
		private int? _FAXH;
		private string _IFJoin;
		private string _CLRSort;
		private string _CCname;
		private int? _FAXHB;
		private int? _CL1;
		private int? _CL2;
		/// <summary>
		/// 
		/// </summary>
		public int TCID
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
		public int? ActYear
		{
			get{ return _ActYear; }
			set
			{
				this.OnPropertyValueChange(_.ActYear,_ActYear,value);
				this._ActYear=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TCHID
		{
			get{ return _TCHID; }
			set
			{
				this.OnPropertyValueChange(_.TCHID,_TCHID,value);
				this._TCHID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StartA
		{
			get{ return _StartA; }
			set
			{
				this.OnPropertyValueChange(_.StartA,_StartA,value);
				this._StartA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EndA
		{
			get{ return _EndA; }
			set
			{
				this.OnPropertyValueChange(_.EndA,_EndA,value);
				this._EndA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PerWeekA
		{
			get{ return _PerWeekA; }
			set
			{
				this.OnPropertyValueChange(_.PerWeekA,_PerWeekA,value);
				this._PerWeekA=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartB
		{
			get{ return _StartB; }
			set
			{
				this.OnPropertyValueChange(_.StartB,_StartB,value);
				this._StartB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndB
		{
			get{ return _EndB; }
			set
			{
				this.OnPropertyValueChange(_.EndB,_EndB,value);
				this._EndB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PerWeekB
		{
			get{ return _PerWeekB; }
			set
			{
				this.OnPropertyValueChange(_.PerWeekB,_PerWeekB,value);
				this._PerWeekB=value;
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
		public int? CTID
		{
			get{ return _CTID; }
			set
			{
				this.OnPropertyValueChange(_.CTID,_CTID,value);
				this._CTID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MaxStuNum
		{
			get{ return _MaxStuNum; }
			set
			{
				this.OnPropertyValueChange(_.MaxStuNum,_MaxStuNum,value);
				this._MaxStuNum=value;
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
		public int? FAXH
		{
			get{ return _FAXH; }
			set
			{
				this.OnPropertyValueChange(_.FAXH,_FAXH,value);
				this._FAXH=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IFJoin
		{
			get{ return _IFJoin; }
			set
			{
				this.OnPropertyValueChange(_.IFJoin,_IFJoin,value);
				this._IFJoin=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLRSort
		{
			get{ return _CLRSort; }
			set
			{
				this.OnPropertyValueChange(_.CLRSort,_CLRSort,value);
				this._CLRSort=value;
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
		/// <summary>
		/// 
		/// </summary>
		public int? FAXHB
		{
			get{ return _FAXHB; }
			set
			{
				this.OnPropertyValueChange(_.FAXHB,_FAXHB,value);
				this._FAXHB=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CL1
		{
			get{ return _CL1; }
			set
			{
				this.OnPropertyValueChange(_.CL1,_CL1,value);
				this._CL1=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CL2
		{
			get{ return _CL2; }
			set
			{
				this.OnPropertyValueChange(_.CL2,_CL2,value);
				this._CL2=value;
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
				_.TCID,
				_.CCID,
				_.ActYear,
				_.TCHID,
				_.StartA,
				_.EndA,
				_.PerWeekA,
				_.StartB,
				_.EndB,
				_.PerWeekB,
				_.RGID,
				_.CTID,
				_.MaxStuNum,
				_.Sort,
				_.FAXH,
				_.IFJoin,
				_.CLRSort,
				_.CCname,
				_.FAXHB,
				_.CL1,
				_.CL2};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._TCID,
				this._CCID,
				this._ActYear,
				this._TCHID,
				this._StartA,
				this._EndA,
				this._PerWeekA,
				this._StartB,
				this._EndB,
				this._PerWeekB,
				this._RGID,
				this._CTID,
				this._MaxStuNum,
				this._Sort,
				this._FAXH,
				this._IFJoin,
				this._CLRSort,
				this._CCname,
				this._FAXHB,
				this._CL1,
				this._CL2};
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
			public readonly static Field All = new Field("*","vw_TeachClass_PK");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCID = new Field("TCID","vw_TeachClass_PK","TCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_TeachClass_PK","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ActYear = new Field("ActYear","vw_TeachClass_PK","ActYear");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TCHID = new Field("TCHID","vw_TeachClass_PK","TCHID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartA = new Field("StartA","vw_TeachClass_PK","StartA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EndA = new Field("EndA","vw_TeachClass_PK","EndA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PerWeekA = new Field("PerWeekA","vw_TeachClass_PK","PerWeekA");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StartB = new Field("StartB","vw_TeachClass_PK","StartB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EndB = new Field("EndB","vw_TeachClass_PK","EndB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PerWeekB = new Field("PerWeekB","vw_TeachClass_PK","PerWeekB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGID = new Field("RGID","vw_TeachClass_PK","RGID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CTID = new Field("CTID","vw_TeachClass_PK","CTID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MaxStuNum = new Field("MaxStuNum","vw_TeachClass_PK","MaxStuNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort","vw_TeachClass_PK","Sort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAXH = new Field("FAXH","vw_TeachClass_PK","FAXH");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IFJoin = new Field("IFJoin","vw_TeachClass_PK","IFJoin");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CLRSort = new Field("CLRSort","vw_TeachClass_PK","CLRSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_TeachClass_PK","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FAXHB = new Field("FAXHB","vw_TeachClass_PK","FAXHB");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CL1 = new Field("CL1","vw_TeachClass_PK","CL1");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CL2 = new Field("CL2","vw_TeachClass_PK","CL2");
		}
		#endregion


	}
}

