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

            //this.dataGridView_resistance_calculate.DataSource = DataBindingByList1();
        }

        

        private DataTable BingDataSouse(DataGridView dataGridView,DataTable dataTable)
        {
            DataRow dr1 = dataTable.NewRow();
            return dataTable;
        }

        /// <summary> 
        /// IList接口（包括一维数组，ArrayList等） 
        /// </summary> 
        /// <returns></returns> 
        private List<string[]> DataBindingByList1()
        {
            List<string[]> Al = new List<string[]>();
            Al.Add(new string[]{"1","2","3","4","5","6","7","8","9"});
            Al.Add(new string[] { "3", "", "6" });
            return Al;
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
        private int ParseInt(string intStr)
        {
            int parseInt=0;
            int.TryParse(intStr, out parseInt);
            return parseInt;
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
            if (n_phase_voltage == 0)
                n_electricity = 0;
            else
                n_electricity = (float)Math.Round((decimal)n_single_phase_power / n_phase_voltage, 4);
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
                            "1",//还需要修改为档位排序
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

        /// <summary>
        /// 导出excel文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToExcel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Before:"+DateTime.Now.ToString("HH:mm:ss.fff"));
            string[,] data=(string[,])ReadDataGridView(this.dataGridView_resistance_calculate);
            if ( data != null)
            {
                string filePath = SelectFilePath();
                Console.WriteLine("save:" + DateTime.Now.ToString("HH:mm:ss.fff"));
                if (filePath != "")
                {
                    WriteToExcel(filePath, data);
                }
            }
            Console.WriteLine("after:" + DateTime.Now.ToString("HH:mm:ss.fff"));
        }

        /// <summary>
        /// 读取DataGridView表格数据
        /// </summary>
        /// <param name="dataGridView">DataGridView控件名</param>
        /// <returns></returns>
        private object[,] ReadDataGridView(DataGridView dataGridView)
        {
            dataGridView.ReadOnly = true;//防止表数据时界面添加和删除数据
            try
            {
                int rows = dataGridView.Rows.Count;//不包括表头
                int columns = dataGridView.Columns.Count-1;//不读取第一列
                string[,] data = new string[rows+1, columns];
                //读取表头
                for (int i = 0; i < columns; i++)
                {
                    data[0, i] = dataGridView.Columns[i+1].HeaderText;
                }
                //读取表的数据
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (dataGridView[j+1, i].ValueType == typeof(string))
                        {
                            //在obj.ToString()前加单引号是为了防止自动转化格式 
                            data[i + 1, j] = "'" + dataGridView[j+1, i].Value.ToString();
                        }
                        else
                        {
                            data[i + 1, j] = dataGridView[j+1, i].Value.ToString();
                        }
                    }
                }
                dataGridView.ReadOnly = false;
                return data;
            }
            catch (Exception e)
            {
                dataGridView.ReadOnly = false;
                Console.WriteLine("ReadDataGridView:" + e.ToString());
                MessageBox.Show("ReadDataGridView:"+e.Message, "警告");
                return null;
            }
        }

        private string SelectFilePath()
        {
            string filePath = "";
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "保存Excel文件";
                sfd.Filter = "Excel文件(*.xlsx;*.xls)|*.xlsx;*.xls|所有文件|*.*";
                sfd.FilterIndex = 1;//指定列表框中的默认选项。 
                sfd.ValidateNames = true;//验证用户输入是否是一个有效的Windows文件名。
                //sfd.CheckFileExists = true;//验证文件有效性(是否存在)。
                sfd.CheckPathExists = true;//验证路径有效性。
                sfd.RestoreDirectory = true;//保存对话框是否记忆上次打开的目录
                sfd.FileName = "test"+DateTime.Now.ToString("MMddHHmm");
                //设置默认的文件名
                //sfd.DefaultFileName = "YourFileName";// in wpf is  sfd.FileName = "YourFileName";
                if (sfd.ShowDialog() == DialogResult.OK)
                    filePath = sfd.FileName;
            }
            catch (Exception e)
            {
                MessageBox.Show("SelectFilePath"+e.Message, "警告");
            }
            return filePath;
        }

        /// <summary>
        /// 保存数据到excel文件
        /// </summary>
        /// <param name="filePath">文件名</param>
        /// <param name="data">数据</param>
        private void WriteToExcel(string filePath, object[,] data)
        {
            ReportExcel excel = new ReportExcel();
            try
            {
                excel.CreateExcel();
                excel.ArrayToExcel(data, 1, 1);
                excel.SaveAsExcel(filePath);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message,"警告");
                excel.Quit();
            }
        }
    }       
}
