﻿using System;
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
    public partial class ShowDoctors : Form
    {
        public ShowDoctors()
        {
            InitializeComponent();
            dataGridView1.DataSource = Services.DoctorServices.GetAllDoctors();
        }
    }
}
