namespace OpenHBC
{
    partial class ReportPainManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBackToReportList = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.testdataset1 = new OpenHBC.rpt_pmgt_patients();
            this.SuspendLayout();
            // 
            // btnBackToReportList
            // 
            this.btnBackToReportList.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBackToReportList.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToReportList.ForeColor = System.Drawing.Color.White;
            this.btnBackToReportList.Location = new System.Drawing.Point(30, 3);
            this.btnBackToReportList.Name = "btnBackToReportList";
            this.btnBackToReportList.Size = new System.Drawing.Size(134, 51);
            this.btnBackToReportList.TabIndex = 3;
            this.btnBackToReportList.Text = "Back";
            this.btnBackToReportList.UseVisualStyleBackColor = false;
            this.btnBackToReportList.Click += new System.EventHandler(this.btnBackToReportList_Click_1);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.AutoSize = true;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.DisplayBackgroundEdge = false;
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(30, 60);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.testdataset1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1113, 581);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // ReportPainManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnBackToReportList);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ReportPainManagement";
            this.Size = new System.Drawing.Size(1159, 672);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private rpt_pmgt_patients testdataset1;
        private System.Windows.Forms.Button btnBackToReportList;
    }
}
