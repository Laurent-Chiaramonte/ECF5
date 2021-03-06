﻿using MaintInfoBll.Gestionnaires.GestionnaireExceptions;
using MaintInfoBo;
using MaintInfoDal.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll.Gestionnaires
{
    public class ContratGestionnaire
    {
        ContratManager ctMngr;

        public ContratGestionnaire()
        {
            ctMngr = new ContratManager(new ContratDao());
        }

        public void ajouterContrat(Contrat ct)
        {
            try
            {
                ctMngr.ajouterContrat(ct);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Ajout impossible"); ;
            }
        }

        public void modifierContrat(Contrat ct)
        {
            try
            {
                switch (ct.statut)
                {
                    // Modification
                    case 1:
                        ctMngr.modifierContrat(ct);
                        break;
                    // Renouvellement
                    case 2:
                        ct.date_echeance = ct.date_echeance.AddYears(1);
                        ctMngr.modifierContrat(ct);
                        break;
                    // Resiliation
                    case 3:
                        ct.date_resiliation = ct.date_echeance;
                        ctMngr.modifierContrat(ct);
                        break;
                }
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Modification impossible"); ;
            }
        }

        public void suppressionContrat(Contrat ct)
        {
            try
            {
                ctMngr.supprimerContrat(ct);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Suppression impossible"); ;
            }
        }

        public IEnumerable<Contrat> afficherTousLesContrats()
        {
            try
            {
                return ctMngr.afficherTousLesContrats();
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible"); ;
            }
        }

        public Contrat afficherContratParID(int id)
        {
            try
            {
                return ctMngr.afficherContratParID(id);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible"); ;
            }
        }

        public bool contratExiste(int idCenInfo)
        {
            return ctMngr.contratExiste(idCenInfo);
        }
    }
}
