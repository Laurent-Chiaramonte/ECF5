using MaintInfoBll;
using MaintInfoBll.Gestionnaires;
using MaintInfoBo;
using MaintInfoDal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientGestionnaire clig = new ClientGestionnaire();

            Client c1 = new Client
            {
                clientID = 3,
                nom_client = "test mod",
                adresse_client = "34, avenue de corot",
                cp_client = "13013",
                ville_client = "Marseille",
                tel_client = "0491609023"
            };
            

            Console.WriteLine(clig.clientExiste("Panzani"));
            //Console.WriteLine(clig.afficherTousLesClients());

            Console.ReadLine();

        }
    }
}
