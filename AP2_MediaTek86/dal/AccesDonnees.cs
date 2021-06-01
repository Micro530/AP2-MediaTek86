using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP2_MediaTek86.connexion;


namespace AP2_MediaTek86.dal
{
    public class AccesDonnees
    {
        /// <summary>
        /// La chaine de connexion
        /// </summary>
        private static string connectionString = "server=localhost;user id=responsable;password=motdepasse;persistsecurityinfo=True;database=mediatek86";
        
        
        
        
        /**
        // Récupère et retourne les développeurs provenant de la BDD
        public static List<Developpeur> GetLesDeveloppeurs()
        {
            List<Developpeur> lesDeveloppeurs = new List<Developpeur>();
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            bdd.ReqSelect("SELECT * from developpeur order by nom, prenom;", parameters);
            if (true)
            {
                while (bdd.Read())
                {
                    lesDeveloppeurs.Add(new Developpeur(int.Parse(bdd.Field("iddeveloppeur").ToString()), bdd.Field("idprofil").ToString(), bdd.Field("nom").ToString(),
                        bdd.Field("prenom").ToString(), bdd.Field("tel").ToString(), bdd.Field("mail").ToString(), bdd.Field("pwd").ToString()));

                }
                bdd.close();
                return lesDeveloppeurs;
            }
            else
            {
                return lesDeveloppeurs;
            }


        }
        // Récupère et retourne les profils provenant de la BDD
        public static List<Profil> GetLesProfils()
        {
            List<Profil> lesProfils = new List<Profil>();
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            bdd.ReqSelect("SELECT * from profil order by nom;", parameters);
            while (bdd.Read())
            {
                lesProfils.Add(new Profil(int.Parse(bdd.Field("idprofil").ToString()), bdd.Field("nom").ToString()));

            }
            bdd.close();
            return lesProfils;


        }
        // Suppression d'un développeur
        public static void DelDepveloppeur(Developpeur developpeur)
        {
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@iddeveloppeur", developpeur.Iddeveloppeur);
            bdd.reqUpdate("delete from developpeur where iddeveloppeur = @iddeveloppeur;", parameters);
        }
        // Ajoute un développeur
        public static void AddDeveloppeur(Developpeur developpeur)
        {
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@iddeveloppeur", developpeur.Iddeveloppeur);
            parameters.Add("@idprofil", developpeur.Profil);
            parameters.Add("@nom", developpeur.Nom);
            parameters.Add("@prenom", developpeur.Prenom);
            parameters.Add("@tel", developpeur.Tel);
            parameters.Add("@mail", developpeur.Mail);
            parameters.Add("@pwd", GetStringSha256Hash(developpeur.Nom));
            bdd.reqUpdate("insert into developpeur (iddeveloppeur,idprofil,nom,prenom,tel,mail,pwd) VALUES (@iddeveloppeur, @idprofil, @nom, @prenom, @tel, @mail, @pwd);", parameters);

        }

        // Modification d'un développeur
        public static void UpdateDeveloppeur(Developpeur developpeur)
        {
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@iddeveloppeur", developpeur.Iddeveloppeur);
            parameters.Add("@idprofil", developpeur.Profil);
            parameters.Add("@nom", developpeur.Nom);
            parameters.Add("@prenom", developpeur.Prenom);
            parameters.Add("@tel", developpeur.Tel);
            parameters.Add("@mail", developpeur.Mail);
            bdd.reqUpdate("update developpeur set idprofil = @idprofil, nom = @nom, prenom = @prenom, tel = @tel, mail =  @mail where iddeveloppeur = @iddeveloppeur;", parameters);
            bdd.close();
        }
        // Demande de modification du pwd
        public static void UpdatePwd(Developpeur developpeur)
        {
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@iddeveloppeur", developpeur.Iddeveloppeur);
            parameters.Add("@pwd", GetStringSha256Hash(developpeur.Pwd));
            bdd.reqUpdate("update developpeur set pwd = @pwd where iddeveloppeur = @iddeveloppeur;", parameters);
            bdd.close();
        }
        public static bool Authentification(String nom, String prenom, String pwd)
        {
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nomDev", nom);
            parameters.Add("@prenomDev", prenom);
            parameters.Add("@pwdDev", GetStringSha256Hash(pwd));
            bdd.ReqSelect("SELECT * from developpeur inner join profil on developpeur.idprofil = profil.idprofil " +
                "where developpeur.nom = @nomDev and prenom = @prenomDev and pwd = @pwdDev and profil.nom = 'admin';", parameters);
            bool temp = bdd.Read();
            bdd.close();
            return temp;

        }
        /// Transformation d'une chaîne avec SHA256 (pour le pwd)
        internal static string GetStringSha256Hash(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
        **/
    }
       
}
