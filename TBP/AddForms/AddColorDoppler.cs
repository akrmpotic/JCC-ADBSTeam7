using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBP.AddForms
{
    public partial class AddColorDoppler : Form
    {
        public AddColorDoppler()
        {
            InitializeComponent();
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
