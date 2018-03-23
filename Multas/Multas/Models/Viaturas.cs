using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Viaturas
    {
        //criar constructor
        public Viaturas()
        {
            ListaMultas = new HashSet<Multas>();
        }

        public int ID { get; set; }
        //descricao da viatura
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }

        //descricao do dono
        public string NomeDono { get; set; }
        public string MoradaDono { get; set; }
        public string CodPostalDono { get; set; }

        //Criar lista de multas associadas a viatura
        public virtual ICollection<Multas> ListaMultas { get; set; }
    }
}