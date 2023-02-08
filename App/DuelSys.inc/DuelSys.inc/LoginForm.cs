using MyLibrary;
using MyLibrary.Manager;

namespace DuelSys.inc
{
    public partial class LoginForm : Form
    {
        private Form activeForm;
        public TournamentManager tournamentManager;
        public PersonManager personManager;

        public LoginForm()
        {
            InitializeComponent();
            panelNav.Visible = false;
        }

        private bool InitializeLogicLayer()
        {
            try
            {
                tournamentManager = new TournamentManager(new TournamentDal());
                personManager = new PersonManager(new PersonDal());
                return true;
            }
            catch (DataLayerConnectionFail ex)
            {
                lblError.Text = "Check your connection.";
                return false;
            }
            catch (Exception ex)
            {
                lblError.Text = "Something went wrong.";
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please check your credentials");
                    return;
                }

                if (InitializeLogicLayer())
                {
                    if (personManager.CheckIfStaff(txtUsername.Text, txtPassword.Text))
                    {
                        OpenChildForm(new Home(this), sender);
                        panelNav.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Please check your credentials");
                    }
                }


            }
            catch (DataLayerConnectionFail ex)
            {
                lblError.Text = "Check your connection.";
            }
            catch (Exception ex)
            {
                lblError.Text = "Something went wrong.";
            }

        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelLogin.Controls.Add(childForm);
            this.panelLogin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnOngoingTournament_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TournamentsForm(this), sender);
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateUser(this), sender);
        }
    }
}