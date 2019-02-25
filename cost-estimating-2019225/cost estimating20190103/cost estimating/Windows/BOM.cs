using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cost_estimating
{
    public partial class BOM : UserControl
    {
        public BOM()
        {
            InitializeComponent();
            dataGridViewWithCheck_BOM.Columns[0].FillWeight = 12;
            dataGridViewWithCheck_BOM.Columns[1].FillWeight = 12;
            dataGridViewWithCheck_BOM.Columns[2].FillWeight = 12;
            dataGridViewWithCheck_BOM.Columns[3].FillWeight = 44;
            dataGridViewWithCheck_BOM.Columns[4].FillWeight = 10;
            dataGridViewWithCheck_BOM.Columns[5].FillWeight = 10;

            instrument ins = new instrument();

            //ins.getDataEvent += new instrument.dataToBom(ins_getDataEvent);
            ins.getDataEvent += ins_getDataEvent;  
        }

        public void ins_getDataEvent(object dt)
        {
            //dataGridViewWithCheck_BOM.DataSource = dt;
          MessageBox.Show((string)dt);
        }

    }
}
