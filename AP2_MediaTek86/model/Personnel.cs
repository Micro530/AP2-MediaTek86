using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_MediaTek86.model
{
    class Personnel
    {
        /// <summary>
        /// propriété de la table personnel
        /// </summary>
        private int idPersonnel;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        private int idService;
        private string service;

        public int IdPersonnel { get => idPersonnel; set => idPersonnel = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Mail { get => mail; set => mail = value; }
        public int IdService { get => idService; set => idService = value; }
        public string Service { get => service; set => service = value; }
        /// <summary>
        /// Constructeur de la class personnel valorisant les propriétés privées
        /// </summary>
        /// <param name="idPersonnel">l'id unique de chaque menbre du personnel</param>
        /// <param name="nom">son nom</param>
        /// <param name="prenom">son prénom</param>
        /// <param name="tel">son numero de téléphone</param>
        /// <param name="mail">son adresse e mail</param>
        /// <param name="idService">id du service auquel il appartient</param>
        /// <param name="service">le nom du service auquel il appartient</param>
        public Personnel(int idPersonnel,string nom, string prenom, string tel, string mail, int idService, string service)
        {
            this.idPersonnel = idPersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idService = idService;
            this.service = service;
        }
    }
}
