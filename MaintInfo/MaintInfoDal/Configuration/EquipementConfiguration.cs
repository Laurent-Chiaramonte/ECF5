using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoDal.Configuration
{
    class EquipementConfiguration : EntityTypeConfiguration<Equipement>
    {
        public EquipementConfiguration() : base()
        {
            #region Mapping
            Property(p => p.designation_equip)
                .HasMaxLength(30)
                .IsRequired();
            ToTable("Equipement", "maintinfo");
            #endregion

            #region Association
            HasRequired(p => p.leContrat)
                .WithMany()
                .HasForeignKey(p => p.idContrat);
            HasRequired(p => p.leModele)
                .WithMany()
                .HasForeignKey(p => p.idModele);
            ToTable("Equipement", "maintinfo");
            #endregion
        }
    }
}
