using System;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameTextField = new System.Windows.Forms.TextBox();
            this.entryFeeTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.teamsPlayersLabel = new System.Windows.Forms.Label();
            this.removeSelectedPlayersButton = new System.Windows.Forms.Button();
            this.removeSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTournamentLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.createTournamentLabel.Location = new System.Drawing.Point(12, 9);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(211, 33);
            this.createTournamentLabel.TabIndex = 1;
            this.createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.tournamentNameLabel.Location = new System.Drawing.Point(12, 42);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(145, 28);
            this.tournamentNameLabel.TabIndex = 3;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameTextField
            // 
            this.tournamentNameTextField.Location = new System.Drawing.Point(12, 73);
            this.tournamentNameTextField.Name = "tournamentNameTextField";
            this.tournamentNameTextField.Size = new System.Drawing.Size(206, 26);
            this.tournamentNameTextField.TabIndex = 9;
            // 
            // entryFeeTextBox
            // 
            this.entryFeeTextBox.Location = new System.Drawing.Point(98, 118);
            this.entryFeeTextBox.Name = "entryFeeTextBox";
            this.entryFeeTextBox.Size = new System.Drawing.Size(67, 26);
            this.entryFeeTextBox.TabIndex = 11;
            this.entryFeeTextBox.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.entryFeeLabel.Location = new System.Drawing.Point(8, 115);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(84, 28);
            this.entryFeeLabel.TabIndex = 10;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(12, 193);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(206, 27);
            this.selectTeamDropDown.TabIndex = 13;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectTeamLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.selectTeamLabel.Location = new System.Drawing.Point(8, 162);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(99, 28);
            this.selectTeamLabel.TabIndex = 12;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(160, 177);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(75, 19);
            this.createNewTeamLink.TabIndex = 14;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            this.createNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLink_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTeamButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.addTeamButton.Location = new System.Drawing.Point(73, 220);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(85, 27);
            this.addTeamButton.TabIndex = 15;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.createPrizeButton.Location = new System.Drawing.Point(73, 253);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(85, 28);
            this.createPrizeButton.TabIndex = 16;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 19;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(246, 73);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(196, 78);
            this.tournamentTeamsListBox.TabIndex = 17;
            // 
            // teamsPlayersLabel
            // 
            this.teamsPlayersLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamsPlayersLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.teamsPlayersLabel.Location = new System.Drawing.Point(242, 42);
            this.teamsPlayersLabel.Name = "teamsPlayersLabel";
            this.teamsPlayersLabel.Size = new System.Drawing.Size(145, 28);
            this.teamsPlayersLabel.TabIndex = 18;
            this.teamsPlayersLabel.Text = "Teams / Players";
            this.teamsPlayersLabel.Click += new System.EventHandler(this.teamPlayersLabel_Click);
            // 
            // removeSelectedPlayersButton
            // 
            this.removeSelectedPlayersButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.removeSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.removeSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.removeSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeSelectedPlayersButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.removeSelectedPlayersButton.Location = new System.Drawing.Point(448, 91);
            this.removeSelectedPlayersButton.Name = "removeSelectedPlayersButton";
            this.removeSelectedPlayersButton.Size = new System.Drawing.Size(85, 36);
            this.removeSelectedPlayersButton.TabIndex = 19;
            this.removeSelectedPlayersButton.Text = "Remove Selected";
            this.removeSelectedPlayersButton.UseVisualStyleBackColor = false;
            this.removeSelectedPlayersButton.Click += new System.EventHandler(this.removeSelectedPlayersButton_Click);
            // 
            // removeSelectedPrizeButton
            // 
            this.removeSelectedPrizeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.removeSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeSelectedPrizeButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.removeSelectedPrizeButton.Location = new System.Drawing.Point(448, 219);
            this.removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            this.removeSelectedPrizeButton.Size = new System.Drawing.Size(85, 36);
            this.removeSelectedPrizeButton.TabIndex = 22;
            this.removeSelectedPrizeButton.Text = "Remove Selected";
            this.removeSelectedPrizeButton.UseVisualStyleBackColor = false;
            this.removeSelectedPrizeButton.Click += new System.EventHandler(this.removeSelectedPrizeButton_Click);
            // 
            // prizesLabel
            // 
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prizesLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.prizesLabel.Location = new System.Drawing.Point(242, 170);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(145, 28);
            this.prizesLabel.TabIndex = 21;
            this.prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 19;
            this.prizesListBox.Location = new System.Drawing.Point(246, 201);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(196, 78);
            this.prizesListBox.TabIndex = 20;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.createTournamentButton.Location = new System.Drawing.Point(209, 335);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(120, 28);
            this.createTournamentButton.TabIndex = 23;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            this.createTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 410);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.removeSelectedPrizeButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.removeSelectedPlayersButton);
            this.Controls.Add(this.teamsPlayersLabel);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeTextBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameTextField);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.createTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameTextField;
        private System.Windows.Forms.TextBox entryFeeTextBox;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.Label teamsPlayersLabel;
        private System.Windows.Forms.Button removeSelectedPlayersButton;
        private System.Windows.Forms.Button removeSelectedPrizeButton;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}