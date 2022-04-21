namespace writeInvoice
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.btnDesing = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnWrite = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnProperties = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.cmbScome = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmStartNo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmStartNo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesing
            // 
            this.btnDesing.BackColor = System.Drawing.Color.IndianRed;
            this.btnDesing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDesing.Location = new System.Drawing.Point(345, 121);
            this.btnDesing.Name = "btnDesing";
            this.btnDesing.Size = new System.Drawing.Size(105, 42);
            this.btnDesing.TabIndex = 0;
            this.btnDesing.Text = "Desing";
            this.btnDesing.UseVisualStyleBackColor = false;
            this.btnDesing.Click += new System.EventHandler(this.btnDesing_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreview.Location = new System.Drawing.Point(12, 121);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(105, 42);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWrite.Location = new System.Drawing.Point(234, 121);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(105, 42);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // btnProperties
            // 
            this.btnProperties.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProperties.Location = new System.Drawing.Point(123, 121);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(105, 42);
            this.btnProperties.TabIndex = 4;
            this.btnProperties.Text = "Properties";
            this.btnProperties.UseCompatibleTextRendering = true;
            this.btnProperties.UseVisualStyleBackColor = false;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // cmbScome
            // 
            this.cmbScome.FormattingEnabled = true;
            this.cmbScome.Location = new System.Drawing.Point(130, 12);
            this.cmbScome.Name = "cmbScome";
            this.cmbScome.Size = new System.Drawing.Size(307, 21);
            this.cmbScome.TabIndex = 15;
            this.cmbScome.SelectedIndexChanged += new System.EventHandler(this.cmbScome_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Document     :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Starting  No  :";
            // 
            // nmStartNo
            // 
            this.nmStartNo.Location = new System.Drawing.Point(131, 51);
            this.nmStartNo.Name = "nmStartNo";
            this.nmStartNo.Size = new System.Drawing.Size(120, 20);
            this.nmStartNo.TabIndex = 18;
            this.nmStartNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 172);
            this.Controls.Add(this.nmStartNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbScome);
            this.Controls.Add(this.btnProperties);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnDesing);
            this.Name = "FrmHome";
            this.Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.nmStartNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesing;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ComboBox cmbScome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmStartNo;
    }
}