using System;
using System.Collections.Generic;
using AP2_MediaTek86.connexion;
using AP2_MediaTek86.model;

namespace AP2_MediaTek86.dal
{
    public class AccesDonnees
    {
        /// <summary>
        /// La chaine de connexion
        /// </summary>
        private static string connectionString = "server=localhost;user id=responsable;password=motdepasse;persistsecurityinfo=True;database=mediatek86";
        /// <summary>
        /// Gere la requete d'authentification
        /// </summary>
        /// <returns>le chaine d'authentification</returns>
        public static string Authentification()
        {
            List<string> lesidentifiants = new List<string>();
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            bdd.ReqSelect("SELECT * from responsable;", parameters);
            if (bdd.Read())
            {
                string identifiant = (string)bdd.Field("login") + "|" + (string)bdd.Field("pwd");
                bdd.close();
                return identifiant;
            }
            else
            {
                bdd.close();
                return null;
            }
        }
        /// <summary>
        /// Gere la récupération de la liste du personnel 
        /// </summary>
        /// <returns>le liste du personnel</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            bdd.ReqSelect("SELECT idpersonnel, personnel.nom as nompersonnel, prenom, tel, mail, personnel.idservice, service.nom as nomservice" +
                " from personnel inner join service on personnel.idservice = service.idservice order by nompersonnel, prenom;", parameters);
            while (bdd.Read())
            {
                lesPersonnels.Add(new Personnel((int)bdd.Field("idpersonnel"), (string)bdd.Field("nompersonnel"), (string)bdd.Field("prenom"),
                    (string)bdd.Field("tel"), (string)bdd.Field("mail"), (int)bdd.Field("idservice"), (string)bdd.Field("nomservice")));
}
            bdd.close();
            return lesPersonnels;
        }
        /// <summary>
        /// Gere la récupération de la liste des absences
        /// </summary>
        /// <param name="unPersonnel">recoie le personnel ayant des absences</param>
        /// <returns>la liste de ses absences</returns>
        public static List<Absences> GetLesAbsences(Personnel unPersonnel)
        {
            List<Absences> lesAbsences = new List<Absences>();
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", unPersonnel.IdPersonnel);
            bdd.ReqSelect("SELECT * from absence inner join motif on absence.idmotif = motif.idmotif where idpersonnel = @idpersonnel order by datedebut desc;", parameters);
            while (bdd.Read())
            {
                lesAbsences.Add(new Absences((int)bdd.Field("idpersonnel"), (DateTime)bdd.Field("datedebut"), (DateTime)bdd.Field("datefin"),
                    (int)bdd.Field("idmotif"), (string)bdd.Field("libelle")));
            }
            bdd.close();
            return lesAbsences;
        }
        /// <summary>
        /// gere la récupération dela liste des services
        /// </summary>
        /// <returns>la liste des services</returns>
        public static List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            bdd.ReqSelect("SELECT * from service order by nom;", parameters);
            while (bdd.Read())
            {
                lesServices.Add(new Service((int)bdd.Field("idservice"), (string)bdd.Field("nom")));
            }
            bdd.close();
            return lesServices;
        }
        /// <summary>
        /// gere la récupération dela liste des motif
        /// </summary>
        /// <returns>la liste des motif</returns>
        public static List<Motif> GetLesMotif()
        {
            List<Motif> lesMotifs = new List<Motif>();
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            bdd.ReqSelect("SELECT * from motif order by libelle;", parameters);
            while (bdd.Read())
            {
                lesMotifs.Add(new Motif((int)bdd.Field("idmotif"), (string)bdd.Field("libelle")));
            }
            bdd.close();
            return lesMotifs;
        }
        /// <summary>
        /// Ajoute un personnel
        /// </summary>
        /// <param name="unePersonne"> la personne à ajouter</param>
        public static void AjoutPersonnel(Personnel unePersonne)
        {
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", unePersonne.Nom);
            parameters.Add("@prenom", unePersonne.Prenom);
            parameters.Add("@tel", unePersonne.Tel);
            parameters.Add("@mail", unePersonne.Mail);
            parameters.Add("@idservice",unePersonne.IdService);
            bdd.reqUpdate("insert into personnel (nom,prenom,tel,mail,idservice) VALUES (@nom, @prenom, @tel, @mail, @idservice);", parameters);
        }
        /// <summary>
        /// Ajoute une absence
        /// </summary>
        /// <param name="uneAbsence">l'absence à rajouter</param>
        public static void AjoutAbsence(Absences uneAbsence)
        {
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", uneAbsence.IdPersonnel);
            parameters.Add("@datedebut", uneAbsence.DateDebut);
            parameters.Add("@idmotif", uneAbsence.IdMotif);
            parameters.Add("@datefin", uneAbsence.DateFin);
            bdd.reqUpdate("insert into absence (idpersonnel,datedebut,idmotif,datefin) VALUES (@idpersonnel, @datedebut, @idmotif, @datefin);", parameters);
        }
        /// <summary>
        /// permet de modifier le personnel envoyé
        /// </summary>
        /// <param name="unePersonne">le personnel à modifier</param>
        public static void ModifierPersonnel(Personnel unePersonne)
        {
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", unePersonne.IdPersonnel);
            parameters.Add("@nom", unePersonne.Nom);
            parameters.Add("@prenom", unePersonne.Prenom);
            parameters.Add("@tel", unePersonne.Tel);
            parameters.Add("@mail", unePersonne.Mail);
            parameters.Add("@idservice", unePersonne.IdService);
            bdd.reqUpdate("update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice where idpersonnel = @idpersonnel;", parameters);
            bdd.close();
        }
        /// <summary>
        /// permet de modifier l'absence envoyé
        /// </summary>
        /// <param name="uneAbsence">modifie l'absence recu</param>
        public static void ModifierAbsence(Absences uneAbsence)
        {
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", uneAbsence.IdPersonnel);
            parameters.Add("@datedebut", uneAbsence.DateDebut);
            parameters.Add("@idmotif", uneAbsence.IdMotif);
            parameters.Add("@datefin", uneAbsence.DateFin);
            bdd.reqUpdate("update absence set datedebut = @datedebut, idmotif = @idmotif, datefin = @datefin where idpersonnel = @idpersonnel and datedebut = @datedebut;", parameters);
            bdd.close();
        }
        /// <summary>
        ///supprime la personne recu en paramètre 
        /// </summary>
        /// <param name="unePersonne">la personne à supprimer</param>
        public static void SupprimerPersonnel(Personnel unePersonne)
        {
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", unePersonne.IdPersonnel);
            bdd.reqUpdate("delete from personnel where idpersonnel = @idpersonnel;", parameters);
        }
        /// <summary>
        /// supprime l'absence recu en paramètre
        /// </summary>
        /// <param name="uneAbsence">l'absence à supprimer</param>
        public static void SupprimerAbsence(Absences uneAbsence)
        {
            ConnexionBDD bdd = ConnexionBDD.getInstance(connectionString);
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", uneAbsence.IdPersonnel);
            parameters.Add("@datedebut", uneAbsence.DateDebut);
            bdd.reqUpdate("delete from absence where idpersonnel = @idpersonnel and datedebut = @datedebut;", parameters);
        }
    }
}
