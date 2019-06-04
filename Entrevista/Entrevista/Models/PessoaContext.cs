using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Entrevista.Models
{
    public class PessoaContext : DbContext
    {
        public PessoaContext() 
            : base("Entrevista")
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
       
    }
}