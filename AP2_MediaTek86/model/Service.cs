namespace AP2_MediaTek86.model
{
    public class Service
    {
        /// <summary>
        /// id su service
        /// </summary>
        private int idService;
        /// <summary>
        /// libelle du service
        /// </summary>
        private string libelle;
        /// <summary>
        /// génération de l'encapsulation
        /// </summary>
        public int IdService { get => idService; set => idService = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        /// <summary>
        /// constructeur de la la class service
        /// </summary>
        /// <param name="idService">l'id unique du service</param>
        /// <param name="libelle">son nom</param>
        public Service(int idService, string libelle)
        {
            this.idService = idService;
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
