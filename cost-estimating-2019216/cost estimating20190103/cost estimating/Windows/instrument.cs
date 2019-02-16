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
    public partial class instrument : UserControl
    {
        private Database.DBConnect dbcon;
        public instrument()
        {
            InitializeComponent();
            //创建数据库连接对象
            dbcon = new Database.DBConnect();
            dataGridViewWithCheck_instruDesc.Columns[0].FillWeight = 80;
            dataGridViewWithCheck_instruDesc.Columns[1].FillWeight = 10;
            dataGridViewWithCheck_instruDesc.Columns[2].FillWeight = 10;
            //dataGridViewWithCheck_instruDesc.Columns[3].FillWeight = 10;
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

      
        

       /* private void material_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            dbcon = new Database.DBConnect();

            list = dbcon.loadIngredient();

        }*/

    }
}
