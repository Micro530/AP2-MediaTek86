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
        BindingSource bdsLesServices = new BindingSource();
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
            RemplirServices();
            DesactiveZoneAjouter();
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
        /// <summary>
        /// permet de remplir le combo des service
        /// </summary>
        private void RemplirServices()
        {
            bdsLesServices.DataSource = controle.GetLesServices();
            comboService.DataSource = bdsLesServices;
        }
        private void ActiveZoneAjouter(string txt)
        {
            zoneAjout.Text = txt;
            zoneAjout.Visible = true;
            zonePers.Enabled = false;
        }

        private void DesactiveZoneAjouter()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtMail.Text = "";
            txtTel.Text = "";
            comboService.SelectedIndex = -1;
            zoneAjout.Visible = false;
            zonePers.Enabled = true;

        }
        private void btsAjouter_Click(object sender, EventArgs e)
        {
            ActiveZoneAjouter("Ajouter un membre aux personnels");
        }

        private void btnZ2Annuler_Click(object sender, EventArgs e)
        {
            DesactiveZoneAjouter();
        }

        private void btnZ2Enregistrer_Click(object sender, EventArgs e)
        {
            if (!(txtNom.Text.Equals("") || txtPrenom.Text.Equals("") || txtMail.Text.Equals("") || txtTel.Text.Equals("")) || comboService.SelectedIndex.Equals(-1))
            {
                Service unService = (Service)bdsLesServices.List[bdsLesServices.Position];
                switch (zoneAjout.Text)
                {
                    case "Ajouter un membre aux personnels":
                        controle.Ajouter(new Personnel(bdsLesPersonnels.Count + 1, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, unService.IdService, unService.Libelle));
                        break;
                    case "Modifier un membre du personnel":
                        int idPersonnel = (int)dgvPersonnel.CurrentRow.Cells["idPersonnel"].Value;
                        controle.Modifier(new Personnel(idPersonnel, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, unService.IdService, unService.Libelle));
                        zonePers.Enabled = true;
                        break;
                }
                ResetFormulaire();
            }
            else
            {
                MessageBox.Show("Vous devez entrer des valeurs dans tous les champs de saisie avant de pouvoir enregistrer une nouvelle entrée", "Champ(s) vide(s)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if(selectionDev("Vous devez selectionner un developpeur avant de pouvoir le modifier", "Aucun developpeur selectionné"))
            {
                ActiveZoneAjouter("Modifier un membre du personnel");
                txtNom.Text = (string)dgvPersonnel.CurrentRow.Cells["nom"].Value;
                txtPrenom.Text = (string)dgvPersonnel.CurrentRow.Cells["prenom"].Value;
                txtMail.Text = (string)dgvPersonnel.CurrentRow.Cells["mail"].Value;
                txtTel.Text = (string)dgvPersonnel.CurrentRow.Cells["tel"].Value;
                comboService.SelectedIndex = comboService.FindStringExact((string)dgvPersonnel.CurrentRow.Cells["service"].Value);
            }
        }
        private bool selectionDev(String msg1, String msg2)
        {
            if (dgvPersonnel.CurrentRow.Index.Equals(-1))
            {
                MessageBox.Show(msg1, msg2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
