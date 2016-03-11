using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DJTUStudentSystem.Interface
{
    public  interface IDataBaseModelToViewModel<T,T2>
    {
       List<T> ConvertDataBaseModelToViewModel(List<T2> t);
    }
}
