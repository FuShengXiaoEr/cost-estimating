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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMinBox = new cost_estimating.controlPlus.buttonPlus();
            this.btnCloseBox = new cost_estimating.controlPlus.buttonPlus();
            this.childForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.material_listitems = new System.Windows.Forms.Panel();
            this.button1 = new cost_estimating.controlPlus.buttonPlus();
            this.label1 = new cost_estimating.controlPlus.buttonPlus();
            this.numerical_listitems = new System.Windows.Forms.Panel();
            this.btnReactance = new cost_estimating.controlPlus.buttonPlus();
            this.btnResistance = new cost_estimating.controlPlus.buttonPlus();
            this.btnCapacitance = new cost_estimating.controlPlus.buttonPlus();
            this.button_numerical_computation = new System.Windows.Forms.Button();
            this.button_material = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.childForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.material_listitems.SuspendLayout();
            this.numerical_listitems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::cost_estimating.Properties.Resources.背景6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnMinBox);
            this.panel1.Controls.Add(this.btnCloseBox);
            this.panel1.Controls.Add(this.childForm);
            this.panel1.Controls.Add(this.menuPanel);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 726);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.form_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::cost_estimating.Properties.Resources.pictureBox3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 45);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(581, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "负载计算系统";
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
            this.btnMinBox.Location = new System.Drawing.Point(1111, 8);
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
            this.btnCloseBox.Location = new System.Drawing.Point(1146, 8);
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
            this.childForm.Controls.Add(this.pictureBox2);
            this.childForm.Location = new System.Drawing.Point(215, 44);
            this.childForm.Name = "childForm";
            this.childForm.Size = new System.Drawing.Size(973, 683);
            this.childForm.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::cost_estimating.Properties.Resources.pictureBox3;
            this.pictureBox2.Location = new System.Drawing.Point(735, 605);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 65);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuPanel.Controls.Add(this.material_listitems);
            this.menuPanel.Controls.Add(this.numerical_listitems);
            this.menuPanel.Controls.Add(this.button_numerical_computation);
            this.menuPanel.Controls.Add(this.button_material);
            this.menuPanel.Location = new System.Drawing.Point(1, 44);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(212, 783);
            this.menuPanel.TabIndex = 3;
            // 
            // material_listitems
            // 
            this.material_listitems.AutoSize = true;
            this.material_listitems.Controls.Add(this.button1);
            this.material_listitems.Controls.Add(this.label1);
            this.material_listitems.Location = new System.Drawing.Point(22, 39);
            this.material_listitems.Name = "material_listitems";
            this.material_listitems.Size = new System.Drawing.Size(187, 62);
            this.material_listitems.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.DownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.button1.DownForeColor = System.Drawing.SystemColors.GrayText;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1, 30);
            this.button1.MoveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.button1.MoveForeColor = System.Drawing.SystemColors.GrayText;
            this.button1.Name = "button1";
            this.button1.NormalBackColor = System.Drawing.Color.Transparent;
            this.button1.NormalForeColor = System.Drawing.Color.Black;
            this.button1.Size = new System.Drawing.Size(183, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "清单";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.DownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.label1.DownForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.label1.FlatAppearance.BorderSize = 0;
            this.label1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.label1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.MoveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.label1.MoveForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Name = "label1";
            this.label1.NormalBackColor = System.Drawing.Color.Transparent;
            this.label1.NormalForeColor = System.Drawing.Color.Black;
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "仪表选择";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseVisualStyleBackColor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numerical_listitems
            // 
            this.numerical_listitems.AutoSize = true;
            this.numerical_listitems.Controls.Add(this.btnReactance);
            this.numerical_listitems.Controls.Add(this.btnResistance);
            this.numerical_listitems.Controls.Add(this.btnCapacitance);
            this.numerical_listitems.Location = new System.Drawing.Point(22, 140);
            this.numerical_listitems.Name = "numerical_listitems";
            this.numerical_listitems.Size = new System.Drawing.Size(187, 91);
            this.numerical_listitems.TabIndex = 3;
            // 
            // btnReactance
            // 
            this.btnReactance.DownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.btnReactance.DownForeColor = System.Drawing.SystemColors.GrayText;
            this.btnReactance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnReactance.FlatAppearance.BorderSize = 0;
            this.btnReactance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.btnReactance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.btnReactance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReactance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReactance.ForeColor = System.Drawing.Color.Black;
            this.btnReactance.Location = new System.Drawing.Point(1, 59);
            this.btnReactance.MoveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.btnReactance.MoveForeColor = System.Drawing.SystemColors.GrayText;
            this.btnReactance.Name = "btnReactance";
            this.btnReactance.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnReactance.NormalForeColor = System.Drawing.Color.Black;
            this.btnReactance.Size = new System.Drawing.Size(183, 29);
            this.btnReactance.TabIndex = 3;
            this.btnReactance.Text = "电抗";
            this.btnReactance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReactance.UseVisualStyleBackColor = true;
            this.btnReactance.Click += new System.EventHandler(this.btnReactance_Click);
            // 
            // btnResistance
            // 
            this.btnResistance.DownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.btnResistance.DownForeColor = System.Drawing.SystemColors.GrayText;
            this.btnResistance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnResistance.FlatAppearance.BorderSize = 0;
            this.btnResistance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.btnResistance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.btnResistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResistance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnResistance.ForeColor = System.Drawing.Color.Black;
            this.btnResistance.Location = new System.Drawing.Point(1, 1);
            this.btnResistance.MoveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.btnResistance.MoveForeColor = System.Drawing.SystemColors.GrayText;
            this.btnResistance.Name = "btnResistance";
            this.btnResistance.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnResistance.NormalForeColor = System.Drawing.Color.Black;
            this.btnResistance.Size = new System.Drawing.Size(183, 29);
            this.btnResistance.TabIndex = 3;
            this.btnResistance.Text = "电阻";
            this.btnResistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResistance.UseVisualStyleBackColor = true;
            this.btnResistance.Click += new System.EventHandler(this.btnResistance_Click);
            // 
            // btnCapacitance
            // 
            this.btnCapacitance.DownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.btnCapacitance.DownForeColor = System.Drawing.SystemColors.GrayText;
            this.btnCapacitance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnCapacitance.FlatAppearance.BorderSize = 0;
            this.btnCapacitance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.btnCapacitance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.btnCapacitance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapacitance.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCapacitance.ForeColor = System.Drawing.Color.Black;
            this.btnCapacitance.Location = new System.Drawing.Point(1, 30);
            this.btnCapacitance.MoveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.btnCapacitance.MoveForeColor = System.Drawing.SystemColors.GrayText;
            this.btnCapacitance.Name = "btnCapacitance";
            this.btnCapacitance.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnCapacitance.NormalForeColor = System.Drawing.Color.Black;
            this.btnCapacitance.Size = new System.Drawing.Size(183, 29);
            this.btnCapacitance.TabIndex = 3;
            this.btnCapacitance.Text = "电容";
            this.btnCapacitance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapacitance.UseVisualStyleBackColor = true;
            this.btnCapacitance.Click += new System.EventHandler(this.btnCapacitance_Click);
            // 
            // button_numerical_computation
            // 
            this.button_numerical_computation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.button_numerical_computation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.button_numerical_computation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.button_numerical_computation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_numerical_computation.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_numerical_computation.Location = new System.Drawing.Point(-1, 101);
            this.button_numerical_computation.Name = "button_numerical_computation";
            this.button_numerical_computation.Size = new System.Drawing.Size(210, 39);
            this.button_numerical_computation.TabIndex = 0;
            this.button_numerical_computation.TabStop = false;
            this.button_numerical_computation.Text = "›数值计算";
            this.button_numerical_computation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_numerical_computation.UseVisualStyleBackColor = true;
            this.button_numerical_computation.Click += new System.EventHandler(this.button_numerical_computation_Click);
            // 
            // button_material
            // 
            this.button_material.BackColor = System.Drawing.Color.Transparent;
            this.button_material.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.button_material.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.button_material.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(236)))));
            this.button_material.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_material.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_material.Location = new System.Drawing.Point(-1, 0);
            this.button_material.Name = "button_material";
            this.button_material.Size = new System.Drawing.Size(210, 39);
            this.button_material.TabIndex = 0;
            this.button_material.TabStop = false;
            this.button_material.Text = "›物料选择";
            this.button_material.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_material.UseVisualStyleBackColor = false;
            this.button_material.Click += new System.EventHandler(this.button_material_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1188, 726);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.lineShape1.X1 = 215;
            this.lineShape1.X2 = 1286;
            this.lineShape1.Y1 = 43;
            this.lineShape1.Y2 = 43;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 726);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.childForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.material_listitems.ResumeLayout(false);
            this.numerical_listitems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel childForm;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel material_listitems;
        private System.Windows.Forms.Panel numerical_listitems;
        public System.Windows.Forms.Button button_numerical_computation;
        public System.Windows.Forms.Button button_material;
        private PanelEnhanced panel1;
        private controlPlus.buttonPlus btnMinBox;
        private controlPlus.buttonPlus btnCloseBox;
        private System.Windows.Forms.Label label9;
        private controlPlus.buttonPlus btnReactance;
        private controlPlus.buttonPlus btnResistance;
        private controlPlus.buttonPlus btnCapacitance;
        private controlPlus.buttonPlus label1;
        private controlPlus.buttonPlus button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;



    }
}

