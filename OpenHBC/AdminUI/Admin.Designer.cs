namespace OpenHBC.AdminUI
{
    partial class Admin
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
            this.lblAdministration = new System.Windows.Forms.Label();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.btnSections = new System.Windows.Forms.Button();
            this.btnCompounds = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdministration
            // 
            this.lblAdministration.AutoSize = true;
            this.lblAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministration.Location = new System.Drawing.Point(258, 56);
            this.lblAdministration.Name = "lblAdministration";
            this.lblAdministration.Size = new System.Drawing.Size(162, 25);
            this.lblAdministration.TabIndex = 0;
            this.lblAdministration.Text = "Administration";
            // 
            // btnSecurity
            // 
            this.btnSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecurity.Location = new System.Drawing.Point(392, 123);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Size = new System.Drawing.Size(173, 51);
            this.btnSecurity.TabIndex = 1;
            this.btnSecurity.Text = "Security";
            this.btnSecurity.UseVisualStyleBackColor = true;
            this.btnSecurity.Click += new System.EventHandler(this.btnSecurity_Click);
            // 
            // btnSections
            // 
            this.btnSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSections.Location = new System.Drawing.Point(392, 257);
            this.btnSections.Name = "btnSections";
            this.btnSections.Size = new System.Drawing.Size(173, 51);
            this.btnSections.TabIndex = 1;
            this.btnSections.Text = "Sections";
            this.btnSections.UseVisualStyleBackColor = true;
            this.btnSections.Click += new System.EventHandler(this.btnSections_Click);
            // 
            // btnCompounds
            // 
            this.btnCompounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompounds.Location = new System.Drawing.Point(111, 257);
            this.btnCompounds.Name = "btnCompounds";
            this.btnCompounds.Size = new System.Drawing.Size(172, 51);
            this.btnCompounds.TabIndex = 1;
            this.btnCompounds.Text = "Compounds";
            this.btnCompounds.UseVisualStyleBackColor = true;
            this.btnCompounds.Click += new System.EventHandler(this.btnCompounds_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(111, 123);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(172, 51);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(240, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 44);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Back to Main Menu";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnCompounds);
            this.Controls.Add(this.btnSections);
            this.Controls.Add(this.btnSecurity);
            this.Controls.Add(this.lblAdministration);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(713, 551);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdministration;
        private System.Windows.Forms.Button btnSecurity;
        private System.Windows.Forms.Button btnSections;
        private System.Windows.Forms.Button btnCompounds;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCancel;
    }
}
