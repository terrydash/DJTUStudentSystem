﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Support: http://www.cnblogs.com/huxj
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

namespace DJTUStudentSystem
{

    /// <summary>
    /// 实体类RSDA 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class RSDA : Entity
    {
        public RSDA() : base("RSDA") { }

        #region Model
        private int _PSID;
        private int? _ComeAtyid;
        private int? _DeptId;
        private int? _EduDeptID;
        private string _Account;
        private string _Password;
        private string _PsName;
        private string _UsedName;
        private string _StandCode;
        private string _PYCode;
        private string _Sex;
        private string _Marry;
        private string _Birthday;
        private int? _Nation;
        private string _CultureLev;
        private string _Degree;
        private string _StartWork;
        private string _Polity;
        private string _ComeDate;
        private string _CardID;
        private string _HomePlace;
        private string _Address;
        private string _PostCode;
        private string _TelAndBPCall;
        private string _Email;
        private int? _Tectitle;
        private int? _Duty;
        private string _BiYeSchool;
        private string _BiYeSubject;
        private string _BiYeDateTime;
        private string _Relation;
        private string _RelationUnit;
        private string _RelationDuty;
        private string _RelationTel;
        private string _Selflove;
        private string _SelfGood;
        private string _State;
        private string _LiZhiRQ;
        private string _LiZhiSM;
        private string _Memo;
        private string _Resume;
        private string _Checked;
        private string _Checker;
        private string _Question;
        private string _ToTeacher;
        private string _ToDept;
        private string _ToEduma;
        private string _ToMaster;
        private int? _RoleID;
        private string _XKLB;
        private string _Xueyuan;
        private string _JSZB;
        private string _PDdate;
        /// <summary>
        /// 
        /// </summary>
        public int PSID
        {
            get { return _PSID; }
            set
            {
                this.OnPropertyValueChange(_.PSID, _PSID, value);
                this._PSID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ComeAtyid
        {
            get { return _ComeAtyid; }
            set
            {
                this.OnPropertyValueChange(_.ComeAtyid, _ComeAtyid, value);
                this._ComeAtyid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? DeptId
        {
            get { return _DeptId; }
            set
            {
                this.OnPropertyValueChange(_.DeptId, _DeptId, value);
                this._DeptId = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? EduDeptID
        {
            get { return _EduDeptID; }
            set
            {
                this.OnPropertyValueChange(_.EduDeptID, _EduDeptID, value);
                this._EduDeptID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Account
        {
            get { return _Account; }
            set
            {
                this.OnPropertyValueChange(_.Account, _Account, value);
                this._Account = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Password
        {
            get { return _Password; }
            set
            {
                this.OnPropertyValueChange(_.Password, _Password, value);
                this._Password = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PsName
        {
            get { return _PsName; }
            set
            {
                this.OnPropertyValueChange(_.PsName, _PsName, value);
                this._PsName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UsedName
        {
            get { return _UsedName; }
            set
            {
                this.OnPropertyValueChange(_.UsedName, _UsedName, value);
                this._UsedName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StandCode
        {
            get { return _StandCode; }
            set
            {
                this.OnPropertyValueChange(_.StandCode, _StandCode, value);
                this._StandCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PYCode
        {
            get { return _PYCode; }
            set
            {
                this.OnPropertyValueChange(_.PYCode, _PYCode, value);
                this._PYCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Sex
        {
            get { return _Sex; }
            set
            {
                this.OnPropertyValueChange(_.Sex, _Sex, value);
                this._Sex = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Marry
        {
            get { return _Marry; }
            set
            {
                this.OnPropertyValueChange(_.Marry, _Marry, value);
                this._Marry = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Birthday
        {
            get { return _Birthday; }
            set
            {
                this.OnPropertyValueChange(_.Birthday, _Birthday, value);
                this._Birthday = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Nation
        {
            get { return _Nation; }
            set
            {
                this.OnPropertyValueChange(_.Nation, _Nation, value);
                this._Nation = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CultureLev
        {
            get { return _CultureLev; }
            set
            {
                this.OnPropertyValueChange(_.CultureLev, _CultureLev, value);
                this._CultureLev = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Degree
        {
            get { return _Degree; }
            set
            {
                this.OnPropertyValueChange(_.Degree, _Degree, value);
                this._Degree = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StartWork
        {
            get { return _StartWork; }
            set
            {
                this.OnPropertyValueChange(_.StartWork, _StartWork, value);
                this._StartWork = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Polity
        {
            get { return _Polity; }
            set
            {
                this.OnPropertyValueChange(_.Polity, _Polity, value);
                this._Polity = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ComeDate
        {
            get { return _ComeDate; }
            set
            {
                this.OnPropertyValueChange(_.ComeDate, _ComeDate, value);
                this._ComeDate = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CardID
        {
            get { return _CardID; }
            set
            {
                this.OnPropertyValueChange(_.CardID, _CardID, value);
                this._CardID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HomePlace
        {
            get { return _HomePlace; }
            set
            {
                this.OnPropertyValueChange(_.HomePlace, _HomePlace, value);
                this._HomePlace = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            get { return _Address; }
            set
            {
                this.OnPropertyValueChange(_.Address, _Address, value);
                this._Address = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PostCode
        {
            get { return _PostCode; }
            set
            {
                this.OnPropertyValueChange(_.PostCode, _PostCode, value);
                this._PostCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TelAndBPCall
        {
            get { return _TelAndBPCall; }
            set
            {
                this.OnPropertyValueChange(_.TelAndBPCall, _TelAndBPCall, value);
                this._TelAndBPCall = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            get { return _Email; }
            set
            {
                this.OnPropertyValueChange(_.Email, _Email, value);
                this._Email = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Tectitle
        {
            get { return _Tectitle; }
            set
            {
                this.OnPropertyValueChange(_.Tectitle, _Tectitle, value);
                this._Tectitle = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Duty
        {
            get { return _Duty; }
            set
            {
                this.OnPropertyValueChange(_.Duty, _Duty, value);
                this._Duty = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BiYeSchool
        {
            get { return _BiYeSchool; }
            set
            {
                this.OnPropertyValueChange(_.BiYeSchool, _BiYeSchool, value);
                this._BiYeSchool = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BiYeSubject
        {
            get { return _BiYeSubject; }
            set
            {
                this.OnPropertyValueChange(_.BiYeSubject, _BiYeSubject, value);
                this._BiYeSubject = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BiYeDateTime
        {
            get { return _BiYeDateTime; }
            set
            {
                this.OnPropertyValueChange(_.BiYeDateTime, _BiYeDateTime, value);
                this._BiYeDateTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Relation
        {
            get { return _Relation; }
            set
            {
                this.OnPropertyValueChange(_.Relation, _Relation, value);
                this._Relation = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RelationUnit
        {
            get { return _RelationUnit; }
            set
            {
                this.OnPropertyValueChange(_.RelationUnit, _RelationUnit, value);
                this._RelationUnit = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RelationDuty
        {
            get { return _RelationDuty; }
            set
            {
                this.OnPropertyValueChange(_.RelationDuty, _RelationDuty, value);
                this._RelationDuty = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RelationTel
        {
            get { return _RelationTel; }
            set
            {
                this.OnPropertyValueChange(_.RelationTel, _RelationTel, value);
                this._RelationTel = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Selflove
        {
            get { return _Selflove; }
            set
            {
                this.OnPropertyValueChange(_.Selflove, _Selflove, value);
                this._Selflove = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SelfGood
        {
            get { return _SelfGood; }
            set
            {
                this.OnPropertyValueChange(_.SelfGood, _SelfGood, value);
                this._SelfGood = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string State
        {
            get { return _State; }
            set
            {
                this.OnPropertyValueChange(_.State, _State, value);
                this._State = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LiZhiRQ
        {
            get { return _LiZhiRQ; }
            set
            {
                this.OnPropertyValueChange(_.LiZhiRQ, _LiZhiRQ, value);
                this._LiZhiRQ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LiZhiSM
        {
            get { return _LiZhiSM; }
            set
            {
                this.OnPropertyValueChange(_.LiZhiSM, _LiZhiSM, value);
                this._LiZhiSM = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Memo
        {
            get { return _Memo; }
            set
            {
                this.OnPropertyValueChange(_.Memo, _Memo, value);
                this._Memo = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Resume
        {
            get { return _Resume; }
            set
            {
                this.OnPropertyValueChange(_.Resume, _Resume, value);
                this._Resume = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Checked
        {
            get { return _Checked; }
            set
            {
                this.OnPropertyValueChange(_.Checked, _Checked, value);
                this._Checked = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Checker
        {
            get { return _Checker; }
            set
            {
                this.OnPropertyValueChange(_.Checker, _Checker, value);
                this._Checker = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Question
        {
            get { return _Question; }
            set
            {
                this.OnPropertyValueChange(_.Question, _Question, value);
                this._Question = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ToTeacher
        {
            get { return _ToTeacher; }
            set
            {
                this.OnPropertyValueChange(_.ToTeacher, _ToTeacher, value);
                this._ToTeacher = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ToDept
        {
            get { return _ToDept; }
            set
            {
                this.OnPropertyValueChange(_.ToDept, _ToDept, value);
                this._ToDept = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ToEduma
        {
            get { return _ToEduma; }
            set
            {
                this.OnPropertyValueChange(_.ToEduma, _ToEduma, value);
                this._ToEduma = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ToMaster
        {
            get { return _ToMaster; }
            set
            {
                this.OnPropertyValueChange(_.ToMaster, _ToMaster, value);
                this._ToMaster = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? RoleID
        {
            get { return _RoleID; }
            set
            {
                this.OnPropertyValueChange(_.RoleID, _RoleID, value);
                this._RoleID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string XKLB
        {
            get { return _XKLB; }
            set
            {
                this.OnPropertyValueChange(_.XKLB, _XKLB, value);
                this._XKLB = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Xueyuan
        {
            get { return _Xueyuan; }
            set
            {
                this.OnPropertyValueChange(_.Xueyuan, _Xueyuan, value);
                this._Xueyuan = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JSZB
        {
            get { return _JSZB; }
            set
            {
                this.OnPropertyValueChange(_.JSZB, _JSZB, value);
                this._JSZB = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PDdate
        {
            get { return _PDdate; }
            set
            {
                this.OnPropertyValueChange(_.PDdate, _PDdate, value);
                this._PDdate = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.PSID;
        }
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                _.PSID};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.PSID,
                _.ComeAtyid,
                _.DeptId,
                _.EduDeptID,
                _.Account,
                _.Password,
                _.PsName,
                _.UsedName,
                _.StandCode,
                _.PYCode,
                _.Sex,
                _.Marry,
                _.Birthday,
                _.Nation,
                _.CultureLev,
                _.Degree,
                _.StartWork,
                _.Polity,
                _.ComeDate,
                _.CardID,
                _.HomePlace,
                _.Address,
                _.PostCode,
                _.TelAndBPCall,
                _.Email,
                _.Tectitle,
                _.Duty,
                _.BiYeSchool,
                _.BiYeSubject,
                _.BiYeDateTime,
                _.Relation,
                _.RelationUnit,
                _.RelationDuty,
                _.RelationTel,
                _.Selflove,
                _.SelfGood,
                _.State,
                _.LiZhiRQ,
                _.LiZhiSM,
                _.Memo,
                _.Resume,
                _.Checked,
                _.Checker,
                _.Question,
                _.ToTeacher,
                _.ToDept,
                _.ToEduma,
                _.ToMaster,
                _.RoleID,
                _.XKLB,
                _.Xueyuan,
                _.JSZB,
                _.PDdate};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._PSID,
                this._ComeAtyid,
                this._DeptId,
                this._EduDeptID,
                this._Account,
                this._Password,
                this._PsName,
                this._UsedName,
                this._StandCode,
                this._PYCode,
                this._Sex,
                this._Marry,
                this._Birthday,
                this._Nation,
                this._CultureLev,
                this._Degree,
                this._StartWork,
                this._Polity,
                this._ComeDate,
                this._CardID,
                this._HomePlace,
                this._Address,
                this._PostCode,
                this._TelAndBPCall,
                this._Email,
                this._Tectitle,
                this._Duty,
                this._BiYeSchool,
                this._BiYeSubject,
                this._BiYeDateTime,
                this._Relation,
                this._RelationUnit,
                this._RelationDuty,
                this._RelationTel,
                this._Selflove,
                this._SelfGood,
                this._State,
                this._LiZhiRQ,
                this._LiZhiSM,
                this._Memo,
                this._Resume,
                this._Checked,
                this._Checker,
                this._Question,
                this._ToTeacher,
                this._ToDept,
                this._ToEduma,
                this._ToMaster,
                this._RoleID,
                this._XKLB,
                this._Xueyuan,
                this._JSZB,
                this._PDdate};
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._PSID = DataUtils.ConvertValue<int>(reader["PSID"]);
            this._ComeAtyid = DataUtils.ConvertValue<int?>(reader["ComeAtyid"]);
            this._DeptId = DataUtils.ConvertValue<int?>(reader["DeptId"]);
            this._EduDeptID = DataUtils.ConvertValue<int?>(reader["EduDeptID"]);
            this._Account = DataUtils.ConvertValue<string>(reader["Account"]);
            this._Password = DataUtils.ConvertValue<string>(reader["Password"]);
            this._PsName = DataUtils.ConvertValue<string>(reader["PsName"]);
            this._UsedName = DataUtils.ConvertValue<string>(reader["UsedName"]);
            this._StandCode = DataUtils.ConvertValue<string>(reader["StandCode"]);
            this._PYCode = DataUtils.ConvertValue<string>(reader["PYCode"]);
            this._Sex = DataUtils.ConvertValue<string>(reader["Sex"]);
            this._Marry = DataUtils.ConvertValue<string>(reader["Marry"]);
            this._Birthday = DataUtils.ConvertValue<string>(reader["Birthday"]);
            this._Nation = DataUtils.ConvertValue<int?>(reader["Nation"]);
            this._CultureLev = DataUtils.ConvertValue<string>(reader["CultureLev"]);
            this._Degree = DataUtils.ConvertValue<string>(reader["Degree"]);
            this._StartWork = DataUtils.ConvertValue<string>(reader["StartWork"]);
            this._Polity = DataUtils.ConvertValue<string>(reader["Polity"]);
            this._ComeDate = DataUtils.ConvertValue<string>(reader["ComeDate"]);
            this._CardID = DataUtils.ConvertValue<string>(reader["CardID"]);
            this._HomePlace = DataUtils.ConvertValue<string>(reader["HomePlace"]);
            this._Address = DataUtils.ConvertValue<string>(reader["Address"]);
            this._PostCode = DataUtils.ConvertValue<string>(reader["PostCode"]);
            this._TelAndBPCall = DataUtils.ConvertValue<string>(reader["TelAndBPCall"]);
            this._Email = DataUtils.ConvertValue<string>(reader["Email"]);
            this._Tectitle = DataUtils.ConvertValue<int?>(reader["Tectitle"]);
            this._Duty = DataUtils.ConvertValue<int?>(reader["Duty"]);
            this._BiYeSchool = DataUtils.ConvertValue<string>(reader["BiYeSchool"]);
            this._BiYeSubject = DataUtils.ConvertValue<string>(reader["BiYeSubject"]);
            this._BiYeDateTime = DataUtils.ConvertValue<string>(reader["BiYeDateTime"]);
            this._Relation = DataUtils.ConvertValue<string>(reader["Relation"]);
            this._RelationUnit = DataUtils.ConvertValue<string>(reader["RelationUnit"]);
            this._RelationDuty = DataUtils.ConvertValue<string>(reader["RelationDuty"]);
            this._RelationTel = DataUtils.ConvertValue<string>(reader["RelationTel"]);
            this._Selflove = DataUtils.ConvertValue<string>(reader["selflove"]);
            this._SelfGood = DataUtils.ConvertValue<string>(reader["selfGood"]);
            this._State = DataUtils.ConvertValue<string>(reader["State"]);
            this._LiZhiRQ = DataUtils.ConvertValue<string>(reader["LiZhiRQ"]);
            this._LiZhiSM = DataUtils.ConvertValue<string>(reader["LiZhiSM"]);
            this._Memo = DataUtils.ConvertValue<string>(reader["Memo"]);
            this._Resume = DataUtils.ConvertValue<string>(reader["Resume"]);
            this._Checked = DataUtils.ConvertValue<string>(reader["Checked"]);
            this._Checker = DataUtils.ConvertValue<string>(reader["Checker"]);
            this._Question = DataUtils.ConvertValue<string>(reader["Question"]);
            this._ToTeacher = DataUtils.ConvertValue<string>(reader["ToTeacher"]);
            this._ToDept = DataUtils.ConvertValue<string>(reader["ToDept"]);
            this._ToEduma = DataUtils.ConvertValue<string>(reader["ToEduma"]);
            this._ToMaster = DataUtils.ConvertValue<string>(reader["ToMaster"]);
            this._RoleID = DataUtils.ConvertValue<int?>(reader["RoleID"]);
            this._XKLB = DataUtils.ConvertValue<string>(reader["XKLB"]);
            this._Xueyuan = DataUtils.ConvertValue<string>(reader["Xueyuan"]);
            this._JSZB = DataUtils.ConvertValue<string>(reader["JSZB"]);
            this._PDdate = DataUtils.ConvertValue<string>(reader["PDdate"]);
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._PSID = DataUtils.ConvertValue<int>(row["PSID"]);
            this._ComeAtyid = DataUtils.ConvertValue<int?>(row["ComeAtyid"]);
            this._DeptId = DataUtils.ConvertValue<int?>(row["DeptId"]);
            this._EduDeptID = DataUtils.ConvertValue<int?>(row["EduDeptID"]);
            this._Account = DataUtils.ConvertValue<string>(row["Account"]);
            this._Password = DataUtils.ConvertValue<string>(row["Password"]);
            this._PsName = DataUtils.ConvertValue<string>(row["PsName"]);
            this._UsedName = DataUtils.ConvertValue<string>(row["UsedName"]);
            this._StandCode = DataUtils.ConvertValue<string>(row["StandCode"]);
            this._PYCode = DataUtils.ConvertValue<string>(row["PYCode"]);
            this._Sex = DataUtils.ConvertValue<string>(row["Sex"]);
            this._Marry = DataUtils.ConvertValue<string>(row["Marry"]);
            this._Birthday = DataUtils.ConvertValue<string>(row["Birthday"]);
            this._Nation = DataUtils.ConvertValue<int?>(row["Nation"]);
            this._CultureLev = DataUtils.ConvertValue<string>(row["CultureLev"]);
            this._Degree = DataUtils.ConvertValue<string>(row["Degree"]);
            this._StartWork = DataUtils.ConvertValue<string>(row["StartWork"]);
            this._Polity = DataUtils.ConvertValue<string>(row["Polity"]);
            this._ComeDate = DataUtils.ConvertValue<string>(row["ComeDate"]);
            this._CardID = DataUtils.ConvertValue<string>(row["CardID"]);
            this._HomePlace = DataUtils.ConvertValue<string>(row["HomePlace"]);
            this._Address = DataUtils.ConvertValue<string>(row["Address"]);
            this._PostCode = DataUtils.ConvertValue<string>(row["PostCode"]);
            this._TelAndBPCall = DataUtils.ConvertValue<string>(row["TelAndBPCall"]);
            this._Email = DataUtils.ConvertValue<string>(row["Email"]);
            this._Tectitle = DataUtils.ConvertValue<int?>(row["Tectitle"]);
            this._Duty = DataUtils.ConvertValue<int?>(row["Duty"]);
            this._BiYeSchool = DataUtils.ConvertValue<string>(row["BiYeSchool"]);
            this._BiYeSubject = DataUtils.ConvertValue<string>(row["BiYeSubject"]);
            this._BiYeDateTime = DataUtils.ConvertValue<string>(row["BiYeDateTime"]);
            this._Relation = DataUtils.ConvertValue<string>(row["Relation"]);
            this._RelationUnit = DataUtils.ConvertValue<string>(row["RelationUnit"]);
            this._RelationDuty = DataUtils.ConvertValue<string>(row["RelationDuty"]);
            this._RelationTel = DataUtils.ConvertValue<string>(row["RelationTel"]);
            this._Selflove = DataUtils.ConvertValue<string>(row["selflove"]);
            this._SelfGood = DataUtils.ConvertValue<string>(row["selfGood"]);
            this._State = DataUtils.ConvertValue<string>(row["State"]);
            this._LiZhiRQ = DataUtils.ConvertValue<string>(row["LiZhiRQ"]);
            this._LiZhiSM = DataUtils.ConvertValue<string>(row["LiZhiSM"]);
            this._Memo = DataUtils.ConvertValue<string>(row["Memo"]);
            this._Resume = DataUtils.ConvertValue<string>(row["Resume"]);
            this._Checked = DataUtils.ConvertValue<string>(row["Checked"]);
            this._Checker = DataUtils.ConvertValue<string>(row["Checker"]);
            this._Question = DataUtils.ConvertValue<string>(row["Question"]);
            this._ToTeacher = DataUtils.ConvertValue<string>(row["ToTeacher"]);
            this._ToDept = DataUtils.ConvertValue<string>(row["ToDept"]);
            this._ToEduma = DataUtils.ConvertValue<string>(row["ToEduma"]);
            this._ToMaster = DataUtils.ConvertValue<string>(row["ToMaster"]);
            this._RoleID = DataUtils.ConvertValue<int?>(row["RoleID"]);
            this._XKLB = DataUtils.ConvertValue<string>(row["XKLB"]);
            this._Xueyuan = DataUtils.ConvertValue<string>(row["Xueyuan"]);
            this._JSZB = DataUtils.ConvertValue<string>(row["JSZB"]);
            this._PDdate = DataUtils.ConvertValue<string>(row["PDdate"]);
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
            public readonly static Field All = new Field("*", "RSDA");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PSID = new Field("PSID", "RSDA", "PSID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ComeAtyid = new Field("ComeAtyid", "RSDA", "ComeAtyid");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DeptId = new Field("DeptId", "RSDA", "DeptId");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field EduDeptID = new Field("EduDeptID", "RSDA", "EduDeptID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Account = new Field("Account", "RSDA", "Account");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Password = new Field("Password", "RSDA", "Password");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PsName = new Field("PsName", "RSDA", "PsName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UsedName = new Field("UsedName", "RSDA", "UsedName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field StandCode = new Field("StandCode", "RSDA", "StandCode");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PYCode = new Field("PYCode", "RSDA", "PYCode");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Sex = new Field("Sex", "RSDA", "Sex");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Marry = new Field("Marry", "RSDA", "Marry");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Birthday = new Field("Birthday", "RSDA", "Birthday");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Nation = new Field("Nation", "RSDA", "Nation");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CultureLev = new Field("CultureLev", "RSDA", "CultureLev");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Degree = new Field("Degree", "RSDA", "Degree");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field StartWork = new Field("StartWork", "RSDA", "StartWork");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Polity = new Field("Polity", "RSDA", "Polity");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ComeDate = new Field("ComeDate", "RSDA", "ComeDate");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CardID = new Field("CardID", "RSDA", "CardID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field HomePlace = new Field("HomePlace", "RSDA", "HomePlace");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Address = new Field("Address", "RSDA", "Address");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PostCode = new Field("PostCode", "RSDA", "PostCode");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TelAndBPCall = new Field("TelAndBPCall", "RSDA", "TelAndBPCall");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Email = new Field("Email", "RSDA", "Email");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Tectitle = new Field("Tectitle", "RSDA", "Tectitle");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Duty = new Field("Duty", "RSDA", "Duty");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BiYeSchool = new Field("BiYeSchool", "RSDA", "BiYeSchool");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BiYeSubject = new Field("BiYeSubject", "RSDA", "BiYeSubject");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BiYeDateTime = new Field("BiYeDateTime", "RSDA", "BiYeDateTime");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Relation = new Field("Relation", "RSDA", "Relation");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RelationUnit = new Field("RelationUnit", "RSDA", "RelationUnit");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RelationDuty = new Field("RelationDuty", "RSDA", "RelationDuty");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RelationTel = new Field("RelationTel", "RSDA", "RelationTel");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Selflove = new Field("selflove", "RSDA", "selflove");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SelfGood = new Field("selfGood", "RSDA", "selfGood");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field State = new Field("State", "RSDA", "State");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field LiZhiRQ = new Field("LiZhiRQ", "RSDA", "LiZhiRQ");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field LiZhiSM = new Field("LiZhiSM", "RSDA", "LiZhiSM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Memo = new Field("Memo", "RSDA", "Memo");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Resume = new Field("Resume", "RSDA", "Resume");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Checked = new Field("Checked", "RSDA", "Checked");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Checker = new Field("Checker", "RSDA", "Checker");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Question = new Field("Question", "RSDA", "Question");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ToTeacher = new Field("ToTeacher", "RSDA", "ToTeacher");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ToDept = new Field("ToDept", "RSDA", "ToDept");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ToEduma = new Field("ToEduma", "RSDA", "ToEduma");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ToMaster = new Field("ToMaster", "RSDA", "ToMaster");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RoleID = new Field("RoleID", "RSDA", "RoleID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field XKLB = new Field("XKLB", "RSDA", "XKLB");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Xueyuan = new Field("Xueyuan", "RSDA", "Xueyuan");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field JSZB = new Field("JSZB", "RSDA", "JSZB");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PDdate = new Field("PDdate", "RSDA", "PDdate");
        }
        #endregion


    }
}

