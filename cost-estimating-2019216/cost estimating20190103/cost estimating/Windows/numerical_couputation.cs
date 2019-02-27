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
                    this.baseRLC.dt = ConvertTo.ConvertToDataTable(baseRLC.culomnsName_ACthree, null);
                    this.baseRLC.preDt = ConvertTo.ConvertToDataTable(baseRLC.culomnsName_ACthree, null);
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
            previewView();
            this.RLCtype = baseRLC.name;
            this.cBox_U.SelectedItem = baseRLC.UType;
            this.cBox_electricityType.SelectedItem = baseRLC.ElectricityType;
            this.textBox_phase_voltage.Text = baseRLC.Voltage.ToString();
            this.textBox_three_phase_power.Text = baseRLC.D_three_phase_power.ToString();
            this.textBox_resistance_power_max.Text = baseRLC.DRPowerSingleMax.ToString();
            int seriesNum = this.baseRLC.getSeriesNum();
            if (cBoxSeriesType.SelectedIndex == 1)
            {
                seriesNum = this.baseRLC.iNumSingle / seriesNum;
            }
            this.textBox_series.Text = seriesNum.ToString();
            this.textBox_wire.Text = this.baseRLC.str_wire;
            this.textBox_cocontactor.Text = this.baseRLC.str_cocontactor;
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
                if (value == "电阻管")
                {
                    this.label3.Text = "W";
                }
                else
                {
                    this.label3.Text = "var";
                }

                if (this.baseRLC.ElectricityType == this.baseRLC.eleTypeArr[2] || this.baseRLC.ElectricityType == this.baseRLC.eleTypeArr[3])
                {
                    this.labelPower.Text = "功率";
                }
                else
                {
                    this.labelPower.Text = "三相功率";
                }
            }
        }

        public numerical_gpbwindows(RLC.BaseRLC baseRLC)
        {
            InitializeComponent();
            this.BaseRLC = baseRLC;
            initForm();
        }
        private void initForm()
        {
            this.cBox_U.Items.AddRange(baseRLC.UTypeArr);
            this.cBox_U.SelectedIndex = 0;
            this.cBox_electricityType.Items.AddRange(baseRLC.eleTypeArr);
            this.cBox_electricityType.SelectedIndex = 0;
            this.cBoxSeriesType.SelectedIndex = 0;
        }

        /// <summary>
        /// 限定textBox只能输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
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
                this.baseRLC.AddRows();
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
            this.baseRLC.previewView();
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
                if (this.baseRLC.dt.Rows.Count == 0)
                {
                    baseRLC.ElectricityType = baseRLC.eleTypeArr[(sender as ComboBox).SelectedIndex];
                    this.previewView();
                    changeParam();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("更改为\"" + text + "\"将清除现有数据，是否继续？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        baseRLC.ElectricityType = baseRLC.eleTypeArr[(sender as ComboBox).SelectedIndex];
                        this.previewView();
                        changeParam();
                    }
                    else
                    {
                        (sender as ComboBox).SelectedItem = baseRLC.ElectricityType;
                    }
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
            try
            {
                int index = (sender as ComboBox).SelectedIndex;
                this.baseRLC.UType = baseRLC.UTypeArr[index];
                this.textBox_phase_voltage.Text = this.baseRLC.Voltage.ToString();
                previewView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告");
                (sender as ComboBox).SelectedItem = this.baseRLC.UType;
            }
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
                    this.textBox_wire.Text = this.baseRLC.str_wire;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "警告");
                previewView();
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
                    this.textBox_wire.Text = this.baseRLC.str_wire;
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
        private void textBox_resistance_power_max_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sender as TextBox).Text.Trim() != "")
                {
                    this.baseRLC.DRPowerSingleMax = Convert.ToDouble((sender as TextBox).Text.Trim());
                    previewView();
                }
            }
            catch (Exception ex)
            {
                previewView();
                //MessageBox.Show(ex.Message, "警告");
                //this.textBox_series.Focus();
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
                    if (cBoxSeriesType.SelectedIndex == 1)//并联数量
                    {
                        value = this.baseRLC.iNumSingle / value;
                    }
                    this.baseRLC.setSeriesNum(value);
                    previewView();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "警告");
                //int value = this.baseRLC.getSeriesNum();
                //if (cBoxSeriesType.SelectedIndex == 1)//并联数量
                //{
                //    value = this.baseRLC.iNumSingle / value;
                //}
               // (sender as TextBox).Text = value.ToString();
                //(sender as TextBox).Focus();
            }
        }
        /// <summary>
        /// 串联数量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_series_Leave(object sender, EventArgs e)
        {
            if (cBoxSeriesType.SelectedIndex == 0)
            {
                (sender as TextBox).Text = this.baseRLC.getSeriesNum().ToString();
            }
            else
            {
                (sender as TextBox).Text = (this.baseRLC.iNumSingle / this.baseRLC.getSeriesNum()).ToString();
            }
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
        /// <summary>
        /// 串并联数量选择项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBoxSeriesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sender as ComboBox).SelectedIndex == 0)
                {
                    this.textBox_series.Text = this.baseRLC.getSeriesNum().ToString();
                }
                else
                {
                    this.textBox_series.Text = (this.baseRLC.iNumSingle/this.baseRLC.getSeriesNum()).ToString();
                }
            }
            catch(Exception ex)
            {
            }
        }
        /// <summary>
        /// 接触器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_cocontactor_TextChanged(object sender, EventArgs e)
        {
            this.baseRLC.str_cocontactor = (sender as TextBox).Text;
        }
    }       
}
