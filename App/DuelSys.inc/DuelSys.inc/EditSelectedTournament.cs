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
    public partial class EditSelectedTournament : Form
    {
        private TournamentsForm parentForm;
        private int selectedID;
        private Tournament selectedTournament;
        private LoginForm mainForm;

        public EditSelectedTournament(TournamentsForm parentForm, int selectedID, LoginForm mainForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.selectedID = selectedID;
            this.mainForm = mainForm;
            selectedTournament = mainForm.tournamentManager.GetTournament(selectedID);
            FillInDetailsOfTournament();
        }

        private void FillInDetailsOfTournament()
        {
            txtName.Text = selectedTournament.Name;
            cbEliminationFormat.Text = selectedTournament.TournamentSystem.ToString();
            txtMinNrOfPlayers.Text = selectedTournament.MinNrOfPlayers.ToString();
            txtMaxNrOfPlayers.Text = selectedTournament.MaxNrOfPlayers.ToString();
            txtVenue.Text = selectedTournament.Venue;
            txtDescription.Text = selectedTournament.Description;

            DisableTheFields();
        }

        private void DisableTheFields()
        {
            txtName.Enabled = false;
            cbEliminationFormat.Enabled = false;
            txtMinNrOfPlayers.Enabled = false;
            txtMaxNrOfPlayers.Enabled = false;
            txtVenue.Enabled = false;
            txtDescription.Enabled = false;
        }

        private bool InputValidation()
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtMinNrOfPlayers.Text) || string.IsNullOrEmpty(txtMaxNrOfPlayers.Text) || string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtVenue.Text))
            {
                MessageBox.Show("Please check if you filled out all the details");
                return false;
            }
            return true;
        }

        private void btnEditTournament_Click(object sender, EventArgs e)
        {
            if(btnEditTournament.Text == "Edit Tournament")
            {
                txtName.Enabled = true;
                txtMinNrOfPlayers.Enabled = true;
                txtMaxNrOfPlayers.Enabled = true;
                txtVenue.Enabled = true;
                txtDescription.Enabled = true;

                btnEditTournament.BackColor = Color.YellowGreen;
                btnEditTournament.Text = "Save Changes";
            }
            else if(btnEditTournament.Text == "Save Changes")
            {
                if (!InputValidation())
                {
                    FillBackOriginalDataIfInputIsInvalid();
                    return;
                }

                DisableTheFields();

                selectedTournament.Name = txtName.Text;

                if(!mainForm.tournamentManager.CheckEditForMinNrOfPlayer(selectedTournament, Convert.ToInt32(txtMinNrOfPlayers.Text), mainForm.personManager))
                {
                    MessageBox.Show("Minimum number of players can not exceed number of player in tournament and min players cant be less than 2");
                    FillBackOriginalDataIfInputIsInvalid();
                    return;
                }

                selectedTournament.MinNrOfPlayers = Convert.ToInt32(txtMinNrOfPlayers.Text);

                if(mainForm.personManager.listOfPlayerInTournament.Count > Convert.ToInt32(txtMaxNrOfPlayers.Text))
                {
                    MessageBox.Show($"Maximum number of players can not be less than number of players in tournament. Nr.Of Players in tournament {mainForm.personManager.listOfPlayerInTournament.Count()}");
                    FillBackOriginalDataIfInputIsInvalid();
                    return;
                }
                selectedTournament.MaxNrOfPlayers = Convert.ToInt32(txtMaxNrOfPlayers.Text);
                selectedTournament.Venue = txtVenue.Text;
                selectedTournament.Description = txtDescription.Text;

                mainForm.tournamentManager.UpdateTournament(selectedTournament);
                btnEditTournament.Text = "Edit Tournament";
                btnEditTournament.BackColor = SystemColors.Control;
                MessageBox.Show("Sucessfully Updated");
            }
        }

        private void FillBackOriginalDataIfInputIsInvalid()
        {
            FillInDetailsOfTournament();
            btnEditTournament.Text = "Edit Tournament";
            btnEditTournament.BackColor = SystemColors.Control;
            return;
        }
    }
}
