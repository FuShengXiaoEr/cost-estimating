using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cost_estimating.RLC
{
    /// <summary>
    /// 电感L
    /// </summary>
    public class Inductance:BaseRLC
    {
        /// <summary>
        /// 感抗，感抗（Ω）=相电压（V）*相电压（V）/单相功率（var）
        /// </summary>
        public double inductiveReactance { get; set; }
        /// <summary>
        /// 电感值，= 感抗/3.14*10
        /// </summary>
        public double inductanceValue { get; set; }
        /// <summary>
        /// 总总功率、总单相功率、总电流、总个数的类
        /// </summary>
        BaseRLCStaticVariables<Inductance> total = new BaseRLCStaticVariables<Inductance>();

        private static Inductance inductance;
        private static readonly object _lock = new object();
        private Inductance() 
        {
            this.culomnsName = new string[] { "相电压(V)", "三相功率(var)", "单相功率(var)", "电流(A)", "接触器", "导线", "感抗(Ω)", "电感值(mH)", "单相电抗数量", "三相电抗数量" };
            this.projectName = "L载部分 ";
        }

        public static Inductance GetInstance()
        {
            lock (_lock)
            {
                if (inductance == null)
                {
                    inductance = new Inductance();
                }
                return inductance;
            }
        }

        public override void CalculatingParam(int i_phase_voltage, double d_three_phase_power, string cocontactor, string wireSize, int RNumber)
        {
            base.CalculatingRLC(i_phase_voltage, d_three_phase_power, cocontactor, wireSize, RNumber);
            this.inductiveReactance = Math.Round(i_phase_voltage * i_phase_voltage / d_single_phase_power, 2);
            this.inductanceValue = Math.Round(inductiveReactance / 3.14 * 10,2);
            total.Total(this.d_three_phase_power, this.d_single_phase_power, this.d_Current, this.iNumThree);
        }

        /// <summary>
        /// 得到电容参数数组
        /// </summary>
        /// <returns></returns>
        public override string[] ToStringArr()
        {
            string[] strArr ={
                                 i_phase_voltage.ToString(),
                                 d_three_phase_power.ToString(),
                                 d_single_phase_power.ToString(),
                                 d_Current.ToString(),
                                 str_cocontactor,
                                 str_wire,
                                 inductiveReactance.ToString(),
                                 inductanceValue.ToString(),
                                 iNumSingle.ToString(),
                                 iNumThree.ToString()
                            };
            return strArr;
        }
        public override string[] GetTotalStringArr()
        {
            return total.GetTotalStringArr();
        }

        public override void DelectRLC(int power, double current, int num)
        {
            total.DelectRLC(power, current, num);
        }

    }
}
