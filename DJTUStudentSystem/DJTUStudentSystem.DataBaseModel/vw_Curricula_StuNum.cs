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
	/// 实体类Vw_Curricula_StuNum 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Curricula_StuNum")]
	[Serializable]
	public partial class Vw_Curricula_StuNum : Entity 
	{
		#region Model
		private int? _StuNum;
		private int _CCID;
		private int? _ATYID;
		private string _GRNo;
		private short? _ClassNum;
		private string _CCode;
		private int? _TermID;
		private string _CSort;
		private string _年级;
		private string _CCname;
		private decimal? _Period;
		private int? _CCStuNum;
		/// <summary>
		/// 
		/// </summary>
		public int? StuNum
		{
			get{ return _StuNum; }
			set
			{
				this.OnPropertyValueChange(_.StuNum,_StuNum,value);
				this._StuNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CCID
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
		public string GRNo
		{
			get{ return _GRNo; }
			set
			{
				this.OnPropertyValueChange(_.GRNo,_GRNo,value);
				this._GRNo=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public short? ClassNum
		{
			get{ return _ClassNum; }
			set
			{
				this.OnPropertyValueChange(_.ClassNum,_ClassNum,value);
				this._ClassNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CCode
		{
			get{ return _CCode; }
			set
			{
				this.OnPropertyValueChange(_.CCode,_CCode,value);
				this._CCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TermID
		{
			get{ return _TermID; }
			set
			{
				this.OnPropertyValueChange(_.TermID,_TermID,value);
				this._TermID=value;
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
		/// <summary>
		/// 
		/// </summary>
		public string 年级
		{
			get{ return _年级; }
			set
			{
				this.OnPropertyValueChange(_.年级,_年级,value);
				this._年级=value;
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
		public decimal? Period
		{
			get{ return _Period; }
			set
			{
				this.OnPropertyValueChange(_.Period,_Period,value);
				this._Period=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CCStuNum
		{
			get{ return _CCStuNum; }
			set
			{
				this.OnPropertyValueChange(_.CCStuNum,_CCStuNum,value);
				this._CCStuNum=value;
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
				_.StuNum,
				_.CCID,
				_.ATYID,
				_.GRNo,
				_.ClassNum,
				_.CCode,
				_.TermID,
				_.CSort,
				_.年级,
				_.CCname,
				_.Period,
				_.CCStuNum};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._StuNum,
				this._CCID,
				this._ATYID,
				this._GRNo,
				this._ClassNum,
				this._CCode,
				this._TermID,
				this._CSort,
				this._年级,
				this._CCname,
				this._Period,
				this._CCStuNum};
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
			public readonly static Field All = new Field("*","vw_Curricula_StuNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StuNum = new Field("StuNum","vw_Curricula_StuNum","StuNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCID = new Field("CCID","vw_Curricula_StuNum","CCID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ATYID = new Field("ATYID","vw_Curricula_StuNum","ATYID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRNo = new Field("GRNo","vw_Curricula_StuNum","GRNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassNum = new Field("ClassNum","vw_Curricula_StuNum","ClassNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCode = new Field("CCode","vw_Curricula_StuNum","CCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field TermID = new Field("TermID","vw_Curricula_StuNum","TermID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CSort = new Field("CSort","vw_Curricula_StuNum","CSort");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 年级 = new Field("年级","vw_Curricula_StuNum","年级");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCname = new Field("CCname","vw_Curricula_StuNum","CCname");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Period = new Field("Period","vw_Curricula_StuNum","Period");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CCStuNum = new Field("CCStuNum","vw_Curricula_StuNum","CCStuNum");
		}
		#endregion


	}
}

