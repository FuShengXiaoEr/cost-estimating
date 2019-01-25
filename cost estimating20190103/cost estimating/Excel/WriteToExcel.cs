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
        DataTable dt;
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

        public void start(DataGridView dataGridView)
        {
            Console.WriteLine("Before ReadDataGridView:" + DateTime.Now.ToString("HH:mm:ss.fff"));
            data = (string[,])ReadDataGridView(dataGridView);
            Console.WriteLine("After ReadDataGridView:" + DateTime.Now.ToString("HH:mm:ss.fff"));
            if (data != null)
            {
                Thread thread = new Thread(WriteToFile);
                thread.IsBackground = true;
                thread.Name = "导出excel文件";
                thread.Start();
                filePath = SelectFilePath();
                _semaphore.Release(1);
            }
            Console.WriteLine("end:" + DateTime.Now.ToString("HH:mm:ss.fff"));
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
                Console.WriteLine("Before WriteToFile:" + DateTime.Now.ToString("HH:mm:ss.fff"));
                excel.CreateExcel();
                excel.ArrayToExcel(data, 1, 1);
                excel.SaveAsExcel(filePath);
                Console.WriteLine("After WriteToFile:" + DateTime.Now.ToString("HH:mm:ss.fff"));
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
                excel.CreateExcel();
                excel.ArrayToExcel(data, 1, 1);
                _semaphore.WaitOne();//阻塞线程，当有新元素插入才执行后面命令
                if (filePath != "")
                {
                    excel.SaveAsExcel(filePath);
                    //filePath = "";
                }
                else
                {
                    excel.CloseWithoutSave();
                }
                Console.WriteLine("After WriteToFile:" + DateTime.Now.ToString("HH:mm:ss.fff"));
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message, "警告");
                excel.Quit();
                throw e;
            }
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
    }
}
