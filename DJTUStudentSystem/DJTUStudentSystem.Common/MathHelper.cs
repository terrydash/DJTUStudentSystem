using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DJTUStudentSystem.Common
{
    public class MathHelper
    {   /// <summary>
    /// 获得数列中的所有偶数
    /// </summary>
    /// <param name="StartNum"></param>
    /// <param name="EndNum"></param>
    /// <returns></returns>
        public static List<int> GetEvenNumbser(int StartNum,int EndNum)
        {
            List<int> intlist = new List<int>();
            
            if (EndNum < StartNum) { return null; }
            for (int i = StartNum; i <= EndNum ; i++)
            {
                if (i % 2 == 0) { intlist.Add(i); }
                

            }
            return intlist;
        }
        /// <summary>
        /// 获得数列中的所有奇数
        /// </summary>
        /// <param name="StartNum"></param>
        /// <param name="EndNum"></param>
        /// <returns></returns>
        public static List<int> GetOddNumbser(int StartNum, int EndNum)
        {
            List<int> intlist = new List<int>();
            if (EndNum < StartNum) { return null; }
                       
            for (int i = StartNum; i <= EndNum; i++)
            {
                if (i % 2 == 1) { intlist.Add(i); }


            }
            return intlist;
        }
    }
}
