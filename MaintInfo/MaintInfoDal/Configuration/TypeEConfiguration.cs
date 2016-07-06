using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoDal.Configuration
{
    class TypeEConfiguration : EntityTypeConfiguration<TypeE>
    {
        public TypeEConfiguration() : base()
        {
            Property(p => p.designation_type)
                .IsRequired()
                .HasMaxLength(30);
            ToTable("TypeE", "maintinfo");
        }
    }
}
