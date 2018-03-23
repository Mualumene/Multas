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
        [ForeignKey("Agentes")]
        public int AgenteFK { get; set; }
        public virtual Agentes Agentes { get; set; }//virtual para poder usar "LazyLoading"

        //chaves FK - dados do condutor
        [ForeignKey("Condutores")]
        public int CondutorFK { get; set; }
        public virtual Condutores Condutores { get; set; }//virtual para poder usar "LazyLoading"

        //chaves FK - dados da viatura
        [ForeignKey("Viaturas")]
        public int ViaturaFK { get; set; }
        public virtual Viaturas Viaturas { get; set; }//virtual para poder usar "LazyLoading"

    }
}