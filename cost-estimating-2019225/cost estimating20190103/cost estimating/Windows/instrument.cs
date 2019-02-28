using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cost_estimating
{
    public delegate void dataToBom(DataTable dt);
    public partial class instrument : UserControl
    {
        private Database.AccessConnect dbcon;
        public instrument()
        {
            InitializeComponent();
            //创建数据库连接对象
            dbcon = new Database.AccessConnect();
            dataGridViewWithCheck_insdesc.Columns[0].FillWeight = 70;
            dataGridViewWithCheck_insdesc.Columns[1].FillWeight = 15;
            dataGridViewWithCheck_insdesc.Columns[2].FillWeight = 15;
            brand_name.SelectedIndex = -1;
        }

        public void combobox_Item(ComboBox combobox,string[] items)
        {
            //允许代码重新绘制,固定大小
            combobox.DrawMode = DrawMode.OwnerDrawFixed;
            //combobox.SelectedText = "--请选择--" ;            
            combobox.Items.AddRange(items);
        }

        /// <summary>
        /// 将combobox中的项居中显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void comboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;
            string s = combobox.Items[e.Index].ToString();
            //计算字符串尺寸（以像素为单位)
            SizeF ss = e.Graphics.MeasureString(s, e.Font);
            //水平居中
            float left = (float)(e.Bounds.Width - ss.Width) / 2;
            if (left < 0)
                left = 0f;
            //垂直居中
            float top = (float)(e.Bounds.Height - ss.Height) / 2;
            if (top < 0)
                top = 0f;
            top = top + combobox.ItemHeight * e.Index;
            //输出
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(
                s,
                e.Font,
                new SolidBrush(e.ForeColor),
                left,
                top);
        }


        private void instrument_Load(object sender, EventArgs e)
        {
            
            string[] list = dbcon.loadIngredient().ToArray();
            //负载组成
            combobox_Item(comboBox_load,list);
            comboBox_load.DrawItem += new DrawItemEventHandler(comboBox_DrawItem);
            
        }

        private void comboBox_load_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecttext = comboBox_load.SelectedItem.ToString();
            material_name.Items.Clear();
            string[] list = dbcon.instrument(selecttext).ToArray();
            combobox_Item(material_name, list);
            material_name.DrawItem += new DrawItemEventHandler(comboBox_DrawItem);
        }

        private void material_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecttext = material_name.SelectedItem.ToString();
            brand_name.Items.Clear();
            string[] list = dbcon.getBrandName(selecttext).ToArray();
            combobox_Item(brand_name, list);
            brand_name.DrawItem += new DrawItemEventHandler(comboBox_DrawItem);
        }

        private void instrument_add_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable(); 
            dt.Rows.Clear(); //刷新列表内容
            
            DataColumn dc_type = new DataColumn();
            DataColumn dc_unit = new DataColumn();
            DataColumn dc_unitprice = new DataColumn();
            dc_type.ColumnName = "dc_type";
            dc_unit.ColumnName = "dc_unit";
            dc_unitprice.ColumnName = "dc_unitprice";
            dt.Columns.Add(dc_type);
            dt.Columns.Add(dc_unit);
            dt.Columns.Add(dc_unitprice);

            //从数据库获取数据
            string specificationName = material_name.SelectedItem.ToString();
            string brandName;
            //当没有选择品牌时，传递空值
            if (brand_name.SelectedIndex == -1)
            {
                brandName = "";
            }
            else
            {
                brandName = brand_name.SelectedItem.ToString();  
            }
            //brandName = brand_name.SelectedItem.ToString();  
            List<string>[] lists = dbcon.getInstrumentDesc(specificationName,brandName);
            
            for (int i = 0; i < lists[0].Count; i++) //这里lists中有三个元素，为了计算出每个元素的长度，这里随机选择其中一个。
            {
                DataRow dr = dt.NewRow();
                dr[dc_type] = lists[0][i].ToString();
                dr[dc_unit] = lists[1][i].ToString();
                dr[dc_unitprice] = lists[2][i].ToString();

                dt.Rows.Add(dr);
            }
            
            dataGridViewWithCheck_insdesc.AutoGenerateColumns = false;
            dataGridViewWithCheck_insdesc.DataSource = dt;
            
            
        }

        /// <summary>
        /// 将选中行的值传递到BOM清单表格中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //public delegate void dataToBom(DataTable dt);
        //public delegate void dataToBom(string str);
        public event dataToBom getDataEvent;
        //public static DataTable ins2bom; //定义静态变量，这样调用的时候无需创建实例
        
        private void button_instrumentAdd_Click(object sender, EventArgs e)
        {
            DataTable ins2bom = new DataTable();
            string constitueName = comboBox_load.SelectedItem.ToString();
            string materialName = material_name.SelectedItem.ToString();
            string brandName = brand_name.SelectedItem.ToString();

            int[] selectedIndex = this.dataGridViewWithCheck_insdesc.selectRows();

            DataColumn loadconstitueColumn = new DataColumn();
            DataColumn materialNameColumn = new DataColumn();
            DataColumn brandNameColumn = new DataColumn();
            DataColumn typeColumn = new DataColumn();
            DataColumn unitColumn = new DataColumn();
            DataColumn unitpriceColumn = new DataColumn();

            loadconstitueColumn.ColumnName = "loadconstitue";
            materialNameColumn.ColumnName = "material_name";
            brandNameColumn.ColumnName = "brand_name";
            typeColumn.ColumnName = "type";
            unitColumn.ColumnName = "unit";
            unitpriceColumn.ColumnName = "unitprice";

            ins2bom.Columns.Add(loadconstitueColumn);
            ins2bom.Columns.Add(materialNameColumn);
            ins2bom.Columns.Add(brandNameColumn);
            ins2bom.Columns.Add(typeColumn);
            ins2bom.Columns.Add(unitColumn);
            ins2bom.Columns.Add(unitpriceColumn);

            if (selectedIndex.Length != 0)
            {
                //通过循环将选中行的内容读取出来
                for (int i = 0; i < selectedIndex.Length; i++)
                {
                    DataRow dr = ins2bom.NewRow();
                    dr[loadconstitueColumn] = constitueName;
                    dr[materialNameColumn] = materialName;
                    dr[brandNameColumn] = brandName;
                    dr[typeColumn] = dataGridViewWithCheck_insdesc.Rows[selectedIndex[i]].Cells["specifications"].Value ;
                    dr[unitColumn] = dataGridViewWithCheck_insdesc.Rows[selectedIndex[i]].Cells["units"].Value;
                    dr[unitpriceColumn] = dataGridViewWithCheck_insdesc.Rows[selectedIndex[i]].Cells["units_price"].Value;

                    /*dr[typeColumn] = dataGridViewWithCheck_insdesc.Rows[selectedIndex[i]].Cells[1].ToString();
                    dr[unitColumn] = dataGridViewWithCheck_insdesc.Rows[selectedIndex[i]].Cells[2].ToString();
                    dr[unitpriceColumn] = dataGridViewWithCheck_insdesc.Rows[selectedIndex[i]].Cells[3].ToString();*/

                    ins2bom.Rows.Add(dr);
                }
                
                getDataEvent(ins2bom);
            }
            else
            {
                MessageBox.Show("请选择！");
            }
        }

      
        

       /* private void material_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            dbcon = new Database.DBConnect();

            list = dbcon.loadIngredient();

        }*/

    }
}
