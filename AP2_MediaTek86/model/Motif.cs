using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_MediaTek86.model
{
    class Motif
    {
        /// <summary>
        /// Propriétés de la table motif 
        /// </summary>
        private int idMotif;
        private string libelle;

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
