﻿using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoDal
{
    public class MaintInfoInitializer : DropCreateDatabaseAlways<MaintInfoContext>
    {
        protected override void Seed(MaintInfoContext db)
        {

            #region Client
            db.Clients.Add(new Client
            {
                clientID = 1,
                nom_client = "Panzani",
                adresse_client = "34, avenue de corot",
                cp_client = "13013",
                ville_client = "Marseille",
                tel_client = "0491609023"
            });
            db.Clients.Add(new Client
            {
                clientID = 2,
                nom_client = "Heineken",
                adresse_client = "14, rue François Chardigny",
                cp_client = "13011",
                ville_client = "Marseille",
                tel_client = "0491691322"
            });
            #endregion

            #region Secteur
            db.Secteurs.Add(new Secteur
            {
                secteurID = 93,
                libelleSecteur = "Provence-Alpes-Côte d'Azur"
            });
            db.Secteurs.Add(new Secteur
            {
                secteurID = 94,
                libelleSecteur = "Corse"
            });
            db.Secteurs.Add(new Secteur
            {
                secteurID = 82,
                libelleSecteur = "Rhône-Alpes"
            });
            db.Secteurs.Add(new Secteur
            {
                secteurID = 91,
                libelleSecteur = "Languedoc-Roussillon"
            });
            db.Secteurs.Add(new Secteur
            {
                secteurID = 73,
                libelleSecteur = "Midi-Pyrénées"
            });
            #endregion

            #region  CentreInformatique
            db.CentresInformatique.Add(new CentreInformatique
            {
                centreInformatiqueID = 1,
                adresse_centre = "34, avenue de corot",
                cp_centre = "13013",
                ville_centre = "Marseille",
                tel_centre = "0491691322",
                secteurID = 1
            });
            db.CentresInformatique.Add(new CentreInformatique
            {
                centreInformatiqueID = 2,
                adresse_centre = "11, chemin du littoral",
                cp_centre = "13002",
                ville_centre = "Marseille",
                tel_centre = "0491601462",
                secteurID = 1
            });
            db.CentresInformatique.Add(new CentreInformatique
            {
                centreInformatiqueID = 3,
                adresse_centre = "14, rue François Chardigny",
                cp_centre = "13011",
                ville_centre = "Marseille",
                tel_centre = "0491691322",
                secteurID = 1
            });
            #endregion

            #region Contrat
            db.Contrats.Add(new Contrat
            {
                contratID = 1,
                montant_contrat = 24.56,
                statut = 1,
                date_creation = new DateTime(2016, 02, 12),
                date_echeance = new DateTime(2017, 02, 12),
                centreInformatiqueID = 1
            });
            db.Contrats.Add(new Contrat
            {
                contratID = 2,
                montant_contrat = 13.480,
                statut = 1,
                date_creation = new DateTime(2016, 06, 24),
                date_echeance = new DateTime(2017, 06, 24),
                centreInformatiqueID = 2
            });
            db.Contrats.Add(new Contrat
            {
                contratID = 3,
                montant_contrat = 32.740,
                statut = 1,
                date_creation = new DateTime(2016, 03, 13),
                date_echeance = new DateTime(2017, 03, 13),
                centreInformatiqueID = 3
            });
            #endregion

            #region Tarif
            db.Tarifs.Add(new Tarif
            {
                tarifID = 1,
                date_tarif = new DateTime(01, 01, 2016),
                montant_tarif = 499.99
            });
            db.Tarifs.Add(new Tarif
            {
                tarifID = 2,
                date_tarif = new DateTime(01, 01, 2016),
                montant_tarif = 799.99
            });
            db.Tarifs.Add(new Tarif
            {
                tarifID = 3,
                date_tarif = new DateTime(01, 01, 2016),
                montant_tarif = 999.99
            });
            db.Tarifs.Add(new Tarif
            {
                tarifID = 4,
                date_tarif = new DateTime(01, 01, 2016),
                montant_tarif = 549.99
            });
            db.Tarifs.Add(new Tarif
            {
                tarifID = 5,
                date_tarif = new DateTime(01, 01, 2016),
                montant_tarif = 949.99
            });
            #endregion

            #region TypeModele
            db.TypeModeles.Add(new TypeModele
            {
                typeModeleID = 1,
                designation_type = "Ordinateur Fixe"
            });
            db.TypeModeles.Add(new TypeModele
            {
                typeModeleID = 2,
                designation_type = "Ordinateur Portable"
            });
            db.TypeModeles.Add(new TypeModele
            {
                typeModeleID = 3,
                designation_type = "Tablette"
            });
            #endregion

            #region Modele
            db.Modeles.Add(new Modele
            {
                modeleID = 1,
                designation_modele = "DELL Optiplex 780",
                tarifID = 1,
                typeModeleID = 1
            });
            db.Modeles.Add(new Modele
            {
                modeleID = 2,
                designation_modele = "DELL Optiplex 880",
                tarifID = 2,
                typeModeleID = 1
            });
            db.Modeles.Add(new Modele
            {
                modeleID = 3,
                designation_modele = "DELL Optiplex 980",
                tarifID = 3,
                typeModeleID = 1
            });
            db.Modeles.Add(new Modele
            {
                modeleID = 4,
                designation_modele = "DELL Lattitude E5430",
                tarifID = 4,
                typeModeleID = 2
            });
            db.Modeles.Add(new Modele
            {
                modeleID = 4,
                designation_modele = "DELL Lattitude E5630",
                tarifID = 5,
                typeModeleID = 2
            });
            #endregion

            #region Equipement
            // Centre 1
            db.Equipements.Add(new Equipement
            {
                equipementID = "4255A56454F6",
                planification = 4,
                contratID = 1,
                modeleID = 1
            });
            db.Equipements.Add(new Equipement
            {
                equipementID = "4255A56454F7",
                planification = 4,
                contratID = 1,
                modeleID = 1
            });
            db.Equipements.Add(new Equipement
            {
                equipementID = "4255A56454F8",
                planification = 4,
                contratID = 1,
                modeleID = 1
            });
            #endregion


        }
    }
}
