using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaintInfoDal.Repository;
using MaintInfoBo;
using System.Data.Entity;
using MaintInfoDal;

namespace MaintInfoWeb.Tests.Controllers
{
    [TestClass]
    public class ClientControllerTest
    {
        private IRepository<Client> repo;

        [TestInitialize]
        public void Init_AvantChaqueTest()
        {
            IDatabaseInitializer<MaintInfoContext> init = new DropCreateDatabaseAlways<MaintInfoContext>();
            Database.SetInitializer(init);
            init.InitializeDatabase(new MaintInfoContext());

            repo = new Repository<Client>();
        }

        [TestCleanup]
        public void ApresChaqueTest()
        {
            repo.Dispose();
        }

        [TestMethod]
        public void Create_AjoutClientEtRecuperation_LeClientEstBienRecupere()
        {
            repo.Insert(new Client
            {
                clientID = 1,
                nom_client = "testAjoutClient",
                adresse_client = "adresse test",
                cp_client = "13013",
                ville_client = "VilleTest",
                tel_client = "0101010101"
            });

            Client client = repo.GetSingleById(1);

            Assert.IsNotNull(client);
            Assert.AreEqual("testAjoutClient", client.nom_client);
        }


    }
}
