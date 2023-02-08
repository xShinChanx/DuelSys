namespace DuelSys.inc
{
    partial class EditSelectedTournament
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
            this.btnEditTournament = new System.Windows.Forms.Button();
            this.lblVenue = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMaxNrOfPlayers = new System.Windows.Forms.Label();
            this.txtMaxNrOfPlayers = new System.Windows.Forms.TextBox();
            this.lblMinNrOfPlayers = new System.Windows.Forms.Label();
            this.txtMinNrOfPlayers = new System.Windows.Forms.TextBox();
            this.cbEliminationFormat = new System.Windows.Forms.ComboBox();
            this.lblEliminationFormat = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEditTournament
            // 
            this.btnEditTournament.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditTournament.Location = new System.Drawing.Point(420, 275);
            this.btnEditTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditTournament.Name = "btnEditTournament";
            this.btnEditTournament.Size = new System.Drawing.Size(201, 31);
            this.btnEditTournament.TabIndex = 44;
            this.btnEditTournament.Text = "Edit Tournament";
            this.btnEditTournament.UseVisualStyleBackColor = false;
            this.btnEditTournament.Click += new System.EventHandler(this.btnEditTournament_Click);
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(543, 70);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(52, 20);
            this.lblVenue.TabIndex = 42;
            this.lblVenue.Text = "Venue:";
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(598, 66);
            this.txtVenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(235, 27);
            this.txtVenue.TabIndex = 41;
            this.txtVenue.Text = "Eindhoven SSC";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(598, 113);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(235, 123);
            this.txtDescription.TabIndex = 40;
            this.txtDescription.Text = "Please bring your rackets";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(511, 113);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(88, 20);
            this.lblDescription.TabIndex = 39;
            this.lblDescription.Text = "Description:";
            // 
            // lblMaxNrOfPlayers
            // 
            this.lblMaxNrOfPlayers.AutoSize = true;
            this.lblMaxNrOfPlayers.Location = new System.Drawing.Point(131, 214);
            this.lblMaxNrOfPlayers.Name = "lblMaxNrOfPlayers";
            this.lblMaxNrOfPlayers.Size = new System.Drawing.Size(202, 20);
            this.lblMaxNrOfPlayers.TabIndex = 37;
            this.lblMaxNrOfPlayers.Text = "Maximum number of players:";
            // 
            // txtMaxNrOfPlayers
            // 
            this.txtMaxNrOfPlayers.Location = new System.Drawing.Point(336, 209);
            this.txtMaxNrOfPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaxNrOfPlayers.Name = "txtMaxNrOfPlayers";
            this.txtMaxNrOfPlayers.Size = new System.Drawing.Size(154, 27);
            this.txtMaxNrOfPlayers.TabIndex = 36;
            this.txtMaxNrOfPlayers.Text = "10";
            // 
            // lblMinNrOfPlayers
            // 
            this.lblMinNrOfPlayers.AutoSize = true;
            this.lblMinNrOfPlayers.Location = new System.Drawing.Point(134, 169);
            this.lblMinNrOfPlayers.Name = "lblMinNrOfPlayers";
            this.lblMinNrOfPlayers.Size = new System.Drawing.Size(199, 20);
            this.lblMinNrOfPlayers.TabIndex = 34;
            this.lblMinNrOfPlayers.Text = "Minimum number of players:";
            // 
            // txtMinNrOfPlayers
            // 
            this.txtMinNrOfPlayers.Location = new System.Drawing.Point(336, 162);
            this.txtMinNrOfPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinNrOfPlayers.Name = "txtMinNrOfPlayers";
            this.txtMinNrOfPlayers.Size = new System.Drawing.Size(154, 27);
            this.txtMinNrOfPlayers.TabIndex = 33;
            this.txtMinNrOfPlayers.Text = "2";
            // 
            // cbEliminationFormat
            // 
            this.cbEliminationFormat.FormattingEnabled = true;
            this.cbEliminationFormat.Items.AddRange(new object[] {
            "Round-robin",
            "Double round-robin"});
            this.cbEliminationFormat.Location = new System.Drawing.Point(336, 113);
            this.cbEliminationFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEliminationFormat.Name = "cbEliminationFormat";
            this.cbEliminationFormat.Size = new System.Drawing.Size(154, 28);
            this.cbEliminationFormat.TabIndex = 32;
            // 
            // lblEliminationFormat
            // 
            this.lblEliminationFormat.AutoSize = true;
            this.lblEliminationFormat.Location = new System.Drawing.Point(195, 116);
            this.lblEliminationFormat.Name = "lblEliminationFormat";
            this.lblEliminationFormat.Size = new System.Drawing.Size(138, 20);
            this.lblEliminationFormat.TabIndex = 31;
            this.lblEliminationFormat.Text = "Elimination Format:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(281, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(336, 66);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 27);
            this.txtName.TabIndex = 25;
            this.txtName.Text = "Badminton";
            // 
            // EditSelectedTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 341);
            this.Controls.Add(this.btnEditTournament);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblMaxNrOfPlayers);
            this.Controls.Add(this.txtMaxNrOfPlayers);
            this.Controls.Add(this.lblMinNrOfPlayers);
            this.Controls.Add(this.txtMinNrOfPlayers);
            this.Controls.Add(this.cbEliminationFormat);
            this.Controls.Add(this.lblEliminationFormat);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "EditSelectedTournament";
            this.Text = "EditSelectedTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnEditTournament;
        private Label lblVenue;
        private TextBox txtVenue;
        private TextBox txtDescription;
        private Label lblDescription;
        private Label lblMaxNrOfPlayers;
        private TextBox txtMaxNrOfPlayers;
        private Label lblMinNrOfPlayers;
        private TextBox txtMinNrOfPlayers;
        private ComboBox cbEliminationFormat;
        private Label lblEliminationFormat;
        private Label lblName;
        private TextBox txtName;
    }
}