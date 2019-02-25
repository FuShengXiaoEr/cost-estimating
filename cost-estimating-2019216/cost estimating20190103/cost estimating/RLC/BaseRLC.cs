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
        public string[] culomnsName = null;
        public string projectName = null;
        public string name = null;
        public DataTable dt;//显示的表格
        public DataTable preDt;//预览的表格

        public string[] UTypeArr = { "线电压", "相电压", "直流电压" };
        public string UType = "线电压";//默认线电压
    

        public string[] eleTypeArr = { "交流三相(星形接法)", "交流三相(三角形接法)", "直流单相" };
        private string eleType = "交流三相(星形接法)";//默认星形接法
        public string ElectricityType
        {
            get { return this.eleType; }
            set
            {
                if (this.eleType != value)
                {
                    this.eleType = value;
                    clearDataTable();
                }
            }
        }
        /// <summary>
        /// 设置线电压/相电压
        /// </summary>
        public double Voltage
        {
            get
            {
                if (UType == UTypeArr[0])//线电压
                {
                    return this.d_Line_voltage;
                }
                else if (UType == UTypeArr[1])//相电压
                {
                    return this.d_phase_voltage;
                }
                else //直流电压
                {
                    return 0;
                }
            }
            set
            {
                if (ElectricityType == eleTypeArr[0])//"交流三相(星形接法)",线电压是相电压的根号3倍
                {
                    if (UType == UTypeArr[0])//线电压
                    {
                        this.d_phase_voltage = Math.Round(value / 1.732, 2);
                        this.d_Line_voltage = value;
                    }
                    else if (UType == UTypeArr[1])//相电压
                    {
                        this.d_phase_voltage = value;
                        this.d_Line_voltage = Math.Round(value * 1.732, 2);
                    }
                }
                else if (ElectricityType == eleTypeArr[1])//"交流三相(三角形接法)"
                {
                    this.d_Line_voltage = value;
                    this.d_phase_voltage = value;
                }
                else//直流单相
                {

                }
            }
        }

        /// <summary>
        /// 相电压
        /// </summary>
        /// 
        public double d_phase_voltage = 0;//相电压
        public double d_Line_voltage = 0;//线电压
        public double d_three_phase_power = 0;//三相功率
        public double d_single_phase_power = 0;//单相功率
        public double d_Current = 0;//电流

        public double D_three_phase_power
        {
            get
            {
                return this.d_three_phase_power;
            }
            set
            {
                this.d_three_phase_power = value;//三相功率
                //单相功率（W）=三相功率（W）/3
                this.d_single_phase_power = Math.Round((double)value / 3, 2);
                //电流（A）=单相功率（W）/相电压（V）
                if (d_phase_voltage == 0)
                    d_Current = 0;
                else
                    d_Current = Math.Round(d_single_phase_power / d_phase_voltage, 2);
            }
        }
        public string str_cocontactor = "LC1D09";//接触器,默认LC1D09
        public string str_wire = "1.5";//导线,默认1.5mm2
        private int numSingle = 1;
        public int iNumSingle 
        {
            get { return numSingle; }
            set
            {
                if (value < 1)
                    value = 1;
                numSingle = value;//单相电阻管数量
                this.iNumThree = this.numSingle * 3;
            }
        }//单相电阻管数量(电容/电抗默认为1)
        public int iNumThree = 3;//三相电阻管数量



        public BaseRLC() { }

        public abstract string[] ToStringArr();
        public abstract void CalculatingParam();
        /// <summary>
        /// 清除静态变量(总档位的记录)
        /// </summary>
        public abstract void clearStaticData();
        public void clearDataTable()
        {
            this.dt.Clear();
            this.preDt.Clear();
            this.clearStaticData();
        }
        /// <summary>
        /// 计算电阻/电容/电感公共参数
        /// </summary>
        /// <param name="voltage">电压</param>
        /// <param name="d_three_phase_power">三相功率</param>
        /// <param name="cocontactor">接触器</param>
        /// <param name="wireSize">导线大小</param>
        /// <param name="RNumber">单相电阻管数量</param>
        public void CalculatingRLC(double voltage, double d_three_phase_power, string cocontactor, string wireSize, int RNumber)
        {
            this.Voltage = voltage;
            this.D_three_phase_power = d_three_phase_power;//三相功率
            this.str_cocontactor = cocontactor;//接触器
            this.str_wire = wireSize;//导线大小
            //阻值（Ω）=相电压*相电压/单相功率
            iNumSingle = RNumber;
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

            /*这里采用逆序删除元素，因为每删除一个元素，datagridview表格自身的索引会重新进行一次排列，这就导致了索引在不停的变化。但是需要删除的
            行的索引已经确定了。
            那么若是从最后的行开始删则保证了前面的行的索引不会受到影响。
             * */
            for (int i = indexs.Length - 1; 0 <= i; i--)
            {
                power = ConvertTo.ParseInt(dt.Rows[indexs[i]][culomnsName[2]].ToString());
                current = Convert.ToDouble(dt.Rows[indexs[i]]["电流(A)"].ToString());
                num = ConvertTo.ParseInt(dt.Rows[i][culomnsName[culomnsName.Length-1]].ToString());
                this.DelectRLC(power, current, num);//减已经统计了的总功率、总电流、总数量       
                dt.Rows.RemoveAt(indexs[i]);
            }
        }
        /// <summary>
        /// 设置电阻的串联数量
        /// </summary>
        public abstract void setSeriesNum(int value);
        public abstract int getSeriesNum();
    }
}
