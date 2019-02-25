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
        bool material_selection;   //根据bool状态用if来确认打开还是收缩  物料选择的flag
        bool numercial_computation;//数值计算的收缩flag
        int material_height = 249; //物料选择时下放空间需要改变的高度
        int numerical_height = 0;//对数字计算控件高度进行递增递减
 
        public instrument win_i;   //定义仪表选择窗口
        public numerical_gpbwindows win_ng;//定义单击数值计算切换窗口

        bool isFormMove = false;//窗体是否移动
        Point formPoint;//记录窗体的位置
        public Main()
        {
             InitializeComponent();
             material_height = this.material_listitems.Height;
             material_selection = false;
             numercial_computation = false;             
             navbar_material_change(material_height);              
             navbar_numerical_change(numerical_height);
             win_i = new instrument();
        }
        /// <summary>
        /// 导航栏伸展变化-物料选择时，数值计算位置移动以及文本控件的显示
        /// </summary>
        /// <param name="material_selection">判断物料选择导航栏是打开还是闭合 true:缩 false:伸</param>
        /// <param name="height_change">打开和闭合时，下放导航栏的变化</param>
        /// <returns></returns>
        private void navbar_material_change(int height_change)
        {
            if (material_selection == true)//打开列表
            {               
                material_listitems.Visible = true;
                button_numerical_computation.Top += height_change;
                numerical_listitems.Top += height_change;
                button_material.Text = "ˇ物料选择";
                material_selection = false;

            }
            else
            {                
                material_listitems.Visible = false;
                button_numerical_computation.Top -= height_change;
                numerical_listitems.Top -= height_change;
                button_material.Text = "›物料选择";
                material_selection = true;                
            }
        }

        /// <summary>
        /// 导航栏伸展变化-数值计算时，数值计算位置移动以及文本控件的显示
        /// </summary>
        /// <param name="numercial_computation">判断数值计算导航栏是打开还是闭合</param>
        /// <param name="height_change">打开和闭合时，下放导航栏的变化</param>
        /// <returns></returns>
        private void navbar_numerical_change(int height_change)
        {
            if (numercial_computation == false)
            {
                numerical_listitems.Visible = false;
                button_numerical_computation.Text = "›数值计算";
                numercial_computation = true;
            }
            else
            {
                numerical_listitems.Visible = true;
                button_numerical_computation.Text = "ˇ数值计算";
                numercial_computation = false;
 
            }
        }   
        /// <summary>
        /// 物料选择按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_material_Click(object sender, EventArgs e)
        {  
            navbar_material_change(material_height); 
                        
        }

        /// <summary>
        /// 数值计算按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_numerical_computation_Click(object sender, EventArgs e)
        {
            navbar_numerical_change(numerical_height);
            //childForm.Controls.Clear();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {
            //win_i = new instrument();            
            childForm.Controls.Clear();//清空之前加载的窗体
            win_i.Show();
            childForm.Controls.Add(win_i);
        }


        private void btnResistance_Click(object sender, EventArgs e)
        {
            win_ngShow(RLC.Resistance.GetInstance());
        }

        private void btnCapacitance_Click(object sender, EventArgs e)
        {
            win_ngShow(RLC.Capacitance.GetInstance());
        }

        private void btnReactance_Click(object sender, EventArgs e)
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
