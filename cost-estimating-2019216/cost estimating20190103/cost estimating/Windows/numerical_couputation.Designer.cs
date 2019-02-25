namespace cost_estimating
{
    partial class numerical_gpbwindows
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_preview = new System.Windows.Forms.DataGridView();
            this.preview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cBoxSeriesType = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label_resistance_num = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.labelPower = new System.Windows.Forms.Button();
            this.textBox_singlePhaseNumber = new System.Windows.Forms.TextBox();
            this.textBox_series = new System.Windows.Forms.TextBox();
            this.cBox_U = new System.Windows.Forms.ComboBox();
            this.textBox_phase_voltage = new System.Windows.Forms.TextBox();
            this.cBox_electricityType = new System.Windows.Forms.ComboBox();
            this.textBox_wire = new System.Windows.Forms.TextBox();
            this.textBox_three_phase_power = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.square = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.textBox_cocontactor = new System.Windows.Forms.TextBox();
            this.btnToExcel = new cost_estimating.controlPlus.buttonPlus();
            this.dataGridView_Resistance = new cost_estimating.DataGridViewWithCheck();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_preview)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resistance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnToExcel);
            this.panel1.Controls.Add(this.dataGridView_Resistance);
            this.panel1.Controls.Add(this.dataGridView_preview);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 680);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_preview
            // 
            this.dataGridView_preview.AllowUserToAddRows = false;
            this.dataGridView_preview.AllowUserToDeleteRows = false;
            this.dataGridView_preview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_preview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_preview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_preview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_preview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_preview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_preview.ColumnHeadersVisible = false;
            this.dataGridView_preview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preview});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_preview.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_preview.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_preview.Location = new System.Drawing.Point(10, 141);
            this.dataGridView_preview.Name = "dataGridView_preview";
            this.dataGridView_preview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_preview.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_preview.RowTemplate.Height = 23;
            this.dataGridView_preview.Size = new System.Drawing.Size(1087, 31);
            this.dataGridView_preview.TabIndex = 15;
            // 
            // preview
            // 
            this.preview.HeaderText = "预览";
            this.preview.Name = "preview";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cBoxSeriesType);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label_resistance_num);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.labelPower);
            this.panel2.Controls.Add(this.textBox_singlePhaseNumber);
            this.panel2.Controls.Add(this.textBox_series);
            this.panel2.Controls.Add(this.cBox_U);
            this.panel2.Controls.Add(this.textBox_cocontactor);
            this.panel2.Controls.Add(this.textBox_phase_voltage);
            this.panel2.Controls.Add(this.cBox_electricityType);
            this.panel2.Controls.Add(this.textBox_wire);
            this.panel2.Controls.Add(this.textBox_three_phase_power);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.square);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(147, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 103);
            this.panel2.TabIndex = 10;
            // 
            // cBoxSeriesType
            // 
            this.cBoxSeriesType.BackColor = System.Drawing.Color.Silver;
            this.cBoxSeriesType.DropDownHeight = 100;
            this.cBoxSeriesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSeriesType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBoxSeriesType.FormattingEnabled = true;
            this.cBoxSeriesType.IntegralHeight = false;
            this.cBoxSeriesType.Items.AddRange(new object[] {
            "串联数量",
            "并联数量"});
            this.cBoxSeriesType.Location = new System.Drawing.Point(718, 62);
            this.cBoxSeriesType.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cBoxSeriesType.Name = "cBoxSeriesType";
            this.cBoxSeriesType.Size = new System.Drawing.Size(136, 29);
            this.cBoxSeriesType.TabIndex = 15;
            this.cBoxSeriesType.SelectedIndexChanged += new System.EventHandler(this.cBoxSeriesType_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(294, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 32);
            this.button3.TabIndex = 16;
            this.button3.Text = "接触器";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label_resistance_num
            // 
            this.label_resistance_num.BackColor = System.Drawing.Color.Silver;
            this.label_resistance_num.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_resistance_num.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_resistance_num.Location = new System.Drawing.Point(718, 10);
            this.label_resistance_num.Name = "label_resistance_num";
            this.label_resistance_num.Size = new System.Drawing.Size(136, 33);
            this.label_resistance_num.TabIndex = 16;
            this.label_resistance_num.Text = "单相电阻管数量";
            this.label_resistance_num.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(504, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 32);
            this.button4.TabIndex = 16;
            this.button4.Text = "导线";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // labelPower
            // 
            this.labelPower.BackColor = System.Drawing.Color.Silver;
            this.labelPower.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelPower.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPower.Location = new System.Drawing.Point(504, 12);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(89, 32);
            this.labelPower.TabIndex = 16;
            this.labelPower.Text = "三相功率";
            this.labelPower.UseVisualStyleBackColor = false;
            // 
            // textBox_singlePhaseNumber
            // 
            this.textBox_singlePhaseNumber.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_singlePhaseNumber.Location = new System.Drawing.Point(854, 13);
            this.textBox_singlePhaseNumber.Name = "textBox_singlePhaseNumber";
            this.textBox_singlePhaseNumber.Size = new System.Drawing.Size(80, 29);
            this.textBox_singlePhaseNumber.TabIndex = 18;
            this.textBox_singlePhaseNumber.Text = "1";
            this.textBox_singlePhaseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_singlePhaseNumber.TextChanged += new System.EventHandler(this.textBox_singlePhaseNumber_TextChanged);
            this.textBox_singlePhaseNumber.Leave += new System.EventHandler(this.textBox_singlePhaseNumber_Leave);
            // 
            // textBox_series
            // 
            this.textBox_series.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_series.Location = new System.Drawing.Point(854, 62);
            this.textBox_series.Name = "textBox_series";
            this.textBox_series.Size = new System.Drawing.Size(77, 29);
            this.textBox_series.TabIndex = 17;
            this.textBox_series.Text = "1";
            this.textBox_series.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_series.TextChanged += new System.EventHandler(this.textBox_series_TextChanged);
            this.textBox_series.Leave += new System.EventHandler(this.textBox_series_Leave);
            // 
            // cBox_U
            // 
            this.cBox_U.BackColor = System.Drawing.Color.Silver;
            this.cBox_U.DropDownHeight = 100;
            this.cBox_U.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_U.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBox_U.FormattingEnabled = true;
            this.cBox_U.IntegralHeight = false;
            this.cBox_U.Location = new System.Drawing.Point(294, 13);
            this.cBox_U.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cBox_U.Name = "cBox_U";
            this.cBox_U.Size = new System.Drawing.Size(92, 29);
            this.cBox_U.TabIndex = 15;
            this.cBox_U.SelectedIndexChanged += new System.EventHandler(this.cBox_U_SelectedIndexChanged);
            // 
            // textBox_phase_voltage
            // 
            this.textBox_phase_voltage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_phase_voltage.Location = new System.Drawing.Point(386, 13);
            this.textBox_phase_voltage.Name = "textBox_phase_voltage";
            this.textBox_phase_voltage.Size = new System.Drawing.Size(74, 29);
            this.textBox_phase_voltage.TabIndex = 15;
            this.textBox_phase_voltage.Text = "0";
            this.textBox_phase_voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_phase_voltage.TextChanged += new System.EventHandler(this.textBox_phase_voltage_TextChanged);
            this.textBox_phase_voltage.Leave += new System.EventHandler(this.textBox_phase_voltage_Leave);
            // 
            // cBox_electricityType
            // 
            this.cBox_electricityType.BackColor = System.Drawing.Color.Silver;
            this.cBox_electricityType.DropDownHeight = 100;
            this.cBox_electricityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_electricityType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBox_electricityType.FormattingEnabled = true;
            this.cBox_electricityType.IntegralHeight = false;
            this.cBox_electricityType.Location = new System.Drawing.Point(85, 13);
            this.cBox_electricityType.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cBox_electricityType.Name = "cBox_electricityType";
            this.cBox_electricityType.Size = new System.Drawing.Size(188, 29);
            this.cBox_electricityType.TabIndex = 15;
            this.cBox_electricityType.SelectedIndexChanged += new System.EventHandler(this.cBox_electricityType_SelectedIndexChanged);
            // 
            // textBox_wire
            // 
            this.textBox_wire.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_wire.Location = new System.Drawing.Point(593, 62);
            this.textBox_wire.Name = "textBox_wire";
            this.textBox_wire.Size = new System.Drawing.Size(70, 29);
            this.textBox_wire.TabIndex = 5;
            this.textBox_wire.Text = "1.5";
            this.textBox_wire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_wire.TextChanged += new System.EventHandler(this.textBox_wire_TextChanged);
            this.textBox_wire.Leave += new System.EventHandler(this.textBox_wire_Leave);
            // 
            // textBox_three_phase_power
            // 
            this.textBox_three_phase_power.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_three_phase_power.Location = new System.Drawing.Point(593, 13);
            this.textBox_three_phase_power.Name = "textBox_three_phase_power";
            this.textBox_three_phase_power.Size = new System.Drawing.Size(70, 29);
            this.textBox_three_phase_power.TabIndex = 5;
            this.textBox_three_phase_power.Text = "0";
            this.textBox_three_phase_power.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_three_phase_power.TextChanged += new System.EventHandler(this.textBox_three_phase_power_TextChanged);
            this.textBox_three_phase_power.Leave += new System.EventHandler(this.textBox_three_phase_power_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 7, 5, 6);
            this.label1.Size = new System.Drawing.Size(75, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "交/直流";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // square
            // 
            this.square.AutoSize = true;
            this.square.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.square.Location = new System.Drawing.Point(667, 66);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(46, 21);
            this.square.TabIndex = 6;
            this.square.Text = "mm²";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(663, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "W";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(466, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "V";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_delete.ForeColor = System.Drawing.Color.MediumOrchid;
            this.button_delete.Image = global::cost_estimating.Properties.Resources.pink_remove26;
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_delete.Location = new System.Drawing.Point(44, 85);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(82, 31);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "删除";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Transparent;
            this.button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.button_add.FlatAppearance.BorderSize = 2;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_add.ForeColor = System.Drawing.Color.MediumOrchid;
            this.button_add.Image = global::cost_estimating.Properties.Resources.round_add26x26;
            this.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_add.Location = new System.Drawing.Point(44, 36);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(82, 31);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "添加";
            this.button_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(1100, 680);
            this.shapeContainer2.TabIndex = 11;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 10;
            this.lineShape1.X2 = 1090;
            this.lineShape1.Y1 = 130;
            this.lineShape1.Y2 = 130;
            // 
            // textBox_cocontactor
            // 
            this.textBox_cocontactor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_cocontactor.Location = new System.Drawing.Point(386, 62);
            this.textBox_cocontactor.Name = "textBox_cocontactor";
            this.textBox_cocontactor.Size = new System.Drawing.Size(101, 29);
            this.textBox_cocontactor.TabIndex = 15;
            this.textBox_cocontactor.Text = "0";
            this.textBox_cocontactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_cocontactor.Leave += new System.EventHandler(this.textBox_phase_voltage_Leave);
            // 
            // btnToExcel
            // 
            this.btnToExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnToExcel.BackgroundImage = global::cost_estimating.Properties.Resources.btnNormal;
            this.btnToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToExcel.DownBackColor = System.Drawing.Color.Transparent;
            this.btnToExcel.DownForeColor = System.Drawing.Color.Black;
            this.btnToExcel.FlatAppearance.BorderSize = 0;
            this.btnToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToExcel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnToExcel.ForeColor = System.Drawing.Color.Black;
            this.btnToExcel.Image = global::cost_estimating.Properties.Resources.report1;
            this.btnToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToExcel.Location = new System.Drawing.Point(880, 636);
            this.btnToExcel.MoveBackColor = System.Drawing.Color.Transparent;
            this.btnToExcel.MoveForeColor = System.Drawing.SystemColors.GrayText;
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.NormalBackColor = System.Drawing.Color.Transparent;
            this.btnToExcel.NormalForeColor = System.Drawing.Color.Black;
            this.btnToExcel.Size = new System.Drawing.Size(131, 30);
            this.btnToExcel.TabIndex = 14;
            this.btnToExcel.Text = "导出excel文件";
            this.btnToExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // dataGridView_Resistance
            // 
            this.dataGridView_Resistance.AllowUserToAddRows = false;
            this.dataGridView_Resistance.AllowUserToDeleteRows = false;
            this.dataGridView_Resistance.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Resistance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Resistance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Resistance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Resistance.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Resistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Resistance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Resistance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Resistance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Resistance.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_Resistance.Location = new System.Drawing.Point(10, 180);
            this.dataGridView_Resistance.Name = "dataGridView_Resistance";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Resistance.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Resistance.RowTemplate.Height = 23;
            this.dataGridView_Resistance.Size = new System.Drawing.Size(1087, 450);
            this.dataGridView_Resistance.TabIndex = 12;
            // 
            // numerical_gpbwindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "numerical_gpbwindows";
            this.Size = new System.Drawing.Size(1100, 680);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_preview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resistance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label square;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_three_phase_power;
        private System.Windows.Forms.TextBox textBox_wire;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private controlPlus.buttonPlus btnToExcel;
        private DataGridViewWithCheck dataGridView_Resistance;
        private System.Windows.Forms.ComboBox cBox_U;
        private System.Windows.Forms.TextBox textBox_phase_voltage;
        private System.Windows.Forms.ComboBox cBox_electricityType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_preview;
        private System.Windows.Forms.DataGridViewTextBoxColumn preview;
        private System.Windows.Forms.TextBox textBox_series;
        private System.Windows.Forms.TextBox textBox_singlePhaseNumber;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button label_resistance_num;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button labelPower;
        private System.Windows.Forms.ComboBox cBoxSeriesType;
        private System.Windows.Forms.TextBox textBox_cocontactor;
    }
}
