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
    public partial class PregnancyHistory : UserControl
    {
        public PregnancyHistory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPregnancyHistory addPregnancyHistory = new AddPregnancyHistory();
            addPregnancyHistory.ShowDialog();
        }
    }
}
