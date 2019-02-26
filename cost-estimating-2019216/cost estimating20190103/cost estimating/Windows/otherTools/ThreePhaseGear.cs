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
    public partial class ThreePhaseGear : UserControl
    {
        string[] u_array = { "线电压", "相电压" };
        string[] power_array = { "档位功率", "档位电流" };
        string[] type_array = { "△", "Y" };
        string[] type2_array = { "R", "L", "C" };
        string[] type3_array = { "三相", "单相" };

        public ThreePhaseGear()
        {
            InitializeComponent();

            comboBox_u.DataSource = u_array;
            comboBox_u.SelectedItem = 0;

            comboBox_gear.DataSource = power_array;
            comboBox_gear.SelectedIndex = 0;

            comboBox_contype.DataSource = type_array;
            comboBox_contype.SelectedIndex = 0;

            comboBox_type.DataSource = type2_array;
            comboBox_type.SelectedIndex = 0;

            comboBox1.DataSource = type3_array;
            comboBox1.SelectedIndex = 0;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
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
                    gear_unitChange();
                    break;
                case 1:
                    gear_unit.Text = "A";
                    break;
            }
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_gear.SelectedIndex == 0)
            {
                gear_unitChange();
            }
        }

        private void gear_unitChange()
        {
                switch (comboBox_type.SelectedIndex)
                {
                    case 0:
                        gear_unit.Text = "W";
                        break;
                    case 1:
                    case 2:
                        gear_unit.Text = "Var";
                        break;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textbox_f.Text != "" && textBox_gear.Text != "" && textBox_percent.Text != "" && textBox_u.Text != "")
            {
                double Uab, Uan, Ian, Power, percent, I, R, Rup, Rdown, Rl, L, Lup, Ldown, Rc, C, Cup, Cdown, F, power;
                percent = Convert.ToDouble(textBox_percent.Text);
                F = Convert.ToDouble(textbox_f.Text);
                if (comboBox_contype.SelectedIndex == 0)
                {
                    Uan = Uab = Convert.ToDouble(textBox_u.Text);
                }
                else
                {
                    if (comboBox_u.SelectedIndex == 0)
                    {
                        Uab = Convert.ToDouble(textBox_u.Text);
                        Uan = Uab / Math.Sqrt(3);
                    }
                    else
                    {
                        Uan = Convert.ToDouble(textBox_u.Text);
                        Uab = Uan * Math.Sqrt(3);
                    }
                }
                if (comboBox_gear.SelectedIndex == 0)
                {
                    Power = Convert.ToDouble(textBox_gear.Text);
                    if (comboBox1.SelectedIndex == 0)
                    {
                        Ian = Power / 3 / Uan;
                        power = Power / 3;
                    }
                    else
                    {
                        Ian = Power / Uan;
                        power = Power;
                    }
                }
                else
                {
                    I = Convert.ToDouble(textBox_gear.Text);
                    if (comboBox1.SelectedIndex == 0)
                    {
                        Ian = I / 3;
                        Power = 3 * Ian * Uan;
                        power = Power / 3;
                    }
                    else
                    {
                        Ian = I;
                        Power = Ian * Uan;
                        power = Power;
                    }                  
                }
                Ian = Math.Floor(Ian * 100 + 0.5) / 100;
                result_1.Text = String.Format("档位功率 = {0}W\n单相电压 = {1}V\n单相电流 = {2}A", Math.Floor(Power * 100 + 0.5) / 100,
                        Math.Floor(Uan * 100 + 0.5) / 100, Ian);
                if (comboBox_type.SelectedIndex == 0)
                {                    
                    R = Uan * Uan / power;
                    Rup = R * (1 + percent / 100);
                    Rdown = R * (1 - percent / 100);
                    R = Math.Floor(R * 10000 + 0.5) / 10000;
                    Rup = Math.Floor(Rup * 10000 + 0.5) / 10000;
                    Rdown = Math.Floor(Rdown * 10000 + 0.5) / 10000;
                    result_2.Text = String.Format("单相阻值 = {0}Ω\n上限阻值 = {1}Ω\n下限阻值 = {2}Ω", R, Rup, Rdown);
                }
                else if (comboBox_type.SelectedIndex == 1)
                {
                    Rl = Uan * Uan / power;
                    L = Rl / (Math.PI * 2 * F) * 1000;
                    Lup = L * (1 + percent / 100);
                    Ldown = L * (1 - percent / 100);
                    L = Math.Floor(L * 10000 + 0.5) / 10000;
                    Lup = Math.Floor(Lup * 10000 + 0.5) / 10000;
                    Ldown = Math.Floor(Ldown * 10000 + 0.5) / 10000;
                    result_2.Text = String.Format("单相感值 = {0}mL\n上限感值 = {1}mL\n下限感值 = {2}mL", L, Lup, Ldown);
                }
                else
                {
                    Rc = Uan * Uan / power;
                    C = 1 / (2 * Math.PI * F * Rc) * 1000000;
                    Cup = C * (1 + percent / 100);
                    Cdown = C * (1 - percent / 100);
                    C = Math.Floor(C * 10000 + 0.5) / 10000;
                    Cup = Math.Floor(Cup * 10000 + 0.5) / 10000;
                    Cdown = Math.Floor(Cdown * 10000 + 0.5) / 10000;
                    result_2.Text = String.Format("单相容值 = {0}uF\n上限容值 = {1}uF\n下限容值 = {2}uF", C, Cup, Cdown);
                }
            }            else
            {
                MessageBox.Show("输入数据有误！\n输入框不能为空。", "错误");///显示一个消息框
            }
        }

        private void comboBox_u_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == 1)
            {
                comboBox_u.SelectedIndex = 1;
            }
        }
    }
}
