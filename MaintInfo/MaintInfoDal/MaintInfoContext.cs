using MaintInfoBo;
using MaintInfoDal.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoDal
{
    public class MaintInfoContext : DbContext
    {
        public MaintInfoContext() : base("name=MaintInfoCs") { }

        #region DbSets
        public DbSet<Client> Clients { get; set; }
        public DbSet<CentreInformatique> CentresInformatique { get; set; }
        public DbSet<Contrat> Contrats { get; set; }
        public DbSet<Equipement> Equipements { get; set; }
        public DbSet<Modele> Modeles { get; set; }
        public DbSet<Secteur> Secteurs { get; set; }
        public DbSet<Tarif> Tarifs { get; set; }
        public DbSet<TypeModele> TypeModeles { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new CentreInformatiqueConfiguration());
            modelBuilder.Configurations.Add(new ContratConfiguration());
            modelBuilder.Configurations.Add(new EquipementConfiguration());
            modelBuilder.Configurations.Add(new ModeleConfiguration());
            modelBuilder.Configurations.Add(new SecteurConfiguration());
            modelBuilder.Configurations.Add(new TarifConfiguration());
            modelBuilder.Configurations.Add(new TypeModeleConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
