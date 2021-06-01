using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2_MediaTek86.connexion
{
    public class ConnexionBDD
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private static ConnexionBDD instance = null;
        public MySqlDataReader curseur;
        /// <summary>
        /// constructeur privé appelé uniquement par GetInstance
        /// </summary>
        /// <param name="chaineConnection">la chaine de connexion à la base de données</param>
        private ConnexionBDD(string chaineConnection)
        {
            try
            {
                this.connection = new MySqlConnection(chaineConnection);
                this.connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
            }

        }
        /// <summary>
        /// création de l'instance si elle n'est pas deja existante
        /// </summary>
        /// <param name="chaineConnection">la chaine de connexion à la base de données</param>
        /// <returns>l'instance de la connexion</returns>
        public static ConnexionBDD getInstance(string chaineConnection)
        {
            // contrôle si l'instance existe déjà
            if (instance == null)
            {
                instance = new ConnexionBDD(chaineConnection);
            }
            // la méthode retourne l'instance créée ou celle déjà existante
            return instance;
        }
        /// <summary>
        /// execution requete de type update (insert, delete, update, ...)
        /// </summary>
        /// <param name="chaineRequete">la requete</param>
        /// <param name="parameters">les paramètres de la requete</param>
        public void reqUpdate(string chaineRequete, Dictionary<string, object> parameters)
        {
            try
            {
                creationCommand(chaineRequete, parameters);
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// execution du requete de type SELECT
        /// </summary>
        /// <param name="chaineRequete">la requete</param>
        /// <param name="parameters">les paramètres de la requete</param>
        public void ReqSelect(String chaineRequete, Dictionary<string, object> parameters)
        {
            try
            {
                creationCommand(chaineRequete, parameters);
                this.curseur = this.command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// permet de créer la commande avec la ChaineRequete et le dictionnaire de paramètres
        /// </summary>
        /// <param name="chaineRequete">la requete</param>
        /// <param name="parameters">les paramètres de la requete</param>
        private void creationCommand(String chaineRequete, Dictionary<string, object> parameters)
        {
            this.command = new MySqlCommand(chaineRequete, this.connection);
            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
            }
            command.Prepare();
        }
        /// <summary>
        /// envoi true si le curseur contient quelques chose et passe à la ligne suivante
        /// </summary>
        /// <returns>bool</returns>
        public bool Read()
        {
            if (curseur is null)
            {
                return false;
            }
            try
            {
                return this.curseur.Read();
            }
            catch
            {
                return false;
            }

        }
        /// <summary>
        /// permet de récupérer une valeur de la ligne actuelle
        /// </summary>
        /// <param name="nomChamps">le nom du champs correspondant à la valeur que l'on souhaite récupérer</param>
        /// <returns>la valeur correspondant au champs</returns>
        public Object Field(String nomChamps)
        {
            if (curseur is null)
            {
                return null;
            }
            try
            {
                return this.curseur[nomChamps];
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// ferme le curseur
        /// </summary>
        public void close()
        {
            if (!(this.curseur is null))
            {
                this.curseur.Close();
            }
        }
    }
}
