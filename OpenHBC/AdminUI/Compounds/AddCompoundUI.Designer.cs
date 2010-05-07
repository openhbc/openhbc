namespace OpenHBC.AdminUI.Compounds
{
    partial class AddCompoundUI
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
            this.lblCompounds = new System.Windows.Forms.Label();
            this.lblCompoundId = new System.Windows.Forms.Label();
            this.lblCompoundName = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtCompoundName = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveCompound = new System.Windows.Forms.Button();
            this.cbxSection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxParish = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompounds
            // 
            this.lblCompounds.AutoSize = true;
            this.lblCompounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompounds.Location = new System.Drawing.Point(315, 34);
            this.lblCompounds.Name = "lblCompounds";
            this.lblCompounds.Size = new System.Drawing.Size(169, 31);
            this.lblCompounds.TabIndex = 0;
            this.lblCompounds.Text = "Compounds";
            // 
            // lblCompoundId
            // 
            this.lblCompoundId.AutoSize = true;
            this.lblCompoundId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompoundId.Location = new System.Drawing.Point(106, 134);
            this.lblCompoundId.Name = "lblCompoundId";
            this.lblCompoundId.Size = new System.Drawing.Size(0, 24);
            this.lblCompoundId.TabIndex = 1;
            this.lblCompoundId.Visible = false;
            // 
            // lblCompoundName
            // 
            this.lblCompoundName.AutoSize = true;
            this.lblCompoundName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompoundName.Location = new System.Drawing.Point(106, 195);
            this.lblCompoundName.Name = "lblCompoundName";
            this.lblCompoundName.Size = new System.Drawing.Size(174, 24);
            this.lblCompoundName.TabIndex = 2;
            this.lblCompoundName.Text = "Compound Name";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(171, 250);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(109, 24);
            this.lblComments.TabIndex = 3;
            this.lblComments.Text = "Comments";
            // 
            // txtCompoundName
            // 
            this.txtCompoundName.Enabled = false;
            this.txtCompoundName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompoundName.Location = new System.Drawing.Point(321, 198);
            this.txtCompoundName.Name = "txtCompoundName";
            this.txtCompoundName.Size = new System.Drawing.Size(214, 29);
            this.txtCompoundName.TabIndex = 4;
            // 
            // txtComments
            // 
            this.txtComments.Enabled = false;
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(321, 250);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(334, 122);
            this.txtComments.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(545, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 46);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveCompound
            // 
            this.btnSaveCompound.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveCompound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCompound.ForeColor = System.Drawing.Color.White;
            this.btnSaveCompound.Location = new System.Drawing.Point(321, 394);
            this.btnSaveCompound.Name = "btnSaveCompound";
            this.btnSaveCompound.Size = new System.Drawing.Size(178, 47);
            this.btnSaveCompound.TabIndex = 11;
            this.btnSaveCompound.Text = "Save Compound";
            this.btnSaveCompound.UseVisualStyleBackColor = false;
            this.btnSaveCompound.Click += new System.EventHandler(this.btnSaveCompound_Click);
            // 
            // cbxSection
            // 
            this.cbxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSection.Enabled = false;
            this.cbxSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSection.Location = new System.Drawing.Point(321, 142);
            this.cbxSection.Name = "cbxSection";
            this.cbxSection.Size = new System.Drawing.Size(252, 32);
            this.cbxSection.TabIndex = 26;
            this.cbxSection.SelectedIndexChanged += new System.EventHandler(this.cbxSection_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Section Name";
            // 
            // cbxParish
            // 
            this.cbxParish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxParish.Location = new System.Drawing.Point(321, 90);
            this.cbxParish.Name = "cbxParish";
            this.cbxParish.Size = new System.Drawing.Size(252, 32);
            this.cbxParish.TabIndex = 28;
            this.cbxParish.SelectedIndexChanged += new System.EventHandler(this.cbxParish_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Parish Name";
            // 
            // AddCompoundUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxParish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveCompound);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtCompoundName);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblCompoundName);
            this.Controls.Add(this.lblCompoundId);
            this.Controls.Add(this.lblCompounds);
            this.Name = "AddCompoundUI";
            this.Size = new System.Drawing.Size(889, 507);
            this.Load += new System.EventHandler(this.AddCompoundUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompounds;
        private System.Windows.Forms.Label lblCompoundId;
        private System.Windows.Forms.Label lblCompoundName;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtCompoundName;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveCompound;
        private System.Windows.Forms.ComboBox cbxSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxParish;
        private System.Windows.Forms.Label label1;
    }
}
