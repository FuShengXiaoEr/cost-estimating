using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cost_estimating.RLC
{
    /// <summary>
    /// 电阻
    /// </summary>
    public class Resistance:BaseRLC
    {
        public double dValueOfResistance{ get; set; }//阻值
        public double dResistancePowerSingle { get; set; }//单根电阻功率
        public double dResistanceValueSingle { get; set; }//单根电阻管阻值

        private static Resistance resistance;
        private static readonly object _lock = new object();

        /// <summary>
        /// 私有构造函数，防止外部直接创建实例
        /// </summary>
        private Resistance()
        {
            this.culomnsName = new string[] {"相电压", "三相功率", "单相功率", "电流", "接触器", "导线", "阻值", "单根电阻管功率", "单根电阻管阻值", "单相电阻管数量", "三相电阻管数量" };
        }
        /// <summary>
        /// 得到电阻实例
        /// </summary>
        /// <param name="i_phase_voltage">相电压</param>
        /// <param name="d_three_phase_power">三相功率</param>
        /// <param name="cocontactor">接触器</param>
        /// <param name="wireSize">导线大小</param>
        /// <param name="RNumber">单相电阻管数量</param>
        /// <returns></returns>
        public static Resistance GetInstance()
        {
            lock (_lock)
            {
                if (resistance == null)
                {
                    resistance = new Resistance();
                }
                return resistance;
            }
        }
        /// <summary>
        /// 计算电阻参数
        /// </summary>
        /// <param name="i_phase_voltage">相电压</param>
        /// <param name="d_three_phase_power">三相功率</param>
        /// <param name="cocontactor">接触器</param>
        /// <param name="wireSize">导线大小</param>
        /// <param name="RNumber">单相电阻管数量</param>
        public override void CalculatingParam(int i_phase_voltage, double d_three_phase_power, string cocontactor, string wireSize, int RNumber)
        {
            base.CalculatingRLC(i_phase_voltage, d_three_phase_power, cocontactor, wireSize, RNumber);
            //阻值（Ω）=相电压*相电压/单相功率
            this.dValueOfResistance = Math.Round(i_phase_voltage * i_phase_voltage / d_single_phase_power, 4);
            
            this.dResistancePowerSingle = this.d_single_phase_power / iNumSingle;//单根电阻管的功率=单相功率/单相电阻管数量
            this.dResistanceValueSingle = this.dValueOfResistance / iNumSingle;//单相电阻管阻值 = 电阻的阻值 / 单相电阻管数量
        }

        /// <summary>
        /// 得到电阻参数数组
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
                                 dValueOfResistance.ToString(),
                                 dResistancePowerSingle.ToString(),
                                 dResistanceValueSingle.ToString(),
                                 iNumSingle.ToString(),
                                 iNumThree.ToString()
                            };
            return strArr;
        }
    }
}
