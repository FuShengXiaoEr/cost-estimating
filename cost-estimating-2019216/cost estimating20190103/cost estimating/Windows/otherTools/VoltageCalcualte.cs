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
    public partial class VoltageCalcualte : UserControl
    {
        public VoltageCalcualte()
        {
            InitializeComponent();
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
            if (textBox_Up.Text != "" && textBox_Ra.Text != "" && textBox_Rb.Text != "" && textBox_Rc.Text != "")
            {
                double up, sqrta, sqrtb, sqrtc;
                Complex ua, ub, uc, ra, rb, rc, un, ua1, ub1, uc1;
                Complex comB = new Complex(-0.5, -Math.Sqrt(3)/2);
                Complex comC = new Complex(-0.5, Math.Sqrt(3) / 2);
                
                up = Convert.ToDouble(textBox_Up.Text);
                ua = new Complex(up, 0);
                ub = up * comB;
                uc = up * comC;

                ra = new Complex(double.Parse(textBox_Ra.Text), 0);
                rb = new Complex(double.Parse(textBox_Rb.Text), 0);
                rc = new Complex(double.Parse(textBox_Rc.Text), 0);

                un = (ua * rb * rc + ub * ra * rc + uc * ra * rb) / (rc * rb + ra * rc + ra * rb);

                ua1 = ua - un;
                ub1 = ub - un;
                uc1 = uc - un;

                sqrta = Math.Round(Math.Sqrt(ua1.Image * ua1.Image + ua1.Real * ua1.Real), 3, MidpointRounding.AwayFromZero);
                sqrtb = Math.Round(Math.Sqrt(ub1.Image * ub1.Image + ub1.Real * ub1.Real), 3, MidpointRounding.AwayFromZero);
                sqrtc = Math.Round(Math.Sqrt(uc1.Image * uc1.Image + uc1.Real * uc1.Real), 3, MidpointRounding.AwayFromZero);

                result_1.Text = String.Format("A相电压 = {0}KV\nB相电压 = {1}KV\nC相电压 = {2}KV\n中性点电压 = {3}KV", sqrta.ToString(), 
                    sqrtb.ToString(), sqrtc.ToString(), un.ToString());

            }
            else
            {
                MessageBox.Show("输入数据有误！\n输入框不能为空。", "错误");///显示一个消息框
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_Sa.Text != "" && textBox_Sb.Text != "" && textBox_Sc.Text != "" && textBox_percent.Text != "")
            {
                double contentA, contentB, contentC, max, min, result, percent;
                contentA = Convert.ToDouble(textBox_Sa.Text);
                contentB = Convert.ToDouble(textBox_Sb.Text);
                contentC = Convert.ToDouble(textBox_Sc.Text);
                percent = Convert.ToDouble(textBox_percent.Text);

                max = contentA > contentB ? contentA : contentB;
                max = max > contentC ? max : contentC;

                min = contentA > contentB ? contentB : contentA;
                min = min > contentC ? contentC : min;

                result = Math.Round((max - min) / max, 3, MidpointRounding.AwayFromZero)*100;

                if (result <= percent)
                {
                    result_2.Text = "三相可以同时投入！";
                    this.result_2.ForeColor = System.Drawing.Color.Green;
;
                }
                else
                {
                    result_2.Text = "三相无法同时投入！";
                    this.result_2.ForeColor = System.Drawing.Color.Maroon;
                }
            }
            else
            {
                MessageBox.Show("输入数据有误！\n输入框不能为空。", "错误");///显示一个消息框
            }
        }
    }
}
