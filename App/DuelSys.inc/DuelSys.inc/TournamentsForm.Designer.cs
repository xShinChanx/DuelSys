namespace DuelSys.inc
{
    partial class TournamentsForm
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
            this.lvOngoingTournaments = new System.Windows.Forms.ListView();
            this.chID = new System.Windows.Forms.ColumnHeader();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chFormatOfElimination = new System.Windows.Forms.ColumnHeader();
            this.chVenue = new System.Windows.Forms.ColumnHeader();
            this.chStartDate = new System.Windows.Forms.ColumnHeader();
            this.chEndDate = new System.Windows.Forms.ColumnHeader();
            this.btnSelectedTournament = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvOngoingTournaments
            // 
            this.lvOngoingTournaments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chFormatOfElimination,
            this.chVenue,
            this.chStartDate,
            this.chEndDate});
            this.lvOngoingTournaments.Location = new System.Drawing.Point(320, 66);
            this.lvOngoingTournaments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvOngoingTournaments.Name = "lvOngoingTournaments";
            this.lvOngoingTournaments.Size = new System.Drawing.Size(680, 328);
            this.lvOngoingTournaments.TabIndex = 0;
            this.lvOngoingTournaments.UseCompatibleStateImageBehavior = false;
            this.lvOngoingTournaments.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 30;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 150;
            // 
            // chFormatOfElimination
            // 
            this.chFormatOfElimination.DisplayIndex = 5;
            this.chFormatOfElimination.Text = "Tournament System";
            this.chFormatOfElimination.Width = 150;
            // 
            // chVenue
            // 
            this.chVenue.DisplayIndex = 2;
            this.chVenue.Text = "Venue";
            this.chVenue.Width = 130;
            // 
            // chStartDate
            // 
            this.chStartDate.DisplayIndex = 3;
            this.chStartDate.Text = "Start Date";
            this.chStartDate.Width = 100;
            // 
            // chEndDate
            // 
            this.chEndDate.DisplayIndex = 4;
            this.chEndDate.Text = "End Date";
            this.chEndDate.Width = 100;
            // 
            // btnSelectedTournament
            // 
            this.btnSelectedTournament.Location = new System.Drawing.Point(51, 230);
            this.btnSelectedTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectedTournament.Name = "btnSelectedTournament";
            this.btnSelectedTournament.Size = new System.Drawing.Size(218, 31);
            this.btnSelectedTournament.TabIndex = 1;
            this.btnSelectedTournament.Text = "Enter Selected Tournament";
            this.btnSelectedTournament.UseVisualStyleBackColor = true;
            this.btnSelectedTournament.Click += new System.EventHandler(this.btnSelectedTournament_Click);
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Location = new System.Drawing.Point(51, 178);
            this.btnCreateTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(218, 31);
            this.btnCreateTournament.TabIndex = 4;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // TournamentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 407);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnSelectedTournament);
            this.Controls.Add(this.lvOngoingTournaments);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TournamentsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvOngoingTournaments;
        private ColumnHeader chID;
        private ColumnHeader chName;
        private ColumnHeader chVenue;
        private ColumnHeader chStartDate;
        private ColumnHeader chEndDate;
        private ColumnHeader chFormatOfElimination;
        private Button btnSelectedTournament;
        private Button btnCreateTournament;
    }
}