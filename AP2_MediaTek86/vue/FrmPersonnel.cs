using AP2_MediaTek86.controleur;
using AP2_MediaTek86.model;
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
        BindingSource bdsLesPersonnels = new BindingSource();
        /// <summary>
        /// le constructeur valorisant controle et initialise le formulaire
        /// </summary>
        /// <param name="controle">l'instance de controle avec qui communiquer</param>
        public FrmPersonnel(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
            ResetFormulaire();
        }
        /// <summary>
        /// Permet de mettre ou remettre le formulaire à l'été d'origine
        /// </summary>
        private void ResetFormulaire()
        {
            RemplirPersonnels();
        }
        /// <summary>
        /// permet de remplire le DataGridView avec le personnel
        /// </summary>
        private void RemplirPersonnels()
        {
            bdsLesPersonnels.DataSource = controle.GetLesPersonnels();
            dgvPersonnel.DataSource = bdsLesPersonnels;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.Columns["idservice"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void zone1Dev_Enter(object sender, EventArgs e)
        {

        }

        private void btsAjouter_Click(object sender, EventArgs e)
        {

        }
    }
}
