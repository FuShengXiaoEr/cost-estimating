namespace cost_estimating
{
    partial class instrument
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
            this.instrument_add = new System.Windows.Forms.Button();
            this.brand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.brand_name = new System.Windows.Forms.ComboBox();
            this.comboBox_load = new System.Windows.Forms.ComboBox();
            this.material_name = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_pirce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search = new System.Windows.Forms.Button();
            this.dataGridViewWithCheck_insdesc = new cost_estimating.DataGridViewWithCheck();
            this.specifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_instrumentAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithCheck_insdesc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.instrument_add);
            this.panel1.Controls.Add(this.brand);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.brand_name);
            this.panel1.Controls.Add(this.comboBox_load);
            this.panel1.Controls.Add(this.material_name);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 125);
            this.panel1.TabIndex = 0;
            // 
            // instrument_add
            // 
            this.instrument_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.instrument_add.Location = new System.Drawing.Point(708, 31);
            this.instrument_add.Name = "instrument_add";
            this.instrument_add.Size = new System.Drawing.Size(138, 37);
            this.instrument_add.TabIndex = 2;
            this.instrument_add.Text = "查找";
            this.instrument_add.UseVisualStyleBackColor = true;
            this.instrument_add.Click += new System.EventHandler(this.instrument_add_Click);
            // 
            // brand
            // 
            this.brand.AutoSize = true;
            this.brand.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.brand.Location = new System.Drawing.Point(548, 25);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(40, 16);
            this.brand.TabIndex = 1;
            this.brand.Text = "品牌";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(188, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "负载组成";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(363, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "物料名称";
            // 
            // brand_name
            // 
            this.brand_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.brand_name.FormattingEnabled = true;
            this.brand_name.Location = new System.Drawing.Point(501, 44);
            this.brand_name.Name = "brand_name";
            this.brand_name.Size = new System.Drawing.Size(131, 24);
            this.brand_name.TabIndex = 0;
            // 
            // comboBox_load
            // 
            this.comboBox_load.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_load.FormattingEnabled = true;
            this.comboBox_load.Location = new System.Drawing.Point(163, 44);
            this.comboBox_load.Name = "comboBox_load";
            this.comboBox_load.Size = new System.Drawing.Size(131, 24);
            this.comboBox_load.TabIndex = 0;
            this.comboBox_load.SelectedIndexChanged += new System.EventHandler(this.comboBox_load_SelectedIndexChanged);
            // 
            // material_name
            // 
            this.material_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.material_name.FormattingEnabled = true;
            this.material_name.Location = new System.Drawing.Point(338, 44);
            this.material_name.Name = "material_name";
            this.material_name.Size = new System.Drawing.Size(131, 24);
            this.material_name.TabIndex = 0;
            this.material_name.SelectedIndexChanged += new System.EventHandler(this.material_name_SelectedIndexChanged);
            // 
            // type
            // 
            this.type.FillWeight = 138.589F;
            this.type.HeaderText = "规格型号";
            this.type.Name = "type";
            // 
            // unit
            // 
            this.unit.FillWeight = 138.589F;
            this.unit.HeaderText = "单位";
            this.unit.Name = "unit";
            // 
            // unit_pirce
            // 
            this.unit_pirce.FillWeight = 138.589F;
            this.unit_pirce.HeaderText = "单价";
            this.unit_pirce.Name = "unit_pirce";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.Location = new System.Drawing.Point(266, 707);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(123, 37);
            this.search.TabIndex = 2;
            this.search.Text = "搜索";
            this.search.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWithCheck_insdesc
            // 
            this.dataGridViewWithCheck_insdesc.AllowUserToAddRows = false;
            this.dataGridViewWithCheck_insdesc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewWithCheck_insdesc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewWithCheck_insdesc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWithCheck_insdesc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewWithCheck_insdesc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewWithCheck_insdesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewWithCheck_insdesc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWithCheck_insdesc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewWithCheck_insdesc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWithCheck_insdesc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.specifications,
            this.units,
            this.units_price});
            this.dataGridViewWithCheck_insdesc.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewWithCheck_insdesc.Location = new System.Drawing.Point(3, 131);
            this.dataGridViewWithCheck_insdesc.Name = "dataGridViewWithCheck_insdesc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWithCheck_insdesc.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewWithCheck_insdesc.RowTemplate.Height = 23;
            this.dataGridViewWithCheck_insdesc.Size = new System.Drawing.Size(959, 491);
            this.dataGridViewWithCheck_insdesc.TabIndex = 1;
            // 
            // specifications
            // 
            this.specifications.DataPropertyName = "dc_type";
            this.specifications.FillWeight = 211.9903F;
            this.specifications.HeaderText = "规格型号";
            this.specifications.Name = "specifications";
            // 
            // units
            // 
            this.units.DataPropertyName = "dc_unit";
            this.units.FillWeight = 211.9903F;
            this.units.HeaderText = "单位";
            this.units.Name = "units";
            // 
            // units_price
            // 
            this.units_price.DataPropertyName = "dc_unitprice";
            this.units_price.FillWeight = 211.9903F;
            this.units_price.HeaderText = "单价";
            this.units_price.Name = "units_price";
            // 
            // button_instrumentAdd
            // 
            this.button_instrumentAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_instrumentAdd.Location = new System.Drawing.Point(200, 637);
            this.button_instrumentAdd.Name = "button_instrumentAdd";
            this.button_instrumentAdd.Size = new System.Drawing.Size(138, 37);
            this.button_instrumentAdd.TabIndex = 2;
            this.button_instrumentAdd.Text = "添加至清单";
            this.button_instrumentAdd.UseVisualStyleBackColor = true;
            this.button_instrumentAdd.Click += new System.EventHandler(this.button_instrumentAdd_Click);
            // 
            // instrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button_instrumentAdd);
            this.Controls.Add(this.dataGridViewWithCheck_insdesc);
            this.Controls.Add(this.panel1);
            this.Name = "instrument";
            this.Size = new System.Drawing.Size(965, 683);
            this.Load += new System.EventHandler(this.instrument_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithCheck_insdesc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox material_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label brand;
        private System.Windows.Forms.ComboBox brand_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_load;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_pirce;
        private System.Windows.Forms.Button search;
        private DataGridViewWithCheck dataGridViewWithCheck_insdesc;
        private System.Windows.Forms.Button instrument_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn specifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn units;
        private System.Windows.Forms.DataGridViewTextBoxColumn units_price;
        private System.Windows.Forms.Button button_instrumentAdd;
    }
}
