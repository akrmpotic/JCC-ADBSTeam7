using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBP.AddForms;

namespace TBP.UserControls
{
    public partial class BloodTest : UserControl
    {
        public BloodTest()
        {
            InitializeComponent();
            dataGridView1.DataSource = Services.ParametarTypeServices.GetAllParameterTypes();
        }

        private void btnAddBloodTest_Click(object sender, EventArgs e)
        {
            AddBloodTests addBloodTests = new AddBloodTests();
            addBloodTests.ShowDialog();
        }

        private void buttonAddParameters_Click(object sender, EventArgs e)
        {
            AddParameters addParameters = new AddParameters();
            addParameters.ShowDialog();
        }
    }
}
