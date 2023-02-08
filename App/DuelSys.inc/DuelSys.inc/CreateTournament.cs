using MyLibrary;
using MyLibrary.Model;
using MyLibrary.Sport;
using MyLibrary.TournamentSystem;
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
    public partial class CreateTournament : Form
    {
        private TournamentsForm parentForm;
        private LoginForm mainForm;

        public CreateTournament(TournamentsForm parentForm, LoginForm mainForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.mainForm = mainForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {
            Tournament newTournament = new Tournament();

            if (!InputValidation())
            {
                return;
            }



            newTournament.Venue = txtVenue.Text;
            newTournament.EndDate = dtEndDate.Value.Date;
            newTournament.StartDate = dtStartDate.Value.Date;
            newTournament.Name = txtName.Text;
            newTournament.MinNrOfPlayers = int.Parse(txtMinNrOfPlayers.Text);
            newTournament.Type = new Badminton();
            newTournament.MaxNrOfPlayers = int.Parse(txtMaxNrOfPlayers.Text);
            newTournament.TournamentSystem = mainForm.tournamentManager.TypeOfElimination(cbEliminationFormat.Text).TournamentSystem;
            newTournament.Description = txtDescription.Text;

            if (mainForm.tournamentManager.CreateTournamentObject(newTournament))
            {
                MessageBox.Show("Tournament successfully added");
                mainForm.OpenChildForm(new TournamentsForm(mainForm), sender);
            }
            else
                MessageBox.Show("Tournament adding unsuccessful");
        }

        private bool InputValidation()
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtMinNrOfPlayers.Text) || string.IsNullOrEmpty(txtMaxNrOfPlayers.Text) || string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtVenue.Text))
            {
                MessageBox.Show("Please check if you filled out all the details");
                return false;
            }

            if (cbEliminationFormat.SelectedIndex == -1)
            {
                MessageBox.Show("Please check if you selected Elimination Format");
                return false;
            }
            if (mainForm.tournamentManager.CheckMinAndMaxNrOfPlayer(Convert.ToInt32(txtMaxNrOfPlayers.Text), Convert.ToInt32(txtMinNrOfPlayers.Text)))
            {
                MessageBox.Show("Maximum number of players cannot be less than minimum number of players");
                return false;
            }
            if (dtEndDate.Value < dtStartDate.Value)
            {
                MessageBox.Show("Choose valid date");
                return false;
            }

            return true;
        }
    }
}
