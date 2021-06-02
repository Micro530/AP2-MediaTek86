using AP2_MediaTek86.connexion;
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
    public partial class FrmAbsences : Form
    {
        Controle controle;
        Personnel unPersonnel;
        BindingSource bdsLesAbsences = new BindingSource();
        BindingSource bdsLesMotifs = new BindingSource();
        public FrmAbsences(Controle controle, Personnel unPersonnel)
        {
            this.unPersonnel = unPersonnel;
            this.controle = controle;
            InitializeComponent();
            ResetFormulaire();
            


        }
        /// <summary>
        /// Permet de mettre ou remettre le formulaire à l'été d'origine
        /// </summary>
        private void ResetFormulaire()
        {
            RemplirAbsences();
            RemplirMotif();
            DesactiveZoneAjouter();
        }
        /// <summary>
        /// permet de remplire le DataGridView avec les absences
        /// </summary>
        private void RemplirAbsences()
        {
            bdsLesAbsences.DataSource = controle.GetLesAbsences(unPersonnel);
            dgvAbsences.DataSource = bdsLesAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.Columns["idmotif"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void RemplirMotif()
        {
            bdsLesMotifs.DataSource = controle.GetLesMotif();
            comboMotif.DataSource = bdsLesMotifs;
        }
        /// <summary>
        /// permet d'activer la zone d'ajout/modification
        /// </summary>
        /// <param name="txt"></param>
        private void ActiveZoneAjouter(string txt)
        {
            zoneAjout.Text = txt;
            zoneAjout.Visible = true;
            zoneAbsence.Enabled = false;
        }
        /// <summary>
        /// permet de desectiver la zone d'aout/modification
        /// </summary>
        private void DesactiveZoneAjouter()
        {
            
            comboMotif.SelectedIndex = -1;
            zoneAjout.Visible = false;
            zoneAbsence.Enabled = true;
        }
        
        private void btnRetourPersonnel_Click(object sender, EventArgs e)
        {
            controle.AccesAuFrmPersonnel();
        }
        /// <summary>
        /// évenement clic sur le bouton ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btsAjouter_Click(object sender, EventArgs e)
        {
            ActiveZoneAjouter("Ajouter une absence");
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (selectionDev("Vous devez selectionner un membre du personel avant de pouvoir le modifier", "Aucun personnel selectionné"))
            {
                ActiveZoneAjouter("Modifier une absence");
                calendrierDebut.Value = (DateTime)dgvAbsences.CurrentRow.Cells["datedebut"].Value;
                calendrierFin.Value = (DateTime)dgvAbsences.CurrentRow.Cells["datefin"].Value;
                comboMotif.SelectedIndex = comboMotif.FindStringExact((string)dgvAbsences.CurrentRow.Cells["motif"].Value);
            }
        }
        private bool selectionDev(String msg1, String msg2)
        {
            if (dgvAbsences.CurrentRow.Index.Equals(-1))
            {
                MessageBox.Show(msg1, msg2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnZ2Enregistrer_Click(object sender, EventArgs e)
        {
            if (!comboMotif.SelectedIndex.Equals(-1) || calendrierDebut.Value > calendrierFin.Value )
            {
                DateTime datedebut = (DateTime)dgvAbsences.CurrentRow.Cells["datedebut"].Value;
                DateTime datedefin = (DateTime)dgvAbsences.CurrentRow.Cells["datefin"].Value;
                if (MessageBox.Show("Voulez-vous vraiment modifier l'absence du" + datedebut + " au " + datedefin + " ?", "Confirmation de modifiation", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Motif unMotif = (Motif)bdsLesMotifs.List[bdsLesMotifs.Position];
                    switch (zoneAjout.Text)
                    {
                        case "Ajouter une absence":
                            controle.Ajouter(new Absences(unPersonnel.IdPersonnel, calendrierDebut.Value, calendrierFin.Value, unMotif.IdMotif, unMotif.Libelle));
                            break;
                        case "Modifier une absence":
                            if (calendrierDebut.Value.Equals((DateTime)dgvAbsences.CurrentRow.Cells["datedebut"].Value))
                            {
                                controle.Modifier(new Absences(unPersonnel.IdPersonnel, datedebut, calendrierFin.Value, unMotif.IdMotif, unMotif.Libelle));
                            }
                            else
                            {
                                modificationDateCle();
                            }
                            break;
                    }
                    ResetFormulaire();
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas sélectionné de motif ou bien les dates ne sont pas cohérente", "Champ(s) vide(s)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void modificationDateCle()
        {
            controle.Supprimer((Absences)bdsLesAbsences.List[bdsLesAbsences.Position]);
            Motif unMotif = (Motif)bdsLesMotifs.List[bdsLesMotifs.Position];
            controle.Ajouter(new Absences(unPersonnel.IdPersonnel, calendrierDebut.Value, calendrierFin.Value, unMotif.IdMotif, unMotif.Libelle));
        } 
        /// <summary>
        /// événement clic sur le bouton annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZ2Annuler_Click(object sender, EventArgs e)
        {
            DesactiveZoneAjouter();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {

        }
    }
}
