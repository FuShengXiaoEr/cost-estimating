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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnToExcel = new controlPlus.buttonPlus();
            this.panel2 = new System.Windows.Forms.Panel();
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

           

            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();

            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();

            this.dataGridView_Resistance = new cost_estimating.DataGridViewWithCheck();

            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Resistance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnToExcel);
            this.panel1.Controls.Add(this.dataGridView_Resistance);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 625);
            this.panel1.TabIndex = 0;
            // 
            // btnToExcel
            // 
            this.btnToExcel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnToExcel.Location = new System.Drawing.Point(862, 697);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(128, 32);
            this.btnToExcel.TabIndex = 13;
            this.btnToExcel.Text = "导出excel文件";
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.square);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.KW);
            this.panel2.Controls.Add(this.textBox_three_phase_power);
            this.panel2.Controls.Add(this.textBox_wire);
            this.panel2.Controls.Add(this.comboBox_cocontactor);
            this.panel2.Controls.Add(this.comboBox_three_power);
            this.panel2.Controls.Add(this.comboBox_phase_voltage);
            this.panel2.Controls.Add(this.label_resistance_num);
            this.panel2.Controls.Add(this.label_wire);
            this.panel2.Controls.Add(this.label_cocontactor);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label_three_phase_power);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox_single_resistance_num);
            this.panel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(159, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 103);
            this.panel2.TabIndex = 10;
            // 
            // square
            // 
            this.square.AutoSize = true;
            this.square.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.square.Location = new System.Drawing.Point(405, 71);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(46, 21);
            this.square.TabIndex = 6;
            this.square.Text = "mm²";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(181, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(401, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "W";
            // 
            // KW
            // 
            this.KW.AutoSize = true;
            this.KW.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KW.Location = new System.Drawing.Point(678, 22);
            this.KW.Name = "KW";
            this.KW.Size = new System.Drawing.Size(26, 21);
            this.KW.TabIndex = 6;
            this.KW.Text = "W";
            // 
            // textBox_three_phase_power
            // 
            this.textBox_three_phase_power.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_three_phase_power.Location = new System.Drawing.Point(331, 18);
            this.textBox_three_phase_power.Name = "textBox_three_phase_power";
            this.textBox_three_phase_power.Size = new System.Drawing.Size(70, 29);
            this.textBox_three_phase_power.TabIndex = 5;
            this.textBox_three_phase_power.Text = "1000";
            this.textBox_three_phase_power.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_wire
            // 
            this.textBox_wire.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_wire.Location = new System.Drawing.Point(331, 67);
            this.textBox_wire.Name = "textBox_wire";
            this.textBox_wire.Size = new System.Drawing.Size(70, 29);
            this.textBox_wire.TabIndex = 5;
            this.textBox_wire.Text = "1.5";
            this.textBox_wire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            "LC1D50"});
            this.comboBox_cocontactor.Location = new System.Drawing.Point(91, 67);
            this.comboBox_cocontactor.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.comboBox_cocontactor.Name = "comboBox_cocontactor";
            this.comboBox_cocontactor.Size = new System.Drawing.Size(90, 29);
            this.comboBox_cocontactor.TabIndex = 3;
            this.comboBox_cocontactor.Text = "LC1D09";
            // 
            // comboBox_three_power
            // 
            this.comboBox_three_power.DropDownHeight = 100;
            this.comboBox_three_power.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.comboBox_three_power.Location = new System.Drawing.Point(588, 18);
            this.comboBox_three_power.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.comboBox_three_power.Name = "comboBox_three_power";
            this.comboBox_three_power.Size = new System.Drawing.Size(90, 29);
            this.comboBox_three_power.TabIndex = 3;
            // 
            // comboBox_phase_voltage
            // 
            this.comboBox_phase_voltage.DropDownHeight = 100;
            this.comboBox_phase_voltage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_phase_voltage.FormattingEnabled = true;
            this.comboBox_phase_voltage.IntegralHeight = false;
            this.comboBox_phase_voltage.Items.AddRange(new object[] {
            "--请选择--",
            "230"});
            this.comboBox_phase_voltage.Location = new System.Drawing.Point(91, 18);
            this.comboBox_phase_voltage.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.comboBox_phase_voltage.Name = "comboBox_phase_voltage";
            this.comboBox_phase_voltage.Size = new System.Drawing.Size(90, 29);
            this.comboBox_phase_voltage.TabIndex = 3;
            this.comboBox_phase_voltage.Text = "230";
            // 
            // label_resistance_num
            // 
            this.label_resistance_num.BackColor = System.Drawing.Color.Silver;
            this.label_resistance_num.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_resistance_num.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_resistance_num.Location = new System.Drawing.Point(501, 64);
            this.label_resistance_num.Margin = new System.Windows.Forms.Padding(0);
            this.label_resistance_num.Name = "label_resistance_num";
            this.label_resistance_num.Padding = new System.Windows.Forms.Padding(5, 7, 5, 6);
            this.label_resistance_num.Size = new System.Drawing.Size(132, 34);
            this.label_resistance_num.TabIndex = 2;
            this.label_resistance_num.Text = "单相电阻管数量";
            this.label_resistance_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_wire
            // 
            this.label_wire.AutoSize = true;
            this.label_wire.BackColor = System.Drawing.Color.Silver;
            this.label_wire.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_wire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_wire.Location = new System.Drawing.Point(247, 64);
            this.label_wire.Margin = new System.Windows.Forms.Padding(0);
            this.label_wire.Name = "label_wire";
            this.label_wire.Padding = new System.Windows.Forms.Padding(21, 7, 21, 6);
            this.label_wire.Size = new System.Drawing.Size(84, 34);
            this.label_wire.TabIndex = 2;
            this.label_wire.Text = "导线";
            this.label_wire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_cocontactor
            // 
            this.label_cocontactor.AutoSize = true;
            this.label_cocontactor.BackColor = System.Drawing.Color.Silver;
            this.label_cocontactor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_cocontactor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_cocontactor.Location = new System.Drawing.Point(19, 64);
            this.label_cocontactor.Margin = new System.Windows.Forms.Padding(0);
            this.label_cocontactor.Name = "label_cocontactor";
            this.label_cocontactor.Padding = new System.Windows.Forms.Padding(7, 7, 7, 6);
            this.label_cocontactor.Size = new System.Drawing.Size(72, 34);
            this.label_cocontactor.TabIndex = 2;
            this.label_cocontactor.Text = "接触器";
            this.label_cocontactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(247, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 7, 5, 6);
            this.label2.Size = new System.Drawing.Size(84, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "三相功率";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_three_phase_power
            // 
            this.label_three_phase_power.AutoSize = true;
            this.label_three_phase_power.BackColor = System.Drawing.Color.Silver;
            this.label_three_phase_power.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_three_phase_power.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_three_phase_power.Location = new System.Drawing.Point(504, 15);
            this.label_three_phase_power.Margin = new System.Windows.Forms.Padding(0);
            this.label_three_phase_power.Name = "label_three_phase_power";
            this.label_three_phase_power.Padding = new System.Windows.Forms.Padding(5, 7, 5, 6);
            this.label_three_phase_power.Size = new System.Drawing.Size(84, 34);
            this.label_three_phase_power.TabIndex = 2;
            this.label_three_phase_power.Text = "三相功率";
            this.label_three_phase_power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 6);
            this.label1.Size = new System.Drawing.Size(72, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "相电压";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_single_resistance_num
            // 
            this.comboBox_single_resistance_num.DropDownHeight = 100;
            this.comboBox_single_resistance_num.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.comboBox_single_resistance_num.Location = new System.Drawing.Point(633, 67);
            this.comboBox_single_resistance_num.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.comboBox_single_resistance_num.MaxDropDownItems = 10;
            this.comboBox_single_resistance_num.Name = "comboBox_single_resistance_num";
            this.comboBox_single_resistance_num.Size = new System.Drawing.Size(90, 29);
            this.comboBox_single_resistance_num.TabIndex = 3;
            this.comboBox_single_resistance_num.Text = "1";
            // 

            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(965, 625);
            this.shapeContainer2.TabIndex = 11;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 10;
            this.lineShape1.X2 = 1043;
            this.lineShape1.Y1 = 130;
            this.lineShape1.Y2 = 130;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 492;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.HeaderText = "";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Width = 492;
            // 

            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.HeaderText = "";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.Width = 492;
            // 
            // dataGridViewCheckBoxColumn7
            // 
            this.dataGridViewCheckBoxColumn7.HeaderText = "";
            this.dataGridViewCheckBoxColumn7.Name = "dataGridViewCheckBoxColumn7";
            this.dataGridViewCheckBoxColumn7.Width = 328;
            // 
            // dataGridViewCheckBoxColumn8
            // 
            this.dataGridViewCheckBoxColumn8.HeaderText = "";
            this.dataGridViewCheckBoxColumn8.Name = "dataGridViewCheckBoxColumn8";
            this.dataGridViewCheckBoxColumn8.Width = 328;
            // 
            // dataGridViewCheckBoxColumn9
            // 
            this.dataGridViewCheckBoxColumn9.HeaderText = "";
            this.dataGridViewCheckBoxColumn9.Name = "dataGridViewCheckBoxColumn9";
            this.dataGridViewCheckBoxColumn9.Width = 328;
            // 
            // dataGridViewCheckBoxColumn10
            // 
            this.dataGridViewCheckBoxColumn10.HeaderText = "";
            this.dataGridViewCheckBoxColumn10.Name = "dataGridViewCheckBoxColumn10";
            this.dataGridViewCheckBoxColumn10.Width = 328;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_delete.BackgroundImage = global::cost_estimating.Properties.Resources.btnNormal;
            this.button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_delete.Image = global::cost_estimating.Properties.Resources.round_remove26x26;
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_delete.Location = new System.Drawing.Point(51, 85);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 31);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "删除";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Transparent;
            this.button_add.BackgroundImage = global::cost_estimating.Properties.Resources.btnBlue;
            this.button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_add.Image = global::cost_estimating.Properties.Resources.add;
            this.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_add.Location = new System.Drawing.Point(51, 36);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 31);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "添加";
            this.button_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
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
            this.btnToExcel.Location = new System.Drawing.Point(792, 577);
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
            this.dataGridView_Resistance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView_Resistance.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_Resistance.Location = new System.Drawing.Point(10, 141);
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
            this.dataGridView_Resistance.Size = new System.Drawing.Size(945, 430);
            this.dataGridView_Resistance.TabIndex = 12;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // numerical_gpbwindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "numerical_gpbwindows";
            this.Size = new System.Drawing.Size(965, 625);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label KW;
        private System.Windows.Forms.TextBox textBox_three_phase_power;
        private System.Windows.Forms.TextBox textBox_wire;
        private System.Windows.Forms.ComboBox comboBox_cocontactor;
        private System.Windows.Forms.ComboBox comboBox_three_power;
        private System.Windows.Forms.ComboBox comboBox_phase_voltage;
        private System.Windows.Forms.Label label_resistance_num;
        private System.Windows.Forms.Label label_wire;
        private System.Windows.Forms.Label label_cocontactor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_three_phase_power;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_single_resistance_num;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private DataGridViewWithCheck dataGridView_Resistance;

        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private controlPlus.buttonPlus btnToExcel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn10;


    }
}
