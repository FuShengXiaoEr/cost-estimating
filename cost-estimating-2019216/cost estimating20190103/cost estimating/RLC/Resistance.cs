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
        public double dValueOfResistance = 0;//单相阻值
        public double dResistancePowerSingle = 0;//单根电阻功率
        public double dResistanceValueSingle = 0;//单根电阻管阻值

        //private double dRPowerSingle_Max = 1670;//单根电阻管功率最大值，根据最大功率计算单相电阻管的数量，每根电阻管的价格一样，所以功率在稳定性能允许的范围内最大化能减少成本
        private int parallelingNum = 1;//单相并联数量
        private int seriesNum = 1;//单相串联数量

        public override void setSeriesNum(int value)
        {
            if (value < 1)
                value = 1;
            if (this.iNumSingle % value == 0)
            {
                seriesNum = value;
                parallelingNum = this.iNumSingle / value;
            }
            else
            {
                throw new Exception("串并联数量填写不正确，单相电阻管数量不能整除串联数量");
            }
        }
        public override int getSeriesNum()
        {
            return this.seriesNum;
        }
        /// <summary>
        /// 总总功率、总单相功率、总电流、总个数的类
        /// </summary>
        BaseRLCStaticVariables<Resistance> total = new BaseRLCStaticVariables<Resistance>();

        private static Resistance resistance;
        private static readonly object _lock = new object();

        /// <summary>
        /// 私有构造函数，防止外部直接创建实例
        /// </summary>
        private Resistance()
        {
            this.culomnsName_ACthree = new string[] { "线电压(V)", "相电压(V)", "三相功率(W)", "单相功率(W)", "单相电流(A)", "接触器", "导线(mm²)", "单相阻值(Ω)", "单根电阻管功率(W)", "单根电阻管阻值(Ω)", "单相电阻管数量", "三相电阻管数量", "串联数量", "并联数量" };
            this.culomnsName_ACSingle = new string[] { "电压(VAC)", "功率(W)", "电流(A)", "接触器", "线径(mm²)", "阻值(Ω)", "单根电阻管功率(W)", "单根电阻管阻值(Ω)", "电阻管数量", "串联数量", "并联数量" };
            this.culomnsName_DC = new string[] { "电压(VDC)", "功率(W)", "电流(A)", "接触器", "线径(mm²)", "阻值(Ω)", "单根电阻管功率(W)", "单根电阻管阻值(Ω)", "电阻管数量", "串联数量", "并联数量" };
            this.projectName = "R载部分 ";
            this.name = "电阻管";
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
        public override void CalculatingParam()
        {
            //this.seriesNum = seriesNumber;
            //单相阻值（Ω）=相电压*相电压/单相功率
            this.dValueOfResistance = Math.Round(this.d_phase_voltage * this.d_phase_voltage / d_single_phase_power, 2);

            this.dResistancePowerSingle = this.d_single_phase_power / iNumSingle;//单根电阻管的功率=单相功率/单相电阻管数量
            this.dResistanceValueSingle = this.dValueOfResistance / this.seriesNum * this.parallelingNum;//单相电阻管阻值 = 电阻的阻值 / 串联数量*并联数量

        }
        public override void AddRows()
        {
            this.CalculatingParam();
            string[] row = this.ToStringArr();
            this.dt.Rows.Add(row);
            total.Total(this.d_three_phase_power, this.d_single_phase_power, this.d_Current, this.iNumSingle);
        }

        /// <summary>
        /// 得到电阻参数数组
        /// </summary>
        /// <returns></returns>
        public override string[] ToStringArr_ACthree()
        {
            string[] strArr ={
                                 d_Line_voltage.ToString(),
                                 d_phase_voltage.ToString(),
                                 d_three_phase_power.ToString(),
                                 d_single_phase_power.ToString(),
                                 d_Current.ToString(),
                                 str_cocontactor,
                                 str_wire,
                                 dValueOfResistance.ToString(),
                                 dResistancePowerSingle.ToString(),
                                 dResistanceValueSingle.ToString(),
                                 iNumSingle.ToString(),
                                 iNumThree.ToString(),
                                 seriesNum.ToString(),
                                 parallelingNum.ToString(),
                            };
            return strArr;
        }

        public override string[] ToStringArr_DC()
        {
            string[] strArr ={
                                 d_phase_voltage.ToString(),
                                 d_single_phase_power.ToString(),
                                 d_Current.ToString(),
                                 str_cocontactor,
                                 str_wire,
                                 dValueOfResistance.ToString(),
                                 dResistancePowerSingle.ToString(),
                                 dResistanceValueSingle.ToString(),
                                 iNumSingle.ToString(),
                                 seriesNum.ToString(),
                                 parallelingNum.ToString(),
                            };
            return strArr;
        }

        public override string[] GetTotalStringArr()
        {
            string[] data = null;
            if (UType == UTypeArr[2] || UType == UTypeArr[3])
            {
                data=total.GetDCTotalStringArr();
            }
            else
            {
                data= total.GetTotalStringArr();
            }
            return data;
        }

        public override void DelectRLC(int power, double current, int num)
        {
            total.DelectRLC(power, current, num);
        }
        public override void clearStaticData()
        {
            total.clear();
        }
    }
}
