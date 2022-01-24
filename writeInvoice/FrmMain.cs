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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Desing();
        }
        public void Desing()
        {
            DataModel dm = new DataModel();

            var scope = dm.tblScomeName.ToList();
            int lblX = 22;
            int lblY = 61;
            Label[] lbl = new Label[scope.Count];
            int i = 0;
            foreach (var item in scope)
            { 
                lbl[i]=new Label(); 
                lbl[i].AutoSize = true;
                lbl[i].Text = item.Name;
                lbl[i].Location = new Point(lblX,lblY);
                lbl[i].Name= "lbl"+item.Name;    
                this.Controls.Add(lbl[i]);
                lblY += 27;
            }

        }
    }
}
