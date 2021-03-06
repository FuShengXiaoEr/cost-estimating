﻿using System;
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
        /// 电感值mH= 感抗/（2*3.14*频率）*1000
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
            this.culomnsName_ACthree = new string[] { "线电压(V)", "相电压(V)", "三相功率(var)", "单相功率(var)", "单相电流(A)", "接触器", "导线(mm²)", "感抗(Ω)", "电感值(mH)", "单相电抗数量", "三相电抗数量" };
            this.culomnsName_ACSingle = new string[] { "电压(VAC)", "功率(var)", "电流(A)", "接触器", "线径(mm²)","感抗(Ω)", "电感值(mH)", "电抗数量" };
            this.culomnsName_DC = new string[] { "电压(VDC)", "功率(var)", "电流(A)", "接触器", "线径(mm²)", "感抗(Ω)", "电感值(mH)", "电抗数量" };
            this.projectName = "L载部分 ";
            this.name = "电抗";
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

        public override void CalculatingParam()
        {
            //base.CalculatingRLC(voltage, d_three_phase_power, cocontactor, wireSize, RNumber);
            this.inductiveReactance = Math.Round(d_phase_voltage * d_phase_voltage / d_single_phase_power, 2);
            this.inductanceValue = Math.Round(this.inductiveReactance /(Math.PI*this.frequency)*500,2);
        }

        public override void AddRows()
        {
            this.CalculatingParam();
            string[] row = this.ToStringArr();
            this.dt.Rows.Add(row);
            total.Total(this.d_three_phase_power, this.d_single_phase_power, this.d_Current, this.iNumSingle);
        }
        /// <summary>
        /// 得到电容参数数组
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
                                 inductiveReactance.ToString(),
                                 inductanceValue.ToString(),
                                 iNumSingle.ToString(),
                                 iNumThree.ToString()
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
                                 inductiveReactance.ToString(),
                                 inductanceValue.ToString(),
                                 iNumSingle.ToString()
                            };
            return strArr;
        }
        public override string[] GetTotalStringArr()
        {
            string[] data = null;
            if (UType == UTypeArr[2] || UType == UTypeArr[3])
            {
                data = total.GetDCTotalStringArr();
            }
            else
            {
                data = total.GetTotalStringArr();
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


        public override int getSeriesNum()
        {
            return 1;
        }

        public override void setSeriesNum(int value)
        {
        }
    }
}
