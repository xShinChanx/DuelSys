using MyLibrary.Model;

namespace DuelSys.inc
{
    public partial class SelectedTournament : Form
    {
        private TournamentsForm parentForm;
        private LoginForm mainForm;
        private int selectedID;
        private Tournament selectedTournament;
        private Dictionary<int, string> dict = new Dictionary<int, string>();

        public SelectedTournament(TournamentsForm parentForm, int selectedID, LoginForm mainForm)
        {
            InitializeComponent();
            this.selectedID = selectedID;
            this.parentForm = parentForm;
            this.mainForm = mainForm;
            this.selectedTournament = this.mainForm.tournamentManager.GetTournament(this.selectedID);
            this.mainForm.personManager.GetTournamentListBasedOnID(this.selectedID);

            lvPlayers.Visible = false;
            lbTournamentResults.Visible = false;

            AddElementsToDict();
            ShowAllTheMatches();
            ShowPlayerRanking();

            if (selectedTournament.Status == true)
            {
                btnStartSelectedTournament.Visible = false;
            }
        }

        private void ShowAllTheMatches()
        {
            lvMatch.Visible = true;
            lvPlayers.Visible = false;
            lvMatch.Items.Clear();

            foreach (Match m in mainForm.tournamentManager.GetMatchBasedOnTournament(selectedTournament.ID))
            {
                ListViewItem item = new ListViewItem(Convert.ToString(m.Id));
                item.SubItems.Add(m.Player1.Name);

                if (m.Player1Score == 0 && m.Player2Score == 0)
                {
                    item.SubItems.Add("vs");
                }
                else
                {
                    item.SubItems.Add($"{m.Player1Score} - {m.Player2Score}");
                }
                item.SubItems.Add(m.Player2.Name);

                if (m.Winner == null)
                {
                    item.SubItems.Add("");
                }
                else
                {
                    item.SubItems.Add(m.Winner.Name);
                }
                lvMatch.Items.Add(item);
            }
        }

        private void btnEditSelectedTournament_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new EditSelectedTournament(parentForm, selectedID, mainForm), sender);
        }

        private void btnStartSelectedTournament_Click(object sender, EventArgs e)
        {
            if (mainForm.personManager.listOfPlayerInTournament.Count() < selectedTournament.MinNrOfPlayers)
            {
                MessageBox.Show($"You need at least {selectedTournament.MinNrOfPlayers} to start the tournament");
                return;
            }

            if (mainForm.tournamentManager.GenerateSchedule(Convert.ToInt32(selectedID), mainForm.personManager))
            {
                MessageBox.Show("Tournament Schedule Created!");
                ShowAllTheMatches();
                mainForm.tournamentManager.GetAllTournaments();
                mainForm.OpenChildForm(new TournamentsForm(mainForm), sender);
            }
            else
                MessageBox.Show("Couldnt Create schedule");

            if (selectedTournament.Status == true)
            {
                btnStartSelectedTournament.Visible = false;
            }
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            lvMatch.Visible = false;
            lvPlayers.Visible = true;
            btnEnterScore.Visible = false;
            lvPlayers.Items.Clear();
            foreach (Player p in mainForm.personManager.listOfPlayerInTournament)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(p.Id));
                item.SubItems.Add((p.Name));
                lvPlayers.Items.Add(item);
            }
        }

        private void btnDeleteTournament_Click(object sender, EventArgs e)
        {
            if (mainForm.tournamentManager.DeleteTournament(selectedTournament))
            {
                MessageBox.Show("Deleted the Tournament");
                mainForm.OpenChildForm(new TournamentsForm(mainForm), sender);
            }
        }

        private void btnScheduledMatches_Click(object sender, EventArgs e)
        {
            btnEnterScore.Visible = true;
            ShowAllTheMatches();
        }

        private void btnEnterScore_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = Convert.ToInt32(lvMatch.SelectedItems[0].SubItems[0].Text);
                Match match = mainForm.tournamentManager.GetMatchBasedOnID(selectedID, selectedTournament.ID);

                mainForm.OpenChildForm(new MatchScoreEnterForm(mainForm, match, selectedTournament), sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a valid match");
            }
        }

        private void ShowPlayerRanking()
        {
            int i = 1;
            if (mainForm.tournamentManager.CheckIfTournamentIsDone(selectedID))
            {
                btnEditSelectedTournament.Enabled = false;
                btnEnterScore.Enabled = false;

                foreach (Player p in mainForm.personManager.GetTopThreePlayersFromTournament(selectedID, mainForm.personManager))
                {
                    lbTournamentResults.Visible = true;
                    lbTournamentResults.Items.Add($"{dict[i]}: {p.Name}");
                    i++;
                }
            }
        }

        private void AddElementsToDict()
        {
            dict.Add(1, "Gold");
            dict.Add(2, "Silver");
            dict.Add(3, "Bronze");
        }
    }
}
