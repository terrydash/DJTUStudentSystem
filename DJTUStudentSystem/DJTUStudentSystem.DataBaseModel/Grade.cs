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
	/// 实体类Grade 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Grade")]
	[Serializable]
	public partial class Grade : Entity 
	{
		#region Model
		private int _GRDID;
		private string _GRName;
		private string _Edusys;
		private string _GRNo;
		private string _State;
		private string _Gxkstate;
		private string _Credithour;
		private decimal? _NeedPoint;
		private int? _PubNums;
		private string _RGstate;
		/// <summary>
		/// 
		/// </summary>
		public int GRDID
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
		public string Edusys
		{
			get{ return _Edusys; }
			set
			{
				this.OnPropertyValueChange(_.Edusys,_Edusys,value);
				this._Edusys=value;
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
		public string Gxkstate
		{
			get{ return _Gxkstate; }
			set
			{
				this.OnPropertyValueChange(_.Gxkstate,_Gxkstate,value);
				this._Gxkstate=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Credithour
		{
			get{ return _Credithour; }
			set
			{
				this.OnPropertyValueChange(_.Credithour,_Credithour,value);
				this._Credithour=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? NeedPoint
		{
			get{ return _NeedPoint; }
			set
			{
				this.OnPropertyValueChange(_.NeedPoint,_NeedPoint,value);
				this._NeedPoint=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PubNums
		{
			get{ return _PubNums; }
			set
			{
				this.OnPropertyValueChange(_.PubNums,_PubNums,value);
				this._PubNums=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RGstate
		{
			get{ return _RGstate; }
			set
			{
				this.OnPropertyValueChange(_.RGstate,_RGstate,value);
				this._RGstate=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.GRDID;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.GRDID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.GRDID,
				_.GRName,
				_.Edusys,
				_.GRNo,
				_.State,
				_.Gxkstate,
				_.Credithour,
				_.NeedPoint,
				_.PubNums,
				_.RGstate};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._GRDID,
				this._GRName,
				this._Edusys,
				this._GRNo,
				this._State,
				this._Gxkstate,
				this._Credithour,
				this._NeedPoint,
				this._PubNums,
				this._RGstate};
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
			public readonly static Field All = new Field("*","Grade");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRDID = new Field("GRDID","Grade","GRDID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRName = new Field("GRName","Grade","GRName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Edusys = new Field("Edusys","Grade","Edusys");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field GRNo = new Field("GRNo","Grade","GRNo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("State","Grade","State");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Gxkstate = new Field("Gxkstate","Grade","Gxkstate");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Credithour = new Field("Credithour","Grade","Credithour");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field NeedPoint = new Field("NeedPoint","Grade","NeedPoint");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PubNums = new Field("PubNums","Grade","PubNums");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field RGstate = new Field("RGstate","Grade","RGstate");
		}
		#endregion


	}
}

