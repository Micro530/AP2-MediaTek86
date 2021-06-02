namespace AP2_MediaTek86.model
{
    public class Motif
    {
        /// <summary>
        /// id du motif
        /// </summary>
        private int idMotif;
        /// <summary>
        /// libellé du motif
        /// </summary>
        private string libelle;
        /// <summary>
        /// génération de l'encapsulation
        /// </summary>
        public int IdMotif { get => idMotif; set => idMotif = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        /// <summary>
        /// constructeur de la la class motif
        /// </summary>
        /// <param name="idService">l'id unique du motif</param>
        /// <param name="libelle">son nom</param>
        public Motif(int idMotif, string libelle)
        {
            this.idMotif = idMotif;
            this.libelle = libelle;
        }
        /// <summary>
        /// redéfinition de la méthode ToString afin de faciliter son utilisation dans les ComboBox
        /// </summary>
        /// <returns>retourne le libellé</returns>
        public override string ToString()
        {
            return libelle;
        }
    }
}
