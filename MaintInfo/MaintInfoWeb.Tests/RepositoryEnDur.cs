using MaintInfoBo;
using MaintInfoDal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoWeb.Tests
{
    public class RepositoryEnDur
    {
        private List<Client> listeDesClients;
        private List<Secteur> listeDesSecteurs;
        private List<CentreInformatique> listeDesCentresInformatique;
        private List<Contrat> listeDesContrats;
        private List<Tarif> listeDesTarifs;
        private List<TypeModele> listeDesTypesModele;
        private List<Modele> listeDesModeles;
        private List<Equipement> listeDesEquipements;

        public RepositoryEnDur()
        {

            #region Client
            listeDesClients = new List<Client>();
            listeDesClients.Add(new Client
            {
                clientID = 1,
                nom_client = "Panzani",
                adresse_client = "34, avenue de corot",
                cp_client = "13013",
                ville_client = "Marseille",
                tel_client = "0491609023"
            });
            listeDesClients.Add(new Client
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
            listeDesSecteurs = new List<Secteur>();
            listeDesSecteurs.Add(new Secteur
            {
                secteurID = 1,
                libelleSecteur = "Provence-Alpes-Côte d'Azur"
            });
            listeDesSecteurs.Add(new Secteur
            {
                secteurID = 2,
                libelleSecteur = "Corse"
            });
            listeDesSecteurs.Add(new Secteur
            {
                secteurID = 3,
                libelleSecteur = "Rhône-Alpes"
            });
            listeDesSecteurs.Add(new Secteur
            {
                secteurID = 4,
                libelleSecteur = "Languedoc-Roussillon"
            });
            listeDesSecteurs.Add(new Secteur
            {
                secteurID = 5,
                libelleSecteur = "Midi-Pyrénées"
            });
            #endregion

            #region  CentreInformatique
            listeDesCentresInformatique = new List<CentreInformatique>();
            listeDesCentresInformatique.Add(new CentreInformatique
            {
                centreInformatiqueID = 1,
                adresse_centre = "34, avenue de corot",
                cp_centre = "13013",
                ville_centre = "Marseille",
                tel_centre = "0491691322",
                clientID = 1,
                secteurID = 1
            });
            listeDesCentresInformatique.Add(new CentreInformatique
            {
                centreInformatiqueID = 2,
                adresse_centre = "11, chemin du littoral",
                cp_centre = "13002",
                ville_centre = "Marseille",
                tel_centre = "0491601462",
                clientID = 1,
                secteurID = 1
            });
            listeDesCentresInformatique.Add(new CentreInformatique
            {
                centreInformatiqueID = 3,
                adresse_centre = "14, rue François Chardigny",
                cp_centre = "13011",
                ville_centre = "Marseille",
                tel_centre = "0491691322",
                clientID = 2,
                secteurID = 1
            });
            #endregion

            #region Contrat
            listeDesContrats = new List<Contrat>();
            listeDesContrats.Add(new Contrat
            {
                contratID = 1,
                montant_contrat = 24.56,
                statut = 1,
                date_creation = new DateTime(2016, 02, 12),
                date_echeance = new DateTime(2017, 02, 12),
                centreInformatiqueID = 1
            });
            listeDesContrats.Add(new Contrat
            {
                contratID = 2,
                montant_contrat = 13.480,
                statut = 1,
                date_creation = new DateTime(2016, 06, 24),
                date_echeance = new DateTime(2017, 06, 24),
                centreInformatiqueID = 2
            });
            listeDesContrats.Add(new Contrat
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
            listeDesTarifs = new List<Tarif>();
            listeDesTarifs.Add(new Tarif
            {
                tarifID = 1,
                date_tarif = new DateTime(01 / 01 / 2016),
                montant_tarif = 499.99
            });
            listeDesTarifs.Add(new Tarif
            {
                tarifID = 2,
                date_tarif = new DateTime(01 / 01 / 2016),
                montant_tarif = 799.99
            });
            listeDesTarifs.Add(new Tarif
            {
                tarifID = 3,
                date_tarif = new DateTime(01 / 01 / 2016),
                montant_tarif = 999.99
            });
            listeDesTarifs.Add(new Tarif
            {
                tarifID = 4,
                date_tarif = new DateTime(01 / 01 / 2016),
                montant_tarif = 549.99
            });
            listeDesTarifs.Add(new Tarif
            {
                tarifID = 5,
                date_tarif = new DateTime(01 / 01 / 2016),
                montant_tarif = 949.99
            });
            listeDesTarifs.Add(new Tarif
            {
                tarifID = 6,
                date_tarif = new DateTime(01 / 01 / 2016),
                montant_tarif = 399
            });
            listeDesTarifs.Add(new Tarif
            {
                tarifID = 7,
                date_tarif = new DateTime(01 / 01 / 2016),
                montant_tarif = 439
            });
            listeDesTarifs.Add(new Tarif
            {
                tarifID = 8,
                date_tarif = new DateTime(01 / 01 / 2016),
                montant_tarif = 919
            });
            #endregion

            #region TypeModele
            listeDesTypesModele = new List<TypeModele>();
            listeDesTypesModele.Add(new TypeModele
            {
                typeModeleID = 1,
                designation_type = "Ordinateur Fixe"
            });
            listeDesTypesModele.Add(new TypeModele
            {
                typeModeleID = 2,
                designation_type = "Ordinateur Portable"
            });
            listeDesTypesModele.Add(new TypeModele
            {
                typeModeleID = 3,
                designation_type = "Tablette"
            });
            #endregion

            #region Modele
            listeDesModeles = new List<Modele>();
            listeDesModeles.Add(new Modele
            {
                modeleID = 1,
                designation_modele = "DELL Optiplex 780",
                tarifID = 1,
                typeModeleID = 1
            });
            listeDesModeles.Add(new Modele
            {
                modeleID = 2,
                designation_modele = "DELL Optiplex 880",
                tarifID = 2,
                typeModeleID = 1
            });
            listeDesModeles.Add(new Modele
            {
                modeleID = 3,
                designation_modele = "DELL Optiplex 980",
                tarifID = 3,
                typeModeleID = 1
            });
            listeDesModeles.Add(new Modele
            {
                modeleID = 4,
                designation_modele = "DELL Lattitude E5430",
                tarifID = 4,
                typeModeleID = 2
            });
            listeDesModeles.Add(new Modele
            {
                modeleID = 5,
                designation_modele = "DELL Lattitude E5630",
                tarifID = 5,
                typeModeleID = 2
            });
            listeDesModeles.Add(new Modele
            {
                modeleID = 6,
                designation_modele = "Ipad Mini 4",
                tarifID = 6,
                typeModeleID = 3
            });
            listeDesModeles.Add(new Modele
            {
                modeleID = 7,
                designation_modele = "Ipad Air 2",
                tarifID = 7,
                typeModeleID = 3
            });
            listeDesModeles.Add(new Modele
            {
                modeleID = 8,
                designation_modele = "Ipad Pro 12.9",
                tarifID = 8,
                typeModeleID = 3
            });
            #endregion

            #region Equipement
            listeDesEquipements = new List<Equipement>();
            // Centre 1
            listeDesEquipements.Add(new Equipement
            {
                equipementID = 1,
                num_serie = "4255A56454F6",
                planification = 4,
                contratID = 1,
                modeleID = 1
            });
            listeDesEquipements.Add(new Equipement
            {
                equipementID = 2,
                num_serie = "4255A56454F7",
                planification = 4,
                contratID = 1,
                modeleID = 1
            });
            listeDesEquipements.Add(new Equipement
            {
                equipementID = 3,
                num_serie = "4255A56454F8",
                planification = 4,
                contratID = 1,
                modeleID = 1
            });
            listeDesEquipements.Add(new Equipement
            {
                equipementID = 4,
                num_serie = "4646574FDG154",
                planification = 1,
                contratID = 1,
                modeleID = 8
            });
            listeDesEquipements.Add(new Equipement
            {
                equipementID = 5,
                num_serie = "1854845DSZE15",
                planification = 4,
                contratID = 1,
                modeleID = 5
            });
            // Centre 2
            listeDesEquipements.Add(new Equipement
            {
                equipementID = 6,
                num_serie = "987464131DDZE1121",
                planification = 2,
                contratID = 2,
                modeleID = 1
            });
            listeDesEquipements.Add(new Equipement
            {
                equipementID = 7,
                num_serie = "464657487HYU4",
                planification = 2,
                contratID = 2,
                modeleID = 1
            });
            listeDesEquipements.Add(new Equipement
            {
                equipementID = 8,
                num_serie = "1KIL41541ZE15",
                planification = 4,
                contratID = 2,
                modeleID = 2
            });
            // Centre 3
            listeDesEquipements.Add(new Equipement
            {
                equipementID = 9,
                num_serie = "4665LO74FDG155",
                planification = 2,
                contratID = 3,
                modeleID = 8
            });
            listeDesEquipements.Add(new Equipement
            {
                equipementID = 10,
                num_serie = "4665LO74FDG154",
                planification = 2,
                contratID = 3,
                modeleID = 8
            });
            listeDesEquipements.Add(new Equipement
            {
                equipementID = 11,
                num_serie = "185545410SZE17",
                planification = 4,
                contratID = 3,
                modeleID = 1
            });
            #endregion
        }

        #region Client
        public void CreerClient(Client cl)
        {
            int id = listeDesClients.Count == 0 ? 1 : listeDesClients.Max(r => r.clientID) + 1;
            cl.clientID = id;
            listeDesClients.Add(cl);
        }

        public void ModifierClient(Client cl)
        {
            Client client = listeDesClients.FirstOrDefault(r => r.clientID == cl.clientID);
            if (client != null)
            {
                client.nom_client = cl.nom_client;
                client.adresse_client = cl.adresse_client;
                client.cp_client = cl.cp_client;
                client.ville_client = cl.ville_client;
                client.tel_client = cl.tel_client;
            }
        }

        public void SupprimerClient(Client cl)
        {
            listeDesClients.Remove(cl);
        }

        public List<Client> AfficherTousLesClients()
        {
            return listeDesClients;
        }

        public Client AfficherClientParID(int id)
        {
            return listeDesClients.FirstOrDefault(u => u.clientID == id);
        }

        #endregion

        #region Secteur
        public void CreerSecteur(Secteur sc)
        {
            int id = listeDesSecteurs.Count == 0 ? 1 : listeDesSecteurs.Max(r => r.secteurID) + 1;
            sc.secteurID = id;
            listeDesSecteurs.Add(sc);
        }
        public void ModifierSecteur(Secteur sc)
        {
            Secteur secteur = listeDesSecteurs.FirstOrDefault(r => r.secteurID == sc.secteurID);
            if (secteur != null)
            {
                secteur.libelleSecteur = sc.libelleSecteur;
            }
        }
        public void SupprimerSecteur(Secteur sc)
        {
            listeDesSecteurs.Remove(sc);
        }
        public List<Secteur> AfficherTousLesSecteurs()
        {
            return listeDesSecteurs;
        }
        public Secteur AfficherSecteurParID(int id)
        {
            return listeDesSecteurs.FirstOrDefault(u => u.secteurID == id);
        }
        #endregion

        #region CentreInformatique
        public void CreerCentreInformatique(CentreInformatique ci)
        {
            int id = listeDesCentresInformatique.Count == 0 ? 1 : 
                listeDesCentresInformatique.Max(r => r.centreInformatiqueID) + 1;
        }
        public void ModifierCentreInformatique(CentreInformatique ci)
        {
            CentreInformatique centre = 
                listeDesCentresInformatique.FirstOrDefault(r => r.centreInformatiqueID == ci.centreInformatiqueID);
            if (centre != null)
            {
                centre.adresse_centre = ci.adresse_centre;
                centre.cp_centre = ci.cp_centre;
                centre.ville_centre = ci.ville_centre;
                centre.tel_centre = ci.tel_centre;
            }
        }
        public void SupprimerCentreInformatique(CentreInformatique ci)
        {
            listeDesCentresInformatique.Remove(ci);
        }
        public List<CentreInformatique> AfficherTousLesCentresInformatique()
        {
            return listeDesCentresInformatique;
        }
        public CentreInformatique AfficherCentreInformatiqueParID(int id)
        {
            return listeDesCentresInformatique.FirstOrDefault(u => u.secteurID == id);
        }

        #endregion

        #region Contrat
        public void CreerContrat(Contrat ct)
        {
            int id = listeDesContrats.Count == 0 ? 1 : listeDesContrats.Max(r => r.contratID) + 1;
            ct.contratID = id;
            listeDesContrats.Add(ct);
        }
        public void ModifierContrat(Contrat ct)
        {
            Contrat contrat = listeDesContrats.FirstOrDefault(r => r.contratID == ct.contratID);
            if (contrat != null)
            {
                switch (ct.statut)
                {
                    case 2:
                        contrat.montant_contrat = ct.montant_contrat;
                        contrat.date_echeance = contrat.date_echeance.AddYears(1);
                        contrat.statut = ct.statut;
                        contrat.commentaire = ct.commentaire;
                        break;
                    case 3:
                        contrat.date_resiliation = ct.date_echeance;
                        contrat.statut = ct.statut;
                        contrat.commentaire = ct.commentaire;
                        break;
                }
                
            }
        }
        public void SupprimerContrat(Contrat ct)
        {
            listeDesContrats.Remove(ct);
        }
        public List<Contrat> AfficherTousLesContrats()
        {
            return listeDesContrats;
        }
        public Contrat AfficherContratParID(int id)
        {
            return listeDesContrats.FirstOrDefault(u => u.contratID == id);
        }

        #endregion

        #region Tarif
        public void CreerTarif(Tarif tf)
        {
            int id = listeDesTarifs.Count == 0 ? 1 : listeDesTarifs.Max(r => r.tarifID) + 1;
            tf.tarifID = id;
            listeDesTarifs.Add(tf);
        }
        public void ModifierTarif(Tarif tf)
        {
            Tarif tarif = listeDesTarifs.FirstOrDefault(r => r.tarifID == tf.tarifID);
            if (tarif != null)
            {
                tarif.montant_tarif = tf.montant_tarif;
                tarif.date_tarif = tf.date_tarif;
            }
        }
        public void SupprimerTarif(Tarif tf)
        {
            listeDesTarifs.Remove(tf);
        }
        public List<Tarif> AfficherTousLesTarifs()
        {
            return listeDesTarifs;
        }
        public Tarif AfficherTarifParID(int id)
        {
            return listeDesTarifs.FirstOrDefault(u => u.tarifID == id);
        }

        #endregion

        #region TypeModele
        public void CreerTypeModele(TypeModele tm)
        {
            int id = listeDesTypesModele.Count == 0 ? 1 : listeDesTypesModele.Max(r => r.typeModeleID) + 1;
            tm.typeModeleID = id;
            listeDesTypesModele.Add(tm);
        }
        public void ModifierTypeModele(TypeModele tm)
        {
            TypeModele typemodele = listeDesTypesModele.FirstOrDefault(r => r.typeModeleID == tm.typeModeleID);
            if (typemodele != null)
            {
                typemodele.designation_type = tm.designation_type;
            }
        }
        public void SupprimerTypeModele(TypeModele tm)
        {
            listeDesTypesModele.Remove(tm);
        }
        public List<TypeModele> AfficherTousLesTypesModele()
        {
            return listeDesTypesModele;
        }
        public TypeModele AfficherTypeModeleParID(int id)
        {
            return listeDesTypesModele.FirstOrDefault(u => u.typeModeleID == id);
        }

        #endregion

        #region Modele
        public void CreerModele(Modele m)
        {
            int id = listeDesModeles.Count == 0 ? 1 : listeDesModeles.Max(r => r.modeleID) + 1;
            m.modeleID = id;
            listeDesModeles.Add(m);
        }
        public void ModifierModele(Modele m)
        {
            Modele modele = listeDesModeles.FirstOrDefault(r => r.modeleID == m.modeleID);
            if (modele != null)
            {
                modele.designation_modele = m.designation_modele;
            }
        }
        public void SupprimerModele(Modele m)
        {
            listeDesModeles.Remove(m);
        }
        public List<Modele> AfficherTousLesModeles()
        {
            return listeDesModeles;
        }
        public Modele AfficherModeleParID(int id)
        {
            return listeDesModeles.FirstOrDefault(u => u.modeleID == id);
        }

        #endregion

        #region Equipement
        public void CreerEquipement(Equipement et)
        {
            int id = listeDesEquipements.Count == 0 ? 1 : listeDesEquipements.Max(r => r.equipementID) + 1;
            et.equipementID = id;
            listeDesEquipements.Add(et);
        }
        public void ModifierEquipement(Equipement et)
        {
            Equipement equip = listeDesEquipements.FirstOrDefault(r => r.equipementID == et.equipementID);
            if (equip != null)
            {
                equip.num_serie = et.num_serie;
                equip.planification = et.planification;
                equip.modeleID = et.modeleID;
                equip.contratID = et.contratID;
            }
        }
        public void SupprimerEquipement(Equipement et)
        {
            listeDesEquipements.Remove(et);
        }
        public List<Equipement> AfficherTousLesEquipements()
        {
            return listeDesEquipements;
        }
        public Equipement AfficherEquipementParID(int id)
        {
            return listeDesEquipements.FirstOrDefault(u => u.equipementID == id);
        }

        #endregion
    }
}
