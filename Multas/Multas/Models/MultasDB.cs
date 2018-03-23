using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class MultasDB : DbContext
    {
        //criar constructor
        public MultasDB() : base("MultasDbConnectionString") { }

        //definir as tabelas da minha base de dados
        public virtual DbSet<Viaturas> Viaturas { get; set; }
        public virtual DbSet<Condutores> Condutores { get; set; }
        public virtual DbSet<Agentes> Agentes { get; set; }
        public virtual DbSet<Multas> Multas { get; set; }

    }
}