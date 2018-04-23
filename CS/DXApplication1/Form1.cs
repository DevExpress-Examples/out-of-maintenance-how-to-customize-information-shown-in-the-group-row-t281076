using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videoRentDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.videoRentDataSet.Customer);
            }


        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
           (e.Info as GridGroupRowInfo).GroupText = "Your custom text";
        }
    }
}
