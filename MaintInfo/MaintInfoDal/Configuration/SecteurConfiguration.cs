using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoDal.Configuration
{
    class SecteurConfiguration : EntityTypeConfiguration<Secteur>
    {
        public SecteurConfiguration() : base()
        {
            #region Mapping
            Property(p => p.libelleSecteur)
                .IsRequired()
                .HasMaxLength(30);
            ToTable("Secteur");
            #endregion
        }
    }
}
