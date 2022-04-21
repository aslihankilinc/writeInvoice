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
        public static int documentNo;
        public static int startPage;
        public FrmHome()
        {
            InitializeComponent();

            DataModel dm = new DataModel();
            documentNo = dm.tblDocument.FirstOrDefault().No;
            cmbScome.DataSource = dm.tblDocument.ToList();
            cmbScome.DisplayMember = "Name";
            cmbScome.ValueMember = "No";
        }

        private void btnDesing_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            startPage=Convert.ToInt32(nmStartNo.Value);
            DialogResult p = printDialog1.ShowDialog();
            if (p == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataModel dm = new DataModel();
            var doc = dm.tblDocument.Where(w => w.No == documentNo).FirstOrDefault();
            

            System.Drawing.Font font = new System.Drawing.Font((doc.FontFamily==null?"Times New Roman": doc.FontFamily.ToString()), Convert.ToInt32(doc.FontSize));
            SolidBrush sb = new SolidBrush(System.Drawing.Color.Black);
            Pen pen = new Pen(System.Drawing.Color.Black);
            if (doc.No == 1)
            {
                startPage = Convert.ToInt32(nmStartNo.Value);
                var writeLst = dm.tblCeki.Where(w => w.No >= startPage).ToList();
                foreach (var item in writeLst)
                {

                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;
                    e.Graphics.DrawString(doc.Head, font, sb, ClientRectangle,sf);
                    e.HasMorePages = true;

                    int headY = 0;
                    foreach (var scome in doc.tblScomeName.OrderBy(o=>o.Order).ToList())
                    {
                        
                        foreach (var head in scome.tblHeader.ToList())
                        {
                            if (head.Left != 0 && head.Top != 0)
                            {
                                
                                e.Graphics.DrawString(scome.Description, font, sb, Convert.ToInt32(head.Left), Convert.ToInt32(head.Top+headY));
                                headY += Convert.ToInt32(head.Top);
                            }
                        }
                    }
                }
                e.HasMorePages = false;

            }


        }

        private void cmbScome_SelectedIndexChanged(object sender, EventArgs e)
        {
            documentNo = Convert.ToInt32(((tblDocument)cmbScome.SelectedItem).No);
        }
    }
}
