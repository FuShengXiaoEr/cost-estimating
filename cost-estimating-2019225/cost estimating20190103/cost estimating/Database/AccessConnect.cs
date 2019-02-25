using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace cost_estimating.Database
{
    class AccessConnect
    {
        private OleDbConnection connection;
        //private string server;
        //private string database;
        //private string uid;
    //private string password;
        //private string charset;

        //Constructor
        public AccessConnect()
        {
            Initialize();
        }
        private void Initialize()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:\Users\rd42\Desktop\cost_estimating.mdb");
        }

        //open connection to database
        private bool OpenConnection()
        {
            connection.Open();
            return true;
            /*try
            {
                connection.Open();
                return true;
            }
            catch (OleDbException ex)
            {
                switch (ex.)
                {
                    case 0:
                        MessageBox.Show("无法连接数据库");
                        break;

                    case 1045:
                        MessageBox.Show("无效的用户名或密码,请重试");
                        break;
                }
                return false;
            }*/
        }

        //close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 将负载组成读取出来赋值给combobox
        /// </summary>
        /// <returns></returns>

        public List<string> loadIngredient()
        {
            string query = "select * from loadingredient";

            List<string> list = new List<string>();

            if (this.OpenConnection() == true)
            {
                //create Command
                OleDbCommand cmd = new OleDbCommand(query, connection);
                OleDbDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(dataReader["uliName"] + "");
                }

                dataReader.Close();

                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }

        /// <summary>
        /// 根据负载选项读取相应的物料名称
        /// </summary>
        /// <param name="selectedtext"></param>
        /// <returns></returns>

        public List<string> instrument(string selectedtext)
        {
            //通过查询物料名称表和负载组成表
            //string sql = "select insName from loadingredient inner join instrumentname on  loadingredient.uliID = instrumentname.uliID where uliName = '@uliName';";
            List<string> list = new List<string>();
            if (this.OpenConnection() == true)
            {

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select insName from loadingredient inner join instrumentname on  loadingredient.uliID = instrumentname.uliID where uliName = @uliName;";
                cmd.Parameters.Add("uliName",OleDbType.VarChar).Value = selectedtext;
                OleDbDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(dataReader["insName"]+"");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
            

        }

        /// <summary>
        /// 根据物料名称获取品牌名
        /// </summary>
        /// <returns></returns>
        public List<string> getBrandName(string selectedText)
        {
            List<String> list = new List<string>();
            if (this.OpenConnection() == true)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select ubnName from brand_name as b inner join instrumentname as i on b.ubnID = i.bnID where i.insName = @insName";
                cmd.Parameters.Add("insName", OleDbType.VarChar).Value = selectedText;
                OleDbDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(dataReader["ubnName"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }
        /// <summary>
        /// 根据物料名称和品牌名称获得物料的详情
        /// 1.有品牌名，显示相应器件类型
        /// 2.无品牌名，显示所有器件类型
        /// </summary>
        public List<String>[] getInstrumentDesc(string specificationName, string brandName)
        {
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            if(this.OpenConnection() == true)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                if (brandName != "")
                {
                    cmd.CommandText = "select uidType,uidUnit,unitCost from ins_desc where uidBrand = (select ubnID from brand_name where ubnName = @ubnName) and insNameID = (select uinID from instrumentname where insName = @insName);";
                    //cmd.CommandText = "select uidType,uidUnit,unitCost from ins_desc where uidBrand = (select ubnID from brand_name where ubnName = '安科瑞') and insNameID = (select uinID from instrumentname where insName = '多功能仪表');";
                    cmd.Parameters.Add("ubnName", OleDbType.VarChar).Value = brandName;
                    
                }
                else
                {
                    cmd.CommandText = "select uidType,uidUnit,unitCost from ins_desc where insNameID = (select uinID from instrumentname where insName = @insName);";
                }
                cmd.Parameters.Add("insName", OleDbType.VarChar).Value = specificationName;
                OleDbDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["uidType"]+ "");
                    list[1].Add(dataReader["uidUnit"]+"");
                    list[2].Add(dataReader["unitCost"] + "");
                }

                dataReader.Close();
                this.CloseConnection();

                return list;    
            }
            else
            {
                return list;
            }
        }
    }
}
