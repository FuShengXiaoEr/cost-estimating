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
        private RLC.BaseRLC baseRLC;
        private string rlcType;
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
                }
                this.dataGridView_Resistance.DataSource = this.baseRLC.dt;
                this.label_resistance_num.Text = baseRLC.culomnsName[baseRLC.culomnsName.Length - 2];
            }
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
            //comboBox_phase_voltage.Items.Insert(0,"-请选择-");
            //comboBox_single_resistance_num.SelectedText="请选择";
            //comboBox_cocontactor.SelectedText="请选择";
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
        private string[] RLCParamCalculate(int i_phase_voltage, double d_three_phase_power, string cocontactor, string wireSize, int RNumber)
        {
            //baseRLC = RLC.BaseRLC.GetInstance(i_phase_voltage, d_three_phase_power, cocontactor, wireSize, RNumber);
            baseRLC.CalculatingParam(i_phase_voltage, d_three_phase_power, cocontactor, wireSize, RNumber);
            string[] param = baseRLC.ToStringArr();
            int len=param.Length+1;
            string[] row=new string[]{"false"};
            //return row.Concat(param).ToArray();//连接row和param
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
                int phaseVoltage = ConvertTo.ParseInt(comboBox_phase_voltage.SelectedItem.ToString());
                double threePhasePower = ConvertTo.ParseInt(textBox_three_phase_power.Text);
                //接触器
                string cocontactor = comboBox_cocontactor.SelectedItem.ToString();
                string wireSize = textBox_wire.Text;
                int SingeRNum = ConvertTo.ParseInt(comboBox_single_resistance_num.SelectedItem.ToString());

                string[] row = RLCParamCalculate(phaseVoltage, threePhasePower, cocontactor, wireSize, SingeRNum);
                this.baseRLC.dt.Rows.Add(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show("参数填写错误："+ex.Message, "警告");
            }
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
    }       
}
