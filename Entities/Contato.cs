using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MODULOAPI.Entities
{
    public class Contato
    {
        //criando quais serão as colunas da tabela do meu banco de dados 
        public int Id { get; set; }
        public string Nome { get; set; }
        public string  Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}