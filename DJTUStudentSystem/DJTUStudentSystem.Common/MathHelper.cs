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
        public static int[] GetEvenNumbser(int StartNum,int EndNum)
        {
            int[] EvenNumbse = new int[] {0};
            int index = 0;
            if (EndNum < StartNum) { return null; }
            for (int i = StartNum; i <= EndNum ; i++)
            {
                if (i % 2 == 0) { EvenNumbse[index] = i; index += 1; }
                

            }
            return EvenNumbse;
        }
        /// <summary>
        /// 获得数列中的所有奇数
        /// </summary>
        /// <param name="StartNum"></param>
        /// <param name="EndNum"></param>
        /// <returns></returns>
        public static int[] GetOddNumbser(int StartNum, int EndNum)
        {
            if (EndNum < StartNum) { return null; }
            int[] OddNumbse = new int[] { 0 };
            int index = 0;
            for (int i = StartNum; i <= EndNum; i++)
            {
                if (i % 2 == 1) { OddNumbse[index] = i; index += 1; }


            }
            return OddNumbse;
        }
    }
}
