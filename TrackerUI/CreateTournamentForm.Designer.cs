namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentnameValue = new System.Windows.Forms.TextBox();
            this.TournamentnameLabel = new System.Windows.Forms.Label();
            this.enteryFeesValue = new System.Windows.Forms.TextBox();
            this.enteryFeesLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createprizeButton = new System.Windows.Forms.Button();
            this.tournamentPlayersListbox = new System.Windows.Forms.ListBox();
            this.tournamentsPlayersLabel = new System.Windows.Forms.Label();
            this.deleteSelectePlayers = new System.Windows.Forms.Button();
            this.deleteSelectedPrizesButton = new System.Windows.Forms.Button();
            this.PrizeLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(2, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(317, 50);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentnameValue
            // 
            this.tournamentnameValue.Location = new System.Drawing.Point(41, 108);
            this.tournamentnameValue.Name = "tournamentnameValue";
            this.tournamentnameValue.Size = new System.Drawing.Size(278, 35);
            this.tournamentnameValue.TabIndex = 10;
            this.tournamentnameValue.TextChanged += new System.EventHandler(this.teamOneScoreValue_TextChanged);
            // 
            // TournamentnameLabel
            // 
            this.TournamentnameLabel.AutoSize = true;
            this.TournamentnameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentnameLabel.Location = new System.Drawing.Point(34, 68);
            this.TournamentnameLabel.Name = "TournamentnameLabel";
            this.TournamentnameLabel.Size = new System.Drawing.Size(236, 37);
            this.TournamentnameLabel.TabIndex = 9;
            this.TournamentnameLabel.Text = "Tournament Name";
            // 
            // enteryFeesValue
            // 
            this.enteryFeesValue.Location = new System.Drawing.Point(179, 149);
            this.enteryFeesValue.Name = "enteryFeesValue";
            this.enteryFeesValue.Size = new System.Drawing.Size(100, 35);
            this.enteryFeesValue.TabIndex = 12;
            this.enteryFeesValue.Text = "0";
            // 
            // enteryFeesLabel
            // 
            this.enteryFeesLabel.AutoSize = true;
            this.enteryFeesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enteryFeesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.enteryFeesLabel.Location = new System.Drawing.Point(34, 146);
            this.enteryFeesLabel.Name = "enteryFeesLabel";
            this.enteryFeesLabel.Size = new System.Drawing.Size(139, 37);
            this.enteryFeesLabel.TabIndex = 11;
            this.enteryFeesLabel.Text = "Entery Fee";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.roundLabel.Location = new System.Drawing.Point(36, 202);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(156, 37);
            this.roundLabel.TabIndex = 13;
            this.roundLabel.Text = "Select Team";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(41, 242);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(278, 38);
            this.selectTeamDropDown.TabIndex = 14;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(198, 209);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(121, 30);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create New";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamButton.Location = new System.Drawing.Point(91, 286);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(179, 50);
            this.addTeamButton.TabIndex = 16;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createprizeButton
            // 
            this.createprizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createprizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createprizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createprizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createprizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createprizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createprizeButton.Location = new System.Drawing.Point(91, 354);
            this.createprizeButton.Name = "createprizeButton";
            this.createprizeButton.Size = new System.Drawing.Size(179, 50);
            this.createprizeButton.TabIndex = 17;
            this.createprizeButton.Text = " Create Prize";
            this.createprizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListbox
            // 
            this.tournamentPlayersListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListbox.FormattingEnabled = true;
            this.tournamentPlayersListbox.ItemHeight = 30;
            this.tournamentPlayersListbox.Location = new System.Drawing.Point(353, 106);
            this.tournamentPlayersListbox.Name = "tournamentPlayersListbox";
            this.tournamentPlayersListbox.Size = new System.Drawing.Size(247, 122);
            this.tournamentPlayersListbox.TabIndex = 18;
            // 
            // tournamentsPlayersLabel
            // 
            this.tournamentsPlayersLabel.AutoSize = true;
            this.tournamentsPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentsPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentsPlayersLabel.Location = new System.Drawing.Point(352, 68);
            this.tournamentsPlayersLabel.Name = "tournamentsPlayersLabel";
            this.tournamentsPlayersLabel.Size = new System.Drawing.Size(248, 37);
            this.tournamentsPlayersLabel.TabIndex = 19;
            this.tournamentsPlayersLabel.Text = "Tournament Players";
            // 
            // deleteSelectePlayers
            // 
            this.deleteSelectePlayers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteSelectePlayers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectePlayers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectePlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectePlayers.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectePlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectePlayers.Location = new System.Drawing.Point(606, 128);
            this.deleteSelectePlayers.Name = "deleteSelectePlayers";
            this.deleteSelectePlayers.Size = new System.Drawing.Size(120, 75);
            this.deleteSelectePlayers.TabIndex = 20;
            this.deleteSelectePlayers.Text = "Delete Selected";
            this.deleteSelectePlayers.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizesButton
            // 
            this.deleteSelectedPrizesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteSelectedPrizesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPrizesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPrizesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPrizesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPrizesButton.Location = new System.Drawing.Point(602, 301);
            this.deleteSelectedPrizesButton.Name = "deleteSelectedPrizesButton";
            this.deleteSelectedPrizesButton.Size = new System.Drawing.Size(120, 75);
            this.deleteSelectedPrizesButton.TabIndex = 23;
            this.deleteSelectedPrizesButton.Text = "Delete Selected";
            this.deleteSelectedPrizesButton.UseVisualStyleBackColor = true;
            // 
            // PrizeLabel
            // 
            this.PrizeLabel.AutoSize = true;
            this.PrizeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PrizeLabel.Location = new System.Drawing.Point(346, 239);
            this.PrizeLabel.Name = "PrizeLabel";
            this.PrizeLabel.Size = new System.Drawing.Size(248, 37);
            this.PrizeLabel.TabIndex = 22;
            this.PrizeLabel.Text = "Tournament Players";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(347, 277);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 122);
            this.listBox1.TabIndex = 21;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(276, 423);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(244, 50);
            this.createTournamentButton.TabIndex = 24;
            this.createTournamentButton.Text = " Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 485);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizesButton);
            this.Controls.Add(this.PrizeLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.deleteSelectePlayers);
            this.Controls.Add(this.tournamentsPlayersLabel);
            this.Controls.Add(this.tournamentPlayersListbox);
            this.Controls.Add(this.createprizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.enteryFeesValue);
            this.Controls.Add(this.enteryFeesLabel);
            this.Controls.Add(this.tournamentnameValue);
            this.Controls.Add(this.TournamentnameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentnameValue;
        private System.Windows.Forms.Label TournamentnameLabel;
        private System.Windows.Forms.TextBox enteryFeesValue;
        private System.Windows.Forms.Label enteryFeesLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createprizeButton;
        private System.Windows.Forms.ListBox tournamentPlayersListbox;
        private System.Windows.Forms.Label tournamentsPlayersLabel;
        private System.Windows.Forms.Button deleteSelectePlayers;
        private System.Windows.Forms.Button deleteSelectedPrizesButton;
        private System.Windows.Forms.Label PrizeLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button createTournamentButton;
    }
}