using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MaintInfoBo;

namespace MaintInfoDal.Configuration
{
    class CentreInformatiqueConfiguration : EntityTypeConfiguration<CentreInformatique>
    {
        public CentreInformatiqueConfiguration() : base()
        {
            #region Mapping
            Property(p => p.adresse_centre)
                .IsRequired();
            Property(p => p.cp_centre)
                .IsRequired()
                .HasMaxLength(5);
            Property(p => p.ville_centre)
                .IsRequired();
            Property(p => p.tel_centre)
                .IsRequired()
                .HasMaxLength(10);
            ToTable("CentreInformatique");
            #endregion

            #region Associations
            HasRequired(p => p.leClient)
                .WithMany()
                .HasForeignKey(p => p.clientID);
            HasRequired(p => p.leSecteur)
                .WithMany()
                .HasForeignKey(p => p.secteurID);
            #endregion
        }
    }
}
