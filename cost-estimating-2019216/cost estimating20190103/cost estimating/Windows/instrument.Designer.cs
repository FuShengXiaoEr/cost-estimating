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
            this.brand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.brand_name = new System.Windows.Forms.ComboBox();
            this.comboBox_load = new System.Windows.Forms.ComboBox();
            this.material_name = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Button();
            this.dataGridViewWithCheck_instruDesc = new cost_estimating.DataGridViewWithCheck();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_pirce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithCheck_instruDesc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.brand);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.brand_name);
            this.panel1.Controls.Add(this.comboBox_load);
            this.panel1.Controls.Add(this.material_name);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 125);
            this.panel1.TabIndex = 0;
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
            // dataGridViewWithCheck_instruDesc
            // 
            this.dataGridViewWithCheck_instruDesc.AllowUserToAddRows = false;
            this.dataGridViewWithCheck_instruDesc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewWithCheck_instruDesc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewWithCheck_instruDesc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWithCheck_instruDesc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewWithCheck_instruDesc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewWithCheck_instruDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewWithCheck_instruDesc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWithCheck_instruDesc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewWithCheck_instruDesc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWithCheck_instruDesc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.unit,
            this.unit_pirce});
            this.dataGridViewWithCheck_instruDesc.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewWithCheck_instruDesc.Location = new System.Drawing.Point(0, 131);
            this.dataGridViewWithCheck_instruDesc.Name = "dataGridViewWithCheck_instruDesc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWithCheck_instruDesc.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewWithCheck_instruDesc.RowTemplate.Height = 23;
            this.dataGridViewWithCheck_instruDesc.Size = new System.Drawing.Size(1065, 555);
            this.dataGridViewWithCheck_instruDesc.TabIndex = 1;
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
            // instrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "instrument";
            this.Size = new System.Drawing.Size(1065, 825);
            this.Load += new System.EventHandler(this.instrument_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithCheck_instruDesc)).EndInit();
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
        private DataGridViewWithCheck dataGridViewWithCheck_instruDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_pirce;
        private System.Windows.Forms.Button search;
    }
}
