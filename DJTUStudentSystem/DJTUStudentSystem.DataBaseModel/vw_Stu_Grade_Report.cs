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
	/// 实体类Vw_Stu_Grade_Report 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("vw_Stu_Grade_Report")]
	[Serializable]
	public partial class Vw_Stu_Grade_Report : Entity 
	{
		#region Model
		private string _StdCode;
		private string _StdName;
		private int? _BJGNum;
		private int? _Lost;
		private int? _LastNum;
		private string _Xuewei;
		private string _Biye;
		private int? _GradeID;
		private string _ClassName;
		private string _GRName;
		private string _DeptName;
		private int _StdID;
		private int? _CX12;
		private string _Sex;
		private string _BYSJ;
		/// <summary>
		/// 
		/// </summary>
		public string StdCode
		{
			get{ return _StdCode; }
			set
			{
				this.OnPropertyValueChange(_.StdCode,_StdCode,value);
				this._StdCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StdName
		{
			get{ return _StdName; }
			set
			{
				this.OnPropertyValueChange(_.StdName,_StdName,value);
				this._StdName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BJGNum
		{
			get{ return _BJGNum; }
			set
			{
				this.OnPropertyValueChange(_.BJGNum,_BJGNum,value);
				this._BJGNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Lost
		{
			get{ return _Lost; }
			set
			{
				this.OnPropertyValueChange(_.Lost,_Lost,value);
				this._Lost=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LastNum
		{
			get{ return _LastNum; }
			set
			{
				this.OnPropertyValueChange(_.LastNum,_LastNum,value);
				this._LastNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Xuewei
		{
			get{ return _Xuewei; }
			set
			{
				this.OnPropertyValueChange(_.Xuewei,_Xuewei,value);
				this._Xuewei=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Biye
		{
			get{ return _Biye; }
			set
			{
				this.OnPropertyValueChange(_.Biye,_Biye,value);
				this._Biye=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GradeID
		{
			get{ return _GradeID; }
			set
			{
				this.OnPropertyValueChange(_.GradeID,_GradeID,value);
				this._GradeID=value;
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
		public int StdID
		{
			get{ return _StdID; }
			set
			{
				this.OnPropertyValueChange(_.StdID,_StdID,value);
				this._StdID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CX12
		{
			get{ return _CX12; }
			set
			{
				this.OnPropertyValueChange(_.CX12,_CX12,value);
				this._CX12=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			get{ return _Sex; }
			set
			{
				this.OnPropertyValueChange(_.Sex,_Sex,value);
				this._Sex=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BYSJ
		{
			get{ return _BYSJ; }
			set
			{
				this.OnPropertyValueChange(_.BYSJ,_BYSJ,value);
				this._BYSJ=value;
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
				_.StdCode,
				_.StdName,
				_.BJGNum,
				_.Lost,
				_.LastNum,
				_.Xuewei,
				_.Biye,
				_.GradeID,
				_.ClassName,
				_.GRName,
				_.DeptName,
				_.StdID,
				_.CX12,
				_.Sex,
				_.BYSJ};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._StdCode,
				this._StdName,
				this._BJGNum,
				this._Lost,
				this._LastNum,
				this._Xuewei,
				this._Biye,
				this._GradeID,
				this._ClassName,
				this._GRName,
				this._DeptName,
				this._StdID,
				this._CX12,
				this._Sex,
				this._BYSJ};
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
			public readonly static Field All = new Field("*","vw_Stu_Grade_Report");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdCode = new Field("StdCode","vw_Stu_Grade_Report","StdCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdName = new Field("StdName","vw_Stu_Grade_Report","StdName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BJGNum = new Field("BJGNum","vw_Stu_Grade_Report","BJGNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Lost = new Field("Lost","vw_Stu_Grade_Report","Lost");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LastNum = new Field("LastNum","vw_Stu_Grade_Report","LastNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Xuewei = new Field("Xuewei","vw_Stu_Grade_Report","Xuewei");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Biye = new Field("Biye","vw_Stu_Grade_Report","Biye");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GradeID = new Field("GradeID","vw_Stu_Grade_Report","GradeID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassName = new Field("ClassName","vw_Stu_Grade_Report","ClassName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","vw_Stu_Grade_Report","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DeptName = new Field("DeptName","vw_Stu_Grade_Report","DeptName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field StdID = new Field("StdID","vw_Stu_Grade_Report","StdID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CX12 = new Field("CX12","vw_Stu_Grade_Report","CX12");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sex = new Field("Sex","vw_Stu_Grade_Report","Sex");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BYSJ = new Field("BYSJ","vw_Stu_Grade_Report","BYSJ");
		}
		#endregion


	}
}
