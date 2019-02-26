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
        Button[] navBarButtons;//左侧导航栏的按钮
        Panel[] navBarLists;//左侧导航栏的list列表
        int[] navBarLists_heights;//左侧导航栏的list列表高度
        bool[] navBarBtnOpenFlag;////左侧导航栏的list列表展开的标记
 
        public instrument win_i;   //定义仪表选择窗口
        public numerical_gpbwindows win_ng;//定义单击数值计算切换窗口

        bool isFormMove = false;//窗体是否移动
        Point formPoint;//记录窗体的位置
        public Main()
        {
             InitializeComponent();
             navBarButtons =new Button[]{this.button_material,this.button_numerical_computation,this.button_OtherTools};
             navBarLists = new Panel[] { this.material_listitems, this.numerical_listitems, this.otherTools_list };
             initNavBar();
             win_i = new instrument();
        }
        /// <summary>
        /// 初始化左侧导航栏
        /// </summary>
        public void initNavBar()
        {
            navBarBtnOpenFlag = new bool[] { false, false, false };
            navBarLists_heights = new int[] {this.material_listitems.Height, this.numerical_listitems.Height, this.otherTools_list.Height };
            for (int i = 0; i < navBarButtons.Length; i++)
            {
                navBar_change(navBarButtons[i]);
            }
        }
        /// <summary>
        /// 左侧导航栏的打开关闭
        /// </summary>
        /// <param name="btnNavBar"></param>
        private void navBar_change(Button btnNavBar)
        {
            int index = Array.IndexOf(navBarButtons, btnNavBar);//查找btnNavBar在数组navBarButtons里面的索引值
            if (navBarBtnOpenFlag[index] == true)//打开列表
            {
                this.navBarLists[index].Visible = true;
                btnNavBar.Text = "ˇ" + btnNavBar.Text.Substring(1);
                for (int i = index + 1; i < navBarButtons.Length; i++)
                {
                    this.navBarButtons[i].Top += this.navBarLists_heights[index];
                    this.navBarLists[i].Top += this.navBarLists_heights[index];
                }
                this.navBarBtnOpenFlag[index] = false;
            }
            else
            {
                this.navBarLists[index].Visible = false;
                btnNavBar.Text = "›" + btnNavBar.Text.Substring(1);
                for (int i = index + 1; i < navBarButtons.Length; i++)
                {
                    this.navBarButtons[i].Top -= this.navBarLists_heights[index];
                    this.navBarLists[i].Top -= this.navBarLists_heights[index];
                }
                this.navBarBtnOpenFlag[index] = true;
            }
        }

        /// <summary>
        /// 左侧导航栏菜单按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_navBar_Click(object sender, EventArgs e)
        {
            navBar_change((sender as Button));            
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
        /// <summary>
        /// 其他计算工具
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void otherTools_Click(object sender, EventArgs e)
        {
            childForm.Controls.Clear();
            switch (((Button)sender).Text)
            {
                case "三相电参数计算":
                    childForm.Controls.Add(new ThreePhaseElectrical());
                    break;
                case "负载档位RLC范围计算":
                    childForm.Controls.Add(new ThreePhaseGear());
                    break;
                case "不对称负载的计算":
                    childForm.Controls.Add(new VoltageCalcualte());
                    break;
                case "降压变频的计算":
                    childForm.Controls.Add(new ChangeVoltageFrequency());
                    break;
            }
        }
    }
}
