using MaintInfoBo;
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
            Client cl1 = new Client
            {
                clientID = 1,
                nom_client = "Panzani",
                adresse_client = "34, avenue de corot",
                cp_client = "13013",
                ville_client = "Marseille",
                tel_client = "0491609023"
            };
            db.Clients.Add(cl1);
            Client cl2 = new Client
            {
                clientID = 2,
                nom_client = "Heineken",
                adresse_client = "14, rue François Chardigny",
                cp_client = "13011",
                ville_client = "Marseille",
                tel_client = "0491691322"
            };
            db.Clients.Add(cl2);
            #endregion

            #region Secteur
            Secteur s1 = new Secteur
            {
                secteurID = 1,
                libelleSecteur = "Provence-Alpes-Côte d'Azur"
            };
            db.Secteurs.Add(s1);
            Secteur s2 = new Secteur
            {
                secteurID = 2,
                libelleSecteur = "Corse"
            };
            db.Secteurs.Add(s2);
            Secteur s3 = new Secteur
            {
                secteurID = 3,
                libelleSecteur = "Rhône-Alpes"
            };
            db.Secteurs.Add(s3);
            Secteur s4 = new Secteur
            {
                secteurID = 4,
                libelleSecteur = "Languedoc-Roussillon"
            };
            db.Secteurs.Add(s4);
            Secteur s5 = new Secteur
            {
                secteurID = 5,
                libelleSecteur = "Midi-Pyrénées"
            };
            db.Secteurs.Add(s5);
            #endregion

            #region  CentreInformatique
            CentreInformatique ci1 = new CentreInformatique
            {
                centreInformatiqueID = 1,
                adresse_centre = "34, avenue de corot",
                cp_centre = "13013",
                ville_centre = "Marseille",
                tel_centre = "0491691322",
                clientID = 1,
                secteurID = 1
            };
            db.CentresInformatique.Add(ci1);
            CentreInformatique ci2 = new CentreInformatique
            {
                centreInformatiqueID = 2,
                adresse_centre = "11, chemin du littoral",
                cp_centre = "13002",
                ville_centre = "Marseille",
                tel_centre = "0491601462",
                clientID = 1,
                secteurID = 1
            };
            db.CentresInformatique.Add(ci2);
            CentreInformatique ci3 = new CentreInformatique
            {
                centreInformatiqueID = 3,
                adresse_centre = "14, rue François Chardigny",
                cp_centre = "13011",
                ville_centre = "Marseille",
                tel_centre = "0491691322",
                clientID = 2,
                secteurID = 1
            };
            db.CentresInformatique.Add(ci3);
            #endregion

            #region Contrat
            Contrat ct1 = new Contrat
            {
                contratID = 1,
                montant_contrat = 24.56,
                statut = 1,
                date_creation = new DateTime(2016, 02, 12),
                date_echeance = new DateTime(2017, 02, 12),
                centreInformatiqueID = 1
            };
            db.Contrats.Add(ct1);
            Contrat ct2 = new Contrat
            {
                contratID = 2,
                montant_contrat = 13.480,
                statut = 1,
                date_creation = new DateTime(2016, 06, 24),
                date_echeance = new DateTime(2017, 06, 24),
                centreInformatiqueID = 2
            };
            db.Contrats.Add(ct2);
            Contrat ct3 = new Contrat
            {
                contratID = 3,
                montant_contrat = 32.740,
                statut = 1,
                date_creation = new DateTime(2016, 03, 13),
                date_echeance = new DateTime(2017, 03, 13),
                centreInformatiqueID = 3
            };
            db.Contrats.Add(ct3);
            #endregion

            #region Tarif
            Tarif tf1 = new Tarif
            {
                tarifID = 1,
                date_tarif = new DateTime(2016, 01, 01),
                montant_tarif = 499.99
            };
            db.Tarifs.Add(tf1);
            Tarif tf2 = new Tarif
            {
                tarifID = 2,
                date_tarif = new DateTime(2016, 01, 01),
                montant_tarif = 799.99
            };
            db.Tarifs.Add(tf2);
            Tarif tf3 = new Tarif
            {
                tarifID = 3,
                date_tarif = new DateTime(2016, 01, 01),
                montant_tarif = 999.99
            };
            db.Tarifs.Add(tf3);
            Tarif tf4 = new Tarif
            {
                tarifID = 4,
                date_tarif = new DateTime(2016, 01, 01),
                montant_tarif = 549.99
            };
            db.Tarifs.Add(tf4);
            Tarif tf5 = new Tarif
            {
                tarifID = 5,
                date_tarif = new DateTime(2016, 01, 01),
                montant_tarif = 949.99
            };
            db.Tarifs.Add(tf5);
            Tarif tf6 = new Tarif
            {
                tarifID = 6,
                date_tarif = new DateTime(2016, 01, 01),
                montant_tarif = 399
            };
            db.Tarifs.Add(tf6);
            Tarif tf7 = new Tarif
            {
                tarifID = 7,
                date_tarif = new DateTime(2016, 01, 01),
                montant_tarif = 439
            };
            db.Tarifs.Add(tf7);
            Tarif tf8 = new Tarif
            {
                tarifID = 8,
                date_tarif = new DateTime(2016, 01, 01),
                montant_tarif = 919
            };
            db.Tarifs.Add(tf8);
            #endregion

            #region TypeModele
            TypeModele tm1 = new TypeModele
            {
                typeModeleID = 1,
                designation_type = "Ordinateur Fixe"
            };
            db.TypeModeles.Add(tm1);
            TypeModele tm2 = new TypeModele
            {
                typeModeleID = 2,
                designation_type = "Ordinateur Portable"
            };
            db.TypeModeles.Add(tm2);
            TypeModele tm3 = new TypeModele
            {
                typeModeleID = 3,
                designation_type = "Tablette"
            };
            db.TypeModeles.Add(tm3);
            #endregion

            #region Modele
            Modele md1 = new Modele
            {
                modeleID = 1,
                designation_modele = "DELL Optiplex 780",
                tarifID = 1,
                typeModeleID = 1
            };
            db.Modeles.Add(md1);
            Modele md2 = new Modele
            {
                modeleID = 2,
                designation_modele = "DELL Optiplex 880",
                tarifID = 2,
                typeModeleID = 1
            };
            db.Modeles.Add(md2);
            Modele md3 = new Modele
            {
                modeleID = 3,
                designation_modele = "DELL Optiplex 980",
                tarifID = 3,
                typeModeleID = 1
            };
            db.Modeles.Add(md3);
            Modele md4 = new Modele
            {
                modeleID = 4,
                designation_modele = "DELL Lattitude E5430",
                tarifID = 4,
                typeModeleID = 2
            };
            db.Modeles.Add(md4);
            Modele md5 = new Modele
            {
                modeleID = 5,
                designation_modele = "DELL Lattitude E5630",
                tarifID = 5,
                typeModeleID = 2
            };
            db.Modeles.Add(md5);
            Modele md6 = new Modele
            {
                modeleID = 6,
                designation_modele = "Ipad Mini 4",
                tarifID = 6,
                typeModeleID = 3
            };
            db.Modeles.Add(md6);
            Modele md7 = new Modele
            {
                modeleID = 7,
                designation_modele = "Ipad Air 2",
                tarifID = 7,
                typeModeleID = 3
            };
            db.Modeles.Add(md7);
            Modele md8 = new Modele
            {
                modeleID = 8,
                designation_modele = "Ipad Pro 12.9",
                tarifID = 8,
                typeModeleID = 3
            };
            db.Modeles.Add(md8);
            #endregion

            #region Equipement
            // Centre 1
            Equipement eq1 = new Equipement
            {
                equipementID = 1,
                num_serie = "4255A56454F6",
                planification = 4,
                contratID = 1,
                modeleID = 1
            };
            db.Equipements.Add(eq1);
            Equipement eq2 = new Equipement
            {
                equipementID = 2,
                num_serie = "4255A56454F7",
                planification = 4,
                contratID = 1,
                modeleID = 1
            };
            db.Equipements.Add(eq2);
            Equipement eq3 = new Equipement
            {
                equipementID = 3,
                num_serie = "4255A56454F8",
                planification = 4,
                contratID = 1,
                modeleID = 1
            };
            db.Equipements.Add(eq3);
            Equipement eq4 = new Equipement
            {
                equipementID = 4,
                num_serie = "4646574FDG154",
                planification = 1,
                contratID = 1,
                modeleID = 8
            };
            db.Equipements.Add(eq4);
            Equipement eq5 = new Equipement
            {
                equipementID = 5,
                num_serie = "1854845DSZE15",
                planification = 4,
                contratID = 1,
                modeleID = 5
            };
            db.Equipements.Add(eq5);
            // Centre 2
            Equipement eq6 = new Equipement
            {
                equipementID = 6,
                num_serie = "987464131DDZE1121",
                planification = 2,
                contratID = 2,
                modeleID = 1
            };
            db.Equipements.Add(eq6);
            Equipement eq7 = new Equipement
            {
                equipementID = 7,
                num_serie = "464657487HYU4",
                planification = 2,
                contratID = 2,
                modeleID = 1
            };
            db.Equipements.Add(eq7);
            Equipement eq8 = new Equipement
            {
                equipementID = 8,
                num_serie = "1KIL41541ZE15",
                planification = 4,
                contratID = 2,
                modeleID = 2
            };
            db.Equipements.Add(eq8);
            // Centre 3
            Equipement eq9 = new Equipement
            {
                equipementID = 9,
                num_serie = "4665LO74FDG155",
                planification = 2,
                contratID = 3,
                modeleID = 8
            };
            db.Equipements.Add(eq9);
            Equipement eq10 = new Equipement
            {
                equipementID = 10,
                num_serie = "4665LO74FDG154",
                planification = 2,
                contratID = 3,
                modeleID = 8
            };
            db.Equipements.Add(eq10);
            Equipement eq11 = new Equipement
            {
                equipementID = 11,
                num_serie = "185545410SZE17",
                planification = 4,
                contratID = 3,
                modeleID = 1
            };
            db.Equipements.Add(eq11);
            #endregion
            
        }
    }
}
