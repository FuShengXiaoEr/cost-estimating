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

        public int iNumSingle { get; set; }//单相电阻管数量(电容/电抗默认为1)
        public int iNumThree { get; set; }//三相电阻管数量

        public static double dTotalPower { get; set; }//总功率
        public static double dTotalSinglePhasePower { get; set; }//总单相功率
        public static double dTotalCurrent { get; set; }//总电流
        public static int iTotalNumber { get; set; }//总电阻/电抗/电容个数

        public BaseRLC() { }

        /// <summary>
        /// 构造函数，删除时用
        /// </summary>
        /// <param name="power">三相功率</param>
        /// <param name="current">电流</param>
        /// <param name="num">三相电阻/电抗/电容数量</param>
        public BaseRLC(int power, double current, int num)
        {
            this.d_three_phase_power = power;
            this.d_Current = current;
            this.iNumThree = num;
        }

        /// <summary>
        /// 计算电阻/电容/电感公共参数
        /// </summary>
        /// <param name="i_phase_voltage">相电压</param>
        /// <param name="d_three_phase_power">三相功率</param>
        /// <param name="cocontactor">接触器</param>
        /// <param name="wireSize">导线大小</param>
        /// <param name="RNumber">单相电阻管数量</param>
        public void CalculatingRLC(int i_phase_voltage, double d_three_phase_power, string cocontactor, string wireSize, int RNumber)
        {
            this.i_phase_voltage = i_phase_voltage;//相电压
            this.d_three_phase_power = d_three_phase_power;//三相功率
            //单相功率（W）=三相功率（W）/3
            this.d_single_phase_power = Math.Round((double)d_three_phase_power / 3, 4);
            //电流（A）=单相功率（W）/相电压（V）
            if (i_phase_voltage == 0)
                d_Current = 0;
            else
                d_Current = Math.Round(d_single_phase_power / i_phase_voltage, 4);
            this.str_cocontactor = cocontactor;//接触器
            this.str_wire = wireSize;//导线大小
            //阻值（Ω）=相电压*相电压/单相功率

            if (RNumber < 1)
                RNumber = 1;
            iNumSingle = RNumber;//单相电阻管数量
            this.iNumThree = this.iNumSingle * 3;

            dTotalPower += d_three_phase_power;
            dTotalSinglePhasePower += d_single_phase_power;
            dTotalCurrent += d_Current;
            iTotalNumber += iNumThree;
        }

        /// <summary>
        /// 得到电阻/电抗/电容的总功率、总单相功率、总电流、总个数的string数组
        /// </summary>
        /// <returns></returns>
        public string[] GetTotalStringArr()
        {
            string[] arr = {
                               dTotalPower.ToString(),
                               dTotalSinglePhasePower.ToString(),
                               dTotalCurrent.ToString(),
                               iTotalNumber.ToString()
                           };
            return arr;
        }

        /// <summary>
        /// 删除电阻/电抗/电容
        /// </summary>
        /// <param name="baseRLC">电阻/电抗/电容</param>
        public void DelectRLC(BaseRLC baseRLC)
        {
            dTotalPower -= baseRLC.d_three_phase_power;
            dTotalSinglePhasePower = dTotalPower / 3;
            dTotalCurrent -= baseRLC.d_Current;
            iTotalNumber -= baseRLC.iNumThree;
        }
    }
}
