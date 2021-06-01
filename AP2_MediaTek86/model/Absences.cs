using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_MediaTek86.model
{
    public class Absences
    {
        /// <summary>
        /// les propriétés de la table absences
        /// </summary>
        private int idPersonnel;
        private DateTime dateDebut;
        private DateTime dateFin;
        private int idMotif;
        private string motif;

        public int IdPersonnel { get => idPersonnel; set => idPersonnel = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        public int IdMotif { get => idMotif; set => idMotif = value; }
        public string Motif { get => motif; set => motif = value; }
        /// <summary>
        /// Constructeur de la class Absences valorisant les propriétes privées
        /// </summary>
        /// <param name="idPersonnel">l'id du personnel auqel l'absence appartient</param>
        /// <param name="dateDebut">date de début de l'absence</param>
        /// <param name="dateFin">date de fin de l'absence</param>
        /// <param name="idMotif">l'id du motif de l'absence</param>
        /// <param name="motif">le libellé du motif</param>
        public Absences(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif, string motif)
        {
            this.idPersonnel = idPersonnel;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.idMotif = idMotif;
            this.motif = motif;
        }
    }
}
