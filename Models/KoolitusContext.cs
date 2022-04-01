using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Koolitusede.Models
{
    public class KoolitusContext: DbContext
    {
        public DbSet<Koolitus> Koolituss { get; set; }
        public DbSet<Laps> Lapss { get; set; }
        public DbSet<Opetaja> Opetajas { get; set; }
    }
}