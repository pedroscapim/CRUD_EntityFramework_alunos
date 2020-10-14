using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EntityFramework_alunos
{
    class Contexto : DbContext
    {

        public Contexto() : base("conexao")
        {

        }


       public DbSet<salaaula> objetosalaaula { get; set; }
       
       public DbSet<Agenda> ObjetoAgenta { get; set; }
    }
}
