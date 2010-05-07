namespace OpenHBC.AdminUI.Compounds
{
    partial class CompoundsUI
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEditCompound = new System.Windows.Forms.Button();
            this.btnDeleteCompound = new System.Windows.Forms.Button();
            this.btnAddCompound = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridCompounds = new System.Windows.Forms.DataGridView();
            this.CompoundName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompoundID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompounds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(769, 344);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 46);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEditCompound
            // 
            this.btnEditCompound.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEditCompound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCompound.ForeColor = System.Drawing.Color.White;
            this.btnEditCompound.Location = new System.Drawing.Point(688, 236);
            this.btnEditCompound.Name = "btnEditCompound";
            this.btnEditCompound.Size = new System.Drawing.Size(191, 47);
            this.btnEditCompound.TabIndex = 19;
            this.btnEditCompound.Text = "Edit Compound";
            this.btnEditCompound.UseVisualStyleBackColor = false;
            this.btnEditCompound.Click += new System.EventHandler(this.btnEditCompound_Click);
            // 
            // btnDeleteCompound
            // 
            this.btnDeleteCompound.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteCompound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCompound.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCompound.Location = new System.Drawing.Point(688, 152);
            this.btnDeleteCompound.Name = "btnDeleteCompound";
            this.btnDeleteCompound.Size = new System.Drawing.Size(191, 47);
            this.btnDeleteCompound.TabIndex = 18;
            this.btnDeleteCompound.Text = "Delete Compound";
            this.btnDeleteCompound.UseVisualStyleBackColor = false;
            this.btnDeleteCompound.Click += new System.EventHandler(this.btnDeleteCompound_Click);
            // 
            // btnAddCompound
            // 
            this.btnAddCompound.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddCompound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCompound.ForeColor = System.Drawing.Color.White;
            this.btnAddCompound.Location = new System.Drawing.Point(688, 73);
            this.btnAddCompound.Name = "btnAddCompound";
            this.btnAddCompound.Size = new System.Drawing.Size(191, 47);
            this.btnAddCompound.TabIndex = 17;
            this.btnAddCompound.Text = "Add Compound";
            this.btnAddCompound.UseVisualStyleBackColor = false;
            this.btnAddCompound.Click += new System.EventHandler(this.btnAddCompound_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Compounds";
            // 
            // dataGridCompounds
            // 
            this.dataGridCompounds.AllowUserToAddRows = false;
            this.dataGridCompounds.AllowUserToDeleteRows = false;
            this.dataGridCompounds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompounds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompoundName,
            this.SectionName,
            this.Comments,
            this.CompoundID});
            this.dataGridCompounds.Location = new System.Drawing.Point(56, 73);
            this.dataGridCompounds.MultiSelect = false;
            this.dataGridCompounds.Name = "dataGridCompounds";
            this.dataGridCompounds.ReadOnly = true;
            this.dataGridCompounds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCompounds.Size = new System.Drawing.Size(593, 317);
            this.dataGridCompounds.TabIndex = 22;
            this.dataGridCompounds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCompounds_CellContentClick);
            // 
            // CompoundName
            // 
            this.CompoundName.HeaderText = "Compound Name";
            this.CompoundName.Name = "CompoundName";
            this.CompoundName.ReadOnly = true;
            this.CompoundName.Width = 150;
            // 
            // SectionName
            // 
            this.SectionName.HeaderText = "Section Name";
            this.SectionName.Name = "SectionName";
            this.SectionName.ReadOnly = true;
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Width = 300;
            // 
            // CompoundID
            // 
            this.CompoundID.HeaderText = "CompoundID";
            this.CompoundID.Name = "CompoundID";
            this.CompoundID.ReadOnly = true;
            this.CompoundID.Visible = false;
            // 
            // CompoundsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridCompounds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEditCompound);
            this.Controls.Add(this.btnDeleteCompound);
            this.Controls.Add(this.btnAddCompound);
            this.Name = "CompoundsUI";
            this.Size = new System.Drawing.Size(927, 489);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEditCompound;
        private System.Windows.Forms.Button btnDeleteCompound;
        private System.Windows.Forms.Button btnAddCompound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridCompounds;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompoundName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompoundID;
    }
}
