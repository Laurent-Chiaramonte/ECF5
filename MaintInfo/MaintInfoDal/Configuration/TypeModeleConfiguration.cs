using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoDal.Configuration
{
    class TypeModeleConfiguration : EntityTypeConfiguration<TypeModele>
    {
        public TypeModeleConfiguration() : base()
        {

            Property(p => p.designation_type)
                .IsRequired()
                .HasMaxLength(30);
            ToTable("TypeModele");
        }
    }
}
