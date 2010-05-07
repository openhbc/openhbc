namespace OpenHBC.AdminUI.Sections
{
    partial class SectionsUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSections = new System.Windows.Forms.Label();
            this.dataGridSections = new System.Windows.Forms.DataGridView();
            this.SectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.btnDeleteSection = new System.Windows.Forms.Button();
            this.btnEditSection = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSections)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSections
            // 
            this.lblSections.AutoSize = true;
            this.lblSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSections.Location = new System.Drawing.Point(263, 35);
            this.lblSections.Name = "lblSections";
            this.lblSections.Size = new System.Drawing.Size(135, 33);
            this.lblSections.TabIndex = 5;
            this.lblSections.Text = "Sections";
            this.lblSections.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridSections
            // 
            this.dataGridSections.AllowUserToAddRows = false;
            this.dataGridSections.AllowUserToDeleteRows = false;
            this.dataGridSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SectionName,
            this.SiteName,
            this.Comments,
            this.SectionId});
            this.dataGridSections.Location = new System.Drawing.Point(68, 110);
            this.dataGridSections.MultiSelect = false;
            this.dataGridSections.Name = "dataGridSections";
            this.dataGridSections.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSections.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSections.Size = new System.Drawing.Size(593, 317);
            this.dataGridSections.TabIndex = 4;
            // 
            // SectionName
            // 
            this.SectionName.HeaderText = "Name";
            this.SectionName.Name = "SectionName";
            this.SectionName.ReadOnly = true;
            this.SectionName.Width = 150;
            // 
            // SiteName
            // 
            this.SiteName.HeaderText = "Site/Parish Name";
            this.SiteName.MinimumWidth = 15;
            this.SiteName.Name = "SiteName";
            this.SiteName.ReadOnly = true;
            this.SiteName.Width = 150;
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Width = 400;
            // 
            // SectionId
            // 
            this.SectionId.HeaderText = "Section Id";
            this.SectionId.Name = "SectionId";
            this.SectionId.ReadOnly = true;
            this.SectionId.Visible = false;
            // 
            // btnAddSection
            // 
            this.btnAddSection.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSection.ForeColor = System.Drawing.Color.White;
            this.btnAddSection.Location = new System.Drawing.Point(699, 110);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(171, 47);
            this.btnAddSection.TabIndex = 0;
            this.btnAddSection.Text = "Add Section";
            this.btnAddSection.UseVisualStyleBackColor = false;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // btnDeleteSection
            // 
            this.btnDeleteSection.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSection.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSection.Location = new System.Drawing.Point(699, 189);
            this.btnDeleteSection.Name = "btnDeleteSection";
            this.btnDeleteSection.Size = new System.Drawing.Size(171, 47);
            this.btnDeleteSection.TabIndex = 1;
            this.btnDeleteSection.Text = "Delete Section";
            this.btnDeleteSection.UseVisualStyleBackColor = false;
            this.btnDeleteSection.Click += new System.EventHandler(this.btnDeleteSection_Click);
            // 
            // btnEditSection
            // 
            this.btnEditSection.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEditSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSection.ForeColor = System.Drawing.Color.White;
            this.btnEditSection.Location = new System.Drawing.Point(699, 273);
            this.btnEditSection.Name = "btnEditSection";
            this.btnEditSection.Size = new System.Drawing.Size(171, 47);
            this.btnEditSection.TabIndex = 2;
            this.btnEditSection.Text = "Edit Section";
            this.btnEditSection.UseVisualStyleBackColor = false;
            this.btnEditSection.Click += new System.EventHandler(this.btnEditSection_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(760, 381);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 46);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SectionsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEditSection);
            this.Controls.Add(this.btnDeleteSection);
            this.Controls.Add(this.btnAddSection);
            this.Controls.Add(this.dataGridSections);
            this.Controls.Add(this.lblSections);
            this.Name = "SectionsUI";
            this.Size = new System.Drawing.Size(908, 467);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSections;
        private System.Windows.Forms.DataGridView dataGridSections;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.Button btnDeleteSection;
        private System.Windows.Forms.Button btnEditSection;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionId;
    }
}
