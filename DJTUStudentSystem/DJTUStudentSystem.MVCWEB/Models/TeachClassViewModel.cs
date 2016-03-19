using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DJTUStudentSystem.DataBaseModel;
using DJTUStudentSystem.Common;
using DJTUStudentSystem.Config;
using DJTUStudentSystem.Interface;
using DJTUStudentSystem.BLL;
namespace DJTUStudentSystem.MVCWEB.Models
{
    public class TeachClassViewModel:IDataBaseModelToViewModel<TeachClassViewModel,Vw_TeachClass>
    {
        public string CourseName { get; set; }//课程名称
        public int TCID { get; set; }//ID
        public string TeacherName { get; set; }//教师名称
        public int? OpenNum { get; set; } //开放人数
        public int? HaveNum { get; set; } //已选人数
        public string KCB { get; set; }// 课程表
        public List<TeachClassKCBViewModel> KCBList { get; set; } //课程表的列表
        public string SelectState { get; set; }//开放状态

        public List<TeachClassViewModel> ConvertDataBaseModelToViewModelList(List<Vw_TeachClass> _EntityList)
        {
            List<TeachClassViewModel> _TeachClassViewModelList = new List<TeachClassViewModel>();
            foreach (var item in _EntityList)
            {
                _TeachClassViewModelList.Add(ConvertDataBaseModelToViewModel(item));
            }
            return _TeachClassViewModelList;
        }

        public TeachClassViewModel ConvertDataBaseModelToViewModel(Vw_TeachClass _Entity)
        {
            TeachClassViewModel _TeachClassViewModel = new TeachClassViewModel();
            TeachClassKCBViewModel _TeachClassKCBViewModel = new TeachClassKCBViewModel();
            List<TeachClassKCBViewModel> _TeachClassKCBViewModelList = new List<TeachClassKCBViewModel>();
            LoadEntityListFromCache_BLL L_BLL = new LoadEntityListFromCache_BLL();
            
            var Vw_CscheduleList= L_BLL.GetNowVw_CscheduleByTCID(Setting.isReadFromDB, _Entity.TCID);
            foreach (var _Vw_Cschedule in Vw_CscheduleList)
            {
                _TeachClassKCBViewModel.CCID = _Vw_Cschedule.CCID;
                _TeachClassKCBViewModel.TCID = _Vw_Cschedule.TCID;
                _TeachClassKCBViewModel.CourseName = _Vw_Cschedule.CCname;
                _TeachClassKCBViewModel.CSID = _Vw_Cschedule.CSID;
                _TeachClassKCBViewModel.StartWeek = _Vw_Cschedule.StartW;
                _TeachClassKCBViewModel.EndWeek = _Vw_Cschedule.EndW;
                _TeachClassKCBViewModel.TeacherName = _Vw_Cschedule.PsName;
                _TeachClassKCBViewModel.PSID = _Vw_Cschedule.PSID;
                _TeachClassKCBViewModel.Section = _Vw_Cschedule.SectionTH;
                _TeachClassKCBViewModel.RoomName = _Vw_Cschedule.CRname;
                if (_Vw_Cschedule.DSZ != "整")
                { _TeachClassKCBViewModel.SingleOrDouble = "(" + _Vw_Cschedule.DSZ + "周)"; }
                else { _TeachClassKCBViewModel.SingleOrDouble = string.Empty; }

                _TeachClassKCBViewModel.Week = _Vw_Cschedule.DayOfWeek;
                var _KCB = "&nbsp;第" + _TeachClassKCBViewModel.StartWeek + "-" +_TeachClassKCBViewModel.EndWeek + "周&nbsp;周"+_TeachClassKCBViewModel.Week+"&nbsp" +_TeachClassKCBViewModel.Section+_TeachClassKCBViewModel.SingleOrDouble + "&nbsp;" + _TeachClassKCBViewModel.RoomName;
                if (string.IsNullOrEmpty(_TeachClassViewModel.KCB))
                {
                    _TeachClassViewModel.KCB = _KCB;

                }else
                {
                    _TeachClassViewModel.KCB = _TeachClassViewModel.KCB +_KCB;
                }
                _TeachClassKCBViewModelList.Add(_TeachClassKCBViewModel);
            }

            _TeachClassViewModel.CourseName = _Entity.课程名称;
            
            _TeachClassViewModel.KCBList = _TeachClassKCBViewModelList;
            if (_Entity.OpenNum == null) { _Entity.OpenNum = 0; }
            if (_Entity.Havenum == null) { _Entity.Havenum = 0; }
            
            _TeachClassViewModel.OpenNum = _Entity.OpenNum;
            _TeachClassViewModel.HaveNum = _Entity.Havenum;
            if (_TeachClassViewModel.HaveNum > _TeachClassViewModel.OpenNum)
            {

                _TeachClassViewModel.HaveNum = _TeachClassViewModel.OpenNum;
            }
            _TeachClassViewModel.TCID = _Entity.TCID;
            _TeachClassViewModel.TeacherName = _Entity.任课教师;
            _TeachClassViewModel.SelectState = _Entity.SelectState;
            return _TeachClassViewModel;

        }
    }
}
