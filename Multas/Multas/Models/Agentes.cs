using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Agentes
    {
        //criar constructor
        public Agentes() {
            ListaMultas = new HashSet<Multas>();
        }

        public int ID { get; set; } // PK
        //dados do agente
        public string Agente { get; set; }
        public string Fotografia { get; set; }
        public string Esquadra { get; set; }

        //Criar lista de multas aplicadas pelo agente
        public virtual ICollection<Multas> ListaMultas { get; set; }
    }
}