namespace OpenHBC.AdminUI.SiteConfig
{
    partial class SiteConfigUI
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
            this.components = new System.ComponentModel.Container();
            this.lbSiteName = new System.Windows.Forms.Label();
            this.cbxSitesName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSiteComments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiteCode = new System.Windows.Forms.TextBox();
            this.tooltipSiteCodeDesc = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSiteName
            // 
            this.lbSiteName.AutoSize = true;
            this.lbSiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSiteName.Location = new System.Drawing.Point(117, 120);
            this.lbSiteName.Name = "lbSiteName";
            this.lbSiteName.Size = new System.Drawing.Size(69, 13);
            this.lbSiteName.TabIndex = 0;
            this.lbSiteName.Text = "Site Name:";
            // 
            // cbxSitesName
            // 
            this.cbxSitesName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSitesName.Location = new System.Drawing.Point(230, 117);
            this.cbxSitesName.Name = "cbxSitesName";
            this.cbxSitesName.Size = new System.Drawing.Size(233, 21);
            this.cbxSitesName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site Comments:";
            // 
            // txtSiteComments
            // 
            this.txtSiteComments.Location = new System.Drawing.Point(232, 208);
            this.txtSiteComments.MaxLength = 200;
            this.txtSiteComments.Multiline = true;
            this.txtSiteComments.Name = "txtSiteComments";
            this.txtSiteComments.Size = new System.Drawing.Size(231, 111);
            this.txtSiteComments.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Site Code:";
            this.tooltipSiteCodeDesc.SetToolTip(this.label2, "This code will be used to prefix the client identification number");
            // 
            // txtSiteCode
            // 
            this.txtSiteCode.Location = new System.Drawing.Point(230, 170);
            this.txtSiteCode.MaxLength = 100;
            this.txtSiteCode.Name = "txtSiteCode";
            this.txtSiteCode.ReadOnly = true;
            this.txtSiteCode.Size = new System.Drawing.Size(233, 20);
            this.txtSiteCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Site Configuration";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(136, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 59);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(319, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 59);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SiteConfigUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSiteCode);
            this.Controls.Add(this.txtSiteComments);
            this.Controls.Add(this.cbxSitesName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSiteName);
            this.Name = "SiteConfigUI";
            this.Size = new System.Drawing.Size(736, 558);
            this.Load += new System.EventHandler(this.SiteConfigUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSiteName;
        private System.Windows.Forms.ComboBox cbxSitesName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSiteComments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip tooltipSiteCodeDesc;
        private System.Windows.Forms.TextBox txtSiteCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
