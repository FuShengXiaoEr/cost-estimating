using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cost_estimating
{
    public partial class Main : Form
    {       
        bool material_selection;   //根据bool状态用if来确认打开还是收缩  
        bool numercial_computation;
        int material_height = 249; //物料选择时下放空间需要改变的高度
        int numerical_height = 0;//对数字计算控件高度进行递增递减
 
        public instrument win_i;   //定义仪表选择窗口
        public numerical_gpbwindows win_ng;//定义单击数值计算切换窗口
        public Main()
        {
             InitializeComponent();          
             material_selection = false;
             numercial_computation = false;             
             material_selection = navbar_material_change(material_selection, material_height);              
             numercial_computation = navbar_numerical_change(numercial_computation, numerical_height);
             win_i = new instrument();
             win_ng = new numerical_gpbwindows();
        }
        /// <summary>
        /// 导航栏伸展变化-物料选择时，数值计算位置移动以及文本控件的显示
        /// </summary>
        /// <param name="navbar_lable">判断物料选择导航栏是打开还是闭合 true:缩 false:伸</param>
        /// <param name="height_change">打开和闭合时，下放导航栏的变化</param>
        /// <returns></returns>
        private bool navbar_material_change(bool navbar_lable,int height_change)
        {
            if (navbar_lable == true)//打开列表
            {               
                material_listitems.Visible = true;
                button_numerical_computation.Top += height_change;
                numerical_listitems.Top += height_change;
                navbar_lable = false;

            }
            else
            {                
                material_listitems.Visible = false;
                button_numerical_computation.Top -= height_change;
                numerical_listitems.Top -= height_change;
                navbar_lable = true;                
            }
            return navbar_lable;
        }

        /// <summary>
        /// 导航栏伸展变化-数值计算时，数值计算位置移动以及文本控件的显示
        /// </summary>
        /// <param name="navbar_lable">判断数值计算导航栏是打开还是闭合</param>
        /// <param name="height_change">打开和闭合时，下放导航栏的变化</param>
        /// <returns></returns>
        private bool navbar_numerical_change(bool navbar_lable, int height_change)
        {
            if (navbar_lable == false)
            {
                numerical_listitems.Visible = false;
                navbar_lable = true;
            }
            else
            {
                numerical_listitems.Visible = true;
                navbar_lable = false;
 
            }
            return navbar_lable;
        }   

        private void button_material_Click(object sender, EventArgs e)
        {                       
            button_material.Visible = true;
            button_numerical_computation.Visible = true;
            material_selection = navbar_material_change(material_selection,material_height); 
                        
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            //win_i = new instrument();            
            gpbwindows.Controls.Clear();//清空之前加载的窗体
            win_i.Show();
            gpbwindows.Controls.Add(win_i);
        }

        /// <summary>
        /// 打击数值计算导航栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_numerical_computation_Click(object sender, EventArgs e)
        {   
            //win_ng = new numerical_gpbwindows();
            win_ng.Show();         
            numercial_computation = navbar_numerical_change(numercial_computation, numerical_height);            
            gpbwindows.Controls.Clear();
            gpbwindows.Controls.Add(win_ng);
        }

      
                 
    }
}
