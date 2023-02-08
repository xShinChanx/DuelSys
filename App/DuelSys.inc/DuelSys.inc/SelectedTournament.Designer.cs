namespace DuelSys.inc
{
    partial class SelectedTournament
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
            this.btnMatches = new System.Windows.Forms.Button();
            this.btnEnterScore = new System.Windows.Forms.Button();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.btnStartSelectedTournament = new System.Windows.Forms.Button();
            this.btnEditSelectedTournament = new System.Windows.Forms.Button();
            this.btnDeleteTournament = new System.Windows.Forms.Button();
            this.lvMatch = new System.Windows.Forms.ListView();
            this.chMatchID = new System.Windows.Forms.ColumnHeader();
            this.chPlayer1 = new System.Windows.Forms.ColumnHeader();
            this.chVS = new System.Windows.Forms.ColumnHeader();
            this.chPlayer2 = new System.Windows.Forms.ColumnHeader();
            this.chWinner = new System.Windows.Forms.ColumnHeader();
            this.lvPlayers = new System.Windows.Forms.ListView();
            this.chID = new System.Windows.Forms.ColumnHeader();
            this.chPlayerName = new System.Windows.Forms.ColumnHeader();
            this.lbTournamentResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMatches
            // 
            this.btnMatches.Location = new System.Drawing.Point(265, 78);
            this.btnMatches.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMatches.Name = "btnMatches";
            this.btnMatches.Size = new System.Drawing.Size(147, 31);
            this.btnMatches.TabIndex = 0;
            this.btnMatches.Text = "Matches";
            this.btnMatches.UseVisualStyleBackColor = true;
            this.btnMatches.Click += new System.EventHandler(this.btnScheduledMatches_Click);
            // 
            // btnEnterScore
            // 
            this.btnEnterScore.Location = new System.Drawing.Point(265, 117);
            this.btnEnterScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnterScore.Name = "btnEnterScore";
            this.btnEnterScore.Size = new System.Drawing.Size(147, 31);
            this.btnEnterScore.TabIndex = 1;
            this.btnEnterScore.Text = "Enter score";
            this.btnEnterScore.UseVisualStyleBackColor = true;
            this.btnEnterScore.Click += new System.EventHandler(this.btnEnterScore_Click);
            // 
            // btnPlayers
            // 
            this.btnPlayers.Location = new System.Drawing.Point(265, 156);
            this.btnPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(147, 31);
            this.btnPlayers.TabIndex = 3;
            this.btnPlayers.Text = "Players";
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // btnStartSelectedTournament
            // 
            this.btnStartSelectedTournament.Location = new System.Drawing.Point(55, 117);
            this.btnStartSelectedTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartSelectedTournament.Name = "btnStartSelectedTournament";
            this.btnStartSelectedTournament.Size = new System.Drawing.Size(194, 31);
            this.btnStartSelectedTournament.TabIndex = 6;
            this.btnStartSelectedTournament.Text = "Start Tournament";
            this.btnStartSelectedTournament.UseVisualStyleBackColor = true;
            this.btnStartSelectedTournament.Click += new System.EventHandler(this.btnStartSelectedTournament_Click);
            // 
            // btnEditSelectedTournament
            // 
            this.btnEditSelectedTournament.Location = new System.Drawing.Point(55, 78);
            this.btnEditSelectedTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditSelectedTournament.Name = "btnEditSelectedTournament";
            this.btnEditSelectedTournament.Size = new System.Drawing.Size(194, 31);
            this.btnEditSelectedTournament.TabIndex = 5;
            this.btnEditSelectedTournament.Text = "Edit Tournament";
            this.btnEditSelectedTournament.UseVisualStyleBackColor = true;
            this.btnEditSelectedTournament.Click += new System.EventHandler(this.btnEditSelectedTournament_Click);
            // 
            // btnDeleteTournament
            // 
            this.btnDeleteTournament.Location = new System.Drawing.Point(55, 156);
            this.btnDeleteTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteTournament.Name = "btnDeleteTournament";
            this.btnDeleteTournament.Size = new System.Drawing.Size(194, 31);
            this.btnDeleteTournament.TabIndex = 9;
            this.btnDeleteTournament.Text = "Delete Tournament";
            this.btnDeleteTournament.UseVisualStyleBackColor = true;
            this.btnDeleteTournament.Click += new System.EventHandler(this.btnDeleteTournament_Click);
            // 
            // lvMatch
            // 
            this.lvMatch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMatchID,
            this.chPlayer1,
            this.chVS,
            this.chPlayer2,
            this.chWinner});
            this.lvMatch.Location = new System.Drawing.Point(438, 44);
            this.lvMatch.Name = "lvMatch";
            this.lvMatch.Size = new System.Drawing.Size(566, 333);
            this.lvMatch.TabIndex = 11;
            this.lvMatch.UseCompatibleStateImageBehavior = false;
            this.lvMatch.View = System.Windows.Forms.View.Details;
            // 
            // chMatchID
            // 
            this.chMatchID.Text = "ID";
            this.chMatchID.Width = 40;
            // 
            // chPlayer1
            // 
            this.chPlayer1.Text = "Player 1";
            this.chPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPlayer1.Width = 130;
            // 
            // chVS
            // 
            this.chVS.Text = "";
            this.chVS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chVS.Width = 130;
            // 
            // chPlayer2
            // 
            this.chPlayer2.Text = "Player 2";
            this.chPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPlayer2.Width = 130;
            // 
            // chWinner
            // 
            this.chWinner.Text = "Winner";
            this.chWinner.Width = 120;
            // 
            // lvPlayers
            // 
            this.lvPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chPlayerName});
            this.lvPlayers.Location = new System.Drawing.Point(627, 44);
            this.lvPlayers.Name = "lvPlayers";
            this.lvPlayers.Size = new System.Drawing.Size(202, 333);
            this.lvPlayers.TabIndex = 12;
            this.lvPlayers.UseCompatibleStateImageBehavior = false;
            this.lvPlayers.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 35;
            // 
            // chPlayerName
            // 
            this.chPlayerName.Text = "Name";
            this.chPlayerName.Width = 150;
            // 
            // lbTournamentResults
            // 
            this.lbTournamentResults.FormattingEnabled = true;
            this.lbTournamentResults.ItemHeight = 20;
            this.lbTournamentResults.Location = new System.Drawing.Point(55, 219);
            this.lbTournamentResults.Name = "lbTournamentResults";
            this.lbTournamentResults.Size = new System.Drawing.Size(357, 144);
            this.lbTournamentResults.TabIndex = 13;
            // 
            // SelectedTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 407);
            this.Controls.Add(this.lbTournamentResults);
            this.Controls.Add(this.lvPlayers);
            this.Controls.Add(this.lvMatch);
            this.Controls.Add(this.btnDeleteTournament);
            this.Controls.Add(this.btnStartSelectedTournament);
            this.Controls.Add(this.btnEditSelectedTournament);
            this.Controls.Add(this.btnPlayers);
            this.Controls.Add(this.btnEnterScore);
            this.Controls.Add(this.btnMatches);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectedTournament";
            this.Text = "SelectedTournament";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMatches;
        private Button btnEnterScore;
        private Button btnPlayers;
        private Button btnStartSelectedTournament;
        private Button btnEditSelectedTournament;
        private Button btnDeleteTournament;
        private ListView lvMatch;
        private ColumnHeader chMatchID;
        private ColumnHeader chPlayer1;
        private ColumnHeader chVS;
        private ColumnHeader chPlayer2;
        private ListView lvPlayers;
        private ColumnHeader chID;
        private ColumnHeader chPlayerName;
        private ColumnHeader chWinner;
        private ListBox lbTournamentResults;
    }
}