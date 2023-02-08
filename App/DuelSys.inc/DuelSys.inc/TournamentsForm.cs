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
    public partial class TournamentsForm : Form
    {
        private LoginForm parentForm;
        public TournamentsForm(LoginForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            ShowOnGoingTournaments();
        }

        public void ShowOnGoingTournaments()
        {
            foreach (Tournament t in parentForm.tournamentManager.listOfTournaments)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(t.ID));
                item.SubItems.Add(t.Name);
                item.SubItems.Add(t.TournamentSystem.ToString());
                item.SubItems.Add(t.Venue);
                item.SubItems.Add(t.StartDate.ToString("dd-MMM-yyy"));
                item.SubItems.Add(t.EndDate.ToString("dd-MMM-yyy"));
                lvOngoingTournaments.Items.Add(item);
            }
        }

        private void btnSelectedTournament_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = Convert.ToInt32(lvOngoingTournaments.SelectedItems[0].SubItems[0].Text);
                parentForm.OpenChildForm(new SelectedTournament(this, selectedID, parentForm), sender);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a tournament before proceding.", "Error");
            }
        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new CreateTournament(this, parentForm), sender);
        }
    }
}
