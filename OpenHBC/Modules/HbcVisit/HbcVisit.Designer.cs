namespace OpenHBC
{
    partial class HbcVisit
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpVisitDate = new System.Windows.Forms.DateTimePicker();
            this.chkbxConfirmedPositive = new System.Windows.Forms.CheckBox();
            this.chkbxCounseled = new System.Windows.Forms.CheckBox();
            this.chkbxOnArt = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkbxConfirmedNegative = new System.Windows.Forms.CheckBox();
            this.gpbxIsClientAdhering = new System.Windows.Forms.GroupBox();
            this.chkbxAdheranceCounselling = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdIsAdheringNo = new System.Windows.Forms.RadioButton();
            this.rdIsAdheringYes = new System.Windows.Forms.RadioButton();
            this.chkbxReceivedSupp = new System.Windows.Forms.CheckBox();
            this.txtClinicalFindings = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.chkbxPainMgmnt = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReferPMgt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboNameOfSuppliment = new System.Windows.Forms.ComboBox();
            this.dtpDied = new System.Windows.Forms.DateTimePicker();
            this.chkbxDied = new System.Windows.Forms.CheckBox();
            this.lblDied = new System.Windows.Forms.Label();
            this.grpDischargeOrTranfer = new System.Windows.Forms.GroupBox();
            this.rdRefer = new System.Windows.Forms.RadioButton();
            this.rdTransfer = new System.Windows.Forms.RadioButton();
            this.rdDischarge = new System.Windows.Forms.RadioButton();
            this.txtRefer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTransferedto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameOfSupplement = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gpbxIsClientAdhering.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpDischargeOrTranfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clinical Findings";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(894, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 46);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(725, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Care Visit";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(-1, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 10);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date";
            // 
            // dtpVisitDate
            // 
            this.dtpVisitDate.Enabled = false;
            this.dtpVisitDate.Font = new System.Drawing.Font("Arial", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVisitDate.Location = new System.Drawing.Point(113, 104);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.Size = new System.Drawing.Size(227, 29);
            this.dtpVisitDate.TabIndex = 1;
            this.dtpVisitDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chkbxConfirmedPositive
            // 
            this.chkbxConfirmedPositive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxConfirmedPositive.Location = new System.Drawing.Point(149, 24);
            this.chkbxConfirmedPositive.Name = "chkbxConfirmedPositive";
            this.chkbxConfirmedPositive.Size = new System.Drawing.Size(93, 37);
            this.chkbxConfirmedPositive.TabIndex = 7;
            this.chkbxConfirmedPositive.Text = "Confirmed HIV +";
            this.chkbxConfirmedPositive.UseVisualStyleBackColor = true;
            this.chkbxConfirmedPositive.CheckedChanged += new System.EventHandler(this.chkbxConfirmedHIVStatus_CheckedChanged);
            // 
            // chkbxCounseled
            // 
            this.chkbxCounseled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxCounseled.Enabled = false;
            this.chkbxCounseled.Location = new System.Drawing.Point(273, 22);
            this.chkbxCounseled.Name = "chkbxCounseled";
            this.chkbxCounseled.Size = new System.Drawing.Size(108, 44);
            this.chkbxCounseled.TabIndex = 7;
            this.chkbxCounseled.Text = "Received Counselling";
            this.chkbxCounseled.UseVisualStyleBackColor = true;
            // 
            // chkbxOnArt
            // 
            this.chkbxOnArt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxOnArt.Enabled = false;
            this.chkbxOnArt.Location = new System.Drawing.Point(425, 19);
            this.chkbxOnArt.Name = "chkbxOnArt";
            this.chkbxOnArt.Size = new System.Drawing.Size(63, 44);
            this.chkbxOnArt.TabIndex = 7;
            this.chkbxOnArt.Text = "Is On ART?";
            this.chkbxOnArt.UseVisualStyleBackColor = true;
            this.chkbxOnArt.CheckedChanged += new System.EventHandler(this.chkbxOnArt_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkbxConfirmedNegative);
            this.groupBox1.Controls.Add(this.gpbxIsClientAdhering);
            this.groupBox1.Controls.Add(this.chkbxConfirmedPositive);
            this.groupBox1.Controls.Add(this.chkbxOnArt);
            this.groupBox1.Controls.Add(this.chkbxCounseled);
            this.groupBox1.Location = new System.Drawing.Point(29, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 76);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tick appropriately";
            // 
            // chkbxConfirmedNegative
            // 
            this.chkbxConfirmedNegative.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxConfirmedNegative.Location = new System.Drawing.Point(14, 23);
            this.chkbxConfirmedNegative.Name = "chkbxConfirmedNegative";
            this.chkbxConfirmedNegative.Size = new System.Drawing.Size(94, 37);
            this.chkbxConfirmedNegative.TabIndex = 9;
            this.chkbxConfirmedNegative.Text = "Confirmed HIV -";
            this.chkbxConfirmedNegative.UseVisualStyleBackColor = true;
            this.chkbxConfirmedNegative.CheckedChanged += new System.EventHandler(this.chkbxConfirmedNegative_CheckedChanged);
            // 
            // gpbxIsClientAdhering
            // 
            this.gpbxIsClientAdhering.Controls.Add(this.chkbxAdheranceCounselling);
            this.gpbxIsClientAdhering.Controls.Add(this.label6);
            this.gpbxIsClientAdhering.Controls.Add(this.rdIsAdheringNo);
            this.gpbxIsClientAdhering.Controls.Add(this.rdIsAdheringYes);
            this.gpbxIsClientAdhering.Enabled = false;
            this.gpbxIsClientAdhering.Location = new System.Drawing.Point(532, 10);
            this.gpbxIsClientAdhering.Name = "gpbxIsClientAdhering";
            this.gpbxIsClientAdhering.Size = new System.Drawing.Size(382, 54);
            this.gpbxIsClientAdhering.TabIndex = 8;
            this.gpbxIsClientAdhering.TabStop = false;
            // 
            // chkbxAdheranceCounselling
            // 
            this.chkbxAdheranceCounselling.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxAdheranceCounselling.Enabled = false;
            this.chkbxAdheranceCounselling.Location = new System.Drawing.Point(257, 10);
            this.chkbxAdheranceCounselling.Name = "chkbxAdheranceCounselling";
            this.chkbxAdheranceCounselling.Size = new System.Drawing.Size(108, 41);
            this.chkbxAdheranceCounselling.TabIndex = 8;
            this.chkbxAdheranceCounselling.Text = "Adherance Counselling";
            this.chkbxAdheranceCounselling.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Is Client Adhering";
            // 
            // rdIsAdheringNo
            // 
            this.rdIsAdheringNo.AutoSize = true;
            this.rdIsAdheringNo.Location = new System.Drawing.Point(196, 20);
            this.rdIsAdheringNo.Name = "rdIsAdheringNo";
            this.rdIsAdheringNo.Size = new System.Drawing.Size(43, 20);
            this.rdIsAdheringNo.TabIndex = 0;
            this.rdIsAdheringNo.TabStop = true;
            this.rdIsAdheringNo.Text = "No";
            this.rdIsAdheringNo.UseVisualStyleBackColor = true;
            // 
            // rdIsAdheringYes
            // 
            this.rdIsAdheringYes.AutoSize = true;
            this.rdIsAdheringYes.Location = new System.Drawing.Point(142, 20);
            this.rdIsAdheringYes.Name = "rdIsAdheringYes";
            this.rdIsAdheringYes.Size = new System.Drawing.Size(48, 20);
            this.rdIsAdheringYes.TabIndex = 0;
            this.rdIsAdheringYes.TabStop = true;
            this.rdIsAdheringYes.Text = "Yes";
            this.rdIsAdheringYes.UseVisualStyleBackColor = true;
            // 
            // chkbxReceivedSupp
            // 
            this.chkbxReceivedSupp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxReceivedSupp.Location = new System.Drawing.Point(28, 14);
            this.chkbxReceivedSupp.Name = "chkbxReceivedSupp";
            this.chkbxReceivedSupp.Size = new System.Drawing.Size(173, 36);
            this.chkbxReceivedSupp.TabIndex = 7;
            this.chkbxReceivedSupp.Text = "Received Supplement";
            this.chkbxReceivedSupp.UseVisualStyleBackColor = true;
            // 
            // txtClinicalFindings
            // 
            this.txtClinicalFindings.Enabled = false;
            this.txtClinicalFindings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicalFindings.Location = new System.Drawing.Point(170, 35);
            this.txtClinicalFindings.Margin = new System.Windows.Forms.Padding(4);
            this.txtClinicalFindings.MaxLength = 100;
            this.txtClinicalFindings.Multiline = true;
            this.txtClinicalFindings.Name = "txtClinicalFindings";
            this.txtClinicalFindings.Size = new System.Drawing.Size(351, 64);
            this.txtClinicalFindings.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Treatment";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Enabled = false;
            this.txtDiagnosis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosis.Location = new System.Drawing.Point(170, 107);
            this.txtDiagnosis.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagnosis.MaxLength = 100;
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(351, 45);
            this.txtDiagnosis.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Remarks";
            // 
            // txtComments
            // 
            this.txtComments.Enabled = false;
            this.txtComments.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(170, 202);
            this.txtComments.Margin = new System.Windows.Forms.Padding(4);
            this.txtComments.MaxLength = 100;
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(351, 80);
            this.txtComments.TabIndex = 4;
            // 
            // chkbxPainMgmnt
            // 
            this.chkbxPainMgmnt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxPainMgmnt.Location = new System.Drawing.Point(30, 160);
            this.chkbxPainMgmnt.Name = "chkbxPainMgmnt";
            this.chkbxPainMgmnt.Size = new System.Drawing.Size(119, 39);
            this.chkbxPainMgmnt.TabIndex = 7;
            this.chkbxPainMgmnt.Text = "Received Pain Management";
            this.chkbxPainMgmnt.UseVisualStyleBackColor = true;
            this.chkbxPainMgmnt.CheckedChanged += new System.EventHandler(this.chkbxPainMgmnt_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtReferPMgt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboLevel);
            this.groupBox2.Controls.Add(this.chkbxPainMgmnt);
            this.groupBox2.Controls.Add(this.txtComments);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDiagnosis);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtClinicalFindings);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(29, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 301);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(319, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Refer To";
            // 
            // txtReferPMgt
            // 
            this.txtReferPMgt.Enabled = false;
            this.txtReferPMgt.Location = new System.Drawing.Point(387, 165);
            this.txtReferPMgt.MaxLength = 100;
            this.txtReferPMgt.Name = "txtReferPMgt";
            this.txtReferPMgt.Size = new System.Drawing.Size(134, 22);
            this.txtReferPMgt.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Level";
            // 
            // cboLevel
            // 
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "N/A",
            "1",
            "2",
            "3"});
            this.cboLevel.Location = new System.Drawing.Point(223, 165);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(69, 24);
            this.cboLevel.TabIndex = 8;
            this.cboLevel.SelectedIndexChanged += new System.EventHandler(this.cboLevel_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboNameOfSuppliment);
            this.groupBox3.Controls.Add(this.dtpDied);
            this.groupBox3.Controls.Add(this.chkbxDied);
            this.groupBox3.Controls.Add(this.lblDied);
            this.groupBox3.Controls.Add(this.grpDischargeOrTranfer);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtNameOfSupplement);
            this.groupBox3.Controls.Add(this.chkbxReceivedSupp);
            this.groupBox3.Location = new System.Drawing.Point(574, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 300);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // cboNameOfSuppliment
            // 
            this.cboNameOfSuppliment.FormattingEnabled = true;
            this.cboNameOfSuppliment.Items.AddRange(new object[] {
            "Heps",
            "Beans",
            "Cooking Oil",
            "Nuts",
            "Maize",
            "Maize Meal",
            "Milk"});
            this.cboNameOfSuppliment.Location = new System.Drawing.Point(186, 47);
            this.cboNameOfSuppliment.Name = "cboNameOfSuppliment";
            this.cboNameOfSuppliment.Size = new System.Drawing.Size(166, 24);
            this.cboNameOfSuppliment.TabIndex = 14;
            // 
            // dtpDied
            // 
            this.dtpDied.Enabled = false;
            this.dtpDied.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDied.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDied.Location = new System.Drawing.Point(206, 247);
            this.dtpDied.Name = "dtpDied";
            this.dtpDied.Size = new System.Drawing.Size(139, 27);
            this.dtpDied.TabIndex = 11;
            // 
            // chkbxDied
            // 
            this.chkbxDied.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbxDied.Location = new System.Drawing.Point(28, 245);
            this.chkbxDied.Name = "chkbxDied";
            this.chkbxDied.Size = new System.Drawing.Size(57, 37);
            this.chkbxDied.TabIndex = 10;
            this.chkbxDied.Text = "Died";
            this.chkbxDied.UseVisualStyleBackColor = true;
            this.chkbxDied.CheckedChanged += new System.EventHandler(this.chkbxDied_CheckedChanged);
            // 
            // lblDied
            // 
            this.lblDied.AutoSize = true;
            this.lblDied.Location = new System.Drawing.Point(109, 254);
            this.lblDied.Name = "lblDied";
            this.lblDied.Size = new System.Drawing.Size(94, 16);
            this.lblDied.TabIndex = 13;
            this.lblDied.Text = "Date of Death";
            // 
            // grpDischargeOrTranfer
            // 
            this.grpDischargeOrTranfer.Controls.Add(this.rdRefer);
            this.grpDischargeOrTranfer.Controls.Add(this.rdTransfer);
            this.grpDischargeOrTranfer.Controls.Add(this.rdDischarge);
            this.grpDischargeOrTranfer.Controls.Add(this.txtRefer);
            this.grpDischargeOrTranfer.Controls.Add(this.label10);
            this.grpDischargeOrTranfer.Controls.Add(this.txtTransferedto);
            this.grpDischargeOrTranfer.Controls.Add(this.label8);
            this.grpDischargeOrTranfer.Location = new System.Drawing.Point(28, 110);
            this.grpDischargeOrTranfer.Name = "grpDischargeOrTranfer";
            this.grpDischargeOrTranfer.Size = new System.Drawing.Size(341, 108);
            this.grpDischargeOrTranfer.TabIndex = 8;
            this.grpDischargeOrTranfer.TabStop = false;
            // 
            // rdRefer
            // 
            this.rdRefer.AutoSize = true;
            this.rdRefer.Location = new System.Drawing.Point(239, 20);
            this.rdRefer.Name = "rdRefer";
            this.rdRefer.Size = new System.Drawing.Size(60, 20);
            this.rdRefer.TabIndex = 1;
            this.rdRefer.TabStop = true;
            this.rdRefer.Text = "Refer";
            this.rdRefer.UseVisualStyleBackColor = true;
            // 
            // rdTransfer
            // 
            this.rdTransfer.AutoSize = true;
            this.rdTransfer.Location = new System.Drawing.Point(133, 20);
            this.rdTransfer.Name = "rdTransfer";
            this.rdTransfer.Size = new System.Drawing.Size(78, 20);
            this.rdTransfer.TabIndex = 0;
            this.rdTransfer.TabStop = true;
            this.rdTransfer.Text = "Transfer";
            this.rdTransfer.UseVisualStyleBackColor = true;
            // 
            // rdDischarge
            // 
            this.rdDischarge.AutoSize = true;
            this.rdDischarge.Location = new System.Drawing.Point(21, 20);
            this.rdDischarge.Name = "rdDischarge";
            this.rdDischarge.Size = new System.Drawing.Size(89, 20);
            this.rdDischarge.TabIndex = 0;
            this.rdDischarge.TabStop = true;
            this.rdDischarge.Text = "Discharge";
            this.rdDischarge.UseVisualStyleBackColor = true;
            this.rdDischarge.CheckedChanged += new System.EventHandler(this.rdDischarge_CheckedChanged);
            // 
            // txtRefer
            // 
            this.txtRefer.Location = new System.Drawing.Point(134, 74);
            this.txtRefer.Name = "txtRefer";
            this.txtRefer.Size = new System.Drawing.Size(134, 22);
            this.txtRefer.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Refer To";
            // 
            // txtTransferedto
            // 
            this.txtTransferedto.Location = new System.Drawing.Point(134, 43);
            this.txtTransferedto.Name = "txtTransferedto";
            this.txtTransferedto.Size = new System.Drawing.Size(134, 22);
            this.txtTransferedto.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Transfered To:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Name of Supplement:";
            // 
            // txtNameOfSupplement
            // 
            this.txtNameOfSupplement.Location = new System.Drawing.Point(186, 80);
            this.txtNameOfSupplement.MaxLength = 100;
            this.txtNameOfSupplement.Name = "txtNameOfSupplement";
            this.txtNameOfSupplement.Size = new System.Drawing.Size(166, 22);
            this.txtNameOfSupplement.TabIndex = 8;
            // 
            // HbcVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpVisitDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HbcVisit";
            this.Size = new System.Drawing.Size(1085, 551);
            this.Load += new System.EventHandler(this.HbcVisit_Load);
            this.groupBox1.ResumeLayout(false);
            this.gpbxIsClientAdhering.ResumeLayout(false);
            this.gpbxIsClientAdhering.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpDischargeOrTranfer.ResumeLayout(false);
            this.grpDischargeOrTranfer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpVisitDate;
        private System.Windows.Forms.CheckBox chkbxConfirmedPositive;
        private System.Windows.Forms.CheckBox chkbxCounseled;
        private System.Windows.Forms.CheckBox chkbxOnArt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbxIsClientAdhering;
        private System.Windows.Forms.RadioButton rdIsAdheringNo;
        private System.Windows.Forms.RadioButton rdIsAdheringYes;
        private System.Windows.Forms.CheckBox chkbxReceivedSupp;
        private System.Windows.Forms.TextBox txtClinicalFindings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.CheckBox chkbxPainMgmnt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNameOfSupplement;
        private System.Windows.Forms.GroupBox grpDischargeOrTranfer;
        private System.Windows.Forms.RadioButton rdTransfer;
        private System.Windows.Forms.RadioButton rdDischarge;
        private System.Windows.Forms.TextBox txtTransferedto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkbxConfirmedNegative;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtReferPMgt;
        private System.Windows.Forms.TextBox txtRefer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDied;
        private System.Windows.Forms.DateTimePicker dtpDied;
        private System.Windows.Forms.CheckBox chkbxDied;
        private System.Windows.Forms.CheckBox chkbxAdheranceCounselling;
        private System.Windows.Forms.RadioButton rdRefer;
        private System.Windows.Forms.ComboBox cboNameOfSuppliment;
    }
}
