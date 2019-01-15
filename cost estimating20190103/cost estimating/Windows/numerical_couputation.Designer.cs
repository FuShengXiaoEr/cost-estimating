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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_toexcel = new System.Windows.Forms.Button();
            this.checkBox_selectall = new System.Windows.Forms.CheckBox();
            this.dataGridView_resistance_calculate = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.phase_voltage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.three_phase_power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.single_power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electricity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cocontactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value_of_resistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistance_power_single = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistance_value_single = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistance_number_single = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistance_num_three = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.square = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KW = new System.Windows.Forms.Label();
            this.textBox_three_phase_power = new System.Windows.Forms.TextBox();
            this.textBox_wire = new System.Windows.Forms.TextBox();
            this.comboBox_cocontactor = new System.Windows.Forms.ComboBox();
            this.comboBox_three_power = new System.Windows.Forms.ComboBox();
            this.comboBox_phase_voltage = new System.Windows.Forms.ComboBox();
            this.label_resistance_num = new System.Windows.Forms.Label();
            this.label_wire = new System.Windows.Forms.Label();
            this.label_cocontactor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_three_phase_power = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_single_resistance_num = new System.Windows.Forms.ComboBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resistance_calculate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 819);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_toexcel);
            this.tabPage1.Controls.Add(this.checkBox_selectall);
            this.tabPage1.Controls.Add(this.dataGridView_resistance_calculate);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.button_delete);
            this.tabPage1.Controls.Add(this.button_add);
            this.tabPage1.Controls.Add(this.shapeContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 793);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_toexcel
            // 
            this.button_toexcel.BackColor = System.Drawing.Color.Lime;
            this.button_toexcel.Location = new System.Drawing.Point(916, 657);
            this.button_toexcel.Name = "button_toexcel";
            this.button_toexcel.Size = new System.Drawing.Size(97, 28);
            this.button_toexcel.TabIndex = 4;
            this.button_toexcel.Text = "确认";
            this.button_toexcel.UseVisualStyleBackColor = false;
            // 
            // checkBox_selectall
            // 
            this.checkBox_selectall.AutoSize = true;
            this.checkBox_selectall.Location = new System.Drawing.Point(89, 122);
            this.checkBox_selectall.Name = "checkBox_selectall";
            this.checkBox_selectall.Size = new System.Drawing.Size(15, 14);
            this.checkBox_selectall.TabIndex = 6;
            this.checkBox_selectall.UseVisualStyleBackColor = true;
            this.checkBox_selectall.Click += new System.EventHandler(this.checkBox_selectall_Click);
            // 
            // dataGridView_resistance_calculate
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_resistance_calculate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_resistance_calculate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_resistance_calculate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_resistance_calculate.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_resistance_calculate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_resistance_calculate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView_resistance_calculate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_resistance_calculate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.phase_voltage,
            this.three_phase_power,
            this.single_power,
            this.electricity,
            this.cocontactor,
            this.wire,
            this.value_of_resistance,
            this.resistance_power_single,
            this.resistance_value_single,
            this.resistance_number_single,
            this.resistance_num_three});
            this.dataGridView_resistance_calculate.Location = new System.Drawing.Point(8, 112);
            this.dataGridView_resistance_calculate.Name = "dataGridView_resistance_calculate";
            this.dataGridView_resistance_calculate.RowTemplate.Height = 23;
            this.dataGridView_resistance_calculate.Size = new System.Drawing.Size(1027, 530);
            this.dataGridView_resistance_calculate.TabIndex = 5;
            this.dataGridView_resistance_calculate.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // check
            // 
            this.check.HeaderText = "选择";
            this.check.Name = "check";
            // 
            // phase_voltage
            // 
            this.phase_voltage.HeaderText = "相电压";
            this.phase_voltage.Name = "phase_voltage";
            // 
            // three_phase_power
            // 
            this.three_phase_power.HeaderText = "三相功率";
            this.three_phase_power.Name = "three_phase_power";
            // 
            // single_power
            // 
            this.single_power.HeaderText = "单相功率";
            this.single_power.Name = "single_power";
            // 
            // electricity
            // 
            this.electricity.HeaderText = "电流";
            this.electricity.Name = "electricity";
            // 
            // cocontactor
            // 
            this.cocontactor.HeaderText = "接触器";
            this.cocontactor.Name = "cocontactor";
            // 
            // wire
            // 
            this.wire.HeaderText = "导线";
            this.wire.Name = "wire";
            // 
            // value_of_resistance
            // 
            this.value_of_resistance.HeaderText = "阻值";
            this.value_of_resistance.Name = "value_of_resistance";
            // 
            // resistance_power_single
            // 
            this.resistance_power_single.HeaderText = "单根电阻管功率";
            this.resistance_power_single.Name = "resistance_power_single";
            // 
            // resistance_value_single
            // 
            this.resistance_value_single.HeaderText = "单根电阻管阻值";
            this.resistance_value_single.Name = "resistance_value_single";
            // 
            // resistance_number_single
            // 
            this.resistance_number_single.HeaderText = "单相电阻管数量";
            this.resistance_number_single.Name = "resistance_number_single";
            // 
            // resistance_num_three
            // 
            this.resistance_num_three.HeaderText = "三相电阻管数量";
            this.resistance_num_three.Name = "resistance_num_three";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.square);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.KW);
            this.panel1.Controls.Add(this.textBox_three_phase_power);
            this.panel1.Controls.Add(this.textBox_wire);
            this.panel1.Controls.Add(this.comboBox_cocontactor);
            this.panel1.Controls.Add(this.comboBox_three_power);
            this.panel1.Controls.Add(this.comboBox_phase_voltage);
            this.panel1.Controls.Add(this.label_resistance_num);
            this.panel1.Controls.Add(this.label_wire);
            this.panel1.Controls.Add(this.label_cocontactor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_three_phase_power);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_single_resistance_num);
            this.panel1.Location = new System.Drawing.Point(178, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 103);
            this.panel1.TabIndex = 4;
            // 
            // square
            // 
            this.square.AutoSize = true;
            this.square.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.square.Location = new System.Drawing.Point(405, 67);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(43, 21);
            this.square.TabIndex = 6;
            this.square.Text = "mm²";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(184, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(405, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "W";
            // 
            // KW
            // 
            this.KW.AutoSize = true;
            this.KW.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KW.Location = new System.Drawing.Point(684, 23);
            this.KW.Name = "KW";
            this.KW.Size = new System.Drawing.Size(21, 21);
            this.KW.TabIndex = 6;
            this.KW.Text = "W";
            // 
            // textBox_three_phase_power
            // 
            this.textBox_three_phase_power.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_three_phase_power.Location = new System.Drawing.Point(329, 14);
            this.textBox_three_phase_power.Name = "textBox_three_phase_power";
            this.textBox_three_phase_power.Size = new System.Drawing.Size(70, 29);
            this.textBox_three_phase_power.TabIndex = 5;
            this.textBox_three_phase_power.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_wire
            // 
            this.textBox_wire.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_wire.Location = new System.Drawing.Point(329, 64);
            this.textBox_wire.Name = "textBox_wire";
            this.textBox_wire.Size = new System.Drawing.Size(70, 29);
            this.textBox_wire.TabIndex = 5;
            this.textBox_wire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_cocontactor
            // 
            this.comboBox_cocontactor.DropDownHeight = 100;
            this.comboBox_cocontactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cocontactor.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_cocontactor.FormattingEnabled = true;
            this.comboBox_cocontactor.IntegralHeight = false;
            this.comboBox_cocontactor.Items.AddRange(new object[] {
            "LC1D09"});
            this.comboBox_cocontactor.Location = new System.Drawing.Point(89, 64);
            this.comboBox_cocontactor.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.comboBox_cocontactor.Name = "comboBox_cocontactor";
            this.comboBox_cocontactor.Size = new System.Drawing.Size(90, 28);
            this.comboBox_cocontactor.TabIndex = 3;
            // 
            // comboBox_three_power
            // 
            this.comboBox_three_power.DropDownHeight = 100;
            this.comboBox_three_power.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_three_power.FormattingEnabled = true;
            this.comboBox_three_power.IntegralHeight = false;
            this.comboBox_three_power.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000"});
            this.comboBox_three_power.Location = new System.Drawing.Point(586, 16);
            this.comboBox_three_power.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.comboBox_three_power.Name = "comboBox_three_power";
            this.comboBox_three_power.Size = new System.Drawing.Size(90, 28);
            this.comboBox_three_power.TabIndex = 3;
            // 
            // comboBox_phase_voltage
            // 
            this.comboBox_phase_voltage.DropDownHeight = 100;
            this.comboBox_phase_voltage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_phase_voltage.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_phase_voltage.FormattingEnabled = true;
            this.comboBox_phase_voltage.IntegralHeight = false;
            this.comboBox_phase_voltage.Items.AddRange(new object[] {
            "230"});
            this.comboBox_phase_voltage.Location = new System.Drawing.Point(88, 15);
            this.comboBox_phase_voltage.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.comboBox_phase_voltage.Name = "comboBox_phase_voltage";
            this.comboBox_phase_voltage.Size = new System.Drawing.Size(90, 28);
            this.comboBox_phase_voltage.TabIndex = 3;
            // 
            // label_resistance_num
            // 
            this.label_resistance_num.AutoSize = true;
            this.label_resistance_num.BackColor = System.Drawing.Color.Silver;
            this.label_resistance_num.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_resistance_num.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_resistance_num.Location = new System.Drawing.Point(501, 64);
            this.label_resistance_num.Margin = new System.Windows.Forms.Padding(0);
            this.label_resistance_num.Name = "label_resistance_num";
            this.label_resistance_num.Padding = new System.Windows.Forms.Padding(5, 7, 5, 6);
            this.label_resistance_num.Size = new System.Drawing.Size(130, 29);
            this.label_resistance_num.TabIndex = 2;
            this.label_resistance_num.Text = "单相电阻管数量";
            this.label_resistance_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_wire
            // 
            this.label_wire.AutoSize = true;
            this.label_wire.BackColor = System.Drawing.Color.Silver;
            this.label_wire.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_wire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_wire.Location = new System.Drawing.Point(247, 64);
            this.label_wire.Margin = new System.Windows.Forms.Padding(0);
            this.label_wire.Name = "label_wire";
            this.label_wire.Padding = new System.Windows.Forms.Padding(21, 7, 21, 6);
            this.label_wire.Size = new System.Drawing.Size(82, 29);
            this.label_wire.TabIndex = 2;
            this.label_wire.Text = "导线";
            this.label_wire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_cocontactor
            // 
            this.label_cocontactor.AutoSize = true;
            this.label_cocontactor.BackColor = System.Drawing.Color.Silver;
            this.label_cocontactor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_cocontactor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_cocontactor.Location = new System.Drawing.Point(19, 64);
            this.label_cocontactor.Margin = new System.Windows.Forms.Padding(0);
            this.label_cocontactor.Name = "label_cocontactor";
            this.label_cocontactor.Padding = new System.Windows.Forms.Padding(7, 7, 7, 6);
            this.label_cocontactor.Size = new System.Drawing.Size(70, 29);
            this.label_cocontactor.TabIndex = 2;
            this.label_cocontactor.Text = "接触器";
            this.label_cocontactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(247, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 7, 5, 6);
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "三相功率";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_three_phase_power
            // 
            this.label_three_phase_power.AutoSize = true;
            this.label_three_phase_power.BackColor = System.Drawing.Color.Silver;
            this.label_three_phase_power.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_three_phase_power.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_three_phase_power.Location = new System.Drawing.Point(504, 16);
            this.label_three_phase_power.Margin = new System.Windows.Forms.Padding(0);
            this.label_three_phase_power.Name = "label_three_phase_power";
            this.label_three_phase_power.Padding = new System.Windows.Forms.Padding(5, 7, 5, 6);
            this.label_three_phase_power.Size = new System.Drawing.Size(82, 29);
            this.label_three_phase_power.TabIndex = 2;
            this.label_three_phase_power.Text = "三相功率";
            this.label_three_phase_power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 6);
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "相电压";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_single_resistance_num
            // 
            this.comboBox_single_resistance_num.DropDownHeight = 100;
            this.comboBox_single_resistance_num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_single_resistance_num.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_single_resistance_num.FormattingEnabled = true;
            this.comboBox_single_resistance_num.IntegralHeight = false;
            this.comboBox_single_resistance_num.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.comboBox_single_resistance_num.Location = new System.Drawing.Point(631, 64);
            this.comboBox_single_resistance_num.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.comboBox_single_resistance_num.MaxDropDownItems = 10;
            this.comboBox_single_resistance_num.Name = "comboBox_single_resistance_num";
            this.comboBox_single_resistance_num.Size = new System.Drawing.Size(90, 28);
            this.comboBox_single_resistance_num.TabIndex = 3;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_delete.Location = new System.Drawing.Point(99, 60);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(64, 31);
            this.button_delete.TabIndex = 0;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_add.Location = new System.Drawing.Point(15, 60);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(64, 31);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1045, 787);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 5;
            this.lineShape1.X2 = 1038;
            this.lineShape1.Y1 = 105;
            this.lineShape1.Y2 = 105;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1051, 793);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numerical_gpbwindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "numerical_gpbwindows";
            this.Size = new System.Drawing.Size(1065, 825);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resistance_calculate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_delete;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label_three_phase_power;
        private System.Windows.Forms.ComboBox comboBox_phase_voltage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_cocontactor;
        private System.Windows.Forms.Label label_resistance_num;
        private System.Windows.Forms.Label label_wire;
        private System.Windows.Forms.Label label_cocontactor;
        private System.Windows.Forms.ComboBox comboBox_single_resistance_num;
        private System.Windows.Forms.DataGridView dataGridView_resistance_calculate;
        private System.Windows.Forms.Button button_toexcel;
        private System.Windows.Forms.Label square;
        private System.Windows.Forms.Label KW;
        private System.Windows.Forms.TextBox textBox_wire;
        private System.Windows.Forms.ComboBox comboBox_three_power;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_three_phase_power;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn phase_voltage;
        private System.Windows.Forms.DataGridViewTextBoxColumn three_phase_power;
        private System.Windows.Forms.DataGridViewTextBoxColumn single_power;
        private System.Windows.Forms.DataGridViewTextBoxColumn electricity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cocontactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn wire;
        private System.Windows.Forms.DataGridViewTextBoxColumn value_of_resistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn resistance_power_single;
        private System.Windows.Forms.DataGridViewTextBoxColumn resistance_value_single;
        private System.Windows.Forms.DataGridViewTextBoxColumn resistance_number_single;
        private System.Windows.Forms.DataGridViewTextBoxColumn resistance_num_three;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_selectall;
    }
}
