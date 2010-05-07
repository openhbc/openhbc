namespace OpenHBC
{
    partial class ReportsBrowser
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPainManagement = new System.Windows.Forms.Button();
            this.btnAllPatients = new System.Windows.Forms.Button();
            this.btnConfirmedStatus = new System.Windows.Forms.Button();
            this.btnFemalePatients = new System.Windows.Forms.Button();
            this.btnMalePatients = new System.Windows.Forms.Button();
            this.btnPatientsUnder15 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmedStatusUnder15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(352, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reports";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(35, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 44);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Back to Menu";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPainManagement
            // 
            this.btnPainManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPainManagement.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnPainManagement.Location = new System.Drawing.Point(492, 126);
            this.btnPainManagement.Name = "btnPainManagement";
            this.btnPainManagement.Size = new System.Drawing.Size(292, 46);
            this.btnPainManagement.TabIndex = 12;
            this.btnPainManagement.Text = "Pain Management";
            this.btnPainManagement.UseVisualStyleBackColor = true;
            this.btnPainManagement.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // btnAllPatients
            // 
            this.btnAllPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllPatients.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnAllPatients.Location = new System.Drawing.Point(99, 126);
            this.btnAllPatients.Name = "btnAllPatients";
            this.btnAllPatients.Size = new System.Drawing.Size(276, 46);
            this.btnAllPatients.TabIndex = 13;
            this.btnAllPatients.Text = "All Patients";
            this.btnAllPatients.UseVisualStyleBackColor = true;
            this.btnAllPatients.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // btnConfirmedStatus
            // 
            this.btnConfirmedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmedStatus.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnConfirmedStatus.Location = new System.Drawing.Point(492, 192);
            this.btnConfirmedStatus.Name = "btnConfirmedStatus";
            this.btnConfirmedStatus.Size = new System.Drawing.Size(292, 46);
            this.btnConfirmedStatus.TabIndex = 14;
            this.btnConfirmedStatus.Text = "Confirmed HIV+";
            this.btnConfirmedStatus.UseVisualStyleBackColor = true;
            this.btnConfirmedStatus.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // btnFemalePatients
            // 
            this.btnFemalePatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFemalePatients.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnFemalePatients.Location = new System.Drawing.Point(99, 192);
            this.btnFemalePatients.Name = "btnFemalePatients";
            this.btnFemalePatients.Size = new System.Drawing.Size(276, 46);
            this.btnFemalePatients.TabIndex = 15;
            this.btnFemalePatients.Text = "Female Patients";
            this.btnFemalePatients.UseVisualStyleBackColor = true;
            this.btnFemalePatients.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // btnMalePatients
            // 
            this.btnMalePatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMalePatients.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnMalePatients.Location = new System.Drawing.Point(99, 256);
            this.btnMalePatients.Name = "btnMalePatients";
            this.btnMalePatients.Size = new System.Drawing.Size(276, 46);
            this.btnMalePatients.TabIndex = 16;
            this.btnMalePatients.Text = "Male Patients";
            this.btnMalePatients.UseVisualStyleBackColor = true;
            this.btnMalePatients.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // btnPatientsUnder15
            // 
            this.btnPatientsUnder15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientsUnder15.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnPatientsUnder15.Location = new System.Drawing.Point(99, 320);
            this.btnPatientsUnder15.Name = "btnPatientsUnder15";
            this.btnPatientsUnder15.Size = new System.Drawing.Size(276, 46);
            this.btnPatientsUnder15.TabIndex = 17;
            this.btnPatientsUnder15.Text = "Patients Under 15 yrs";
            this.btnPatientsUnder15.UseVisualStyleBackColor = true;
            this.btnPatientsUnder15.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select the report you want to create";
            // 
            // btnConfirmedStatusUnder15
            // 
            this.btnConfirmedStatusUnder15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmedStatusUnder15.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnConfirmedStatusUnder15.Location = new System.Drawing.Point(492, 256);
            this.btnConfirmedStatusUnder15.Name = "btnConfirmedStatusUnder15";
            this.btnConfirmedStatusUnder15.Size = new System.Drawing.Size(292, 46);
            this.btnConfirmedStatusUnder15.TabIndex = 19;
            this.btnConfirmedStatusUnder15.Text = "Under 15 yrs Confirmed HIV+";
            this.btnConfirmedStatusUnder15.UseVisualStyleBackColor = true;
            this.btnConfirmedStatusUnder15.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // ReportsBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnConfirmedStatusUnder15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPatientsUnder15);
            this.Controls.Add(this.btnMalePatients);
            this.Controls.Add(this.btnFemalePatients);
            this.Controls.Add(this.btnConfirmedStatus);
            this.Controls.Add(this.btnAllPatients);
            this.Controls.Add(this.btnPainManagement);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Name = "ReportsBrowser";
            this.Size = new System.Drawing.Size(787, 369);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPainManagement;
        private System.Windows.Forms.Button btnAllPatients;
        private System.Windows.Forms.Button btnConfirmedStatus;
        private System.Windows.Forms.Button btnFemalePatients;
        private System.Windows.Forms.Button btnMalePatients;
        private System.Windows.Forms.Button btnPatientsUnder15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmedStatusUnder15;

    }
}
