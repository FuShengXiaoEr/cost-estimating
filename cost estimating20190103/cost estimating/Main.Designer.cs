namespace cost_estimating
{
    partial class Main
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new cost_estimating.PanelEnhanced();
            this.btnMinBox = new cost_estimating.controlPlus.buttonPlus();
            this.btnCloseBox = new cost_estimating.controlPlus.buttonPlus();
            this.childForm = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.material_listitems = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numerical_listitems = new System.Windows.Forms.Panel();
            this.label_reactance = new System.Windows.Forms.Label();
            this.label_capacitance = new System.Windows.Forms.Label();
            this.label_resistance = new System.Windows.Forms.Label();
            this.button_numerical_computation = new System.Windows.Forms.Button();
            this.button_material = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.material_listitems.SuspendLayout();
            this.numerical_listitems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::cost_estimating.Properties.Resources.背景6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnMinBox);
            this.panel1.Controls.Add(this.btnCloseBox);
            this.panel1.Controls.Add(this.childForm);
            this.panel1.Controls.Add(this.menuPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 826);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.form_MouseUp);
            // 
            // btnMinBox
            // 
            this.btnMinBox.BackColor = System.Drawing.Color.Transparent;
            this.btnMinBox.DownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMinBox.DownForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinBox.FlatAppearance.BorderSize = 0;
            this.btnMinBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinBox.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMinBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinBox.Location = new System.Drawing.Point(1211, 8);
            this.btnMinBox.MoveBackColor = System.Drawing.Color.Silver;
            this.btnMinBox.MoveForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinBox.Name = "btnMinBox";
            this.btnMinBox.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnMinBox.NormalForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinBox.Size = new System.Drawing.Size(30, 30);
            this.btnMinBox.TabIndex = 6;
            this.btnMinBox.Text = "▬";
            this.btnMinBox.UseVisualStyleBackColor = false;
            this.btnMinBox.Click += new System.EventHandler(this.btnMinBox_Click);
            // 
            // btnCloseBox
            // 
            this.btnCloseBox.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseBox.DownBackColor = System.Drawing.SystemColors.Control;
            this.btnCloseBox.DownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnCloseBox.FlatAppearance.BorderSize = 0;
            this.btnCloseBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseBox.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCloseBox.ForeColor = System.Drawing.Color.Maroon;
            this.btnCloseBox.Location = new System.Drawing.Point(1246, 8);
            this.btnCloseBox.MoveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.btnCloseBox.MoveForeColor = System.Drawing.Color.LightCoral;
            this.btnCloseBox.Name = "btnCloseBox";
            this.btnCloseBox.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnCloseBox.NormalForeColor = System.Drawing.Color.Maroon;
            this.btnCloseBox.Size = new System.Drawing.Size(30, 30);
            this.btnCloseBox.TabIndex = 5;
            this.btnCloseBox.Text = "✘";
            this.btnCloseBox.UseVisualStyleBackColor = false;
            this.btnCloseBox.Click += new System.EventHandler(this.btnCloseBox_Click);
            // 
            // childForm
            // 
            this.childForm.BackColor = System.Drawing.Color.Transparent;
            this.childForm.Location = new System.Drawing.Point(217, 44);
            this.childForm.Name = "childForm";
            this.childForm.Size = new System.Drawing.Size(1071, 783);
            this.childForm.TabIndex = 4;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuPanel.Controls.Add(this.material_listitems);
            this.menuPanel.Controls.Add(this.numerical_listitems);
            this.menuPanel.Controls.Add(this.button_numerical_computation);
            this.menuPanel.Controls.Add(this.button_material);
            this.menuPanel.Controls.Add(this.shapeContainer1);
            this.menuPanel.Location = new System.Drawing.Point(1, 44);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(212, 783);
            this.menuPanel.TabIndex = 3;
            // 
            // material_listitems
            // 
            this.material_listitems.Controls.Add(this.label3);
            this.material_listitems.Controls.Add(this.label8);
            this.material_listitems.Controls.Add(this.label5);
            this.material_listitems.Controls.Add(this.label4);
            this.material_listitems.Controls.Add(this.label2);
            this.material_listitems.Controls.Add(this.label7);
            this.material_listitems.Controls.Add(this.label6);
            this.material_listitems.Controls.Add(this.label1);
            this.material_listitems.Location = new System.Drawing.Point(51, 64);
            this.material_listitems.Name = "material_listitems";
            this.material_listitems.Size = new System.Drawing.Size(141, 242);
            this.material_listitems.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "控制回路器件";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(7, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "其他";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(7, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "负载部分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(7, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "风机部分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "主回路器件";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(7, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "线材";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(7, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "箱体";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "仪表器件";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numerical_listitems
            // 
            this.numerical_listitems.Controls.Add(this.label_reactance);
            this.numerical_listitems.Controls.Add(this.label_capacitance);
            this.numerical_listitems.Controls.Add(this.label_resistance);
            this.numerical_listitems.Location = new System.Drawing.Point(51, 352);
            this.numerical_listitems.Name = "numerical_listitems";
            this.numerical_listitems.Size = new System.Drawing.Size(77, 87);
            this.numerical_listitems.TabIndex = 3;
            // 
            // label_reactance
            // 
            this.label_reactance.AutoSize = true;
            this.label_reactance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_reactance.Location = new System.Drawing.Point(7, 63);
            this.label_reactance.Name = "label_reactance";
            this.label_reactance.Size = new System.Drawing.Size(47, 19);
            this.label_reactance.TabIndex = 1;
            this.label_reactance.Text = "电抗";
            this.label_reactance.Click += new System.EventHandler(this.label_reactance_Click);
            // 
            // label_capacitance
            // 
            this.label_capacitance.AutoSize = true;
            this.label_capacitance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_capacitance.Location = new System.Drawing.Point(7, 36);
            this.label_capacitance.Name = "label_capacitance";
            this.label_capacitance.Size = new System.Drawing.Size(47, 19);
            this.label_capacitance.TabIndex = 1;
            this.label_capacitance.Text = "电容";
            this.label_capacitance.Click += new System.EventHandler(this.label_capacitance_Click);
            // 
            // label_resistance
            // 
            this.label_resistance.AutoSize = true;
            this.label_resistance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_resistance.Location = new System.Drawing.Point(7, 9);
            this.label_resistance.Name = "label_resistance";
            this.label_resistance.Size = new System.Drawing.Size(47, 19);
            this.label_resistance.TabIndex = 1;
            this.label_resistance.Text = "电阻";
            this.label_resistance.Click += new System.EventHandler(this.label_resistance_Click);
            // 
            // button_numerical_computation
            // 
            this.button_numerical_computation.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_numerical_computation.Location = new System.Drawing.Point(24, 307);
            this.button_numerical_computation.Name = "button_numerical_computation";
            this.button_numerical_computation.Size = new System.Drawing.Size(168, 39);
            this.button_numerical_computation.TabIndex = 0;
            this.button_numerical_computation.TabStop = false;
            this.button_numerical_computation.Text = "数值计算";
            this.button_numerical_computation.UseVisualStyleBackColor = true;
            this.button_numerical_computation.Click += new System.EventHandler(this.button_numerical_computation_Click);
            // 
            // button_material
            // 
            this.button_material.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_material.Location = new System.Drawing.Point(24, 21);
            this.button_material.Name = "button_material";
            this.button_material.Size = new System.Drawing.Size(168, 39);
            this.button_material.TabIndex = 0;
            this.button_material.TabStop = false;
            this.button_material.Text = "物料选择";
            this.button_material.UseVisualStyleBackColor = true;
            this.button_material.Click += new System.EventHandler(this.button_material_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(208, 779);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 214;
            this.lineShape1.X2 = 215;
            this.lineShape1.Y1 = 3;
            this.lineShape1.Y2 = 713;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 826);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.material_listitems.ResumeLayout(false);
            this.material_listitems.PerformLayout();
            this.numerical_listitems.ResumeLayout(false);
            this.numerical_listitems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel childForm;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel material_listitems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel numerical_listitems;
        private System.Windows.Forms.Label label_reactance;
        private System.Windows.Forms.Label label_capacitance;
        private System.Windows.Forms.Label label_resistance;
        public System.Windows.Forms.Button button_numerical_computation;
        public System.Windows.Forms.Button button_material;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private PanelEnhanced panel1;
        private controlPlus.buttonPlus btnMinBox;
        private controlPlus.buttonPlus btnCloseBox;



    }
}

