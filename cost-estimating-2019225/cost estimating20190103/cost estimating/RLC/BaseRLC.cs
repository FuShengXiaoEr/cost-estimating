using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace cost_estimating.RLC
{
    /// <summary>
    /// 电阻/电抗/电容的基类
    /// </summary>
    public abstract class BaseRLC
    {
        public string[] culomnsName=null;
        public string projectName = null;
        public DataTable dt;//显示的表格
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


        public BaseRLC() { }

        public abstract string[] ToStringArr();
        public abstract void CalculatingParam(int i_phase_voltage, double d_three_phase_power, string cocontactor, string wireSize, int RNumber);

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
            this.d_single_phase_power = Math.Round((double)d_three_phase_power / 3, 2);
            //电流（A）=单相功率（W）/相电压（V）
            if (i_phase_voltage == 0)
                d_Current = 0;
            else
                d_Current = Math.Round(d_single_phase_power / i_phase_voltage, 2);
            this.str_cocontactor = cocontactor;//接触器
            this.str_wire = wireSize;//导线大小
            //阻值（Ω）=相电压*相电压/单相功率

            if (RNumber < 1)
                RNumber = 1;
            iNumSingle = RNumber;//单相电阻管数量
            this.iNumThree = this.iNumSingle * 3;
        }
        /// <summary>
        /// 得到电阻/电抗/电容的总功率、总单相功率、总电流、总个数的string数组
        /// </summary>
        /// <returns></returns>
        public abstract string[] GetTotalStringArr();

        /// <summary>
        /// 删除电阻/电抗/电容
        /// </summary>
        /// <param name="power">总功率</param>
        /// <param name="current">总电流</param>
        /// <param name="num">总个数</param>
        public abstract void DelectRLC(int power, double current, int num);
        /// <summary>
        /// 删除DataTable里面所选择的行
        /// </summary>
        /// <param name="indexs">选择的行号</param>
        public void DelectSelectRows(int[] indexs)
        {
            int power = 0;//三相功率
            double current = 0;//电流
            int num = 0;//三相电阻/电抗/电容总数量
            //int index_d_three_phase_powers=dt.Columns[]

            /*这里采用逆序删除元素，因为每删除一个元素，datagridview表格自身的索引会重新进行一次排列，这就导致了索引在不停的变化。但是需要删除的
            行的索引已经确定了。
            那么若是从最后的行开始删则保证了前面的行的索引不会受到影响。
             * */
            for (int i = indexs.Length - 1; 0 <= i; i--)
            {
                power = ConvertTo.ParseInt(dt.Rows[indexs[i]][culomnsName[1]].ToString());
                current = Convert.ToDouble(dt.Rows[indexs[i]]["电流(A)"].ToString());
                num = ConvertTo.ParseInt(dt.Rows[i][culomnsName[culomnsName.Length-1]].ToString());
                this.DelectRLC(power, current, num);//减已经统计了的总功率、总电流、总数量       
                dt.Rows.RemoveAt(indexs[i]);
            }
        }
    }
}
