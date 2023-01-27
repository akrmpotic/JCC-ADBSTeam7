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
    public partial class AddPerson : UserControl
    {
        public AddPerson()
        {
            InitializeComponent();
            dataGridView1.DataSource = Services.PersonServices.GetAllPersons();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowHospitals showHospitals = new ShowHospitals();
            showHospitals.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDoctors showDoctors = new ShowDoctors();
            showDoctors.ShowDialog();
        }
    }
}
