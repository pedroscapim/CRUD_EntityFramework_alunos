using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EntityFramework_alunos
{
    class Agenda
    {
        public static EntityState Modified { get; internal set; }
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string cep { get; set; }

    
    }
}
