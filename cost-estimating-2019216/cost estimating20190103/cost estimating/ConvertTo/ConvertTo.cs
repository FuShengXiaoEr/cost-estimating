using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace cost_estimating
{
    public class ConvertTo
    {
        /// <summary>
        /// 将字符串转换为int型整数
        /// </summary>
        /// <param name="intStr"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int ParseInt(string intStr)
        {
            int parseInt = 0;
            int.TryParse(intStr, out parseInt);
            return parseInt;
        }
        

        /// <summary>  
        /// 二维数组转换为DataTable  
        /// </summary>  
        /// <param name="ColumnNames">一维数组，代表列名，不能有重复值</param>  
        /// <param name="Arrays">M行N列的二维数组</param>  
        /// <returns>返回DataTable</returns>  
        public static DataTable ConvertToDataTable(string[] ColumnNames, string[][] Arrays)
        {
            DataTable dt = new DataTable();
            return ConvertToDataTable(ColumnNames, Arrays, dt);
        }

        /// <summary>  
        /// 二维数组转换为DataTable  
        /// </summary>  
        /// <param name="ColumnNames">一维数组，代表列名，不能有重复值</param>  
        /// <param name="Arrays">M行N列的二维数组</param>  
        /// <returns>返回DataTable</returns>  
        public static DataTable ConvertToDataTable(string[] ColumnNames, string[][] Arrays, DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                dt.Clear();
            }
            if (dt.Columns.Count > 0)
            {
                dt.Columns.Clear();
            }
            if (ColumnNames == null)
                return null;
            foreach (string ColumnName in ColumnNames)
            {
                dt.Columns.Add(ColumnName, typeof(string));
            }
            if (Arrays != null)
            {
                for (int i1 = 0; i1 < Arrays.GetLength(0); i1++)
                {
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < Arrays[i1].Length; i++)
                    {
                        dr[ColumnNames[i]] = Arrays[i1][i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
    }
}
