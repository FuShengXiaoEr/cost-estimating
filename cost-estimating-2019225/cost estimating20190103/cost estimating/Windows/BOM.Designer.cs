namespace cost_estimating
{
    partial class BOM
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewWithCheck_BOM = new cost_estimating.DataGridViewWithCheck();
            this.loadConstitue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithCheck_BOM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(422, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "BOM清单";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(192, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWithCheck_BOM
            // 
            this.dataGridViewWithCheck_BOM.AllowUserToAddRows = false;
            this.dataGridViewWithCheck_BOM.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewWithCheck_BOM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewWithCheck_BOM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWithCheck_BOM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewWithCheck_BOM.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewWithCheck_BOM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewWithCheck_BOM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWithCheck_BOM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewWithCheck_BOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWithCheck_BOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loadConstitue,
            this.material_name,
            this.brand_name,
            this.type,
            this.unit,
            this.unitprice});
            this.dataGridViewWithCheck_BOM.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewWithCheck_BOM.Location = new System.Drawing.Point(3, 43);
            this.dataGridViewWithCheck_BOM.Name = "dataGridViewWithCheck_BOM";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWithCheck_BOM.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewWithCheck_BOM.RowTemplate.Height = 23;
            this.dataGridViewWithCheck_BOM.Size = new System.Drawing.Size(962, 561);
            this.dataGridViewWithCheck_BOM.TabIndex = 0;
            // 
            // loadConstitue
            // 
            this.loadConstitue.DataPropertyName = "loadconstitue";
            this.loadConstitue.FillWeight = 151.7559F;
            this.loadConstitue.HeaderText = "负载组成";
            this.loadConstitue.Name = "loadConstitue";
            // 
            // material_name
            // 
            this.material_name.DataPropertyName = "material_name";
            this.material_name.FillWeight = 113.5236F;
            this.material_name.HeaderText = "物料名称";
            this.material_name.Name = "material_name";
            // 
            // brand_name
            // 
            this.brand_name.DataPropertyName = "brand_name";
            this.brand_name.FillWeight = 113.5236F;
            this.brand_name.HeaderText = "品牌名称";
            this.brand_name.Name = "brand_name";
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.FillWeight = 113.5236F;
            this.type.HeaderText = "规格型号";
            this.type.Name = "type";
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.FillWeight = 113.5236F;
            this.unit.HeaderText = "单位";
            this.unit.Name = "unit";
            // 
            // unitprice
            // 
            this.unitprice.DataPropertyName = "unitprice";
            this.unitprice.FillWeight = 113.5236F;
            this.unitprice.HeaderText = "单价";
            this.unitprice.Name = "unitprice";
            // 
            // BOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewWithCheck_BOM);
            this.Name = "BOM";
            this.Size = new System.Drawing.Size(965, 683);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithCheck_BOM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridViewWithCheck dataGridViewWithCheck_BOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadConstitue;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
    }
}
