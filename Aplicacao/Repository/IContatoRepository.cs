using Aplicacao.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Repository
{
    public interface IContatoRepository
    {
        bool Incluir(Contato contato);
        bool Atualizar(Contato contato);
        bool Deletar(Contato contato);

        List<Contato> ObterTodos();

        List<Contato> ObterTodosPorNome(int Nome);
        List<Contato> ObterTodosPorEmail(int Email);
        List<Contato> ObterTodosPorTelefone(int Telefone);
        Contato ObterCargo(int id);

    }
}
