using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Koolitusede.Models
{
    public class Koolitus
    {
        public int Id { get; set; }
        public string Koolitusenimetus { get; set; }
        public string Koolitusekirjaldus { get; set; }
        public int OpetajaId { get; set; }
        public int Koolitusehind { get; set; }
        public int Koolitusemaht { get; set; }
    }
}