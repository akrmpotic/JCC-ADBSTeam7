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
    public partial class UrinaryIncontinence : UserControl
    {
        public UrinaryIncontinence()
        {
            InitializeComponent();
            dataGridView2.DataSource = Services.ExistingContinences.GetAllExistingContinences();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUrinaryIncontinences addUrinaryIncontinences = new AddUrinaryIncontinences();
            addUrinaryIncontinences.ShowDialog();
        }
    }
}
