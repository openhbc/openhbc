namespace OpenHBC.AdminUI.UserRole
{
    partial class RoleSecurityDetailsUI
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
            this.lblRoleSecurityDetails = new System.Windows.Forms.Label();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.txtBxRoleName = new System.Windows.Forms.TextBox();
            this.grpRights = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRoleSecurityDetails
            // 
            this.lblRoleSecurityDetails.AutoSize = true;
            this.lblRoleSecurityDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleSecurityDetails.Location = new System.Drawing.Point(252, 29);
            this.lblRoleSecurityDetails.Name = "lblRoleSecurityDetails";
            this.lblRoleSecurityDetails.Size = new System.Drawing.Size(233, 25);
            this.lblRoleSecurityDetails.TabIndex = 0;
            this.lblRoleSecurityDetails.Text = "Role Security Details";
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleName.Location = new System.Drawing.Point(118, 82);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(86, 16);
            this.lblRoleName.TabIndex = 1;
            this.lblRoleName.Text = "Role Name";
            // 
            // txtBxRoleName
            // 
            this.txtBxRoleName.Location = new System.Drawing.Point(240, 81);
            this.txtBxRoleName.MaxLength = 30;
            this.txtBxRoleName.Name = "txtBxRoleName";
            this.txtBxRoleName.Size = new System.Drawing.Size(179, 20);
            this.txtBxRoleName.TabIndex = 2;
            // 
            // grpRights
            // 
            this.grpRights.Location = new System.Drawing.Point(121, 143);
            this.grpRights.Name = "grpRights";
            this.grpRights.Size = new System.Drawing.Size(463, 323);
            this.grpRights.TabIndex = 3;
            this.grpRights.TabStop = false;
            this.grpRights.Text = "Role Rights";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(450, 496);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 46);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(155, 496);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 46);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // RoleSecurityDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpRights);
            this.Controls.Add(this.txtBxRoleName);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.lblRoleSecurityDetails);
            this.Name = "RoleSecurityDetails";
            this.Size = new System.Drawing.Size(777, 587);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoleSecurityDetails;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.TextBox txtBxRoleName;
        private System.Windows.Forms.GroupBox grpRights;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
