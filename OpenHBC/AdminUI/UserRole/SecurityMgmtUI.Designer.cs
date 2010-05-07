namespace OpenHBC
{
    partial class SecurityMgmtUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserRoleTabControl = new System.Windows.Forms.TabControl();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.btnUserBack = new System.Windows.Forms.Button();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tabPageRoles = new System.Windows.Forms.TabPage();
            this.btnRoleBack = new System.Windows.Forms.Button();
            this.rolesGridView = new System.Windows.Forms.DataGridView();
            this.roleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditRole = new System.Windows.Forms.Button();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.UserRoleTabControl.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.tabPageRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserRoleTabControl
            // 
            this.UserRoleTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.UserRoleTabControl.Controls.Add(this.tabPageUsers);
            this.UserRoleTabControl.Controls.Add(this.tabPageRoles);
            this.UserRoleTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRoleTabControl.Location = new System.Drawing.Point(28, 22);
            this.UserRoleTabControl.Name = "UserRoleTabControl";
            this.UserRoleTabControl.SelectedIndex = 0;
            this.UserRoleTabControl.Size = new System.Drawing.Size(775, 570);
            this.UserRoleTabControl.TabIndex = 0;
            this.UserRoleTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.UserRoleTabControl_Selected);
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.btnUserBack);
            this.tabPageUsers.Controls.Add(this.usersGridView);
            this.tabPageUsers.Controls.Add(this.btnEditUser);
            this.tabPageUsers.Controls.Add(this.btnDeleteUser);
            this.tabPageUsers.Controls.Add(this.btnAddUser);
            this.tabPageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageUsers.Location = new System.Drawing.Point(4, 36);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(767, 530);
            this.tabPageUsers.TabIndex = 0;
            this.tabPageUsers.Text = "Users";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // btnUserBack
            // 
            this.btnUserBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnUserBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserBack.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUserBack.Location = new System.Drawing.Point(378, 454);
            this.btnUserBack.Name = "btnUserBack";
            this.btnUserBack.Size = new System.Drawing.Size(110, 46);
            this.btnUserBack.TabIndex = 8;
            this.btnUserBack.Text = "Back";
            this.btnUserBack.UseVisualStyleBackColor = false;
            this.btnUserBack.Click += new System.EventHandler(this.btnUserCancel_Click);
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.assignedRole,
            this.userId});
            this.usersGridView.Location = new System.Drawing.Point(191, 48);
            this.usersGridView.MultiSelect = false;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.ReadOnly = true;
            this.usersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersGridView.Size = new System.Drawing.Size(552, 375);
            this.usersGridView.TabIndex = 5;
            // 
            // userName
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.DefaultCellStyle = dataGridViewCellStyle1;
            this.userName.HeaderText = "User Name";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Width = 230;
            // 
            // assignedRole
            // 
            this.assignedRole.HeaderText = "Assigned Role";
            this.assignedRole.Name = "assignedRole";
            this.assignedRole.ReadOnly = true;
            this.assignedRole.Width = 230;
            // 
            // userId
            // 
            this.userId.HeaderText = "User ID";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Visible = false;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(6, 116);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(109, 49);
            this.btnEditUser.TabIndex = 0;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(6, 184);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(151, 49);
            this.btnDeleteUser.TabIndex = 0;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(6, 48);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(109, 49);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tabPageRoles
            // 
            this.tabPageRoles.Controls.Add(this.btnRoleBack);
            this.tabPageRoles.Controls.Add(this.rolesGridView);
            this.tabPageRoles.Controls.Add(this.btnEditRole);
            this.tabPageRoles.Controls.Add(this.btnDeleteRole);
            this.tabPageRoles.Controls.Add(this.btnAddRole);
            this.tabPageRoles.Location = new System.Drawing.Point(4, 36);
            this.tabPageRoles.Name = "tabPageRoles";
            this.tabPageRoles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoles.Size = new System.Drawing.Size(767, 530);
            this.tabPageRoles.TabIndex = 1;
            this.tabPageRoles.Text = "Roles";
            this.tabPageRoles.UseVisualStyleBackColor = true;
            // 
            // btnRoleBack
            // 
            this.btnRoleBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnRoleBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleBack.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRoleBack.Location = new System.Drawing.Point(327, 448);
            this.btnRoleBack.Name = "btnRoleBack";
            this.btnRoleBack.Size = new System.Drawing.Size(124, 36);
            this.btnRoleBack.TabIndex = 11;
            this.btnRoleBack.Text = "Back";
            this.btnRoleBack.UseVisualStyleBackColor = false;
            this.btnRoleBack.Click += new System.EventHandler(this.btnRoleBack_Click);
            // 
            // rolesGridView
            // 
            this.rolesGridView.AllowUserToAddRows = false;
            this.rolesGridView.AllowUserToDeleteRows = false;
            this.rolesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleName,
            this.roleId});
            this.rolesGridView.Location = new System.Drawing.Point(259, 27);
            this.rolesGridView.MultiSelect = false;
            this.rolesGridView.Name = "rolesGridView";
            this.rolesGridView.ReadOnly = true;
            this.rolesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesGridView.Size = new System.Drawing.Size(341, 394);
            this.rolesGridView.TabIndex = 9;
            // 
            // roleName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleName.DefaultCellStyle = dataGridViewCellStyle2;
            this.roleName.HeaderText = "Role Name";
            this.roleName.Name = "roleName";
            this.roleName.ReadOnly = true;
            this.roleName.Width = 230;
            // 
            // roleId
            // 
            this.roleId.HeaderText = "Role ID";
            this.roleId.Name = "roleId";
            this.roleId.ReadOnly = true;
            this.roleId.Visible = false;
            // 
            // btnEditRole
            // 
            this.btnEditRole.Location = new System.Drawing.Point(15, 111);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(109, 49);
            this.btnEditRole.TabIndex = 8;
            this.btnEditRole.Text = "Edit Role";
            this.btnEditRole.UseVisualStyleBackColor = true;
            this.btnEditRole.Click += new System.EventHandler(this.btnEditRole_Click);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Location = new System.Drawing.Point(15, 190);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(151, 49);
            this.btnDeleteRole.TabIndex = 6;
            this.btnDeleteRole.Text = "Delete Role";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(15, 45);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(109, 49);
            this.btnAddRole.TabIndex = 7;
            this.btnAddRole.Text = "Add Role";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // SecurityMgmtUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserRoleTabControl);
            this.Name = "SecurityMgmtUI";
            this.Size = new System.Drawing.Size(849, 664);
            this.Load += new System.EventHandler(this.SecurityMgmtUI_OnLoad);
            this.UserRoleTabControl.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.tabPageRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rolesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl UserRoleTabControl;
        private System.Windows.Forms.TabPage tabPageRoles;
        private System.Windows.Forms.DataGridView rolesGridView;
        private System.Windows.Forms.Button btnEditRole;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.Button btnUserBack;
        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnRoleBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleId;
    }
}
