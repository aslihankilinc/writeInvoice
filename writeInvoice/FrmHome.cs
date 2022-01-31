using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
