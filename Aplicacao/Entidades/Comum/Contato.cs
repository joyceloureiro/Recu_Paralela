using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Entidades.Comum
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public DateTime DataDoContato { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Empresa { get; set; }
        public string Cargo { get; set; }

      

       
    }
}
