using AP2_MediaTek86.dal;
using AP2_MediaTek86.model;
using AP2_MediaTek86.vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2_MediaTek86.controleur
{
    public class Controle
    {
        private FrmPersonnel frmPersonnel;
        private FrmAbsences frmAbsences;
        private FrmConnexion frmConnexion;
        /// <summary>
        /// constructeur de control qui instancie le formulaire de connexion
        /// </summary>
        public Controle()
        {
            frmConnexion = new FrmConnexion(this);
            frmConnexion.ShowDialog();
        }
        public List<Personnel> GetLesPersonnels()
        {
            return AccesDonnees.GetLesPersonnels();
        }
        public List<Absences> GetLesAbsences(int idpersonnel)
        {
            return null;
        }
        public List<Motif> GetLesMotif()
        {
            return null;
        }
        public List<Service> GetLesServices()
        {
            return null;
        }
        public void Ajouter(object unObjet)
        {

        }
        public void Modifier(object unObjet)
        {

        }
        public void Supprimer(object unObjet)
        {

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
                frmPersonnel = new FrmPersonnel(this);
                frmPersonnel.ShowDialog();
                frmConnexion.Hide();
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect", "Authentification impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        public void AccesAuFrmAbsences()
        {

        }
        public void AccesAuFrmPersonnel()
        {

        }
        /// <summary>
        /// fonction permettant de hacher en 256 en chaine
        /// </summary>
        /// <param name="text"></param>
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
