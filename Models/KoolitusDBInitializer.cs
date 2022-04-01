using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Koolitusede.Models
{
    public class KoolitusDBInitializer : CreateDatabaseIfNotExists<KoolitusContext>
    {
        protected override void Seed(KoolitusContext db)
        {
            base.Seed(db);
        }
    }
}