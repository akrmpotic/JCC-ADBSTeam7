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
    public partial class ColorDoppler : UserControl
    {
        public ColorDoppler()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddColorDoppler addColorDoppler = new AddColorDoppler();
            addColorDoppler.ShowDialog();
        }
    }
}
