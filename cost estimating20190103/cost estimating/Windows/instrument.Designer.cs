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
            this.panel1 = new System.Windows.Forms.Panel();
            this.brand = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.brand_name = new System.Windows.Forms.ComboBox();
            this.material_name = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.brand);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.brand_name);
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
            this.brand.Location = new System.Drawing.Point(333, 21);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(40, 16);
            this.brand.TabIndex = 1;
            this.brand.Text = "品牌";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(148, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "物料名称";
            // 
            // brand_name
            // 
            this.brand_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.brand_name.FormattingEnabled = true;
            this.brand_name.Location = new System.Drawing.Point(286, 40);
            this.brand_name.Name = "brand_name";
            this.brand_name.Size = new System.Drawing.Size(131, 24);
            this.brand_name.TabIndex = 0;
            // 
            // material_name
            // 
            this.material_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.material_name.FormattingEnabled = true;
            this.material_name.Location = new System.Drawing.Point(123, 40);
            this.material_name.Name = "material_name";
            this.material_name.Size = new System.Drawing.Size(131, 24);
            this.material_name.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox material_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label brand;
        private System.Windows.Forms.ComboBox brand_name;
    }
}
