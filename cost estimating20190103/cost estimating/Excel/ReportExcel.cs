using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace cost_estimating
{
    public class ReportExcel
    {
        private Application xlApp;//引用Excel对象
        private _Workbook xlWorkBook;//Excel工作薄文件
        private _Worksheet xlWorkSheet;//一个Excel工作表
        object misValue = System.Reflection.Missing.Value;

        public ReportExcel() { }

        #region 创建Excel
        /// <summary>
        /// 新建一个excel文档
        /// </summary>
        /// <returns>成功：true</returns>
        public bool CreateExcel()
        {
            try
            {
                //1.创建一个Excel 应用程序
                xlApp = new Application();
                //设置app属性，及其进行如下操作
                xlApp.Visible = false;//不显示excel操作
                xlApp.UserControl = true;
                //设置禁止弹出保存和覆盖的询问提示框
                xlApp.DisplayAlerts = false;//是否需要显示提示
                xlApp.AlertBeforeOverwriting = false;//是否弹出提示覆盖

                xlWorkBook = xlApp.Workbooks.Add(true);//新建一个excel文档
                xlWorkSheet = (_Worksheet)xlWorkBook.Sheets.get_Item(1); //第一个工作薄。
                if (xlWorkSheet == null)
                    return false;  //工作薄中没有工作表.
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("创建Excel失败：" + e.ToString());
            }
        }

        /// <summary>
        /// 根据模板创建创建Excel文件
        /// </summary>
        /// <param name="templateFilePath">模板路径</param>
        /// <param name="isShowExcle">是否显示excel文件</param>
        /// <returns></returns>
        public bool CreateExcel(string templateFilePath, bool isShowExcle)
        {
            try
            {
                if (templateFilePath == null)
                    throw new Exception("Excel模板文件路径不能为空！");
                //1.创建一个Excel 应用程序
                xlApp = new Application();
                //设置app属性，及其进行如下操作
                xlApp.Visible = isShowExcle;
                xlApp.UserControl = true;
                xlWorkBook = xlApp.Workbooks.Add(templateFilePath);//加载模板
                xlWorkSheet = (_Worksheet)xlWorkBook.Sheets.get_Item(1); //第一个工作薄。
                if (xlWorkSheet == null)
                    return false;  //工作薄中没有工作表.
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("打开excel模板出错：" + e.ToString());
            }

        }
        #endregion

        #region 保存Excel
        /// <summary>
        /// 3.对已导出好的Excel报表进行保存到指定路径下，以便进行查看。
        /// </summary>
        /// <param name="saveFilePath">另存为的文件路径</param>
        /// <returns></returns>
        public bool SaveAsExcel(string saveFilePath)
        {
            //xlExclusive（独占模式）
            //xlWorkBook.SaveAs(saveFilePath, misValue, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //默认 （不更改访问模式）
            xlWorkBook.SaveAs(saveFilePath, misValue, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
            //4.关闭Excel对象
            xlWorkBook.Close(misValue, misValue, misValue);
            xlApp.Quit();//这一句非常重要，否则Excel对象不能从内存中退出
            xlApp = null;
            return true;
        }

        #endregion

        #region 批量写入Excel内容

        /// <summary>
        /// 将二维数组数据写入Excel文件
        /// </summary>
        /// <param name="arr">二维数组</param>
        /// <param name="top">行索引</param>
        /// <param name="left">列索引</param>
        public void ArrayToExcel(object[,] arr, int top, int left)
        {
            int rowCount = arr.GetLength(0); //二维数组行数（一维长度）
            int colCount = arr.GetLength(1); //二维数据列数（二维长度）

            Range range = (Range)xlWorkSheet.Cells[top, left];
            range = range.get_Resize(rowCount, colCount);
            range.FormulaArray = arr;

            xlWorkSheet.Columns.EntireColumn.AutoFit();//列宽自适应
        }

        #endregion

        #region 行操作

        /// <summary>
        /// 插行（在指定行上面插入指定数量行）
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="count"></param>
        public void InsertRows(int rowIndex, int count)
        {
            try
            {
                Range range = (Range)xlWorkSheet.Rows[rowIndex, this.misValue];
                for (int i = 0; i < count; i++)
                {
                    range.Insert(XlDirection.xlDown, misValue);
                }
            }
            catch (Exception e)
            {
                this.KillExcelProcess(false);
                throw e;
            }
        }

        /// <summary>
        /// 复制行（在指定行下面复制指定数量行）
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="count"></param>
        public void CopyRows(int rowIndex, int count)
        {
            try
            {
                Range range1 = (Range)xlWorkSheet.Rows[rowIndex, this.misValue];
                Range range2;
                for (int i = 1; i <= count; i++)
                {
                    range2 = (Range)xlWorkSheet.Rows[rowIndex + i, this.misValue];
                    range1.Copy(range2);
                }
            }
            catch (Exception e)
            {
                this.KillExcelProcess(false);
                throw e;
            }
        }

        /// <summary>
        /// 删除行
        /// </summary>
        /// <param name="sheetIndex"></param>
        /// <param name="rowIndex"></param>
        /// <param name="count"></param>
        public void DeleteRows(int rowIndex, int count)
        {
            try
            {
                Range range;
                for (int i = 0; i < count; i++)
                {
                    range = (Range)xlWorkSheet.Rows[rowIndex, this.misValue];
                    range.Delete(XlDirection.xlDown);
                }
            }
            catch (Exception e)
            {
                this.KillExcelProcess(false);
                throw e;
            }
        }

        #endregion

        #region 列操作

        /// <summary>
        /// 插列（在指定列右边插入指定数量列）
        /// </summary>
        /// <param name="columnIndex"></param>
        /// <param name="count"></param>
        public void InsertColumns(int columnIndex, int count)
        {
            try
            {
                Range range = (Range)(xlWorkSheet.Columns[columnIndex, this.misValue]);  //注意：这里和VS的智能提示不一样，第一个参数是columnindex

                for (int i = 0; i < count; i++)
                {
                    range.Insert(XlDirection.xlDown, misValue);
                }
            }
            catch (Exception e)
            {
                this.KillExcelProcess(false);
                throw e;
            }
        }

        /// <summary>
        /// 删除列
        /// </summary> 
        /// <param name="columnIndex"></param>
        /// <param name="count"></param>
        public void DeleteColumns(int columnIndex, int count)
        {
            try
            {
                for (int i = columnIndex + count - 1; i >= columnIndex; i--)
                {
                    ((Range)xlWorkSheet.Cells[1, i]).EntireColumn.Delete(0);
                }
            }
            catch (Exception e)
            {
                this.KillExcelProcess(false);
                throw e;
            }
        }

        #endregion

        #region 单元格操作

        /// <summary>
        /// 合并单元格，并赋值，对指定WorkSheet操作
        /// </summary>
        /// <param name="sheetIndex">WorkSheet索引</param>
        /// <param name="beginRowIndex">开始行索引</param>
        /// <param name="beginColumnIndex">开始列索引</param>
        /// <param name="endRowIndex">结束行索引</param>
        /// <param name="endColumnIndex">结束列索引</param>
        /// <param name="text">合并后Range的值</param>
        public void MergeCells(int beginRowIndex, int beginColumnIndex, int endRowIndex, int endColumnIndex, string text)
        {
            Range range = xlWorkSheet.get_Range(xlWorkSheet.Cells[beginRowIndex, beginColumnIndex], xlWorkSheet.Cells[endRowIndex, endColumnIndex]);

            range.ClearContents(); //先把Range内容清除，合并才不会出错
            range.MergeCells = true;

            range.Value2 = text;
            range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            range.VerticalAlignment = XlVAlign.xlVAlignCenter;
        }

        /// <summary>
        /// 向单元格写入数据，对当前WorkSheet操作
        /// </summary>
        /// <param name="rowIndex">行索引</param>
        /// <param name="columnIndex">列索引</param>
        /// <param name="text">要写入的文本值</param>
        public void SetCells(int rowIndex, int columnIndex, string text)
        {
            try
            {
                xlWorkSheet.Cells[rowIndex, columnIndex] = text;
            }
            catch
            {
                this.KillExcelProcess(false);
                throw new Exception("向单元格[" + rowIndex + "," + columnIndex + "]写数据出错！");
            }
        }

        /// <summary>
        /// 向单元格写入数据，对当前WorkSheet操作
        /// </summary>
        /// <param name="rowIndex">行索引</param>
        /// <param name="columnIndex">列索引</param>
        /// <param name="text">要写入的文本值</param>
        public void SetCells(int rowIndex, int columnIndex, string text, string comment)
        {
            try
            {
                xlWorkSheet.Cells[rowIndex, columnIndex] = text;
                SetCellComment(rowIndex, columnIndex, comment);
            }
            catch
            {
                this.KillExcelProcess(false);
                throw new Exception("向单元格[" + rowIndex + "," + columnIndex + "]写数据出错！");
            }
        }

        /// <summary>
        /// 向单元格写入数据，对当前WorkSheet操作
        /// </summary>
        /// <param name="rowIndex">行索引</param>
        /// <param name="columnIndex">列索引</param>
        /// <param name="text">要写入的文本值</param>
        public void SetCellComment(int rowIndex, int columnIndex, string comment)
        {
            try
            {
                Range range = xlWorkSheet.Cells[rowIndex, columnIndex] as Range;
                range.AddComment(comment);
            }
            catch
            {
                this.KillExcelProcess(false);
                throw new Exception("向单元格[" + rowIndex + "," + columnIndex + "]写数据出错！");
            }
        }

        /// <summary>
        /// 单元格背景色及填充方式
        /// </summary>
        /// <param name="startRow">起始行</param>
        /// <param name="startColumn">起始列</param>
        /// <param name="endRow">结束行</param>
        /// <param name="endColumn">结束列</param>
        /// <param name="color">颜色索引</param>
        public void SetCellsBackColor(int startRow, int startColumn, int endRow, int endColumn, ColorIndex color)
        {
            Range range = xlApp.get_Range(xlApp.Cells[startRow, startColumn], xlApp.Cells[endRow, endColumn]);
            range.Interior.ColorIndex = color;
        }

        #endregion

        #region 杀进程释放资源

        /// <summary>
        /// 结束Excel进程
        /// </summary>
        public void KillExcelProcess(bool bAll)
        {
            if (bAll)
            {
                KillAllExcelProcess();
            }
            else
            {
                KillSpecialExcel();
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);


        /// <summary>
        /// 杀特殊进程的Excel
        /// </summary>
        public void KillSpecialExcel()
        {
            try
            {
                if (xlApp != null)
                {
                    int lpdwProcessId;
                    GetWindowThreadProcessId((IntPtr)xlApp.Hwnd, out lpdwProcessId);

                    if (lpdwProcessId > 0)    //c-s方式
                    {
                        System.Diagnostics.Process.GetProcessById(lpdwProcessId).Kill();
                    }
                    else
                    {
                        Quit();
                    }
                }
            }
            catch { }
        }
        /// <summary>
        /// 释放资源
        /// </summary>
        public void Quit()
        {
            if (xlWorkBook != null)
                xlWorkBook.Close(null, null, null);
            if (xlApp != null)
            {
                xlApp.Workbooks.Close();
                xlApp.Quit();
            }
            if (xlWorkSheet != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
                xlWorkSheet = null;
            }
            if (xlWorkBook != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
                xlWorkBook = null;
            }
            if (xlApp != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                xlApp = null;
            }
            GC.Collect();
        }

        /// <summary>
        /// 接口方法 释放资源
        /// </summary>
        public void Dispose()
        {
            Quit();
        }

        #endregion

        #region 杀Excel进程

        /// <summary>
        /// 杀Excel进程
        /// </summary>
        public static void KillAllExcelProcess()
        {
            System.Diagnostics.Process[] myProcesses;
            myProcesses = System.Diagnostics.Process.GetProcessesByName("Excel");

            //得不到Excel进程ID，暂时只能判断进程启动时间
            foreach (System.Diagnostics.Process myProcess in myProcesses)
            {
                myProcess.Kill();
            }
        }

        /// <summary>
        /// 如果打开了filePath文件，就关闭Excel进程
        /// </summary>
        public void killWnWordProcess(string filePath)
        {
            string fileName = System.IO.Path.GetFileName(filePath);
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("WINWORD");
            foreach (System.Diagnostics.Process process in processes)
            {
                if (process.MainWindowTitle == fileName + " - Microsoft Word" || process.MainWindowTitle == "")
                {
                    process.Kill();
                }
            }
            string openName = System.IO.Path.GetDirectoryName(filePath) + "\\~$" + fileName.Substring(2, fileName.Length - 2);
            if (System.IO.File.Exists(openName))
            {
                System.IO.File.Delete(openName);//删除
            }
        }
        #endregion
        /// <summary>
        /// 常用颜色定义,对就Excel中颜色名
        /// </summary>
        public enum ColorIndex
        {
            无色 = -4142,
            自动 = -4105,
            黑色 = 1,
            褐色 = 53,
            橄榄 = 52,
            深绿 = 51,
            深青 = 49,
            深蓝 = 11,
            靛蓝 = 55,
            灰色80 = 56,
            深红 = 9,
            橙色 = 46,
            深黄 = 12,
            绿色 = 10,
            青色 = 14,
            蓝色 = 5,
            蓝灰 = 47,
            灰色50 = 16,
            红色 = 3,
            浅橙色 = 45,
            酸橙色 = 43,
            海绿 = 50,
            水绿色 = 42,
            浅蓝 = 41,
            紫罗兰 = 13,
            灰色40 = 48,
            粉红 = 7,
            金色 = 44,
            黄色 = 6,
            鲜绿 = 4,
            青绿 = 8,
            天蓝 = 33,
            梅红 = 54,
            灰色25 = 15,
            玫瑰红 = 38,
            茶色 = 40,
            浅黄 = 36,
            浅绿 = 35,
            浅青绿 = 34,
            淡蓝 = 37,
            淡紫 = 39,
            白色 = 2
        }

    }
}
