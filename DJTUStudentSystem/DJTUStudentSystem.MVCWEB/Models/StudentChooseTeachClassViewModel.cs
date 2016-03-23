using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DJTUStudentSystem.MVCWEB.Models
{
    public class StudentChooseTeachClassViewModel :TeachClassViewModel
    {
        public int stuid { get; set; }
        public bool IsStudentChoose { get; set; }
        
    }
}
