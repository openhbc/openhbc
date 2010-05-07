namespace OpenHBC
{
    partial class PatientSummary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxBioSummary = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtDateofbirth = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewVisit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicalFindings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.txtClinicalFindings = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditVisit = new System.Windows.Forms.Button();
            this.btnDeleteVisit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxBioSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(526, 606);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Visit Details";
            // 
            // gbxBioSummary
            // 
            this.gbxBioSummary.BackColor = System.Drawing.Color.Transparent;
            this.gbxBioSummary.Controls.Add(this.btnEdit);
            this.gbxBioSummary.Controls.Add(this.txtGender);
            this.gbxBioSummary.Controls.Add(this.txtDateofbirth);
            this.gbxBioSummary.Controls.Add(this.txtMiddleName);
            this.gbxBioSummary.Controls.Add(this.txtSurname);
            this.gbxBioSummary.Controls.Add(this.txtFirstName);
            this.gbxBioSummary.Controls.Add(this.label6);
            this.gbxBioSummary.Controls.Add(this.label5);
            this.gbxBioSummary.Controls.Add(this.label4);
            this.gbxBioSummary.Controls.Add(this.label3);
            this.gbxBioSummary.Controls.Add(this.label2);
            this.gbxBioSummary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBioSummary.Location = new System.Drawing.Point(14, 51);
            this.gbxBioSummary.Name = "gbxBioSummary";
            this.gbxBioSummary.Size = new System.Drawing.Size(496, 257);
            this.gbxBioSummary.TabIndex = 2;
            this.gbxBioSummary.TabStop = false;
            this.gbxBioSummary.Text = "Registration Summary Information";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(148, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(225, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Registration Details";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.White;
            this.txtGender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGender.Enabled = false;
            this.txtGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.Color.Black;
            this.txtGender.Location = new System.Drawing.Point(194, 214);
            this.txtGender.MaxLength = 60;
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(168, 26);
            this.txtGender.TabIndex = 6;
            this.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGender.WordWrap = false;
            // 
            // txtDateofbirth
            // 
            this.txtDateofbirth.BackColor = System.Drawing.Color.White;
            this.txtDateofbirth.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDateofbirth.Enabled = false;
            this.txtDateofbirth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateofbirth.ForeColor = System.Drawing.Color.Black;
            this.txtDateofbirth.Location = new System.Drawing.Point(194, 181);
            this.txtDateofbirth.Name = "txtDateofbirth";
            this.txtDateofbirth.ReadOnly = true;
            this.txtDateofbirth.Size = new System.Drawing.Size(168, 26);
            this.txtDateofbirth.TabIndex = 5;
            this.txtDateofbirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDateofbirth.WordWrap = false;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.White;
            this.txtMiddleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMiddleName.Enabled = false;
            this.txtMiddleName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.ForeColor = System.Drawing.Color.Black;
            this.txtMiddleName.Location = new System.Drawing.Point(194, 141);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.ReadOnly = true;
            this.txtMiddleName.Size = new System.Drawing.Size(168, 26);
            this.txtMiddleName.TabIndex = 4;
            this.txtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiddleName.WordWrap = false;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.White;
            this.txtSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSurname.Enabled = false;
            this.txtSurname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.Black;
            this.txtSurname.Location = new System.Drawing.Point(194, 105);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(168, 26);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSurname.WordWrap = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(194, 69);
            this.txtFirstName.MaxLength = 60;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(168, 26);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstName.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // btnNewVisit
            // 
            this.btnNewVisit.BackColor = System.Drawing.Color.MediumBlue;
            this.btnNewVisit.Enabled = false;
            this.btnNewVisit.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btnNewVisit.FlatAppearance.BorderSize = 2;
            this.btnNewVisit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewVisit.Location = new System.Drawing.Point(559, 463);
            this.btnNewVisit.Name = "btnNewVisit";
            this.btnNewVisit.Size = new System.Drawing.Size(125, 41);
            this.btnNewVisit.TabIndex = 7;
            this.btnNewVisit.Text = "&New Visit";
            this.btnNewVisit.UseVisualStyleBackColor = false;
            this.btnNewVisit.Click += new System.EventHandler(this.btnNewVisit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateOfVisit,
            this.clinicalFindings,
            this.comments,
            this.visitId});
            this.dataGridView1.Location = new System.Drawing.Point(559, 69);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(424, 385);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.visitsGrid_SelectionChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateOfVisit
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfVisit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateOfVisit.HeaderText = "Date Of Visit";
            this.dateOfVisit.Name = "dateOfVisit";
            this.dateOfVisit.ReadOnly = true;
            this.dateOfVisit.Width = 110;
            // 
            // clinicalFindings
            // 
            this.clinicalFindings.HeaderText = "Visit Type";
            this.clinicalFindings.Name = "clinicalFindings";
            this.clinicalFindings.ReadOnly = true;
            this.clinicalFindings.Width = 120;
            // 
            // comments
            // 
            this.comments.HeaderText = "User";
            this.comments.Name = "comments";
            this.comments.ReadOnly = true;
            this.comments.Width = 120;
            // 
            // visitId
            // 
            this.visitId.HeaderText = "visitId";
            this.visitId.Name = "visitId";
            this.visitId.ReadOnly = true;
            this.visitId.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.txtTreatment);
            this.groupBox2.Controls.Add(this.txtClinicalFindings);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(14, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 272);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.Enabled = false;
            this.txtRemarks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.ForeColor = System.Drawing.Color.Black;
            this.txtRemarks.Location = new System.Drawing.Point(121, 206);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.Size = new System.Drawing.Size(358, 54);
            this.txtRemarks.TabIndex = 1;
            // 
            // txtTreatment
            // 
            this.txtTreatment.BackColor = System.Drawing.Color.White;
            this.txtTreatment.Enabled = false;
            this.txtTreatment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreatment.ForeColor = System.Drawing.Color.Black;
            this.txtTreatment.Location = new System.Drawing.Point(121, 145);
            this.txtTreatment.Multiline = true;
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.ReadOnly = true;
            this.txtTreatment.Size = new System.Drawing.Size(358, 49);
            this.txtTreatment.TabIndex = 1;
            // 
            // txtClinicalFindings
            // 
            this.txtClinicalFindings.BackColor = System.Drawing.Color.White;
            this.txtClinicalFindings.Enabled = false;
            this.txtClinicalFindings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicalFindings.ForeColor = System.Drawing.Color.Black;
            this.txtClinicalFindings.Location = new System.Drawing.Point(121, 68);
            this.txtClinicalFindings.Multiline = true;
            this.txtClinicalFindings.Name = "txtClinicalFindings";
            this.txtClinicalFindings.ReadOnly = true;
            this.txtClinicalFindings.Size = new System.Drawing.Size(358, 56);
            this.txtClinicalFindings.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "Comments";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Comments";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Treatment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Clinical Findings";
            // 
            // btnEditVisit
            // 
            this.btnEditVisit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditVisit.Enabled = false;
            this.btnEditVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditVisit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditVisit.ForeColor = System.Drawing.Color.White;
            this.btnEditVisit.Location = new System.Drawing.Point(729, 463);
            this.btnEditVisit.Name = "btnEditVisit";
            this.btnEditVisit.Size = new System.Drawing.Size(123, 41);
            this.btnEditVisit.TabIndex = 8;
            this.btnEditVisit.Text = "Edit Visit";
            this.btnEditVisit.UseVisualStyleBackColor = false;
            this.btnEditVisit.Click += new System.EventHandler(this.btnEditVisit_Click);
            // 
            // btnDeleteVisit
            // 
            this.btnDeleteVisit.BackColor = System.Drawing.Color.Red;
            this.btnDeleteVisit.Enabled = false;
            this.btnDeleteVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVisit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVisit.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVisit.Location = new System.Drawing.Point(858, 463);
            this.btnDeleteVisit.Name = "btnDeleteVisit";
            this.btnDeleteVisit.Size = new System.Drawing.Size(125, 41);
            this.btnDeleteVisit.TabIndex = 9;
            this.btnDeleteVisit.Text = "Delete Visit";
            this.btnDeleteVisit.UseVisualStyleBackColor = false;
            this.btnDeleteVisit.Click += new System.EventHandler(this.btnDeleteVisit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(590, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Visit History";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(14, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 42);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PatientSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteVisit);
            this.Controls.Add(this.btnEditVisit);
            this.Controls.Add(this.btnNewVisit);
            this.Controls.Add(this.gbxBioSummary);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label11);
            this.Name = "PatientSummary";
            this.Size = new System.Drawing.Size(999, 606);
            this.Load += new System.EventHandler(this.PatientSummary_Load);
            this.gbxBioSummary.ResumeLayout(false);
            this.gbxBioSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxBioSummary;
        private System.Windows.Forms.Button btnNewVisit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtDateofbirth;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.TextBox txtClinicalFindings;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEditVisit;
        private System.Windows.Forms.Button btnDeleteVisit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicalFindings;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitId;
    }
}
