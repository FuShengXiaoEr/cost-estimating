using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cost_estimating.RLC
{
    /// <summary>
    /// 电容
    /// </summary>
    public class Capacitance:BaseRLC
    {
        /// <summary>
        /// 容抗，容抗（Ω）=相电压（V）*相电压（V）/单相功率（var）
        /// </summary>
        public double capacitiveReactance { get; set; }
        /// <summary>
        /// 电容值，电容值（uF）=(1/(容抗*3.14))*10000
        /// </summary>
        public double capacitanceValue { get; set; }

        private static Capacitance capacitance;
        private static readonly object _lock = new object();
        /// <summary>
        /// 私有构造函数，防止外部直接创建实例
        /// </summary>
        private Capacitance() 
        {
            this.culomnsName = new string[] { "相电压", "三相功率", "单相功率", "电流", "接触器", "导线", "容抗", "电容值", "单相电容数量", "三相电容数量" };
            this.projectName = "C载部分 ";
        }

        /// <summary>
        /// 得到电容的实例
        /// </summary>
        /// <param name="i_phase_voltage">相电压</param>
        /// <param name="d_three_phase_power">三相功率</param>
        /// <param name="cocontactor">接触器</param>
        /// <param name="wireSize">导线大小</param>
        /// <param name="RNumber">单相电阻管数量</param>
        /// <returns></returns>
        public static Capacitance GetInstance()
        {
            lock (_lock)
            {
                if (capacitance == null)
                {
                    capacitance = new Capacitance();
                }
                return capacitance;
            }
        }
        /// <summary>
        /// 计算电容值
        /// </summary>
        /// <param name="i_phase_voltage">相电压</param>
        /// <param name="d_three_phase_power">三相功率</param>
        /// <param name="cocontactor">接触器</param>
        /// <param name="wireSize">导线大小</param>
        /// <param name="RNumber">单相电阻管数量</param>
        public override void CalculatingParam(int i_phase_voltage, double d_three_phase_power, string cocontactor, string wireSize, int RNumber)
        {
            base.CalculatingRLC(i_phase_voltage, d_three_phase_power, cocontactor, wireSize, RNumber);
            //容抗（Ω）=相电压*相电压/单相功率
            this.capacitiveReactance = Math.Round(i_phase_voltage * i_phase_voltage / d_single_phase_power, 4);
            this.capacitanceValue=Math.Round((1/(this.capacitiveReactance*3.14))*10000,2);
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
                                 capacitiveReactance.ToString(),
                                 capacitanceValue.ToString(),
                                 iNumSingle.ToString(),
                                 iNumThree.ToString()
                            };
            return strArr;
        }
    }
}
