using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoDal.Configuration
{
    class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration() : base()
        {
            #region Mapping
            Property(p => p.nom_client)
                .IsRequired()
                .HasMaxLength(30);
            Property(p => p.adresse_client)
                .IsRequired();
            Property(p => p.cp_client)
                .IsRequired()
                .HasMaxLength(5);
            Property(p => p.ville_client)
                .IsRequired();
            Property(p => p.tel_client)
                .IsRequired()
                .HasMaxLength(10);
            ToTable("Client", "maintinfo");
            #endregion

            
        }
    }
}
