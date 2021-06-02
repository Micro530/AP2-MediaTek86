using System;

namespace AP2_MediaTek86.model
{
    public class Absences
    {
        /// <summary>
        /// idpersonnel
        /// </summary>
        private int idPersonnel;
        /// <summary>
        /// la date de debut
        /// </summary>
        private DateTime dateDebut;
        /// <summary>
        /// la date de fin
        /// </summary>
        private DateTime dateFin;
        /// <summary>
        /// id du motif
        /// </summary>
        private int idMotif;
        /// <summary>
        /// le libelle du motif
        /// </summary>
        private string motif;
        /// <summary>
        /// génération de l'encapsulation
        /// </summary>
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
