namespace DuelSys.inc
{
    partial class CreateTournament
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbEliminationFormat = new System.Windows.Forms.ComboBox();
            this.lblEliminationFormat = new System.Windows.Forms.Label();
            this.lblMinNrOfPlayers = new System.Windows.Forms.Label();
            this.txtMinNrOfPlayers = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblMaxNrOfPlayers = new System.Windows.Forms.Label();
            this.txtMaxNrOfPlayers = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(336, 41);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 27);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Badminton";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(281, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // cbEliminationFormat
            // 
            this.cbEliminationFormat.FormattingEnabled = true;
            this.cbEliminationFormat.Items.AddRange(new object[] {
            "Round-robin",
            "Double round-robin"});
            this.cbEliminationFormat.Location = new System.Drawing.Point(336, 90);
            this.cbEliminationFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEliminationFormat.Name = "cbEliminationFormat";
            this.cbEliminationFormat.Size = new System.Drawing.Size(154, 28);
            this.cbEliminationFormat.TabIndex = 8;
            // 
            // lblEliminationFormat
            // 
            this.lblEliminationFormat.AutoSize = true;
            this.lblEliminationFormat.Location = new System.Drawing.Point(195, 93);
            this.lblEliminationFormat.Name = "lblEliminationFormat";
            this.lblEliminationFormat.Size = new System.Drawing.Size(138, 20);
            this.lblEliminationFormat.TabIndex = 7;
            this.lblEliminationFormat.Text = "Elimination Format:";
            this.lblEliminationFormat.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMinNrOfPlayers
            // 
            this.lblMinNrOfPlayers.AutoSize = true;
            this.lblMinNrOfPlayers.Location = new System.Drawing.Point(139, 140);
            this.lblMinNrOfPlayers.Name = "lblMinNrOfPlayers";
            this.lblMinNrOfPlayers.Size = new System.Drawing.Size(199, 20);
            this.lblMinNrOfPlayers.TabIndex = 10;
            this.lblMinNrOfPlayers.Text = "Minimum number of players:";
            // 
            // txtMinNrOfPlayers
            // 
            this.txtMinNrOfPlayers.Location = new System.Drawing.Point(336, 136);
            this.txtMinNrOfPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinNrOfPlayers.Name = "txtMinNrOfPlayers";
            this.txtMinNrOfPlayers.Size = new System.Drawing.Size(154, 27);
            this.txtMinNrOfPlayers.TabIndex = 9;
            this.txtMinNrOfPlayers.Text = "2";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(170, 243);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(79, 20);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(526, 243);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(73, 20);
            this.lblEndDate.TabIndex = 16;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblMaxNrOfPlayers
            // 
            this.lblMaxNrOfPlayers.AutoSize = true;
            this.lblMaxNrOfPlayers.Location = new System.Drawing.Point(131, 185);
            this.lblMaxNrOfPlayers.Name = "lblMaxNrOfPlayers";
            this.lblMaxNrOfPlayers.Size = new System.Drawing.Size(202, 20);
            this.lblMaxNrOfPlayers.TabIndex = 14;
            this.lblMaxNrOfPlayers.Text = "Maximum number of players:";
            // 
            // txtMaxNrOfPlayers
            // 
            this.txtMaxNrOfPlayers.Location = new System.Drawing.Point(339, 182);
            this.txtMaxNrOfPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaxNrOfPlayers.Name = "txtMaxNrOfPlayers";
            this.txtMaxNrOfPlayers.Size = new System.Drawing.Size(154, 27);
            this.txtMaxNrOfPlayers.TabIndex = 13;
            this.txtMaxNrOfPlayers.Text = "10";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(511, 88);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(88, 20);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(598, 88);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(235, 128);
            this.txtDescription.TabIndex = 18;
            this.txtDescription.Text = "Please bring your rackets";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(543, 52);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(52, 20);
            this.lblVenue.TabIndex = 20;
            this.lblVenue.Text = "Venue:";
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(598, 48);
            this.txtVenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(235, 27);
            this.txtVenue.TabIndex = 19;
            this.txtVenue.Text = "Eindhoven SSC";
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Location = new System.Drawing.Point(428, 298);
            this.btnCreateTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(201, 31);
            this.btnCreateTournament.TabIndex = 22;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(255, 236);
            this.dtStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(235, 27);
            this.dtStartDate.TabIndex = 23;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(598, 236);
            this.dtEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(235, 27);
            this.dtEndDate.TabIndex = 24;
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 367);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblMaxNrOfPlayers);
            this.Controls.Add(this.txtMaxNrOfPlayers);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblMinNrOfPlayers);
            this.Controls.Add(this.txtMinNrOfPlayers);
            this.Controls.Add(this.cbEliminationFormat);
            this.Controls.Add(this.lblEliminationFormat);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "CreateTournament";
            this.Text = "CreateTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private ComboBox cbEliminationFormat;
        private Label lblEliminationFormat;
        private Label lblMinNrOfPlayers;
        private TextBox txtMinNrOfPlayers;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblMaxNrOfPlayers;
        private TextBox txtMaxNrOfPlayers;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblVenue;
        private TextBox txtVenue;
        private Button btnCreateTournament;
        private DateTimePicker dtStartDate;
        private DateTimePicker dtEndDate;
    }
}