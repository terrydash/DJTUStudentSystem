using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DJTUStudentSystem.Interface
{
      public interface IDataBaseModelToViewModel<T,T2>
    {
         List<T> ConvertDataBaseModelToViewModelList(List<T2> _EntityList);
        T ConvertDataBaseModelToViewModel(T2 _Entity);
    }
}
