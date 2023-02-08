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
    public partial class CreateUser : Form
    {
        private LoginForm parentForm;
        public CreateUser(LoginForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    MessageBox.Show("Please make sure you have filled all data before creating a user");
                    return;
                }

                Staff newStaff = new Staff();
                newStaff.Username = txtUsername.Text;

                if (txtConfirmPassword.Text == txtPassword.Text)
                {
                    newStaff.Password = txtConfirmPassword.Text;
                    if (parentForm.personManager.CreateUser(newStaff))
                    {
                        MessageBox.Show("Successfuly Added");
                    }
                    else
                        MessageBox.Show("Unsuccesfull, Couldn't add");
                }
                else
                {
                    MessageBox.Show("Please make sure that you have entered the same password");
                }
            }
            catch(DataLayerConnectionFail ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}
