using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Threading;


namespace cost_estimating
{
    public class WriteToExcel
    {
        ToExcel excel = new ToExcel();
        private static WriteToExcel instance;
        private static readonly object _lock = new object();
        private Semaphore _semaphore = new Semaphore(0, 256);
        string[,] data;
        string filePath;

        /// <summary>
        /// 得到实例
        /// </summary>
        /// <returns></returns>
        public static WriteToExcel getInstance()
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = new WriteToExcel();
                }
                return instance;
            }
        }

        private WriteToExcel() { }

        public void start()
        {
            Thread thread = new Thread(WriteToFile);//新建线程写数据到excel表格
            thread.IsBackground = true;
            thread.Name = "导出excel文件";
            thread.Start();
            filePath = SelectFilePath();
            _semaphore.Release(1);
        }
        /// <summary>
        /// 选择保存excel文件的路径
        /// </summary>
        /// <returns></returns>
        public string SelectFilePath()
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
                sfd.FileName = "test" + DateTime.Now.ToString("MMddHHmmss");
                //设置默认的文件名
                //sfd.DefaultFileName = "YourFileName";// in wpf is  sfd.FileName = "YourFileName";
                if (sfd.ShowDialog() == DialogResult.OK)
                    filePath = sfd.FileName;
            }
            catch (Exception e)
            {
                MessageBox.Show("SelectFilePath:" + e.Message, "警告");
            }
            return filePath;
        }
        /// <summary>
        /// 保存数据到excel文件
        /// </summary>
        /// <param name="filePath">文件名</param>
        /// <param name="data">数据</param>
        private void WriteToFile(string filePath, object[,] data)
        {
            try
            {
                int startRow = 3;
                int startCloumn = 1;
                excel.CreateExcel();
                excel.ArrayToExcel(data, startRow, startCloumn);
                excel.setBorders(startRow, startCloumn, startRow + data.GetLength(0)-1, startCloumn + data.GetLength(1)-1);
                excel.SaveAsExcel(filePath);
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message, "警告");
                excel.Quit();
                throw e;
            }
        }

        /// <summary>
        /// 保存数据到excel文件
        /// </summary>
        /// <param name="data">数据</param>
        private void WriteToFile()
        {
            try
            {
                Console.WriteLine("Before WriteToFile:" + DateTime.Now.ToString("HH:mm:ss.fff"));
                excel.CreateExcel();//创建文件
                //写数据
                //excel.ArrayToExcel(data, startRow + 1, startCloumn);
                int result=WriteDataToExcel();
                //保存文件
                _semaphore.WaitOne();//阻塞线程，当_semaphore.Release(1);才执行后面命令
                if (result == 0)
                {
                    throw new Exception("无数据写入excel");
                }
                if (filePath != "")
                {
                    excel.SaveAsExcel(filePath);
                }
                else
                {
                    excel.CloseWithoutSave();
                }
                Console.WriteLine("After WriteToFile:" + DateTime.Now.ToString("HH:mm:ss.fff"));
            }
            catch (Exception e)
            {
                excel.Quit();
                MessageBox.Show(e.Message, "写Excel文件出错");
            }
        }

        /// <summary>
        /// 写电阻、电容、电抗表格到excel文件
        /// </summary>
        /// <returns>写入的行数</returns>
        private int WriteDataToExcel()
        {
            try
            {
                int startRow = 2;
                int startColumn = 1;
                RLC.Resistance R= RLC.Resistance.GetInstance();
                RLC.Capacitance C = RLC.Capacitance.GetInstance();
                RLC.Inductance L = RLC.Inductance.GetInstance();
                if (R.dt!=null&&R.dt.Rows.Count > 0)
                {
                    int optRows= WriteDataTable(R, startRow, startColumn);
                    startRow = startRow + optRows + 5;
                }
                if (C.dt!=null&&C.dt.Rows.Count > 0)
                {
                    int optRows = WriteDataTable(C, startRow, startColumn);
                    startRow = startRow + optRows + 5;
                }
                if (L.dt!=null&&L.dt.Rows.Count > 0)
                {
                    int optRows = WriteDataTable(L, startRow, startColumn);
                    startRow = startRow + optRows + 5;
                }
                return startRow - 2;
            }
            catch (Exception e)
            {
                throw new Exception("写数据到excel出错:"+e.Message,e);
            }
        }
        /// <summary>
        /// 写电阻/电容/电抗的表格数据到excel
        /// </summary>
        /// <param name="rlc">电阻/电容/电抗</param>
        /// <param name="startRow">开始行</param>
        /// <param name="startColumn">开始列</param>
        /// <returns>操作的行数</returns>
        private int WriteDataTable(RLC.BaseRLC rlc, int startRow, int startColumn)
        {
            string[,] rlcData = (string[,])ReadDataTable(rlc.dt);
            excel.MergeCells(startRow, startColumn, startRow, startColumn + rlcData.GetLength(1)-1, rlc.projectName);
            excel.ArrayToExcel(rlcData, startRow + 1, startColumn);
            excel.MergeCells(startRow + rlcData.GetLength(0) + 1, startColumn, startRow + rlcData.GetLength(0) + 1, startColumn + rlcData.GetLength(1) - 1, "");
            excel.ArrayToExcel(rlc.GetTotalStringArr(), startRow + rlcData.GetLength(0) + 2, startColumn);
            excel.setBorders(startRow, startColumn, startRow + rlcData.GetLength(0) + 2, startColumn + rlcData.GetLength(1) - 1);
            return rlcData.GetLength(0) + 2;
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
                string[,] data = new string[rows + 1, columns];
                //读取表头
                data[0, 0] = "档位";
                for (int i = 1; i < columns; i++)
                {
                    data[0, i] = dataGridView.Columns[i].HeaderText;
                }
                //读取表的数据
                for (int i = 0; i < rows; i++)
                {
                    data[i + 1, 0] = (i + 1).ToString();//档位
                    for (int j = 1; j < columns; j++)
                    {
                        if (dataGridView[j, i].ValueType == typeof(string))
                        {
                            //在obj.ToString()前加单引号是为了防止自动转化格式 
                            data[i + 1, j] = "'" + dataGridView[j, i].Value.ToString();
                        }
                        else
                        {
                            data[i + 1, j] = dataGridView[j, i].Value.ToString();
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
                MessageBox.Show("ReadDataGridView:" + e.Message, "警告");
                return null;
            }
        }

        /// <summary>
        /// 读取DataGridView表格数据
        /// </summary>
        /// <param name="dataGridView">DataGridView控件名</param>
        /// <returns></returns>
        private object[,] ReadDataTable(DataTable dt)
        {
            try
            {
                if (dt.Rows.Count < 1)
                    return null;
                int rows = dt.Rows.Count;//不包括表头
                int columns = dt.Columns.Count;//要添加档位顺序列
                string[,] data = new string[rows + 1, columns+1];
                //读取表头
                data[0, 0] = "档位";
                for (int i = 0; i < columns; i++)
                {
                    data[0, i+1] = dt.Columns[i].ColumnName;
                }
                //读取表的数据
                for (int i = 0; i < rows; i++)
                {
                    data[i + 1, 0] = (i + 1).ToString();//档位
                    for (int j = 0; j < columns; j++)
                    {
                        if (dt.Columns[j].DataType == typeof(string))
                        {
                            //在obj.ToString()前加单引号是为了防止自动转化格式 
                            data[i + 1, j + 1] = "'" + dt.Rows[i][j];
                        }
                        else
                        {
                            data[i + 1, j + 1] = dt.Rows[i][j].ToString();
                        }
                    }
                }
                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine("ReadDataTable:" + e.ToString());
                MessageBox.Show("ReadDataTable:" + e.Message, "警告");
                return null;
            }
        }
    }
}
