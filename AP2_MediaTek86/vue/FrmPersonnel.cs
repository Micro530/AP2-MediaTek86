﻿using AP2_MediaTek86.controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2_MediaTek86.vue
{
    public partial class FrmPersonnel : Form
    {
        Controle controle;
        public FrmPersonnel(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
        }

        private void zone1Dev_Enter(object sender, EventArgs e)
        {

        }

        private void btsAjouter_Click(object sender, EventArgs e)
        {

        }
    }
}
