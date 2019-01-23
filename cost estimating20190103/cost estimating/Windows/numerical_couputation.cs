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
        private DataGridViewRowCollection t;
        private RLC.Resistance resistance;//电阻管

        public numerical_gpbwindows()
        {
            InitializeComponent();
            button_add.Enabled = true;
            button_delete.Enabled = true;
            comboBox_phase_voltage.Items.Insert(0,"-请选择-");
            comboBox_single_resistance_num.SelectedText="请选择";
            comboBox_cocontactor.SelectedText="请选择";

            //this.dataGridView_Resistance.DataSource = DataBindingByList1();
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
            Al.Add(new string[]{"check","1","2","3","4","5","6","7","8","9"});
            Al.Add(new string[] { "true","3", "", "6" });
            return Al;
        } 


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
        /// 得到电阻参数数组
        /// </summary>
        /// <param name="i_phase_voltage">相电压</param>
        /// <param name="d_three_phase_power">三相功率</param>
        /// <param name="cocontactor">接触器</param>
        /// <param name="wireSize">导线大小</param>
        /// <param name="RNumber">单相电阻管数量</param>
        /// <returns>返回电阻参数数组</returns>
        private string[] ResistanceCalculate(int i_phase_voltage, double d_three_phase_power, string cocontactor, string wireSize, int RNumber)
        {
            resistance = RLC.Resistance.GetResistance(i_phase_voltage, d_three_phase_power, cocontactor, wireSize, RNumber);
            string[] param = resistance.ToStringArr();
            int len=param.Length+1;
            string[] row=new string[]{"false"};
            return row.Concat(param).ToArray();//连接row和param
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
                dataGridView_Resistance.RowHeadersWidth - 4,
                e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dataGridView_Resistance.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dataGridView_Resistance.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
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
                int phaseVoltage = ParseInt(comboBox_phase_voltage.SelectedItem.ToString());
                double threePhasePower = ParseInt(textBox_three_phase_power.Text);
                //接触器
                string cocontactor = comboBox_cocontactor.SelectedItem.ToString();
                string wireSize = textBox_wire.Text;
                int SingeRNum = ParseInt(comboBox_single_resistance_num.SelectedItem.ToString());

                string[] row = ResistanceCalculate(phaseVoltage, threePhasePower, cocontactor, wireSize, SingeRNum);
                dataGridView_Resistance.Rows.Add(row);
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
            List<int> index = new List<int>();
            int power = 0;//三相功率
            double current = 0;//电流
            int num = 0;//三相电阻/电抗/电容总数量
                      
            if (dataGridView_Resistance.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView_Resistance.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dataGridView_Resistance.Rows[i].Cells["check"];                    
                    Boolean flak = Convert.ToBoolean(checkcell.EditedFormattedValue);                   
                    if (flak)
                    {                        
                        index.Add(checkcell.RowIndex);
                        power = ParseInt(dataGridView_Resistance.Rows[i].Cells["three_phase_power"].Value.ToString());
                        current = Convert.ToDouble(dataGridView_Resistance.Rows[i].Cells["electricity"].Value.ToString());
                        num = ParseInt(dataGridView_Resistance.Rows[i].Cells["resistance_num_three"].Value.ToString());
                        resistance.DelectRLC(new RLC.BaseRLC(power,current,num));//减已经统计了的总功率、总电流、总数量
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
                dataGridView_Resistance.Rows.RemoveAt(index_item[i]);                
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
                for (int i = 0; i < dataGridView_Resistance.RowCount; i++)
                {
                    DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dataGridView_Resistance.Rows[i].Cells["check"];
                    checkcell.Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dataGridView_Resistance.RowCount; i++)
                {
                    DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dataGridView_Resistance.Rows[i].Cells["check"];
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
            string[,] data=(string[,])ReadDataGridView(this.dataGridView_Resistance);
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
                int columns = dataGridView.Columns.Count;//不保存第一列的选择，添加档位顺序
                string[,] data = new string[rows+1, columns];
                //读取表头
                data[0, 0] = "档位";
                for (int i = 1; i < columns; i++)
                {
                    data[0, i] = dataGridView.Columns[i].HeaderText;
                }
                //读取表的数据
                for (int i = 0; i < rows; i++)
                {
                    data[i+1, 0] = (i+1).ToString();//档位
                    for (int j = 1; j < columns; j++)
                    {
                        if (dataGridView[j, i].ValueType == typeof(string))
                        {
                            //在obj.ToString()前加单引号是为了防止自动转化格式 
                            data[i+1, j] = "'" + dataGridView[j, i].Value.ToString();
                        }
                        else
                        {
                            data[i+1, j] = dataGridView[j, i].Value.ToString();
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
        /// <summary>
        /// 选择保存excel文件的路径
        /// </summary>
        /// <returns></returns>
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
            ToExcel excel = new ToExcel();
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
