namespace TrackerUI
{
    partial class CreateTeamForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tournamentnameValue = new System.Windows.Forms.TextBox();
            this.TeamnameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addNewMemberGroupbox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.phonenoValue = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.phoneNoLable = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastnameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListbox = new System.Windows.Forms.ListBox();
            this.deleteSelectePlayers = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tournamentnameValue
            // 
            this.tournamentnameValue.Location = new System.Drawing.Point(45, 72);
            this.tournamentnameValue.Name = "tournamentnameValue";
            this.tournamentnameValue.Size = new System.Drawing.Size(322, 35);
            this.tournamentnameValue.TabIndex = 13;
            // 
            // TeamnameLabel
            // 
            this.TeamnameLabel.AutoSize = true;
            this.TeamnameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamnameLabel.Location = new System.Drawing.Point(40, 39);
            this.TeamnameLabel.Name = "TeamnameLabel";
            this.TeamnameLabel.Size = new System.Drawing.Size(124, 30);
            this.TeamnameLabel.TabIndex = 12;
            this.TeamnameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(12, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(128, 30);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addMemberButton.Location = new System.Drawing.Point(114, 187);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(177, 36);
            this.addMemberButton.TabIndex = 19;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(45, 143);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(322, 38);
            this.selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(40, 110);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(207, 30);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupbox
            // 
            this.addNewMemberGroupbox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupbox.Controls.Add(this.phonenoValue);
            this.addNewMemberGroupbox.Controls.Add(this.textBox1);
            this.addNewMemberGroupbox.Controls.Add(this.phoneNoLable);
            this.addNewMemberGroupbox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupbox.Controls.Add(this.lastnameValue);
            this.addNewMemberGroupbox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupbox.Controls.Add(this.firstNameValue);
            this.addNewMemberGroupbox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupbox.Location = new System.Drawing.Point(45, 229);
            this.addNewMemberGroupbox.Name = "addNewMemberGroupbox";
            this.addNewMemberGroupbox.Size = new System.Drawing.Size(362, 256);
            this.addNewMemberGroupbox.TabIndex = 20;
            this.addNewMemberGroupbox.TabStop = false;
            this.addNewMemberGroupbox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createMemberButton.Location = new System.Drawing.Point(99, 206);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(197, 45);
            this.createMemberButton.TabIndex = 21;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // phonenoValue
            // 
            this.phonenoValue.Location = new System.Drawing.Point(119, 160);
            this.phonenoValue.Name = "phonenoValue";
            this.phonenoValue.Size = new System.Drawing.Size(203, 35);
            this.phonenoValue.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 35);
            this.textBox1.TabIndex = 14;
            // 
            // phoneNoLable
            // 
            this.phoneNoLable.AutoSize = true;
            this.phoneNoLable.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNoLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.phoneNoLable.Location = new System.Drawing.Point(6, 153);
            this.phoneNoLable.Name = "phoneNoLable";
            this.phoneNoLable.Size = new System.Drawing.Size(106, 30);
            this.phoneNoLable.TabIndex = 21;
            this.phoneNoLable.Text = "Phone No";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.emailLabel.Location = new System.Drawing.Point(6, 116);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(63, 30);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            // 
            // lastnameValue
            // 
            this.lastnameValue.Location = new System.Drawing.Point(119, 78);
            this.lastnameValue.Name = "lastnameValue";
            this.lastnameValue.Size = new System.Drawing.Size(203, 35);
            this.lastnameValue.TabIndex = 12;
            this.lastnameValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lastNameLabel.Location = new System.Drawing.Point(6, 75);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(112, 30);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(119, 34);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(203, 35);
            this.firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstNameLabel.Location = new System.Drawing.Point(6, 34);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(107, 30);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "FirstName";
            this.firstNameLabel.Click += new System.EventHandler(this.tramOneScoreLabel_Click);
            // 
            // teamMembersListbox
            // 
            this.teamMembersListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListbox.FormattingEnabled = true;
            this.teamMembersListbox.ItemHeight = 30;
            this.teamMembersListbox.Location = new System.Drawing.Point(440, 72);
            this.teamMembersListbox.Name = "teamMembersListbox";
            this.teamMembersListbox.Size = new System.Drawing.Size(215, 332);
            this.teamMembersListbox.TabIndex = 21;
            // 
            // deleteSelectePlayers
            // 
            this.deleteSelectePlayers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteSelectePlayers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectePlayers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectePlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectePlayers.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectePlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectePlayers.Location = new System.Drawing.Point(661, 146);
            this.deleteSelectePlayers.Name = "deleteSelectePlayers";
            this.deleteSelectePlayers.Size = new System.Drawing.Size(120, 75);
            this.deleteSelectePlayers.TabIndex = 22;
            this.deleteSelectePlayers.Text = "Delete Selected";
            this.deleteSelectePlayers.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTeamButton.Location = new System.Drawing.Point(497, 430);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(244, 50);
            this.createTeamButton.TabIndex = 25;
            this.createTeamButton.Text = " Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 516);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectePlayers);
            this.Controls.Add(this.teamMembersListbox);
            this.Controls.Add(this.addNewMemberGroupbox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.tournamentnameValue);
            this.Controls.Add(this.TeamnameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroupbox.ResumeLayout(false);
            this.addNewMemberGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tournamentnameValue;
        private System.Windows.Forms.Label TeamnameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewMemberGroupbox;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastnameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox phonenoValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label phoneNoLable;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ListBox teamMembersListbox;
        private System.Windows.Forms.Button deleteSelectePlayers;
        private System.Windows.Forms.Button createTeamButton;
    }
}