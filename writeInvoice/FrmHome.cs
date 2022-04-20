using MigraDoc.DocumentObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MigraDoc.Rendering;
using Orientation = MigraDoc.DocumentObjectModel.Orientation;
using System.IO;

namespace writeInvoice
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnDesing_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            DialogResult write;
            write = printDialog1.ShowDialog();
            if (write == DialogResult.OK)
            {
              //  printDocument1.
            }
        }

  
    }
}
