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
using TBP.DataAccess;

namespace TBP.UserControls
{
    public partial class CTG : UserControl
    {
        public CTG()
        {
            InitializeComponent();
            dataGridView1.DataSource = Services.CTGServices.GetAllCTGs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCTG addCTG = new AddCTG();
            addCTG.ShowDialog();
        }
    }
}
