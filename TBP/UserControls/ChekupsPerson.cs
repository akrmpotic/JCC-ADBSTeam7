using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBP.UserControls;

namespace TBP
{
    public partial class ChekupsPerson : Form
    {
        public ChekupsPerson()
        {
            InitializeComponent();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnPAP_Click(object sender, EventArgs e)
        {
            PAPTest papTest = new PAPTest();
            AddUserControl(papTest);

        }

        private void btnTumors_Click(object sender, EventArgs e)
        {
            GynecologicalTumors gynecologicalTumors = new GynecologicalTumors();
            AddUserControl(gynecologicalTumors);
        }

        private void btnUrinary_Click(object sender, EventArgs e)
        {
            UrinaryIncontinence urinaryIncontinence = new UrinaryIncontinence();
            AddUserControl(urinaryIncontinence);
        }

        private void btnBlood_Click(object sender, EventArgs e)
        {
            BloodTest bloodTest = new BloodTest();
            AddUserControl(bloodTest);
        }

        private void btnColorDoppler_Click(object sender, EventArgs e)
        {
            ColorDoppler colorDoppler = new ColorDoppler();
            AddUserControl(colorDoppler);
        }

        private void btnCTG_Click(object sender, EventArgs e)
        {
            CTG ctg = new CTG();
            AddUserControl(ctg);
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            GynecologicalEamination gynecologicalEamination = new GynecologicalEamination();
            AddUserControl(gynecologicalEamination);
        }

        private void btnUltrasound_Click(object sender, EventArgs e)
        {
            UltraSound ultraSound = new UltraSound();
            AddUserControl(ultraSound);
        }

        private void btnPregnancyHistory_Click(object sender, EventArgs e)
        {
            PregnancyHistory pregnancyHistory = new PregnancyHistory();
            AddUserControl(pregnancyHistory);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            AddUserControl(addPerson);
        }
    }
}
