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
	/// 实体类Stu 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("stu")]
	[Serializable]
	public partial class Stu : Entity 
	{
		#region Model
		private string _学号;
		private string _系部;
		private string _专业;
		private string _年级;
		private string _班级;
		private string _学生姓名;
		private string _性别;
		private string _入学方式;
		private string _State;
		/// <summary>
		/// 
		/// </summary>
		public string 学号
		{
			get{ return _学号; }
			set
			{
				this.OnPropertyValueChange(_.学号,_学号,value);
				this._学号=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 系部
		{
			get{ return _系部; }
			set
			{
				this.OnPropertyValueChange(_.系部,_系部,value);
				this._系部=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 专业
		{
			get{ return _专业; }
			set
			{
				this.OnPropertyValueChange(_.专业,_专业,value);
				this._专业=value;
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
		public string 班级
		{
			get{ return _班级; }
			set
			{
				this.OnPropertyValueChange(_.班级,_班级,value);
				this._班级=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 学生姓名
		{
			get{ return _学生姓名; }
			set
			{
				this.OnPropertyValueChange(_.学生姓名,_学生姓名,value);
				this._学生姓名=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 性别
		{
			get{ return _性别; }
			set
			{
				this.OnPropertyValueChange(_.性别,_性别,value);
				this._性别=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 入学方式
		{
			get{ return _入学方式; }
			set
			{
				this.OnPropertyValueChange(_.入学方式,_入学方式,value);
				this._入学方式=value;
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
		#endregion

		#region Method
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.学号,
				_.系部,
				_.专业,
				_.年级,
				_.班级,
				_.学生姓名,
				_.性别,
				_.入学方式,
				_.State};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._学号,
				this._系部,
				this._专业,
				this._年级,
				this._班级,
				this._学生姓名,
				this._性别,
				this._入学方式,
				this._State};
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
			public readonly static Field All = new Field("*","stu");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学号 = new Field("学号","stu","学号");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 系部 = new Field("系部","stu","系部");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 专业 = new Field("专业","stu","专业");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 年级 = new Field("年级","stu","年级");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 班级 = new Field("班级","stu","班级");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 学生姓名 = new Field("学生姓名","stu","学生姓名");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 性别 = new Field("性别","stu","性别");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field 入学方式 = new Field("入学方式","stu","入学方式");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field State = new Field("state","stu","state");
		}
		#endregion


	}
}

