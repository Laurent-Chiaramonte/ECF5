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
            Property(p => p.num_serie)
                .IsRequired()
                .HasMaxLength(30);
            Property(p => p.planification)
                .IsRequired();
            ToTable("Equipement");
            #endregion

            #region Association
            HasRequired(p => p.leContrat)
                .WithMany()
                .HasForeignKey(p => p.contratID);
            HasRequired(p => p.leModele)
                .WithMany()
                .HasForeignKey(p => p.modeleID);
            #endregion
        }
    }
}
