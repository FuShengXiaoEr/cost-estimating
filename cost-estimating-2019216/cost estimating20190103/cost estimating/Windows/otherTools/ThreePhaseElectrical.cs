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
    public partial class ThreePhaseElectrical : UserControl
    {
        string[] u_array = { "线电压", "相电压", "线电流", "相电流"};
        string[] power_array = { "有功功率", "无功功率", "视在功率" };
        string[] type_array = { "△", "Y" };
        public ThreePhaseElectrical()
        {
            InitializeComponent();
            
            comboBox_u.DataSource = u_array;
            comboBox_u.SelectedItem = 0;

            comboBox_power.DataSource = power_array;
            comboBox_power.SelectedIndex = 0;

            comboBox_type.DataSource = type_array;
            comboBox_type.SelectedIndex = 0;


        }

        private void textBox_u_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            } 
        }

        private void comboBox_power_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    power_unit.Text = "W";
                    break;
                case 1:
                    power_unit.Text = "Var";
                    break;
                case 2:
                    power_unit.Text = "Va";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double PF, Uab, Uan, Iab, Ian, P, Q, S;

            if (textbox_pf.Text != "" && textBox_power.Text != "" && textBox_u.Text != "")
            {

                PF = Convert.ToDouble(textbox_pf.Text);
                if (comboBox_power.SelectedIndex == 0)
                {
                    P = Convert.ToDouble(textBox_power.Text);
                    S = P / PF;
                    Q = Math.Sqrt(S * S - P * P);
                }
                else if (comboBox_power.SelectedIndex == 1)
                {
                    Q = Convert.ToDouble(textBox_power.Text);
                    S = Q / Math.Sqrt(1 - PF * PF);
                    P = S * PF;
                }
                else
                {
                    S = Convert.ToDouble(textBox_power.Text);
                    P = S * PF;
                    Q = Math.Sqrt(S * S - P * P);
                }


                if (comboBox_type.SelectedIndex == 0)
                {
                    if (comboBox_u.SelectedIndex == 0 || comboBox_u.SelectedIndex == 1)
                    {
                        Uab = Uan = Convert.ToDouble(textBox_u.Text);
                        Iab = S / (Uab * Math.Sqrt(3));
                        Ian = Iab / Math.Sqrt(3);
                    }
                    else if (comboBox_u.SelectedIndex == 2)
                    {
                        Iab = Convert.ToDouble(textBox_u.Text);
                        Ian = Iab * Math.Sqrt(3);
                        Uan = Uab = S / (Iab * Math.Sqrt(3));
                    }
                    else
                    {
                        Ian = Convert.ToDouble(textBox_u.Text);
                        Iab = Ian / Math.Sqrt(3);
                        Uan = Uab = S / (Iab * Math.Sqrt(3));
                    }
                }
                else
                {
                    if (comboBox_u.SelectedIndex == 0)
                    {
                        Uab = Convert.ToDouble(textBox_u.Text);
                        Uan = Uab / Math.Sqrt(3);
                        Ian = Iab = S / (Uab * Math.Sqrt(3));
                    }
                    else if (comboBox_u.SelectedIndex == 1)
                    {
                        Uan = Convert.ToDouble(textBox_u.Text);
                        Uab = Uan * Math.Sqrt(3);
                        Ian = Iab = S / (Uab * Math.Sqrt(3));
                    }
                    else
                    {
                        Ian = Iab = Convert.ToDouble(textBox_u.Text);
                        Uab = S / (Iab * Math.Sqrt(3));
                        Uan = Uab / Math.Sqrt(3);
                    }
                }

                Uab = Math.Floor(Uab * 100 + 0.5) / 100;
                Iab = Math.Floor(Iab * 100 + 0.5) / 100;
                Uan = Math.Floor(Uan * 100 + 0.5) / 100;
                Ian = Math.Floor(Ian * 100 + 0.5) / 100;
                P = Math.Floor(P * 100 + 0.5) / 100;
                Q = Math.Floor(Q * 100 + 0.5) / 100;
                S = Math.Floor(S * 100 + 0.5) / 100;

                result_1.Text = "线电压 = " + Uab + "V\n线电流 = " + Iab + "A\n相电压 = " + Uan + "V\n相电流 = " + Ian + "A";
                result_2.Text = "有功功率 = " + P + "W\n无功功率 = " + Q + "Var\n视在功率 = " + S + "Va";

            }
            else
            {
                MessageBox.Show("输入数据有误！\n输入框不能为空。", "错误");///显示一个消息框
            }
        }

   }
}
