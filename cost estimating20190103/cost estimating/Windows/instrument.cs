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
        public instrument()
        {
            InitializeComponent();          

        }

        public void combobox_Item(ComboBox combobox,string[] items)
        {
            //允许代码重新绘制,固定大小
            combobox.DrawMode = DrawMode.OwnerDrawFixed;
            combobox.SelectedText = "--请选择--" ;            
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
           
            //物料名称           
            string[] material_items = { 
                                        "多功能仪表",
                                        "温控器",
                                        "电流互感器"
                                        };
            combobox_Item(material_name, material_items);
            material_name.DrawItem += new DrawItemEventHandler(comboBox_DrawItem);

            //品牌名称
            string[] brand_items = {
                                        "欧姆龙",
                                        "安科瑞",
                                        "正泰"
                                    };
            combobox_Item(brand_name, brand_items);
            brand_name.DrawItem += new DrawItemEventHandler(comboBox_DrawItem);
           
            
        }      
               

       
        private void material_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
                                    
       
    }
}
