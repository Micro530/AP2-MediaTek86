using AP2_MediaTek86.model;
using AP2_MediaTek86.vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_MediaTek86.controleur
{
    class Controle
    {
        FrmPersonnel frmPersonnel;
        FrmAbsences frmAbsences;
        FrmConnexion frmConnexion;
        public Controle()
        {

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

        }
        public void AccesAuFrmAbsences()
        {

        }
        public void AccesAuFrmPersonnel()
        {

        }
    }
}
