using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoDal
{
    public class MaintInfoInitializer : DropCreateDatabaseAlways<MaintInfoContext>
    {
        protected override void Seed(MaintInfoContext db)
        {
            base.Seed(db);
        }
    }
}
