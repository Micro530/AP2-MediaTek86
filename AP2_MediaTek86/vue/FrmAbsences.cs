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
            calendrierDebut.Value = DateTime.Now;
            calendrierFin.Value = DateTime.Now;
            comboMotif.SelectedIndex = -1;
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
            if (selectionDgv("Vous devez selectionner une absence avant de pouvoir la modifier", "Aucune absence selectionnée"))
            {
                ActiveZoneAjouter("Modifier une absence");
                calendrierDebut.Value = (DateTime)dgvAbsences.CurrentRow.Cells["datedebut"].Value;
                calendrierFin.Value = (DateTime)dgvAbsences.CurrentRow.Cells["datefin"].Value;
                comboMotif.SelectedIndex = comboMotif.FindStringExact((string)dgvAbsences.CurrentRow.Cells["motif"].Value);
            }
        }
        private bool selectionDgv(String msg1, String msg2)
        {
            if (dgvAbsences.CurrentRow is null || dgvAbsences.CurrentRow.Index.Equals(-1))
            {
                MessageBox.Show(msg1, msg2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// évènement enregistrer un ajout ou une modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZ2Enregistrer_Click(object sender, EventArgs e)
        {
            if (!(comboMotif.SelectedIndex.Equals(-1) || DateTime.Compare(calendrierDebut.Value, calendrierFin.Value).Equals(1)) )
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
                            DateTime datedebut = (DateTime)dgvAbsences.CurrentRow.Cells["datedebut"].Value;
                            DateTime datedefin = (DateTime)dgvAbsences.CurrentRow.Cells["datefin"].Value;
                            if (MessageBox.Show("Voulez-vous vraiment modifier l'absence du" + datedebut + " au " + datedefin + " ?", "Confirmation de modifiation",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                controle.Modifier(new Absences(unPersonnel.IdPersonnel, datedebut, calendrierFin.Value, unMotif.IdMotif, unMotif.Libelle));
                            }
                        }
                        else
                        {
                            modificationDateCle();
                        }
                        break;
                        ResetFormulaire();
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas sélectionné de motif ou bien les dates ne sont pas cohérente", "Champ(s) vide(s)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// evenement si la modification change la date de début
        /// </summary>
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
            if(selectionDgv("Vous devez selectionner une absence avant de pouvoir la supprimer", "Aucune absence selectionnée"))
            {
                DateTime datedebut = (DateTime)dgvAbsences.CurrentRow.Cells["datedebut"].Value;
                DateTime datedefin = (DateTime)dgvAbsences.CurrentRow.Cells["datefin"].Value;
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence du" + datedebut + " au " + datedefin + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    controle.Supprimer((Absences)bdsLesAbsences.List[bdsLesAbsences.Position]);
                    ResetFormulaire();
                }
            }       
        }
    }
}
