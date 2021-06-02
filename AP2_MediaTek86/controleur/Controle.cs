using AP2_MediaTek86.dal;
using AP2_MediaTek86.model;
using AP2_MediaTek86.vue;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AP2_MediaTek86.controleur
{
    public class Controle
    {
        /// <summary>
        /// permet de mémoriser le formulaire personnel
        /// </summary>
        private FrmPersonnel frmPersonnel;
        /// <summary>
        /// permet de mémoriser le formulaire absence
        /// </summary>
        private FrmAbsences frmAbsences;
        /// <summary>
        /// permet de mémoriser le formulaire connexion
        /// </summary>
        private FrmConnexion frmConnexion;
        /// <summary>
        /// constructeur de control qui instancie le formulaire de connexion
        /// </summary>
        public Controle()
        {
            frmConnexion = new FrmConnexion(this);
            frmConnexion.ShowDialog();
        }
        /// <summary>
        /// recupére les données depuis AccesDonnees
        /// </summary>
        /// <returns>la liste du personnel</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return AccesDonnees.GetLesPersonnels();
        }
        /// <summary>
        /// recupére les données depuis AccesDonnees
        /// </summary>
        /// <param name="idpersonnel">le personnel</param>
        /// <returns>la liste des absences</returns>
        public List<Absences> GetLesAbsences(Personnel unPersonnel)
        {
            return AccesDonnees.GetLesAbsences(unPersonnel);
        }
        /// <summary>
        /// recupére les données depuis AccesDonnees
        /// </summary>
        /// <returns>la liste dus motif d'absences</returns>
        public List<Motif> GetLesMotif()
        {
            return AccesDonnees.GetLesMotif();
        }
        /// <summary>
        /// recupére les données depuis AccesDonnees
        /// </summary>
        /// <returns>la liste des services</returns>
        public List<Service> GetLesServices()
        {
            return AccesDonnees.GetLesServices();
        }
        /// <summary>
        /// envoie l'objet pour qu'il soit ajouté à la bdd
        /// </summary>
        /// <param name="unObjet">soit de type Personnel ou Absences</param>
        public void Ajouter(object unObjet)
        {
            if(unObjet is Personnel)
            {
                AccesDonnees.AjoutPersonnel((Personnel)unObjet);
            }
            else
            {
                AccesDonnees.AjoutAbsence((Absences)unObjet);
            }
        }
        /// <summary>
        /// envoie l'objet devant être modifié à la bdd
        /// </summary>
        /// <param name="unObjet">soit de type Personnel ou Absences</param>
        public void Modifier(object unObjet)
        {
            if (unObjet is Personnel)
            {
                AccesDonnees.ModifierPersonnel((Personnel)unObjet);
            }
            else
            {
                AccesDonnees.ModifierAbsence((Absences)unObjet);
            }
        }
        /// <summary>
        /// gére la demande de suppression
        /// </summary>
        /// <param name="unObjet">soit de type Personnel ou Absences</param>
        public void Supprimer(object unObjet)
        {
            if (unObjet is Personnel)
            {
                AccesDonnees.SupprimerPersonnel((Personnel)unObjet);
            }
            else
            {
                AccesDonnees.SupprimerAbsence((Absences)unObjet);
            }
        }
        /// <summary>
        /// récupère la chaine d'authentification de la base de données et la compare avec les informations saisies
        /// </summary>
        /// <param name="identifiant">l'identifiant saisie par l'utilisateur</param>
        /// <param name="mdp">le mot de passe saisie par l'utilisateur</param>
        public void Authentification(string identifiant, string mdp)
        {
            mdp = GetStringSha256Hash(mdp);
            if ((identifiant + "|" + mdp).Equals(AccesDonnees.Authentification()))
            {
                frmConnexion.Hide();
                frmPersonnel = new FrmPersonnel(this);
                frmPersonnel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect", "Authentification impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        /// <summary>
        /// permet de créer l'acces au formulaire des absences avec le personnel envoyé
        /// </summary>
        /// <param name="unPersonnel">le personnel ayant de absences</param>
        public void AccesAuFrmAbsences(Personnel unPersonnel)
        {
            frmPersonnel.Visible = false;
            frmAbsences = new FrmAbsences(this, unPersonnel);
            frmAbsences.ShowDialog();

        }
        /// <summary>
        /// permet de retourner au formulaire du personnel
        /// </summary>
        public void AccesAuFrmPersonnel()
        {
            frmAbsences.Dispose();
            frmPersonnel.Visible = true;
        }
        /// <summary>
        /// fonction permettant de hacher en 256 en chaine
        /// </summary>
        /// <param name="text">texte devant être Haché</param>
        /// <returns>la chaine hachée</returns>
        internal static string GetStringSha256Hash(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return (BitConverter.ToString(hash).Replace("-", string.Empty)).ToLower();
            }
        }
    }
}
