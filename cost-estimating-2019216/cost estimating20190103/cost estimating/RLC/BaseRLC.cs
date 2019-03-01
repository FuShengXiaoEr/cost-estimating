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
        public string[] culomnsName_ACthree = null;//交流三相列名
        public string[] culomnsName_ACSingle = null;//交流单相列名
        public string[] culomnsName_DC = null;//直流列名
        public string projectName = null;
        public string name = null;
        public DataTable dt;//显示的表格
        public DataTable preDt;//预览的表格

        public string[] UTypeArr = { "线电压", "相电压", "直流电压","交流单相" };//直流电压和交流单相是一样的计算
        public string uType = "线电压";//默认线电压
        public string UType
        {
            get
            {
                return uType;
            }
            set
            {
                if (value == UTypeArr[2] && ElectricityType == eleTypeArr[2]
                    || value == UTypeArr[3] && ElectricityType == eleTypeArr[3]
                    || (value == UTypeArr[0] || value == UTypeArr[1]) && (ElectricityType == eleTypeArr[0] || ElectricityType == eleTypeArr[1]))
                {
                    this.uType = value;
                }
                else
                {
                    throw new Exception("选择出错");
                }
            }
        }
    

        public string[] eleTypeArr = { "交流三相(星形接法)", "交流三相(三角形接法)", "直流单相","交流单相" };
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
                    if (eleType == eleTypeArr[2])//直流
                    {
                        this.UType = UTypeArr[2];
                        this.dt = ConvertTo.ConvertToDataTable(this.culomnsName_DC, null, this.dt);
                        this.preDt = ConvertTo.ConvertToDataTable(this.culomnsName_DC, null, this.preDt);
                    }
                    else if (eleType == eleTypeArr[3])//交流单相
                    {
                        this.UType = UTypeArr[3];
                        this.dt = ConvertTo.ConvertToDataTable(this.culomnsName_ACSingle, null, this.dt);
                        this.preDt = ConvertTo.ConvertToDataTable(this.culomnsName_ACSingle, null, this.preDt);
                    }
                    else
                    {
                        this.UType = UTypeArr[0];
                        this.dt = ConvertTo.ConvertToDataTable(this.culomnsName_ACthree, null, this.dt);
                        this.preDt = ConvertTo.ConvertToDataTable(this.culomnsName_ACthree, null, this.preDt);
                    }
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
                else//相电压//直流电压，交流单相
                {
                    return this.d_phase_voltage;
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
                else//直流单相，交流单相，//"交流三相(三角形接法)"
                {
                    this.d_Line_voltage = value;
                    this.d_phase_voltage = value;
                }
                setCurrent();
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
        /// <summary>
        /// 三相功率
        /// </summary>
        public double D_three_phase_power
        {
            get
            {
                if (ElectricityType == eleTypeArr[0] || ElectricityType == eleTypeArr[1])
                {
                    return this.d_three_phase_power;
                }
                else
                {
                    return this.d_single_phase_power;
                }
            }
            set
            {
                if (ElectricityType == eleTypeArr[0] || ElectricityType == eleTypeArr[1])
                {
                    this.d_three_phase_power = value;//三相功率
                    //单相功率（W）=三相功率（W）/3
                    this.d_single_phase_power = Math.Round((double)value / 3, 2);
                }
                else
                {
                    this.d_single_phase_power = value;
                    this.d_three_phase_power = value * 3;
                }
                if (this.R_PowerMax_or_SingleNum == this.R_PowerMax_or_SingleNum_Arr[0])
                {
                    this.iNumSingle = (int)Math.Ceiling(this.d_single_phase_power / this.dRPowerSingleMax); //只要有小数都加1
                }
                setCurrent();
            }
        }
        /// <summary>
        /// 计算电流
        /// </summary>
        public void setCurrent()
        {
            //电流（A）=单相功率（W）/相电压（V）
            if (d_phase_voltage == 0)
                d_Current = 0;
            else
                d_Current = Math.Round(d_single_phase_power / d_phase_voltage, 2);
            this.str_wire = CalculatedWire.CalculatedWireSize(d_Current);
        }
        public string str_cocontactor = "";//接触器,默认LC1D09
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
                try
                {
                    setSeriesNum(getSeriesNum());//刷新串联数量，因为更改单相数量没有自动改变串并联数量
                }
                catch(Exception ex1)
                {
                    setSeriesNum(1);
                    throw new Exception("串联数量不正确，已自动调整为1");
                }
            }
        }//单相电阻管数量(电容/电抗默认为1)
        public int iNumThree = 3;//三相电阻管数量

        public string[] R_PowerMax_or_SingleNum_Arr = new string[] { "电阻管功率最大值", "单相电阻管数量" };
        public string R_PowerMax_or_SingleNum = "电阻管功率最大值";
        private double dRPowerSingleMax = 1670;//单根电阻管功率最大值，根据最大功率计算单相电阻管的数量，
                                   //每根电阻管的价格一样，所以功率在稳定性能允许的范围内最大化能减少成本
        public double DRPowerSingleMax
        {
            get
            {
                double value = 0;
                if (R_PowerMax_or_SingleNum == this.R_PowerMax_or_SingleNum_Arr[0])
                {
                    value = this.dRPowerSingleMax;
                }
                else
                {
                    value = this.iNumSingle;
                }
                return value;
            }
            set
            {
                try
                {
                    if (this.name == "电阻管"&&value!=0)
                    {
                        if (R_PowerMax_or_SingleNum == this.R_PowerMax_or_SingleNum_Arr[0])
                        {
                            this.dRPowerSingleMax = value;
                            this.iNumSingle = (int)Math.Ceiling(this.d_single_phase_power / value); //只要有小数都加1
                        }
                        else
                        {
                            this.iNumSingle = (int)value;
                        }
                    }
                }
                catch (Exception ex2)
                {
                    throw ex2;
                }
            }
        }

        /// <summary>
        /// 频率,默认50Hz
        /// </summary>
        public double frequency = 50;

        public BaseRLC() { }
        public string[] ToStringArr()
        {
            if (this.ElectricityType == eleTypeArr[0] || this.ElectricityType == eleTypeArr[1])
            {
                return this.ToStringArr_ACthree();
            }
            else
            {
                return this.ToStringArr_DC();
            }
        }

        public abstract string[] ToStringArr_ACthree();
        public abstract string[] ToStringArr_DC();
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
        /*
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
         * */
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
                if (UType == UTypeArr[0] || UType == UTypeArr[1])
                {
                    power = ConvertTo.ParseInt(dt.Rows[indexs[i]][culomnsName_ACthree[2]].ToString());
                    current = Convert.ToDouble(dt.Rows[indexs[i]]["单相电流(A)"].ToString());
                    num = ConvertTo.ParseInt(dt.Rows[indexs[i]]["单相"+this.name + "数量"].ToString());
                }
                else
                {
                    power =(int) Convert.ToDouble(dt.Rows[indexs[i]][culomnsName_DC[1]].ToString()) * 3;
                    current = Convert.ToDouble(dt.Rows[indexs[i]]["电流(A)"].ToString());
                    num = ConvertTo.ParseInt(dt.Rows[indexs[i]][this.name + "数量"].ToString());
                }
                this.DelectRLC(power, current, num);//减已经统计了的总功率、总电流、总数量       
                dt.Rows.RemoveAt(indexs[i]);
            }
        }
        /// <summary>
        /// 把计算的数据放在预览dataTable里面
        /// </summary>
        public void previewView()
        {
            this.CalculatingParam();
            string[] row = this.ToStringArr();
            this.preDt.Rows.Clear();
            this.preDt.Rows.Add(row);
        }
        /// <summary>
        /// 在最终dataTable表里面添加一行，
        /// </summary>
        public abstract void AddRows();
        /// <summary>
        /// 设置电阻的串联数量
        /// </summary>
        public abstract void setSeriesNum(int value);
        public abstract int getSeriesNum();
    }
}
