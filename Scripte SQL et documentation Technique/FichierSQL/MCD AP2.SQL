DROP DATABASE IF EXISTS MEDIATEK86;

CREATE DATABASE IF NOT EXISTS MEDIATEK86;
USE MEDIATEK86;
# -----------------------------------------------------------------------------
#       TABLE : ABSENCE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ABSENCE
 (
   IDPERSONNEL INTEGER(2) NOT NULL  ,
   DATEDEBUT DATETIME NOT NULL  ,
   IDMOTIF INTEGER(2) NOT NULL  ,
   DATEFIN DATETIME NULL  
   , PRIMARY KEY (IDPERSONNEL,DATEDEBUT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : MOTIF
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS MOTIF
 (
   IDMOTIF INTEGER(2) NOT NULL AUTO_INCREMENT ,
   LIBELLE VARCHAR(128) NULL  
   , PRIMARY KEY (IDMOTIF) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : SERVICE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS SERVICE
 (
   IDSERVICE INTEGER(2) NOT NULL AUTO_INCREMENT ,
   NOM VARCHAR(50) NULL  
   , PRIMARY KEY (IDSERVICE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : PERSONNEL
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PERSONNEL
 (
   IDPERSONNEL INTEGER(2) NOT NULL AUTO_INCREMENT ,
   IDSERVICE INTEGER(2) NOT NULL  ,
   NOM VARCHAR(50) NULL  ,
   PRENOM VARCHAR(50) NULL  ,
   TEL VARCHAR(15) NULL  ,
   MAIL VARCHAR(128) NULL  
   , PRIMARY KEY (IDPERSONNEL) 
 ) 
 comment = "";


# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE ABSENCE 
  ADD FOREIGN KEY FK_ABSENCE_MOTIF (IDMOTIF)
      REFERENCES MOTIF (IDMOTIF) ;


ALTER TABLE ABSENCE 
  ADD FOREIGN KEY FK_ABSENCE_PERSONNEL (IDPERSONNEL)
      REFERENCES PERSONNEL (IDPERSONNEL) ;


ALTER TABLE PERSONNEL 
  ADD FOREIGN KEY FK_PERSONNEL_SERVICE (IDSERVICE)
      REFERENCES SERVICE (IDSERVICE) ;

