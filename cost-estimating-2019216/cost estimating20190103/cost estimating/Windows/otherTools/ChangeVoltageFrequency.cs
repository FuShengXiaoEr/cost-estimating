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
    public partial class ChangeVoltageFrequency : UserControl
    {
        string[] array = { "负载箱有功功率", "负载箱无功功率", "负载箱视在功率", "实际有功功率", "实际无功功率", 
                             "实际视在功率", "实际电流" };
        string[] type_array = { "△", "Y" };
        string[] array4 = { "负载箱功率因数", "实际功率因数" };

        public ChangeVoltageFrequency()
        {
            InitializeComponent();

            comboBox_value.DataSource = array;
            comboBox_value.SelectedIndex = 0;

            comboBox_contype.DataSource = type_array;
            comboBox_contype.SelectedIndex = 0;

            comboBox_pf.DataSource = array4;
            comboBox_pf.SelectedIndex = 0;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_F1.Text != "" && textBox_F2.Text != "" && textBox_Pf.Text != "" && textBox_U1.Text != "" &&
                textBox_U2.Text != "" && textBox_value.Text != "")
            {
                double Uab1, Uab2, Uan1, Uan2, F1, F2, Pf2, P1, P2, Q1, Q2, S1, S2, Pf1, Iab1, Ian1, Iab2, Ian2;
                F1 = Convert.ToDouble(textBox_F1.Text);
                F2 = Convert.ToDouble(textBox_F2.Text);
                Uab1 = Convert.ToDouble(textBox_U1.Text);
                Uab2 = Convert.ToDouble(textBox_U2.Text);
                
                if (comboBox_contype.SelectedIndex == 0)
                {
                    Uan1 = Uab1;
                    Uan2 = Uab2;
                }
                else
                {
                    Uan1 = Uab1 / Math.Sqrt(3);
                    Uan2 = Uab2 / Math.Sqrt(3);
                }

                if (comboBox_value.Text == "负载箱有功功率")
                {
                    P1 = Convert.ToDouble(textBox_value.Text) * 1000;
                    P2 = P1 * Uan2 * Uan2 / Uan1 / Uan1;
                    if (comboBox_contype.SelectedIndex == 0)
                    {
                        Iab1 = P1 / (Uab1 * Math.Sqrt(3));
                        Ian1 = Iab1 / Math.Sqrt(3);
                        Iab2 = P2 / (Uab2 * Math.Sqrt(3));
                        Ian2 = Iab2 / Math.Sqrt(3);
                    }
                    else
                    {
                        Ian1 = P1 / (Uab1 * Math.Sqrt(3));
                        Ian2 = P2 / (Uab2 * Math.Sqrt(3));
                    }
                    result_1.Text = String.Format("有功功率 = {0}KW\n相电流 = {1}", Math.Floor(P1 * 10 + 0.5) / 10000,
                        Math.Floor(Ian1 * 10000 + 0.5) / 10000);
                    result_2.Text = String.Format("有功功率 = {0}KW\n相电流 = {1}", Math.Floor(P2 * 10 + 0.5) / 10000,
                        Math.Floor(Ian2 * 10000 + 0.5) / 10000);
                }
                else if (comboBox_value.Text == "负载箱无功功率")
                {
                    Q1 = Convert.ToDouble(textBox_value.Text) * 1000;
                    Q2 = Q1 * F1 * Uan2 * Uan2 / F2 / Uan1 / Uan1;
                    if (comboBox_contype.SelectedIndex == 0)
                    {
                        Iab1 = Q1 / (Uab1 * Math.Sqrt(3));
                        Ian1 = Iab1 / Math.Sqrt(3);
                        Iab2 = Q2 / (Uab2 * Math.Sqrt(3));
                        Ian2 = Iab2 / Math.Sqrt(3);
                    }
                    else
                    {
                        Ian1 = Q1 / (Uab1 * Math.Sqrt(3));
                        Ian2 = Q2 / (Uab2 * Math.Sqrt(3));
                    }
                    result_1.Text = String.Format("无功功率 = {0}KVar\n相电流 = {1}", Math.Floor(Q1 * 10 + 0.5) / 10000,
                        Math.Floor(Ian1* 10000 + 0.5) / 10000);
                    result_2.Text = String.Format("无功功率 = {0}KVar\n相电流 = {1}", Math.Floor(Q2 * 10 + 0.5) / 10000,
                        Math.Floor(Ian2 * 10000 + 0.5) / 10000);
                }
                else if (comboBox_value.Text == "实际视在功率")
                {
                    Pf2 = Convert.ToDouble(textBox_Pf.Text);
                    S2 = Convert.ToDouble(textBox_value.Text) * 1000;
                    P2 = S2 * Pf2;
                    Q2 = Math.Sqrt(S2 * S2 - P2 * P2);
                    P1 = P2 * Uan1 * Uan1 / Uan2 / Uan2;
                    Q1 = Q2 * Uan1 * Uan1 * F2 / Uan2 / Uan2 / F1;
                    S1 = Math.Sqrt(P1 * P1 + Q1 * Q1);
                    Pf1 = P1 / S1;
                    if (comboBox_contype.SelectedIndex == 0)
                    {
                        Iab1 = S1 / (Uab1 * Math.Sqrt(3));
                        Ian1 = Iab1 / Math.Sqrt(3);
                        Iab2 = S2 / (Uab2 * Math.Sqrt(3));
                        Ian2 = Iab2 / Math.Sqrt(3);
                    }
                    else
                    {
                        Ian1 = S1 / (Uab1 * Math.Sqrt(3));
                        Ian2 = S2 / (Uab2 * Math.Sqrt(3));
                    }
                    result_1.Text = String.Format("视在功率 = {0}KVar\n有功功率 = {1}KW\n无功功率 = {2}KVa\n功率因素 = {3}\n相电流 = {4}A",
                        Math.Floor(S1 * 10 + 0.5) / 10000, Math.Floor(P1 * 10 + 0.5) / 10000,
                        Math.Floor(Q1 * 10 + 0.5) / 10000, Math.Floor(Pf1 * 10000 + 0.5) / 10000,
                        Math.Floor(Ian1 * 10000 + 0.5) / 10000);
                    result_2.Text = String.Format("视在功率 = {0}KVar\n有功功率 = {1}KW\n无功功率 = {2}KVa\n功率因素 = {3}\n相电流 = {4}A",
                        Math.Floor(S2 * 10 + 0.5) / 10000, Math.Floor(P2 * 10 + 0.5) / 10000,
                        Math.Floor(Q2 * 10 + 0.5) / 10000, Math.Floor(Pf2 * 10000 + 0.5) / 10000,
                        Math.Floor(Ian2 * 10000 + 0.5) / 10000); 
                }
                else if (comboBox_value.Text == "负载箱视在功率")
                {
                    Pf1 = Convert.ToDouble(textBox_Pf.Text);
                    S1 = Convert.ToDouble(textBox_value.Text) * 1000;
                    P1 = S1 * Pf1;
                    Q1 = Math.Sqrt(S1 * S1 - P1 * P1);
                    P2 = P1 * Uan2 * Uan2 / Uan1 / Uan1;
                    Q2 = Q1 * Uan2 * Uan2 * F1 / Uan1 / Uan1 / F2;
                    S2 = Math.Sqrt(P2 * P2 + Q2 * Q2);
                    Pf2 = P2 / S2;
                    if (comboBox_contype.SelectedIndex == 0)
                    {
                        Iab1 = S1 / (Uab1 * Math.Sqrt(3));
                        Ian1 = Iab1 / Math.Sqrt(3);
                        Iab2 = S2 / (Uab2 * Math.Sqrt(3));
                        Ian2 = Iab2 / Math.Sqrt(3);
                    }
                    else
                    {
                        Ian1 = S1 / (Uab1 * Math.Sqrt(3));
                        Ian2 = S2 / (Uab2 * Math.Sqrt(3));
                    }
                    result_1.Text = String.Format("视在功率 = {0}KVar\n有功功率 = {1}KW\n无功功率 = {2}KVa\n功率因素 = {3}\n相电流 = {4}A",
                        Math.Floor(S1 * 10 + 0.5) / 10000, Math.Floor(P1 * 10 + 0.5) / 10000,
                        Math.Floor(Q1 * 10 + 0.5) / 10000, Math.Floor(Pf1 * 10000 + 0.5) / 10000,
                        Math.Floor(Ian1 * 10000 + 0.5) / 10000);
                    result_2.Text = String.Format("视在功率 = {0}KVar\n有功功率 = {1}KW\n无功功率 = {2}KVa\n功率因素 = {3}\n相电流 = {4}A",
                        Math.Floor(S2 * 10 + 0.5) / 10000, Math.Floor(P2 * 10 + 0.5) / 10000,
                        Math.Floor(Q2 * 10 + 0.5) / 10000, Math.Floor(Pf2 * 10000 + 0.5) / 10000,
                        Math.Floor(Ian2 * 10000 + 0.5) / 10000); 
                }
                else if (comboBox_value.Text == "实际有功功率")
                {
                    P2 = Convert.ToDouble(textBox_value.Text) * 1000;
                    P1 = P2 * Uan1 * Uan1 / Uan2 / Uan2;
                    if (comboBox_contype.SelectedIndex == 0)
                    {
                        Iab1 = P1 / (Uab1 * Math.Sqrt(3));
                        Ian1 = Iab1 / Math.Sqrt(3);
                        Iab2 = P2 / (Uab2 * Math.Sqrt(3));
                        Ian2 = Iab2 / Math.Sqrt(3);
                    }
                    else
                    {
                        Ian1 = P1 / (Uab1 * Math.Sqrt(3));
                        Ian2 = P2 / (Uab2 * Math.Sqrt(3));
                    }
                    result_1.Text = String.Format("有功功率 = {0}KW\n相电流 = {1}", Math.Floor(P1 * 10 + 0.5) / 10000,
                        Math.Floor(Ian1 * 10000 + 0.5) / 10000);
                    result_2.Text = String.Format("有功功率 = {0}KW\n相电流 = {1}", Math.Floor(P2 * 10 + 0.5) / 10000,
                        Math.Floor(Ian2 * 10000 + 0.5) / 10000);
                }
                else if (comboBox_value.Text == "实际无功功率")
                {
                    Q2 = Convert.ToDouble(textBox_value.Text) * 1000;
                    Q1 = Q2 * Uan1 * Uan1 * F2 / Uan2 / Uan2 / F1;
                    if (comboBox_contype.SelectedIndex == 0)
                    {
                        Iab1 = Q1 / (Uab1 * Math.Sqrt(3));
                        Ian1 = Iab1 / Math.Sqrt(3);
                        Iab2 = Q2 / (Uab2 * Math.Sqrt(3));
                        Ian2 = Iab2 / Math.Sqrt(3);
                    }
                    else
                    {
                        Ian1 = Q1 / (Uab1 * Math.Sqrt(3));
                        Ian2 = Q2 / (Uab2 * Math.Sqrt(3));
                    }
                    result_1.Text = String.Format("无功功率 = {0}KVar\n相电流 = {1}", Math.Floor(Q1 * 10 + 0.5) / 10000,
                        Math.Floor(Ian1 * 10000 + 0.5) / 10000);
                    result_2.Text = String.Format("无功功率 = {0}KVar\n相电流 = {1}", Math.Floor(Q2 * 10 + 0.5) / 10000,
                        Math.Floor(Ian2 * 10000 + 0.5) / 10000);
                }
                else if (comboBox_value.Text == "实际电流")
                {
                    Ian2 = Convert.ToDouble(textBox_value.Text);
                    Pf2 = Convert.ToDouble(textBox_Pf.Text);
                    if (comboBox_contype.SelectedIndex == 0)
                    {
                        Iab2 = Ian2 * Math.Sqrt(3);
                    }
                    else
                    {
                        Iab2 = Ian2;
                    }
                    S2 = Math.Sqrt(3) * Uab2 * Iab2;
                    P2 = S2 * Pf2;
                    Q2 = Math.Sqrt(S2 * S2 - P2 * P2);
                    P1 = P2 * Uan1 * Uan1 / Uan2 / Uan2;
                    Q1 = Q2 * Uan1 * Uan1 * F2 / Uan2 / Uan2 / F1;
                    S1 = Math.Sqrt(P1 * P1 + Q1 * Q1);
                    Pf1 = P1 / S1;
                    if (comboBox_contype.SelectedIndex == 0)
                    {
                        Iab1 = S1 / (Uab1 * Math.Sqrt(3));
                        Ian1 = Iab1 / Math.Sqrt(3);
                    }
                    else
                    {
                        Ian1 = S1 / (Uab1 * Math.Sqrt(3));      
                    }
                    result_1.Text = String.Format("视在功率 = {0}KVar\n有功功率 = {1}KW\n无功功率 = {2}KVa\n功率因素 = {3}\n相电流 = {4}A",
                        Math.Floor(S1 * 10 + 0.5) / 10000, Math.Floor(P1 * 10 + 0.5) / 10000,
                        Math.Floor(Q1 * 10 + 0.5) / 10000, Math.Floor(Pf1 * 10000 + 0.5) / 10000,
                        Math.Floor(Ian1 * 10000 + 0.5) / 10000);
                    result_2.Text = String.Format("视在功率 = {0}KVar\n有功功率 = {1}KW\n无功功率 = {2}KVa\n功率因素 = {3}\n相电流 = {4}A",
                        Math.Floor(S2 * 10 + 0.5) / 10000, Math.Floor(P2 * 10 + 0.5) / 10000,
                        Math.Floor(Q2 * 10 + 0.5) / 10000, Math.Floor(Pf2 * 10000 + 0.5) / 10000,
                        Math.Floor(Ian2 * 10000 + 0.5) / 10000); 
                }
            }
            else
            {
                MessageBox.Show("输入数据有误！\n输入框不能为空。", "错误");///显示一个消息框
            }

        }

        private void comboBox_value_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).Text)
            {
                case "负载箱有功功率":
                case "实际有功功率":
                    unit_value.Text = "KW";
                    break;
                case "负载箱无功功率":
                case "实际无功功率":
                    unit_value.Text = "KVar";
                    break;
                case "负载箱视在功率":
                    unit_value.Text = "KVa";
                    comboBox_pf.SelectedIndex = 0;
                    break;
                case "实际视在功率":
                    unit_value.Text = "KVa";
                    comboBox_pf.SelectedIndex = 1;
                    break;
                case "实际电流":
                    unit_value.Text = "A";
                    comboBox_pf.SelectedIndex = 1;
                    break;
            }
        }

        private void comboBox_pf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).Text == "负载箱功率因数" && comboBox_value.Text == "实际视在功率")
            {
                comboBox_value.Text = "负载箱视在功率";
            }
            else if (((ComboBox)sender).Text == "实际功率因数" && comboBox_value.Text == "负载箱视在功率")
            {
                comboBox_value.Text = "实际视在功率";
            }
        }
    }
}
