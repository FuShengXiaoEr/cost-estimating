namespace cost_estimating
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点0");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("节点7");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("节点4", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            this.电阻ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.电容ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.电抗ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.数值计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 电阻ToolStripMenuItem1
            // 
            this.电阻ToolStripMenuItem1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.电阻ToolStripMenuItem1.Name = "电阻ToolStripMenuItem1";
            this.电阻ToolStripMenuItem1.Size = new System.Drawing.Size(124, 30);
            this.电阻ToolStripMenuItem1.Text = "电阻";
            // 
            // 电容ToolStripMenuItem1
            // 
            this.电容ToolStripMenuItem1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.电容ToolStripMenuItem1.Name = "电容ToolStripMenuItem1";
            this.电容ToolStripMenuItem1.Size = new System.Drawing.Size(124, 30);
            this.电容ToolStripMenuItem1.Text = "电容";
            // 
            // 电抗ToolStripMenuItem1
            // 
            this.电抗ToolStripMenuItem1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.电抗ToolStripMenuItem1.Name = "电抗ToolStripMenuItem1";
            this.电抗ToolStripMenuItem1.Size = new System.Drawing.Size(124, 30);
            this.电抗ToolStripMenuItem1.Text = "电抗";
            // 
            // 数值计算ToolStripMenuItem
            // 
            this.数值计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.电阻ToolStripMenuItem1,
            this.电容ToolStripMenuItem1,
            this.电抗ToolStripMenuItem1});
            this.数值计算ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.数值计算ToolStripMenuItem.Name = "数值计算ToolStripMenuItem";
            this.数值计算ToolStripMenuItem.Size = new System.Drawing.Size(115, 35);
            this.数值计算ToolStripMenuItem.Text = "数值计算";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.treeView1.Indent = 15;
            this.treeView1.ItemHeight = 25;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "节点1";
            treeNode2.Name = "节点2";
            treeNode2.Text = "节点2";
            treeNode3.Name = "节点3";
            treeNode3.Text = "节点3";
            treeNode4.Name = "节点0";
            treeNode4.Text = "节点0";
            treeNode5.Name = "节点1";
            treeNode5.Text = "节点1";
            treeNode6.BackColor = System.Drawing.Color.LightSkyBlue;
            treeNode6.ForeColor = System.Drawing.Color.Black;
            treeNode6.Name = "节点0";
            treeNode6.Text = "节点0";
            treeNode7.Name = "节点5";
            treeNode7.Text = "节点5";
            treeNode8.Name = "节点6";
            treeNode8.Text = "节点6";
            treeNode9.Name = "节点7";
            treeNode9.Text = "节点7";
            treeNode10.Name = "节点4";
            treeNode10.Text = "节点4";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode10});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(180, 398);
            this.treeView1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Size = new System.Drawing.Size(676, 398);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 398);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 电阻ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 电容ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 电抗ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 数值计算ToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;


    }
}