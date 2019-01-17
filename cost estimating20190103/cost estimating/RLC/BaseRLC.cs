using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cost_estimating.RLC
{
    /// <summary>
    /// 电阻/电抗/电容的基类
    /// </summary>
    public class BaseRLC
    {
        public int i_Gear_position { get; set; }//档位
        /// <summary>
        /// 相电压
        /// </summary>
        public int i_phase_voltage{ get; set; }//相电压
        public double d_three_phase_power{ get; set; }//三相功率
        public double d_single_phase_power{ get; set; }//单相功率
        /// <summary>
        /// 
        /// </summary>
        public double d_Current{ get; set; }//电流
        public string str_cocontactor{ get; set; }//接触器
        public string str_wire{ get; set; }//导线


        public static double dTotalPower { get; set; }//总功率
        public static double dTotalSinglePhasePower { get; set; }//总单相功率
        public static double dTotalCurrent { get; set; }//总电流
        public static int iTotalNumber { get; set; }//总电阻/电抗/电容个数


    }
}
