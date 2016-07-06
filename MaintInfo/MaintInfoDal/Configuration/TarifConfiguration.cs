using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoDal.Configuration
{
    class TarifConfiguration : EntityTypeConfiguration<Tarif>
    {
        public TarifConfiguration() : base()
        {
            #region Mapping
            Property(p => p.montant_tarif)
                .IsRequired();
            Property(p => p.date_tarif)
                .HasColumnType("date")
                .IsRequired();
            ToTable("Tarif", "maintinfo");
            #endregion
        }
    }
}
