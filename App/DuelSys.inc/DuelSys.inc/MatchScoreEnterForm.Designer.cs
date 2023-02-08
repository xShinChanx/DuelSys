namespace DuelSys.inc
{
    partial class MatchScoreEnterForm
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
            this.nmPlayer2Score = new System.Windows.Forms.NumericUpDown();
            this.nmPlayer1Score = new System.Windows.Forms.NumericUpDown();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.btnEnterScore = new System.Windows.Forms.Button();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmPlayer2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPlayer1Score)).BeginInit();
            this.SuspendLayout();
            // 
            // nmPlayer2Score
            // 
            this.nmPlayer2Score.Location = new System.Drawing.Point(610, 145);
            this.nmPlayer2Score.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmPlayer2Score.Name = "nmPlayer2Score";
            this.nmPlayer2Score.Size = new System.Drawing.Size(150, 27);
            this.nmPlayer2Score.TabIndex = 0;
            // 
            // nmPlayer1Score
            // 
            this.nmPlayer1Score.Location = new System.Drawing.Point(296, 145);
            this.nmPlayer1Score.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmPlayer1Score.Name = "nmPlayer1Score";
            this.nmPlayer1Score.Size = new System.Drawing.Size(150, 27);
            this.nmPlayer1Score.TabIndex = 1;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(296, 80);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(64, 20);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Player 1:";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Location = new System.Drawing.Point(508, 110);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(22, 20);
            this.lblVS.TabIndex = 3;
            this.lblVS.Text = "vs";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(610, 80);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(64, 20);
            this.lblPlayer2.TabIndex = 4;
            this.lblPlayer2.Text = "Player 2:";
            // 
            // btnEnterScore
            // 
            this.btnEnterScore.Location = new System.Drawing.Point(467, 218);
            this.btnEnterScore.Name = "btnEnterScore";
            this.btnEnterScore.Size = new System.Drawing.Size(128, 29);
            this.btnEnterScore.TabIndex = 5;
            this.btnEnterScore.Text = "Enter Score";
            this.btnEnterScore.UseVisualStyleBackColor = true;
            this.btnEnterScore.Click += new System.EventHandler(this.btnEnterScore_Click);
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Location = new System.Drawing.Point(696, 80);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(0, 20);
            this.lblPlayer2Name.TabIndex = 6;
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(382, 80);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(0, 20);
            this.lblPlayer1Name.TabIndex = 7;
            // 
            // MatchScoreEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 295);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.btnEnterScore);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.nmPlayer1Score);
            this.Controls.Add(this.nmPlayer2Score);
            this.Name = "MatchScoreEnterForm";
            this.Text = "MatchScoreEnterForm";
            ((System.ComponentModel.ISupportInitialize)(this.nmPlayer2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPlayer1Score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nmPlayer2Score;
        private NumericUpDown nmPlayer1Score;
        private Label lblPlayer1;
        private Label lblVS;
        private Label lblPlayer2;
        private Button btnEnterScore;
        private Label lblPlayer2Name;
        private Label lblPlayer1Name;
    }
}