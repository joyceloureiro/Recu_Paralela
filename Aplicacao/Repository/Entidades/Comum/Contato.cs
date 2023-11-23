using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Repository.Entidades.Comum
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public DateTime DataDoContato { get; set; }
        public string DataNascimento { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }


        public Contato(int id, string nome, string telefone, string email, string dataNascimento, string uf, string cidade, string numero, string empresa, string bairro, string cargo)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
            DataDoContato = DateTime.Now;
            Uf = uf;
            Cidade = cidade;
            Numero = numero;
            Bairro = bairro;
            Empresa = empresa;
            Cargo = cargo;


        }




    }
}
