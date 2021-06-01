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
        FrmPersonnel frmPersonnel;
        FrmAbsences frmAbsences;
        FrmConnexion frmConnexion;
        public Controle()
        {
            frmConnexion = new FrmConnexion(this);
            frmConnexion.ShowDialog();
        }
        public List<Personnel> GetLesPersonnels()
        {
            return null;
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
