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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnToExcel = new cost_estimating.controlPlus.buttonPlus();
            this.dataGridView_Resistance = new cost_estimating.DataGridViewWithCheck();
            this.dataGridView_preview = new System.Windows.Forms.DataGridView();
            this.preview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_singlePhaseNumber = new System.Windows.Forms.TextBox();
            this.textBox_series = new System.Windows.Forms.TextBox();
            this.cBox_U = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_cocontactor = new System.Windows.Forms.Label();
            this.label_wire = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBox_cocontactor = new System.Windows.Forms.ComboBox();
            this.textBox_phase_voltage = new System.Windows.Forms.TextBox();
            this.comboBox_cocontactor = new System.Windows.Forms.ComboBox();
            this.cBox_electricityType = new System.Windows.Forms.ComboBox();
            this.textBox_wire = new System.Windows.Forms.TextBox();
            this.label_resistance_num = new System.Windows.Forms.Label();
            this.textBox_three_phase_power = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.square = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_preview)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.btnToExcel.Location = new System.Drawing.Point(792, 637);
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
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Resistance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView_Resistance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Resistance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Resistance.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Resistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Resistance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Resistance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView_Resistance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Resistance.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_Resistance.Location = new System.Drawing.Point(10, 180);
            this.dataGridView_Resistance.Name = "dataGridView_Resistance";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Resistance.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView_Resistance.RowTemplate.Height = 23;
            this.dataGridView_Resistance.Size = new System.Drawing.Size(1087, 490);
            this.dataGridView_Resistance.TabIndex = 12;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_preview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView_preview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_preview.ColumnHeadersVisible = false;
            this.dataGridView_preview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preview});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_preview.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView_preview.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_preview.Location = new System.Drawing.Point(10, 141);
            this.dataGridView_preview.Name = "dataGridView_preview";
            this.dataGridView_preview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_preview.RowsDefaultCellStyle = dataGridViewCellStyle24;
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
            this.panel2.Controls.Add(this.textBox_singlePhaseNumber);
            this.panel2.Controls.Add(this.textBox_series);
            this.panel2.Controls.Add(this.cBox_U);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label_cocontactor);
            this.panel2.Controls.Add(this.label_wire);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cBox_cocontactor);
            this.panel2.Controls.Add(this.textBox_phase_voltage);
            this.panel2.Controls.Add(this.comboBox_cocontactor);
            this.panel2.Controls.Add(this.cBox_electricityType);
            this.panel2.Controls.Add(this.textBox_wire);
            this.panel2.Controls.Add(this.label_resistance_num);
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
            this.textBox_series.Location = new System.Drawing.Point(854, 63);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(509, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 7, 5, 6);
            this.label2.Size = new System.Drawing.Size(84, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "三相功率";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(304, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(7, 7, 7, 6);
            this.label7.Size = new System.Drawing.Size(72, 34);
            this.label7.TabIndex = 2;
            this.label7.Text = "接触器";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_cocontactor
            // 
            this.label_cocontactor.AutoSize = true;
            this.label_cocontactor.BackColor = System.Drawing.Color.Silver;
            this.label_cocontactor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_cocontactor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_cocontactor.Location = new System.Drawing.Point(304, 59);
            this.label_cocontactor.Margin = new System.Windows.Forms.Padding(0);
            this.label_cocontactor.Name = "label_cocontactor";
            this.label_cocontactor.Padding = new System.Windows.Forms.Padding(7, 7, 7, 6);
            this.label_cocontactor.Size = new System.Drawing.Size(72, 34);
            this.label_cocontactor.TabIndex = 2;
            this.label_cocontactor.Text = "接触器";
            this.label_cocontactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_wire
            // 
            this.label_wire.AutoSize = true;
            this.label_wire.BackColor = System.Drawing.Color.Silver;
            this.label_wire.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_wire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_wire.Location = new System.Drawing.Point(509, 59);
            this.label_wire.Margin = new System.Windows.Forms.Padding(0);
            this.label_wire.Name = "label_wire";
            this.label_wire.Padding = new System.Windows.Forms.Padding(21, 7, 21, 6);
            this.label_wire.Size = new System.Drawing.Size(84, 34);
            this.label_wire.TabIndex = 2;
            this.label_wire.Text = "导线";
            this.label_wire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(738, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 7, 5, 6);
            this.label5.Size = new System.Drawing.Size(116, 34);
            this.label5.TabIndex = 16;
            this.label5.Text = "单相串联数量";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBox_cocontactor
            // 
            this.cBox_cocontactor.DropDownHeight = 100;
            this.cBox_cocontactor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBox_cocontactor.FormattingEnabled = true;
            this.cBox_cocontactor.IntegralHeight = false;
            this.cBox_cocontactor.Items.AddRange(new object[] {
            "--请选择--",
            "LC1D09",
            "LC1D18",
            "LC1D25",
            "LC1D32",
            "LC1D45",
            "LC1D50",
            "其他"});
            this.cBox_cocontactor.Location = new System.Drawing.Point(376, 63);
            this.cBox_cocontactor.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cBox_cocontactor.Name = "cBox_cocontactor";
            this.cBox_cocontactor.Size = new System.Drawing.Size(90, 29);
            this.cBox_cocontactor.TabIndex = 3;
            this.cBox_cocontactor.Text = "LC1D09";
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
            // comboBox_cocontactor
            // 
            this.comboBox_cocontactor.DropDownHeight = 100;
            this.comboBox_cocontactor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_cocontactor.FormattingEnabled = true;
            this.comboBox_cocontactor.IntegralHeight = false;
            this.comboBox_cocontactor.Items.AddRange(new object[] {
            "--请选择--",
            "LC1D09",
            "LC1D18",
            "LC1D25",
            "LC1D32",
            "LC1D45",
            "LC1D50",
            "其他"});
            this.comboBox_cocontactor.Location = new System.Drawing.Point(376, 62);
            this.comboBox_cocontactor.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.comboBox_cocontactor.Name = "comboBox_cocontactor";
            this.comboBox_cocontactor.Size = new System.Drawing.Size(90, 29);
            this.comboBox_cocontactor.TabIndex = 3;
            this.comboBox_cocontactor.Text = "LC1D09";
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
            // label_resistance_num
            // 
            this.label_resistance_num.BackColor = System.Drawing.Color.Silver;
            this.label_resistance_num.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_resistance_num.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_resistance_num.Location = new System.Drawing.Point(710, 10);
            this.label_resistance_num.Margin = new System.Windows.Forms.Padding(0);
            this.label_resistance_num.Name = "label_resistance_num";
            this.label_resistance_num.Padding = new System.Windows.Forms.Padding(5, 7, 5, 6);
            this.label_resistance_num.Size = new System.Drawing.Size(144, 34);
            this.label_resistance_num.TabIndex = 2;
            this.label_resistance_num.Text = "单相电阻管数量";
            this.label_resistance_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // numerical_gpbwindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "numerical_gpbwindows";
            this.Size = new System.Drawing.Size(1100, 680);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_preview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox_cocontactor;
        private System.Windows.Forms.Label label_wire;
        private System.Windows.Forms.Label label_cocontactor;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_series;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBox_cocontactor;
        private System.Windows.Forms.TextBox textBox_singlePhaseNumber;
        private System.Windows.Forms.Label label_resistance_num;
    }
}
