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
        public numerical_gpbwindows()
        {
            InitializeComponent();
            button_add.Enabled = true;
            button_delete.Enabled = true;
            comboBox_phase_voltage.Items.Insert(0,"-请选择-");
            comboBox_single_resistance_num.SelectedText="请选择";
            comboBox_cocontactor.SelectedText="请选择";
            dataGridView_resistance_calculate.AllowUserToAddRows = false;
            dataGridView_resistance_calculate.AllowUserToDeleteRows = false;                      
            
        }

        private int n_phase_voltage;//相电压
        private int n_three_phase_power;//三相功率
        private float n_single_phase_power;//单相功率
        private float n_electricity;//电流
        private string n_cocontactor;//接触器
        private string n_wire;//导线
        private float n_value_of_resistance;//阻值
        private float n_resistance_power_single;//单根电阻功率
        private float n_resistance_value_single;//单根电阻管阻值
        private int  n_resistance_num_single;//单相电阻管数量
        private int n_resistance_num_three;//三相电阻管数量
        private DataGridViewRowCollection t;


        /// <summary>
        /// 将字符串转换为int型整数
        /// </summary>
        /// <param name="intStr"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        private int ParseInt(string intStr,int defaultValue = 0)
        {
            int parseInt;
            if(int.TryParse(intStr,out parseInt))
                return parseInt;
            return defaultValue;
 
        }

        /// <summary>
        /// 电阻计算公式
        /// </summary>
        private void ResistanceCalculate()
        {           
            //相电压
            n_phase_voltage = ParseInt(comboBox_phase_voltage.SelectedItem.ToString());      
            //三相功率
            n_three_phase_power = ParseInt(textBox_three_phase_power.Text);
            //单相功率
            n_single_phase_power = (float)Math.Round((decimal)n_three_phase_power / 3, 4);
            //电流 = 单相功率 / 相电压
            try
            {
                n_electricity = (float)Math.Round((decimal)n_single_phase_power / n_phase_voltage, 4);
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("除数不为0");
            }
            //接触器
            n_cocontactor = comboBox_cocontactor.SelectedItem.ToString();
            //导线
            n_wire = textBox_wire.Text;
            //电阻的阻值 = 相电压的平方 / 单相功率
            n_value_of_resistance = (float)Math.Round((float)Math.Pow(n_phase_voltage, 2) / n_single_phase_power, 4);
            //单相电阻管数量
            n_resistance_num_single = ParseInt(comboBox_single_resistance_num.SelectedItem.ToString());
            //单根电阻管的功率=单相功率/单相电阻管数量
            n_resistance_power_single = n_single_phase_power / n_resistance_num_single;
            //单相电阻管阻值 = 电阻的阻值 / 单相电阻管数量
            n_resistance_value_single = n_value_of_resistance / n_resistance_num_single;
            //三相电阻管数量
            n_resistance_num_three = n_resistance_num_single * 3;
        }

        /// <summary>
        /// 给表格添加行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                dataGridView_resistance_calculate.RowHeadersWidth - 4,
                e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dataGridView_resistance_calculate.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dataGridView_resistance_calculate.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 新增一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_add_Click(object sender, EventArgs e)
        {
            
            ResistanceCalculate();
            string[] row = {    
                            "false",
                            n_phase_voltage.ToString(),
                            n_three_phase_power.ToString(),
                            n_single_phase_power.ToString(),
                            n_electricity.ToString(),
                            n_cocontactor,
                            n_wire,
                            n_value_of_resistance.ToString(),
                            n_resistance_power_single.ToString(),
                            n_resistance_value_single.ToString(),
                            n_resistance_num_single.ToString(),                         
                            n_resistance_num_three.ToString()
                        };
            dataGridView_resistance_calculate.Rows.Add(row);
            
        }

        /// <summary>
        /// 删除一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_delete_Click(object sender, EventArgs e)
        {
            List<int> index = new List<int>();
                      
            if (dataGridView_resistance_calculate.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView_resistance_calculate.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dataGridView_resistance_calculate.Rows[i].Cells["check"];                    
                    Boolean flak = Convert.ToBoolean(checkcell.EditedFormattedValue);                   
                    if (flak)
                    {                        
                        index.Add(checkcell.RowIndex);
                    }
                }
            }

            /*这里采用逆序删除元素，因为每删除一个元素，datagridview表格自身的索引会重新进行一次排列，这就导致了索引在不停的变化。但是需要删除的
            行的索引已经确定了。
            那么若是从最后的行开始删则保证了前面的行的索引不会受到影响。
             * */
            int[] index_item = index.ToArray();            
            for (int i = index_item.Length-1; 0 <= i; i--)
            {                          
                dataGridView_resistance_calculate.Rows.RemoveAt(index_item[i]);                
            }
        }

        /// <summary>
        /// 实现全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_selectall_Click(object sender, EventArgs e)
        {
            if (checkBox_selectall.CheckState == CheckState.Checked)
            {
                for (int i = 0; i < dataGridView_resistance_calculate.RowCount; i++)
                {
                    DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dataGridView_resistance_calculate.Rows[i].Cells["check"];
                    checkcell.Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dataGridView_resistance_calculate.RowCount; i++)
                {
                    DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dataGridView_resistance_calculate.Rows[i].Cells["check"];
                    checkcell.Value = false;
                }
            }
        }

        

             
                 
        
    }       
              
                       
             
}
