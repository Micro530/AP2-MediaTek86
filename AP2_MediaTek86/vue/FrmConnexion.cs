using AP2_MediaTek86.controleur;
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
    public partial class FrmConnexion : Form
    {
        Controle controle;
        public FrmConnexion(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(txtIdentifiant.Text.Equals("") || txtPwd.Text.Equals(""))
            {
                MessageBox.Show("Vous devez remplir tous les champs afin de vous connecter", "Champ(s) vide(s)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                controle.Authentification(txtIdentifiant.Text, txtPwd.Text);
            }
        }
    }
}
