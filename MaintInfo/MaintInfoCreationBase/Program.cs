using MaintInfoDal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoCreationBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MaintInfoInitializer());
            using (var context = new MaintInfoContext())
            {
                context.Database.Initialize(false);
            }
        }
    }
}
