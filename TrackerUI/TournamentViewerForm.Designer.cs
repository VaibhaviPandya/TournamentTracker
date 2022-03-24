namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListbox = new System.Windows.Forms.ListBox();
            this.tramOneName = new System.Windows.Forms.Label();
            this.tramOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoretextox = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(0, 30);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(196, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournment:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentName.Location = new System.Drawing.Point(193, 30);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(150, 50);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.roundLabel.Location = new System.Drawing.Point(12, 90);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(94, 37);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            this.roundLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(112, 93);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(207, 38);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(112, 137);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(216, 41);
            this.unplayedOnlyCheckbox.TabIndex = 4;
            this.unplayedOnlyCheckbox.Text = " Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListbox
            // 
            this.matchupListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListbox.FormattingEnabled = true;
            this.matchupListbox.ItemHeight = 30;
            this.matchupListbox.Location = new System.Drawing.Point(21, 196);
            this.matchupListbox.Name = "matchupListbox";
            this.matchupListbox.Size = new System.Drawing.Size(298, 152);
            this.matchupListbox.TabIndex = 5;
            // 
            // tramOneName
            // 
            this.tramOneName.AutoSize = true;
            this.tramOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tramOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tramOneName.Location = new System.Drawing.Point(334, 175);
            this.tramOneName.Name = "tramOneName";
            this.tramOneName.Size = new System.Drawing.Size(171, 37);
            this.tramOneName.TabIndex = 6;
            this.tramOneName.Text = "<Team One>";
            // 
            // tramOneScoreLabel
            // 
            this.tramOneScoreLabel.AutoSize = true;
            this.tramOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tramOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tramOneScoreLabel.Location = new System.Drawing.Point(352, 221);
            this.tramOneScoreLabel.Name = "tramOneScoreLabel";
            this.tramOneScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.tramOneScoreLabel.TabIndex = 7;
            this.tramOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(454, 221);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(100, 35);
            this.teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoretextox
            // 
            this.teamTwoScoretextox.Location = new System.Drawing.Point(463, 383);
            this.teamTwoScoretextox.Name = "teamTwoScoretextox";
            this.teamTwoScoretextox.Size = new System.Drawing.Size(100, 35);
            this.teamTwoScoretextox.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(361, 383);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.teamTwoScoreLabel.TabIndex = 10;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoName.Location = new System.Drawing.Point(343, 337);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(171, 37);
            this.teamTwoName.TabIndex = 9;
            this.teamTwoName.Text = "<Team Two>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(431, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "vs";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.scoreButton.Location = new System.Drawing.Point(598, 277);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(120, 50);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 470);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamTwoScoretextox);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.tramOneScoreLabel);
            this.Controls.Add(this.tramOneName);
            this.Controls.Add(this.matchupListbox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox matchupListbox;
        private System.Windows.Forms.Label tramOneName;
        private System.Windows.Forms.Label tramOneScoreLabel;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.TextBox teamTwoScoretextox;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scoreButton;
    }
}

