using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace cost_estimating
{
    public partial class numerical_gpbwindows : UserControl
    {
        //电阻管
        private RLC.BaseRLC baseRLC;//电阻电容电抗实例
        private string rlcType;//RLC类型
        public RLC.BaseRLC BaseRLC
        {
            get
            {
                return this.baseRLC;
            }
            set
            {
                this.baseRLC = value;
                if (this.baseRLC.dt == null)
                {
                    this.baseRLC.dt = ConvertTo.ConvertToDataTable(baseRLC.culomnsName, null);
                    this.baseRLC.preDt = ConvertTo.ConvertToDataTable(baseRLC.culomnsName, null);
                }
                changeParam();//改变界面显示值
            }
        }
        /// <summary>
        ///改变界面显示值
        /// </summary>
        private void changeParam()
        {
            this.dataGridView_Resistance.DataSource = this.baseRLC.dt;
            this.dataGridView_preview.DataSource = this.baseRLC.preDt;
            this.RLCtype = baseRLC.name;
            this.cBox_U.SelectedItem = baseRLC.UType;
            this.cBox_electricityType.SelectedItem = baseRLC.ElectricityType;
            this.textBox_phase_voltage.Text = baseRLC.Voltage.ToString();
            this.textBox_three_phase_power.Text = baseRLC.D_three_phase_power.ToString();
            this.textBox_singlePhaseNumber.Text = baseRLC.iNumSingle.ToString();
            this.textBox_series.Text = this.baseRLC.getSeriesNum().ToString();
            this.textBox_wire.Text = this.baseRLC.str_wire;
            this.cBox_cocontactor.SelectedItem = this.baseRLC.str_cocontactor;
        }
        /// <summary>
        /// 预留，直接修改RLCtype的值改变label_resistance_num.Text
        /// </summary>
        public string RLCtype
        {
            get
            {
                return this.rlcType;
            }
            set
            {
                rlcType = value;
                this.label_resistance_num.Text = "单相" + rlcType + "数量";
            }
        }

        public numerical_gpbwindows(RLC.BaseRLC baseRLC)
        {
            InitializeComponent();
            this.BaseRLC = baseRLC;
            this.cBox_U.Items.AddRange(baseRLC.UTypeArr);
            this.cBox_U.SelectedIndex = 0;
            this.cBox_electricityType.Items.AddRange(baseRLC.eleTypeArr);
            this.cBox_electricityType.SelectedIndex = 0;
        }
        

        /// <summary>
        /// 得到电阻/电容/电抗参数数组
        /// </summary>
        /// <param name="i_phase_voltage">相电压</param>
        /// <param name="d_three_phase_power">三相功率</param>
        /// <param name="cocontactor">接触器</param>
        /// <param name="wireSize">导线大小</param>
        /// <param name="RNumber">单相电阻管数量</param>
        /// <returns>返回电阻参数数组</returns>
        private string[] RLCParamCalculate()
        {
            //baseRLC = RLC.BaseRLC.GetInstance(i_phase_voltage, d_three_phase_power, cocontactor, wireSize, RNumber);
            baseRLC.CalculatingParam();
            string[] param = baseRLC.ToStringArr();
            return param;
        }

        /// <summary>
        /// 新增一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                int phaseVoltage = ConvertTo.ParseInt(textBox_phase_voltage.Text.ToString());
                double threePhasePower = ConvertTo.ParseInt(textBox_three_phase_power.Text);
                //接触器
                string cocontactor = comboBox_cocontactor.SelectedItem.ToString();
                string wireSize = textBox_wire.Text;
                int SingeRNum = ConvertTo.ParseInt(this.textBox_singlePhaseNumber.Text.Trim());
                int seriesNumber=ConvertTo.ParseInt(this.textBox_series.Text.Trim());
                //string[] row = RLCParamCalculate(phaseVoltage, threePhasePower, cocontactor, wireSize, SingeRNum, seriesNumber);
                string[] row = RLCParamCalculate();
                this.baseRLC.dt.Rows.Add(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show("参数填写错误："+ex.Message, "警告");
            }
        }
        /// <summary>
        /// 预览
        /// </summary>
        private void previewView()
        {
            string[] row = RLCParamCalculate();
            this.baseRLC.preDt.Rows.Clear();
            this.baseRLC.preDt.Rows.Add(row);
            this.dataGridView_preview.Rows[0].Cells[0].Value = "预览";
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_delete_Click(object sender, EventArgs e)
        {
             int[] index = this.dataGridView_Resistance.selectRows();
             baseRLC.DelectSelectRows(index);
        }


        /// <summary>
        /// 导出excel文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                WriteToExcel.getInstance().start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作错误");
            }
        }
        /// <summary>
        /// 更改交（星形、三角形）、直流接法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBox_electricityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = baseRLC.eleTypeArr[(sender as ComboBox).SelectedIndex];
            if (text != baseRLC.ElectricityType)
            {
                DialogResult dr = MessageBox.Show("更改为\"" + text + "\"将清除现有数据，是否继续？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    baseRLC.ElectricityType = baseRLC.eleTypeArr[(sender as ComboBox).SelectedIndex];
                }
                else
                {
                    (sender as ComboBox).SelectedItem = baseRLC.ElectricityType;
                }
            }
        }
        /// <summary>
        /// 更改电压类型（线电压/相电压）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBox_U_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.baseRLC.UType = baseRLC.UTypeArr[(sender as ComboBox).SelectedIndex];
        }
        /// <summary>
        /// 三相功率值改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_three_phase_power_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sender as TextBox).Text.Trim() != "")
                {
                    double d_three_phase_power = Convert.ToDouble((sender as TextBox).Text.Trim());
                    this.baseRLC.D_three_phase_power = d_three_phase_power;
                    previewView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告");
            }
        }
        /// <summary>
        /// 三相功率不聚焦后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_three_phase_power_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Trim() == "")
            {
                (sender as TextBox).Text = this.baseRLC.D_three_phase_power.ToString();
            }
        }
        /// <summary>
        /// 线/相电压值改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_phase_voltage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sender as TextBox).Text.Trim()!="")
                {
                    double voltage = Convert.ToDouble((sender as TextBox).Text.Trim());
                    this.baseRLC.Voltage = voltage;
                    previewView();
                }
                //(sender as TextBox).Text = this.baseRLC.Voltage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告");
            }
        }
        /// <summary>
        /// 线/相电压控件不聚焦时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_phase_voltage_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Trim() == "")
            {
                (sender as TextBox).Text = this.baseRLC.Voltage.ToString();
            }
        }
        /// <summary>
        /// 单相数量值改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_singlePhaseNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sender as TextBox).Text.Trim() != "")
                {
                    this.baseRLC.iNumSingle = ConvertTo.ParseInt((sender as TextBox).Text.Trim());
                    (sender as TextBox).Text = this.baseRLC.iNumSingle.ToString();//防止出错
                    previewView();
                }
            }
            catch (Exception ex)
            {
                (sender as TextBox).Focus();
            }
        }
        /// <summary>
        /// 单相数量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_singlePhaseNumber_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Trim() == "")
            {
                (sender as TextBox).Text = this.baseRLC.iNumSingle.ToString();
            }
        }
        /// <summary>
        /// 串联数量改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_series_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sender as TextBox).Text.Trim() != "")
                {
                    int value = ConvertTo.ParseInt((sender as TextBox).Text.Trim());
                    this.baseRLC.setSeriesNum(value);
                    (sender as TextBox).Text = this.baseRLC.getSeriesNum().ToString();//防止出错
                    previewView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告");
                (sender as TextBox).Text = this.baseRLC.getSeriesNum().ToString();
                (sender as TextBox).Focus();
            }
        }
        /// <summary>
        /// 串联数量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_series_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = this.baseRLC.getSeriesNum().ToString();
        }
        /// <summary>
        /// 导线大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_wire_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Trim() != "")
            {
                this.baseRLC.str_wire = (sender as TextBox).Text;
                previewView();
            }
        }
        /// <summary>
        /// 导线大小为空时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_wire_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Trim() == "")
            {
                (sender as TextBox).Text = this.baseRLC.str_wire;
            }
        }
    }       
}
