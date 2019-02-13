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

        bool isFormMove = false;//窗体是否移动
        Point formPoint;//记录窗体的位置

        public Main()
        {
             InitializeComponent();          
             material_selection = false;
             numercial_computation = false;             
             material_selection = navbar_material_change(material_selection, material_height);              
             numercial_computation = navbar_numerical_change(numercial_computation, numerical_height);
             win_i = new instrument();
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
            childForm.Controls.Clear();//清空之前加载的窗体
            win_i.Show();
            childForm.Controls.Add(win_i);
        }

        /// <summary>
        /// 点击数值计算导航栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_numerical_computation_Click(object sender, EventArgs e)
        {   
            //win_ng = new numerical_gpbwindows();
            //win_ng.Show();         
            numercial_computation = navbar_numerical_change(numercial_computation, numerical_height);            
            childForm.Controls.Clear();
            //gpbwindows.Controls.Add(win_ng);
        }

        private void label_resistance_Click(object sender, EventArgs e)
        {
            win_ngShow(RLC.Resistance.GetInstance());
        }

        private void label_capacitance_Click(object sender, EventArgs e)
        {
            win_ngShow(RLC.Capacitance.GetInstance());
        }

        private void label_reactance_Click(object sender, EventArgs e)
        {
            win_ngShow(RLC.Inductance.GetInstance());
        }
        private readonly object _mylock = new object();//防止多创建win_ng窗体
        /// <summary>
        /// 显示win_ng
        /// </summary>
        private void win_ngShow(RLC.BaseRLC baseRLC)
        {
            lock (_mylock)
            {
                if (win_ng == null || win_ng.IsDisposed)
                {
                    win_ng = new numerical_gpbwindows(baseRLC);
                }
                else
                {
                    win_ng.BaseRLC = baseRLC;
                }
            }
            if (!childForm.Controls.Contains(win_ng))
            {
                win_ng.Show();
                childForm.Controls.Clear();
                childForm.Controls.Add(win_ng);
            }
        }

        private void btnMinBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseBox_Click(object sender, EventArgs e)
        {
            /*if (modbusThread != null)
            {
                modbusThread.stop();
            }*/
            //this.Close();
            Application.Exit();
        }

        private void form_MouseDown(object sender, MouseEventArgs e)//鼠标按下
        {
            formPoint = new Point();
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
                formPoint = new Point(xOffset, yOffset);
                isFormMove = true;//开始移动
            }
        }
        private void form_MouseMove(object sender, MouseEventArgs e)//鼠标移动
        {
            if (isFormMove == true)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void form_MouseUp(object sender, MouseEventArgs e)//鼠标松开
        {
            if (e.Button == MouseButtons.Left)//按下的是鼠标左键
            {
                isFormMove = false;//停止移动
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 testForm = new Form1();
            testForm.Show();
        }     
    }
}
