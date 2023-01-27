using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            LoginPerson loginPerson = new LoginPerson();
            loginPerson.ShowDialog();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            LoginDoctor loginDoctor = new LoginDoctor();
            loginDoctor.ShowDialog();
        }
    }
}
