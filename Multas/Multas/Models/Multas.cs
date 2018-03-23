using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Multas
    {
        public int ID { get; set; }// PK
        //dados da multa
        public string Local { get; set; }
        public string TipoInfraccao { get; set; }
        public decimal ValorMulta { get; set; }
        public DateTime DataMulta { get; set; }
        //++++++++++++++++++++++++++++++++++++++++++++
        //chaves FK - dados do agente
        [ForeignKey("Agente")]
        public int AgenteFK { get; set; }
        public virtual Agentes Agente { get; set; }//virtual para poder usar "LazyLoading"

        //chaves FK - dados do condutor
        [ForeignKey("Condutor")]
        public int CondutorFK { get; set; }
        public virtual Condutores Condutor { get; set; }//virtual para poder usar "LazyLoading"

        //chaves FK - dados da viatura
        [ForeignKey("Viatura")]
        public int ViaturaFK { get; set; }
        public virtual Viaturas Viatura { get; set; }//virtual para poder usar "LazyLoading"

    }
}