using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cost_estimating
{
    public partial class DataGridViewWithCheck : DataGridView
    {
        public CheckBox checkBox1;
        public DataGridViewCheckBoxColumn checkColumn;
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

        public DataGridViewWithCheck()
        {
            InitializeComponent();
            InitDataGridView();
            CreateCheckBox();
            //InitCheckColumnInfo();//添加全选列
        }

        /// <summary>
        /// 添加全选列
        /// </summary>
        private void AddCheckColumn()
        {
            this.checkColumn = new DataGridViewCheckBoxColumn();
            // 
            // check
            // 
            
            this.checkColumn.HeaderText = "";
            this.checkColumn.Name = "check";
            this.Columns.Insert(0,checkColumn);
        }

        private void CreateCheckBox()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(82, 23);
            this.checkBox1.Name = "checkAll";
            this.checkBox1.Size = new System.Drawing.Size(78, 16);
            this.checkBox1.Text = "全选";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.BackColor = Color.Transparent;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.Controls.Add(checkBox1);
        }

        private void InitDataGridView()
        {
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridColor = System.Drawing.Color.Gray;
            this.RowTemplate.Height = 23;
            this.Size = new System.Drawing.Size(1027, 530);

            //给表格添加行号
            this.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
        }

        /// <summary>
        /// 重绘
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (this.Columns.Count > 0&&this.Columns[0]==checkColumn)
            {
                var cell = this.GetCellDisplayRectangle(0, -1, true);
                this.checkBox1.Font = this.ColumnHeadersDefaultCellStyle.Font;
                int left = cell.Left + (cell.Width - checkBox1.Width) / 2;
                checkBox1.Left = left > cell.Left ? left : cell.Left;
                checkBox1.Top = cell.Top + (cell.Height - checkBox1.Height) / 2;
            }
            else
            {
                AddCheckColumn();
            }
        }

        /// <summary>
        /// 给表格添加行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                (sender as DataGridView).RowHeadersWidth - 4,
                e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                (sender as DataGridView).RowHeadersDefaultCellStyle.Font,
                rectangle,
                (sender as DataGridView).RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void checkHeader_OnCheckBoxClicked(bool state)
        {
            //当datagridview某行选中时，点击全选复选框，该行是没有反应的。这是因为该行处于编辑状态，无法获取该行的值。
            //这一句很重要,结束编辑状态,
            this.EndEdit();
            this.Rows.OfType<DataGridViewRow>().ToList().ForEach(t => t.Cells[0].Value = state);
        }
        /// <summary>
        /// 实现全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = (sender as CheckBox).CheckState == CheckState.Checked;
            checkHeader_OnCheckBoxClicked(status);
        }

        /// <summary>
        /// 返回选择的行号
        /// </summary>
        /// <returns></returns>
        public int[] selectRows()
        {
            List<int> index = new List<int>();
            if (this.Rows.Count > 0)
            {
                for (int i = 0; i < this.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)this.Rows[i].Cells[0];
                    Boolean flag = Convert.ToBoolean(checkcell.EditedFormattedValue);
                    if (flag)
                    {
                        index.Add(i);
                    }
                }
            }
            int[] index_item = index.ToArray();
            if (this.checkBox1.CheckState == CheckState.Checked)
            {
                this.checkBox1.CheckState = CheckState.Unchecked;
            }
            return index_item;
        }
        /// <summary>
        /// 删除所选
        /// </summary>
        public void delectRows()
        {
            /*这里采用逆序删除元素，因为每删除一个元素，datagridview表格自身的索引会重新进行一次排列，这就导致了索引在不停的变化。但是需要删除的
            行的索引已经确定了。
            那么若是从最后的行开始删则保证了前面的行的索引不会受到影响。
             * */
            int[] index_item = selectRows();
            for (int i = index_item.Length - 1; 0 <= i; i--)
            {
                this.Rows.RemoveAt(index_item[i]);
            }
        }
    }
}
