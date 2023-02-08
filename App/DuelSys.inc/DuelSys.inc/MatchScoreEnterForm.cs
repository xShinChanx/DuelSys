using MyLibrary;
using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuelSys.inc
{
    public partial class MatchScoreEnterForm : Form
    {
        private LoginForm mainForm;
        private Match match;
        private Tournament selectedTournament;
        public MatchScoreEnterForm(LoginForm mainForm, Match match, Tournament seletedTournament)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.match = match;
            this.selectedTournament = seletedTournament;

            lblPlayer1Name.Text = this.match.Player1.Name;
            lblPlayer2Name.Text = this.match.Player2.Name;
            //rbPlayer1ReachedFirst.Visible = false;
            //rbPlayer2ReachedFirst.Visible = false;
            //btnWinnerSelect.Visible = false;

        }

        private void btnEnterScore_Click(object sender, EventArgs e)
        {
            if (nmPlayer1Score.Value < 21 && nmPlayer2Score.Value < 21)
            {
                MessageBox.Show("Please input valid score");
                return;
            }
            try
            {
                match.Player1Score = Convert.ToInt32(nmPlayer1Score.Value);
                match.Player2Score = Convert.ToInt32(nmPlayer2Score.Value);

                match.Winner = selectedTournament.Type.Rules.GetMatchWinner(match);

                if(match.Winner == null)
                {
                    MessageBox.Show("Please enter a valid score");
                    return;
                }

                mainForm.tournamentManager.UpdateMatch(match);
                SuccesfullyAdded();
            }
            catch (CustomException)
            {
                //rbPlayer1ReachedFirst.Visible = true;
                //rbPlayer2ReachedFirst.Visible = true;

                //btnWinnerSelect.Visible = true;
                //btnEnterScore.Visible = false;
            }
            catch (Exception ex)
            {

            }
        }

        //private void btnWinnerSelect_Click(object sender, EventArgs e)
        //{
        //    if (!rbPlayer1ReachedFirst.Checked && !rbPlayer2ReachedFirst.Checked)
        //    {
        //        MessageBox.Show("Please select a winner");
        //    }

        //    if (rbPlayer1ReachedFirst.Checked)
        //    {
        //        match.Winner = match.Player1;
        //        mainForm.tournamentManager.UpdateMatch(match);
        //        SuccesfullyAdded();
        //    }
        //    else if (rbPlayer2ReachedFirst.Checked)
        //    {
        //        match.Winner = match.Player2;
        //        mainForm.tournamentManager.UpdateMatch(match);
        //        SuccesfullyAdded();
        //    }
        //}

        private void SuccesfullyAdded()
        {
            MessageBox.Show("Succesfully Updated");
            mainForm.OpenChildForm(new TournamentsForm(mainForm), mainForm);
        }
    }
}
