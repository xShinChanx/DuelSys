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
    public partial class Home : Form
    {
        private LoginForm parentForm;
        public Home(LoginForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            PictureBox pictureBox = new PictureBox();
        }
    }
}
