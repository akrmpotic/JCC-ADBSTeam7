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
    public partial class GynecologicalTumors : UserControl
    {
        public GynecologicalTumors()
        {
            InitializeComponent();
            dataGridView2.DataSource = Services.ExistingTumorsService.GetAllExistingTumors();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddGynecologicalTumors addGynecologicalTumors = new AddGynecologicalTumors();
            addGynecologicalTumors.ShowDialog();
        }
    }
}
