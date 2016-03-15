using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DJTUStudentSystem.MVCWEB.Models
{
    /// <summary>
    /// 课程表抽象实体 便于生成课程用
    /// </summary>
    public abstract class AbstractKCBViewModel
    {
        public string CourseName
        { get; set; }         //课程名称
        public string TeacherName
        { get; set; }         //任课教师姓名
        public int? Week { get; set; }                  //上课星期
        public int? StartWeek { get; set; }           //起始周
        public int? EndWeek { get; set; }             //结束周
        public string SingleOrDouble { get; set; }     //单双周
        public string RoomName { get; set; }       //上课教室
        public int? TCID { get; set; }              //TeachAndClass(聘课表)的ID
        public int? PSID { get; set; }              //RSDA(教师表) 的ID
        public int? CCID { get; set; }              //Curricula (课程库表)的ID
        public int? CSID { get; set; }              //Cshe (课程库表)的ID
        public string Section { get; set; }              //上课的节数
        public string TCName { get; set; }              //教学班级名称
    }
}
