using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cost_estimating.RLC
{
    /// <summary>
    /// baseRLC里面静态变量的类，防止所有子类具有一样的静态变量
    /// </summary>
    /// <typeparam name="T">where T:BaseRLC约束T只能是BaseRLC或它的子类</typeparam>
    public class BaseRLCStaticVariables<T> where T:BaseRLC
    {
        public static double dTotalPower { get; set; }//总功率
        public static double dTotalSinglePhasePower { get; set; }//总单相功率
        public static double dTotalCurrent { get; set; }//总电流
        public static int iTotalNumber { get; set; }//总电阻/电抗/电容个数

        /// <summary>
        /// 叠加静态变量
        /// </summary>
        /// <param name="d_three_phase_power">总功率</param>
        /// <param name="d_single_phase_power">总单相功率</param>
        /// <param name="d_Current">总电流</param>
        /// <param name="iNumThree">总电阻/电抗/电容个数</param>
        public void Total(double d_three_phase_power, double d_single_phase_power, double d_Current, int iNumThree)
        {
            dTotalPower +=  d_three_phase_power;
            dTotalSinglePhasePower += d_single_phase_power;
            dTotalCurrent += d_Current;
            iTotalNumber += iNumThree;
        }

        public string[] GetTotalStringArr()
        {
            string[] arr = {
                               "总功率",
                               dTotalPower.ToString(),
                               "总单相功率",
                               dTotalSinglePhasePower.ToString(),
                               "总电流",
                               dTotalCurrent.ToString(),
                               "总个数",
                               iTotalNumber.ToString()
                           };
            return arr;
        }
        /// <summary>
        /// 删除电阻/电抗/电容
        /// </summary>
        /// <param name="power">总功率</param>
        /// <param name="current">总电流</param>
        /// <param name="num">总个数</param>
        public void DelectRLC(int power, double current, int num)
        {
            dTotalPower -= power;
            dTotalSinglePhasePower = dTotalPower / 3;
            dTotalCurrent -= current;
            iTotalNumber -= num;
        }
        /// <summary>
        /// 类的变量全为0
        /// </summary>
        public void clear()
        {
            dTotalPower = 0;
            dTotalSinglePhasePower = 0;
            dTotalCurrent = 0;
            iTotalNumber = 0;
        }
    }
}
