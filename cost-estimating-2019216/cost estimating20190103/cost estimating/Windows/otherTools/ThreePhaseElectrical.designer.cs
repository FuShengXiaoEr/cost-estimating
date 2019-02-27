namespace cost_estimating
{
    partial class ThreePhaseElectrical
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_u = new System.Windows.Forms.ComboBox();
            this.comboBox_power = new System.Windows.Forms.ComboBox();
            this.textBox_u = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.power_unit = new System.Windows.Forms.Label();
            this.textBox_power = new System.Windows.Forms.TextBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_pf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.result_1 = new System.Windows.Forms.Label();
            this.result_2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SuspendLayout();
            // 
            // comboBox_u
            // 
            this.comboBox_u.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_u.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_u.FormattingEnabled = true;
            this.comboBox_u.Items.AddRange(new object[] {
            "相电压",
            "线电压"});
            this.comboBox_u.Location = new System.Drawing.Point(107, 131);
            this.comboBox_u.Name = "comboBox_u";
            this.comboBox_u.Size = new System.Drawing.Size(88, 35);
            this.comboBox_u.TabIndex = 0;
            // 
            // comboBox_power
            // 
            this.comboBox_power.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_power.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_power.FormattingEnabled = true;
            this.comboBox_power.Items.AddRange(new object[] {
            "相电压",
            "线电压"});
            this.comboBox_power.Location = new System.Drawing.Point(510, 131);
            this.comboBox_power.Name = "comboBox_power";
            this.comboBox_power.Size = new System.Drawing.Size(109, 35);
            this.comboBox_power.TabIndex = 0;
            this.comboBox_power.SelectedIndexChanged += new System.EventHandler(this.comboBox_power_SelectedIndexChanged);
            // 
            // textBox_u
            // 
            this.textBox_u.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_u.Location = new System.Drawing.Point(195, 131);
            this.textBox_u.Name = "textBox_u";
            this.textBox_u.Size = new System.Drawing.Size(108, 34);
            this.textBox_u.TabIndex = 1;
            this.textBox_u.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_u.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_u_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(303, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "V";
            // 
            // power_unit
            // 
            this.power_unit.AutoSize = true;
            this.power_unit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.power_unit.Location = new System.Drawing.Point(724, 135);
            this.power_unit.Name = "power_unit";
            this.power_unit.Size = new System.Drawing.Size(32, 27);
            this.power_unit.TabIndex = 3;
            this.power_unit.Text = "W";
            // 
            // textBox_power
            // 
            this.textBox_power.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_power.Location = new System.Drawing.Point(619, 131);
            this.textBox_power.Name = "textBox_power";
            this.textBox_power.Size = new System.Drawing.Size(105, 34);
            this.textBox_power.TabIndex = 4;
            this.textBox_power.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_u_KeyPress);
            // 
            // comboBox_type
            // 
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "相电压",
            "线电压"});
            this.comboBox_type.Location = new System.Drawing.Point(203, 209);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(60, 29);
            this.comboBox_type.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(103, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "连接方式";
            // 
            // textbox_pf
            // 
            this.textbox_pf.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textbox_pf.Location = new System.Drawing.Point(604, 208);
            this.textbox_pf.Name = "textbox_pf";
            this.textbox_pf.Size = new System.Drawing.Size(81, 34);
            this.textbox_pf.TabIndex = 1;
            this.textbox_pf.Text = "1";
            this.textbox_pf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_pf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_u_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(506, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "功率因素";
            // 
            // result_1
            // 
            this.result_1.AutoSize = true;
            this.result_1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result_1.Location = new System.Drawing.Point(102, 364);
            this.result_1.Name = "result_1";
            this.result_1.Size = new System.Drawing.Size(0, 31);
            this.result_1.TabIndex = 6;
            // 
            // result_2
            // 
            this.result_2.AutoSize = true;
            this.result_2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result_2.Location = new System.Drawing.Point(520, 364);
            this.result_2.Name = "result_2";
            this.result_2.Size = new System.Drawing.Size(0, 31);
            this.result_2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(842, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 76);
            this.button1.TabIndex = 8;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(427, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "三相电参数计算";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1100, 680);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.FillColor = System.Drawing.Color.FloralWhite;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.FloralWhite;
            this.rectangleShape1.Location = new System.Drawing.Point(45, 314);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(983, 265);
            // 
            // ThreePhaseElectrical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result_2);
            this.Controls.Add(this.result_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_power);
            this.Controls.Add(this.power_unit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_pf);
            this.Controls.Add(this.textBox_u);
            this.Controls.Add(this.comboBox_power);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.comboBox_u);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ThreePhaseElectrical";
            this.Size = new System.Drawing.Size(1100, 680);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_u;
        private System.Windows.Forms.ComboBox comboBox_power;
        private System.Windows.Forms.TextBox textBox_u;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label power_unit;
        private System.Windows.Forms.TextBox textBox_power;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_pf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label result_1;
        private System.Windows.Forms.Label result_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}
