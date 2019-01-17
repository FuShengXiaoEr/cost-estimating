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
        public int iResistanceNumSingle{ get; set; }//单相电阻管数量
        public int iResistanceNumThree{ get; set; }//三相电阻管数量

        public Resistance()
        {
            i_Gear_position = 0;
        }

        public Resistance(int i_phase_voltage, double d_three_phase_power, string cocontactor,string wireSize,int RNumber)
        {
            i_Gear_position = 0;
            this.i_phase_voltage=i_phase_voltage;
            this.d_three_phase_power=d_three_phase_power;
            //单相功率（W）=三相功率（W）/3
            this.d_single_phase_power=Math.Round((double)d_three_phase_power / 3, 4);
            //电流（A）=单相功率（W）/相电压（V）
            if (i_phase_voltage == 0)
                d_Current = 0;
            else
                d_Current = Math.Round(d_single_phase_power / i_phase_voltage, 4);
            this.str_cocontactor=cocontactor;
            this.str_wire = wireSize;
            //阻值（Ω）=相电压*相电压/单相功率
            this.dValueOfResistance = Math.Round(i_phase_voltage * i_phase_voltage/d_single_phase_power, 4);
            //单相电阻管数量
            if (RNumber < 1)
                RNumber = 1;
            iTotalNumber = RNumber;
            this.dResistancePowerSingle = this.d_single_phase_power / iTotalNumber;
            this.dResistanceValueSingle = this.dValueOfResistance / RNumber;
            this.iResistanceNumThree = this.iResistanceNumSingle * 3;

            dTotalPower += d_three_phase_power;
            dTotalSinglePhasePower += d_single_phase_power;
            dTotalCurrent += d_Current;
            iTotalNumber += iResistanceNumThree;
        }
    }
}
