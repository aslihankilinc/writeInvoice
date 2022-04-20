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

        public static int documentNo;
        public FrmMain()
        {
            InitializeComponent();

            DataModel dm = new DataModel();
            documentNo = dm.tblDocument.FirstOrDefault().No;
            cmbScome.DataSource = dm.tblDocument.ToList();
            cmbScome.DisplayMember = "Name";
            cmbScome.ValueMember = "No";
            Desing();

        }

        public void Desing()
        {
            DataModel dm = new DataModel();

            var scope = dm.tblScomeName.Where(w => w.DocumentNo == documentNo).ToList();
            int lblX = 32;
            int lblY = 110;
            int chkX = 12;
            int chkY = 110;
            int nmHeadLeftX = 294;
            int nmHeadLeftY = 110;
            int nmHeadTopX = 456;
            int nmHeadTopY = 110;
            int nmBodyLeftX = 574;
            int nmBodyLeftY = 110;
            int nmBodyTopX = 739;
            int nmBodyTopY = 110;
            Label[] lbl = new Label[scope.Count];
            CheckBox[] chk = new CheckBox[scope.Count];
            NumericUpDown[] nmHeadLeft = new NumericUpDown[scope.Count];
            NumericUpDown[] nmHeadTop = new NumericUpDown[scope.Count];
            NumericUpDown[] nmBodyLeft = new NumericUpDown[scope.Count];
            NumericUpDown[] nmBodyTop = new NumericUpDown[scope.Count];
            int i = 0;
            foreach (var item in scope)
            {
                lbl[i] = new Label();
                lbl[i].AutoSize = true;
                lbl[i].Text = item.Name;
                lbl[i].Location = new Point(lblX, lblY);
                lbl[i].Name = "lbl" + item.Name;
                this.Controls.Add(lbl[i]);
                lblY += 27;
            }
            foreach (var item in scope)
            {
                chk[i] = new CheckBox();
                chk[i].AutoSize = true;
                chk[i].Text = "";
                chk[i].Location = new Point(chkX, chkY);
                chk[i].Name = item.No.ToString();
                this.Controls.Add(chk[i]);
                chkY += 27;
            }
            foreach (var item in scope)
            {
                nmHeadLeft[i] = new NumericUpDown();
                nmHeadLeft[i].Size = new Size(65, 18);
                nmHeadLeft[i].Location = new Point(nmHeadLeftX, nmHeadLeftY);
                nmHeadLeft[i].Name = "nmHeadLeft" + item.No.ToString();
                this.Controls.Add(nmHeadLeft[i]);
                nmHeadLeftY += 27;
            }
            foreach (var item in scope)
            {
                nmHeadTop[i] = new NumericUpDown();
                nmHeadTop[i].Size = new Size(65, 18);
                nmHeadTop[i].Location = new Point(nmHeadTopX, nmHeadTopY);
                nmHeadTop[i].Name = "nmHeadTop" + item.No.ToString();
                this.Controls.Add(nmHeadTop[i]);
                nmHeadTopY += 27;
            }
            foreach (var item in scope)
            {
                nmBodyLeft[i] = new NumericUpDown();
                nmBodyLeft[i].Size = new Size(65, 18);
                nmBodyLeft[i].Location = new Point(nmBodyLeftX, nmBodyLeftY);
                nmBodyLeft[i].Name = "nmBodyLeft" + item.No.ToString();
                this.Controls.Add(nmBodyLeft[i]);
                nmBodyLeftY += 27;
            }
            foreach (var item in scope)
            {
                nmBodyTop[i] = new NumericUpDown();
                nmBodyTop[i].Size = new Size(65, 18);
                nmBodyTop[i].Location = new Point(nmBodyTopX, nmBodyTopY);
                nmBodyTop[i].Name = "nmBodyTop" + item.No.ToString();
                this.Controls.Add(nmBodyTop[i]);
                nmBodyTopY += 27;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataModel dm = new DataModel();
            var scopeLst = dm.tblScomeName.ToList();
            foreach (var item in scopeLst)
            {
                tblBody body = new tblBody();
                tblHeader head = new tblHeader();
                if (((CheckBox)(Controls[item.No.ToString()])).Checked)
                {
                    body.Left = ((NumericUpDown)this.Controls.Find("nmBodyLeft" + item.No.ToString(), true)[0]).Value;
                    body.Top = ((NumericUpDown)this.Controls.Find("nmBodyTop" + item.No.ToString(), true)[0]).Value;
                    head.Left = ((NumericUpDown)this.Controls.Find("nmHeadLeft" + item.No.ToString(), true)[0]).Value;
                    head.Top = ((NumericUpDown)this.Controls.Find("nmHeadTop" + item.No.ToString(), true)[0]).Value;
                    if (item.tblBody.Count==0)
                    {
                        body.ScomeNo = item.No;
                        dm.tblBody.Add(body);
                    }
                    else
                    {
                        var sBody = item.tblBody.FirstOrDefault();
                        sBody.Left = body.Left;
                        sBody.Top = body.Top;
                        
                    }
                    if (item.tblHeader.Count==0)
                    {
                        head.ScomeNo = item.No;
                        dm.tblHeader.Add(head);
                        
                    }
                    else
                    {
                        var sHead = item.tblHeader.FirstOrDefault();
                        sHead.Left = head.Left;
                        sHead.Top = head.Top;
                    }


                    dm.SaveChanges();

                }
            }
            MessageBox.Show("Başarılı");
            Desing();
        }

        private void cmbScome_SelectedIndexChanged(object sender, EventArgs e)
        {
            documentNo = Convert.ToInt32(((tblDocument)cmbScome.SelectedItem).No);
            Desing();
        }
    }
}
