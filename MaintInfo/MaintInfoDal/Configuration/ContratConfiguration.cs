using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoDal.Configuration
{
    class ContratConfiguration : EntityTypeConfiguration<Contrat>
    {
        public ContratConfiguration() : base()
        {
            #region Mapping
            Property(p => p.montant_contrat)
                .IsRequired();
            Property(p => p.statut)
                .IsRequired();
            Property(p => p.commentaire)
                .IsOptional()
                .HasMaxLength(30);
            Property(p => p.date_creation)
                .HasColumnType("date")
                .IsRequired();
            Property(p => p.date_echeance)
                .HasColumnType("date")
                .IsRequired();
            Property(p => p.date_resiliation)
                .HasColumnType("date")
                .IsOptional();
            ToTable("Contrat", "maintinfo");
            #endregion

            #region Association
            HasRequired(p => p.leCentre)
                .WithMany()
                .HasForeignKey(p => p.idCentre);
            #endregion
        }
    }
}
