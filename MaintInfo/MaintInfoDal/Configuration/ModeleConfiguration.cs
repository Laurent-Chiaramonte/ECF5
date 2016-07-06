using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoDal.Configuration
{
    class ModeleConfiguration : EntityTypeConfiguration<Modele>
    {
        public ModeleConfiguration() : base()
        {
            #region Mapping
            Property(p => p.designation_modele)
                .IsRequired()
                .HasMaxLength(30);
            ToTable("Modele", "maintinfo");
            #endregion

            #region Association
            HasRequired(p => p.leTarif)
                .WithMany()
                .HasForeignKey(p => p.idTarif);
            HasRequired(p => p.leType)
                .WithMany()
                .HasForeignKey(p => p.idType);
            ToTable("Modele", "maintinfo");
            #endregion
        }
    }
}
