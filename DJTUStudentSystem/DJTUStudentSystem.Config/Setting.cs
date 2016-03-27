using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DJTUStudentSystem.Config
{
    public class Setting
    {
        private static bool AllowChooseChourse = true;//是否允许选课
        private static DateTime StartChooseTime { get; set; }//开始选课时间        
        private static DateTime EndChooseTime { get; set; }//结束选课时间
        public static int AllowConfictWeeks = 3;//选课时，所选的课程与学生课表存在冲突时，允许冲突几周
        public static bool isReadFromDB = false;//是否忽略缓存，从数据库直接读取数据；
       public static List<GradeCanChooseCourseModel> GradeCanChooseCourse()//哪个年纪可以选课
        {
            GradeCanChooseCourseModel _GradeCanChooseCourseModel = new GradeCanChooseCourseModel() { GradeName = "2012", HowManyCanChoose = 3, isChooseCouse = true };
            GradeCanChooseCourseModel _GradeCanChooseCourseModel1 = new GradeCanChooseCourseModel() { GradeName = "2013", HowManyCanChoose = 2, isChooseCouse = true };
            GradeCanChooseCourseModel _GradeCanChooseCourseModel2 = new GradeCanChooseCourseModel() { GradeName = "2014", HowManyCanChoose = 1, isChooseCouse = true };
            List<GradeCanChooseCourseModel> _GradeCanChooseCourseModelList = new List<GradeCanChooseCourseModel>();
            
            _GradeCanChooseCourseModelList.Add(_GradeCanChooseCourseModel);
            _GradeCanChooseCourseModelList.Add(_GradeCanChooseCourseModel1);
            _GradeCanChooseCourseModelList.Add(_GradeCanChooseCourseModel2);
            
            return _GradeCanChooseCourseModelList;
        }


    }
    public class GradeCanChooseCourseModel//哪个年纪可以选课，可以选几门
    {
       
        public string GradeName { get; set; }
        public bool isChooseCouse { get; set; }
        public int HowManyCanChoose { get; set; }
    }
}
